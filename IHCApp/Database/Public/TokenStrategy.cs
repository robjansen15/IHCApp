using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IHCApp.Models;
using System.Data.SqlClient;
using System.Data;
using IHCApp.Database.Helper;

namespace IHCApp.Database.Public
{
    public class TokenStrategy
    {
        public TokenStrategy(DatabaseConnection databaseConnection)
        {
            _DatabaseConnection = databaseConnection;
        }


        public void UpdateToken(string email, string password, string token)
        {
            _DatabaseConnection.Connect();

            try
            {
                SqlCommand command = new SqlCommand("UpdateToken", _DatabaseConnection.GetActiveConnection());
                command.CommandType = CommandType.StoredProcedure;

                //Add as many parameters as you want
                command.Parameters.Add(new SqlParameter("@EMAIL", email));
                command.Parameters.Add(new SqlParameter("@PASS", password));
                command.Parameters.Add(new SqlParameter("@TOKEN", token));

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                var x = e.ToString();
            }
            finally
            {
                _DatabaseConnection.Disconnect();
            }

            _DatabaseConnection.Disconnect();
        }

        /// <summary>
        /// Check Credentials
        /// This is used to check the credentials that the user inputs
        /// </summary>
        public Token ValidateCredentials(string email, string password)
        {
            DataAccess da = new DataAccess(_DatabaseConnection);

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@EMAIL", email));
            parameters.Add(new SqlParameter("@PASS", password));

            DataTable table = da.GetData(new StoredProcedureObj("CheckLogin", parameters));

            //if the rows are greater than or less than 1 then there is something wonky going on
            if (table.Rows.Count == 1)
            {
                //verifies that the sql returns the correct email and password and no sql injection occured
                if (table.Rows[0]["Admin_Username"].ToString().ToLower() == email.ToLower()
                    && table.Rows[0]["Admin_Password"].ToString().ToLower() == password.ToLower())
                {
                    string tokenString = GenerateRandomToken();
                    UpdateToken(email, password, tokenString);
                    return new Token(tokenString, email);
                }
            }

            return new Token("NULL", email);
        }


        public string GenerateRandomToken()
        {
            int length = 48;
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }


        /// <summary>
        /// Check Token
        /// This is used to check the database if the token the person has is valid
        /// </summary>
        public bool ValidateToken(Token token)
        {
            bool isValid = false;

            DataAccess da = new DataAccess(_DatabaseConnection);

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@EMAIL", token._Email));
            parameters.Add(new SqlParameter("@TOKEN", token._Token));

            DataTable table = da.GetData(new StoredProcedureObj("CheckToken", parameters));

            //if the rows are greater than or less than 1 then there is something wonky going on
            if (table.Rows.Count == 1)
            {
                //verifies that the sql returns the correct token and no sql injection occured
                if (table.Rows[0]["Admin_Username"].ToString().ToLower() == token._Email.ToLower()
                    && table.Rows[0]["Admin_Token"].ToString().ToLower() == token._Token.ToLower())
                {
                    isValid = true;
                }
            }

            return isValid;
        }


        private DatabaseConnection _DatabaseConnection { get; set; }
    }
}