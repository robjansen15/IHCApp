using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataHandler.Models;
using System.Web.Script.Serialization;


namespace DataHandler.Controllers
{
    public class SearchController : Controller
    {
        /*Serialization example*/

        // GET: Search/applicantBySchool
        public string applicantBySchool()
        {
            string obj = "";

            List<Applicant> applicants = new List<Applicant>();

            try
            {
                applicants.Add(new Applicant("rob", "jansen"));
                applicants.Add(new Applicant("jim", "godfrey"));

                obj = new JavaScriptSerializer().Serialize(applicants);            
            }
            catch
            {

            }

            return obj;
        }
    }
}