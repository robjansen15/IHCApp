using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataHandler.Models;

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

            applicants.Add(new Applicant("rob", "jansen"));
            applicants.Add(new Applicant("jim", "godfrey"));
            
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

            return applicants;
        }




        private DatabaseConnection _DatabaseConnection { get; set; }
    }
}