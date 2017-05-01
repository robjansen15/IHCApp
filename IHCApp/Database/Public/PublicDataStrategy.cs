using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using IHCApp.Models;
using System.Web;
using IHCApp.Database.Helper;

namespace IHCApp.Database.Public
{
    public class PublicDataStrategy
    {
        public PublicDataStrategy(DatabaseConnection databaseConnection)
        {
            _DatabaseConnection = databaseConnection;
        }

        public List<string> ResetPasswsord(string username)
        {
            List<string> pieces = new List<string>();

            DataAccess da = new DataAccess(_DatabaseConnection);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@USERNAME", username));

            DataTable dt = da.GetData(new StoredProcedureObj("ForgotPassword", parameters));

            foreach (DataRow row in dt.Rows)
            {
                pieces.Add(row["Admin_Password"].ToString());
                pieces.Add(row["Admin_Email"].ToString());
            }

            return pieces;
        }

        /// <summary>
        /// Get the pre-form HOST information
        /// </summary>


        /// <summary>
        /// Get the pre-form APPLICANT information
        /// </summary>


        /// <summary>
        /// Get the Host information page
        /// </summary>
        public string GetHostInformation()
        {
            string html = "";
            _DatabaseConnection.Connect();

            try
            {
                SqlCommand command = new SqlCommand("SPGetFormHTML", _DatabaseConnection.GetActiveConnection());
                command.CommandType = CommandType.StoredProcedure;

                //Add as many parameters as you want
                command.Parameters.Add(new SqlParameter("@ID", "HOST"));

                using (SqlDataReader rdr = command.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        html += rdr.GetString(2);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                html += "You must be connected to the database to populate this field";
            }
            finally
            {
                _DatabaseConnection.Disconnect();
            }

            return html;
        }



        /// <summary>
        /// Get the Applicant information page
        /// </summary>
        public string GetApplicantFormInfo()
        {
            string html = "";
            _DatabaseConnection.Connect();

            try
            {
                SqlCommand command = new SqlCommand("SPGetFormHTML", _DatabaseConnection.GetActiveConnection());
                command.CommandType = CommandType.StoredProcedure;

                //Add as many parameters as you want
                command.Parameters.Add(new SqlParameter("@ID", "APPLICANT"));

                using (SqlDataReader rdr = command.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        html += rdr.GetString(2);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                html += "You must be connected to the database to populate this field";
            }
            finally
            {
                _DatabaseConnection.Disconnect();
            }

            return html;
        }

        /// <summary>
        /// Get a list of the Countries
        /// </summary>
        public List<string> GetAllCountries()
        {
            List<string> countries = new List<string>();

            DataAccess da = new DataAccess(_DatabaseConnection);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Discriminator", "Country"));

            DataTable dt = da.GetData(new StoredProcedureObj("SPGetDisplayData", parameters));

            foreach(DataRow row in dt.Rows)
            {
                countries.Add(row["Text"].ToString());
            }

            return countries;
        }

        /// <summary>
        /// Get a list of relations to host
        /// </summary>
        public List<string> RelationToHostDatasource()
        {
            List<string> relationToHost = new List<string>();

            DataAccess da = new DataAccess(_DatabaseConnection);
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Discriminator", "RelationToHost"));

            DataTable dt = da.GetData(new StoredProcedureObj("SPGetDisplayData", parameters));

            foreach (DataRow row in dt.Rows)
            {
                relationToHost.Add(row["Text"].ToString());
            }

            return relationToHost;
        }


        private DatabaseConnection _DatabaseConnection { get; set; }
    }
}