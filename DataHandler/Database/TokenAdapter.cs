using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataHandler.Models;

namespace DataHandler.Database
{
    public class TokenAdapter
    {
        public TokenAdapter(DatabaseConnection databaseConnection)
        {
            _DatabaseConnection = databaseConnection;
        }


        public bool Validate(string token)
        {
            bool validated = false;

            //temporary
            validated = true;

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

            return validated;
        }

        /// <summary>
        /// example stored procedure for validation of user and password
        /// </summary>
        public bool Validate(string username, string password)
        {
            bool validated = false;

            //temporary
            validated = true;

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

            return validated;
        }


        public string GetExistingToken(string username)
        {
            string token = "null";

            _DatabaseConnection.Connect();

            try
            {
                //if(tokenExists)
                //  if(tokenIsFromToday)
                //     if(both of the last two are true return the token)
            }
            catch
            {

            }

            _DatabaseConnection.Disconnect();

            return token;
        }


        public void SaveToken(Token token)
        {    
            _DatabaseConnection.Connect();

            try
            {
                ///write the token to the database
            }
            catch
            {

            }

            _DatabaseConnection.Disconnect();    
        }


        private DatabaseConnection _DatabaseConnection { get; set; }

    }
}