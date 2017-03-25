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


        /// <summary>
        /// Check Credentials
        /// This is used to check the credentials that the user inputs
        /// </summary>
        public bool ValidateCredentials(string email, string password)
        {
            DataAccess da = new DataAccess(_DatabaseConnection);

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@EMAIL", email));
            parameters.Add(new SqlParameter("@PASSWORD", password));

            DataTable table = da.GetData(new StoredProcedureObj("CheckCredentials", parameters));

            //if the rows are greater than or less than 1 then there is something wonky going on
            if(table.Rows.Count == 1)
            {
                //verifies that the sql returns the correct email and password and no sql injection occured
                if(table.Rows[0]["EMAIL"].ToString().ToLower() == email.ToLower()
                    && table.Rows[0]["PASSWORD"].ToString().ToLower() == password.ToLower())
                {
                    return true;
                }
            }

            return false;
        }



        /// <summary>
        /// Check Token
        /// This is used to check the database if the token the person has is valid
        /// </summary>
        public bool ValidateToken(Token token)
        {
            DataAccess da = new DataAccess(_DatabaseConnection);

            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@EMAIL", token._Email));
            parameters.Add(new SqlParameter("@TOKEN", token._Token));

            DataTable table = da.GetData(new StoredProcedureObj("CheckCredentials", parameters));

            //if the rows are greater than or less than 1 then there is something wonky going on
            if (table.Rows.Count == 1)
            {
                //verifies that the sql returns the correct token and no sql injection occured
                if (table.Rows[0]["EMAIL"].ToString().ToLower() == token._Email.ToLower()
                    && table.Rows[0]["TOKEN"].ToString().ToLower() == token._Token.ToLower())
                {
                    return true;
                }
            }

            return false;
        }


        private DatabaseConnection _DatabaseConnection { get; set; }
    }
}