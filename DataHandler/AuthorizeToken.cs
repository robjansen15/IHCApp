using System.Web.Mvc;
using System;
using System.Web.Security;
using System.Collections.Generic;
using System.Linq;
using DataHandler.Database;

namespace DataHandler
{
    public class AuthorizeToken : AuthorizeAttribute
    { 
        private readonly string[] allowedroles;
        public AuthorizeToken(params string[] roles)
        {
            this.allowedroles = roles;
        }

        protected override bool AuthorizeCore(System.Web.HttpContextBase httpContext)
        {
            bool authorize = false;

            List<string> pathList = httpContext.Request.RawUrl.Split('?').ToList();
            string token = pathList.Last(x => x.Contains("token")).Split('=')[1];

            //checks to see if the token is valid
            Database.DatabaseConnection databaseConnection = new DatabaseConnection();

            if(databaseConnection._TokenStrategy.Validate(token) == true)
            {
                authorize = true;
            }

            return authorize;
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new HttpUnauthorizedResult();
        }
    }
}