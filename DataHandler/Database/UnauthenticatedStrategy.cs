using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataHandler.Models;

namespace DataHandler.Database
{
    public class UnauthenticatedStrategy
    {
        public UnauthenticatedStrategy(DatabaseConnection databaseConnection)
        {
            _DatabaseConnection = databaseConnection;
        }

        /// <summary>
        /// this is an example of an unauthenticated route that could pou
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        public List<string> exampleUnauthenticated()
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

        private DatabaseConnection _DatabaseConnection { get; set; }
    }
}