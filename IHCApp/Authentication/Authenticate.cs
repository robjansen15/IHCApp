using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IHCApp.Models;
using IHCApp.Database;

namespace IHCApp.Authentication
{
    public class Authenticate
    {
        public Authenticate() { }


        public bool ValidateToken(Token token)
        {
            bool isValid = false;

            try
            {
                isValid = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateToken(token);
            }
            catch
            {

            }       

            return isValid;
        }



        public bool ValidateCredentials(string email, string password)
        {
            bool isValid = false;

            try
            {
                isValid = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials(email, password);
            }
            catch
            {

            }

            return isValid;
        }

    }
}