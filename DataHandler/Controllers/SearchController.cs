using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataHandler.Models;
using System.Web.Script.Serialization;
using DataHandler.Database;


namespace DataHandler.Controllers
{
    public class SearchController : Controller
    {

        /// <summary>
        /// get a list of school names from the database
        /// </summary>
        /// <returns></returns>
        [AuthorizeToken]
        public string getSchoolNames(string token)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();

            string obj = "";

            List<string> schools = new List<string>();

            try
            {
                schools = databaseConnection._SearchStrategy.getSchoolNames();

                obj = new JavaScriptSerializer().Serialize(schools);
            }
            catch
            {

            }

            return obj;
        }


        /// <summary>
        /// Gets all applicants by school name
        /// </summary>
        /// <param name="token"></param>
        /// <param name="schoolName"></param>
        /// <returns></returns>
        // GET: Search/getApplicantsBySchool
        [AuthorizeToken]
        public string getApplicantsBySchool(string token, string schoolName)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            
            string obj = "";

            List<Applicant> applicants = new List<Applicant>();

            try
            {
                applicants = databaseConnection._SearchStrategy.getApplicantBySchool(schoolName);
            
                obj = new JavaScriptSerializer().Serialize(applicants);            
            }
            catch
            {

            }

            return obj;
        }

    }
}