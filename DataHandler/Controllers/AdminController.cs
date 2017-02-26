using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataHandler.Models;
using DataHandler.Database;
using System.Web.Script.Serialization;

namespace DataHandler.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/autenticate/
        public string authenticate(string username, string password)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();


            //can't do anything with an empty parameter
            if(username == null)
            {
                return new HttpException(500, "null request").ToString();
            }
            if(password == null)
            {
                return new HttpException(500, "null request").ToString();
            }

            //lets see if they are who they say they are...
            if(databaseConnection._TokenAdapter.Validate(username, password))
            {
                string obj = "";
                Token token = new Token().GenerateToken(username);
                obj = new JavaScriptSerializer().Serialize(token);

                return obj;
            }

            return new HttpException(500, "null request").ToString();
        }


    }
}
