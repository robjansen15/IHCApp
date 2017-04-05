using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IHCApp.Database.Protected
{
    public class FormUpdateHTMLStrategy
    {
        public FormUpdateHTMLStrategy(DatabaseConnection databaseConnection)
        {
            _DatabaseConnection = databaseConnection;
        }


        /// <summary>
        /// Update the Applicant information page
        /// </summary>      
        public void UpdateFormInfo(string html, string identifier)
        {
            _DatabaseConnection.Connect();

            try
            {
                SqlCommand command = new SqlCommand("UpdateFormInfo", _DatabaseConnection.GetActiveConnection());
                command.CommandType = CommandType.StoredProcedure;

                //Add as many parameters as you want
                command.Parameters.Add(new SqlParameter("@IDENTIFIER", identifier));
                command.Parameters.Add(new SqlParameter("@HTML_BLOB", html));

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
        }



        /// <summary>
        /// Rollback the Form information page
        /// </summary>
        public void RollBackFormInfo(string identifier)
        {
            _DatabaseConnection.Connect();

            try
            {
                SqlCommand command = new SqlCommand("RollbackFormInfo", _DatabaseConnection.GetActiveConnection());
                command.CommandType = CommandType.StoredProcedure;

                //Add as many parameters as you want
                command.Parameters.Add(new SqlParameter("@IDENTIFIER", identifier));
                command.Parameters.Add(new SqlParameter("@TEMP_HTML", "temp"));

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
        }

        private DatabaseConnection _DatabaseConnection { get; set; }
    }
}