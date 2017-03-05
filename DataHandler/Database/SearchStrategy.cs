using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataHandler.Models;
using System.Data;
using System.Data.SqlClient;

namespace DataHandler.Database
{
    public class SearchStrategy
    {
        public SearchStrategy(DatabaseConnection databaseConnection)
        {
            _DatabaseConnection = databaseConnection;
        }

        /// <summary>
        /// get school names 
        /// </summary>
        /// <returns></returns>
        public List<string> getSchoolNames()
        {
            List<string> schools = new List<string>();

            schools.Add("IUPUI");
            schools.Add("BSU");

            /*
             Uncomment and use this framework. You need to connect and disconnect OUTSIDE of the try catch.

            _DatabaseConnection.Connect();

            try
            {
                
            }
            catch
            {

            }

            _DatabaseConnection.Disconnect();
            */

            return schools;
        }


        /// <summary>
        /// get applicants who are visiting a specific school
        /// </summary>
        public List<Applicant> getApplicantBySchool(string schoolName)
        {
            List<Applicant> applicants = new List<Applicant>();
            
            _DatabaseConnection.Connect();

            try
            {
                SqlCommand command = new SqlCommand("SPReadStudentBySchool", _DatabaseConnection._Connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@I_Name", schoolName));

                using (SqlDataReader rdr = command.ExecuteReader())
                {
                    ///gets the specific columns needed from the table
                    List<int> enumerations = new List<int>();
                    List <string> enumString = new Enumerations.EnumerationContainer()._GetStudentsBySchoolEnumeration.Split(';').ToList();
                    foreach(string str in enumString)
                    {
                        enumerations.Add(Convert.ToInt32(str));
                    }

                    while (rdr.Read())
                    {
                        var firstName = rdr.GetString(enumerations.ElementAt(0));
                        var lastName = rdr.GetString(enumerations.ElementAt(1));

                        applicants.Add(new Applicant(firstName, lastName));
                    }
                }
            }
            catch(Exception e)
            {
                var x = e.ToString();
            }
            finally
            {
                _DatabaseConnection.Disconnect();
            }

            return applicants;
        }




        private DatabaseConnection _DatabaseConnection { get; set; }
    }
}