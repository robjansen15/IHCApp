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
        /*Serialization example*/

        // GET: Search/applicantBySchool
        [AuthorizeToken]
        public string applicantBySchool(string token)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            
            string obj = "";

            List<Applicant> applicants = new List<Applicant>();

            try
            {
                Applicant a = databaseConnection._StoredProcedureAdapter.getApplicant();
                applicants.Add(a);
                applicants.Add(a);

                obj = new JavaScriptSerializer().Serialize(applicants);            
            }
            catch
            {

            }

            return obj;
        }
    }
}