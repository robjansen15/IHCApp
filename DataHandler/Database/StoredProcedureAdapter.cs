using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataHandler.Models;

namespace DataHandler.Database
{
    public class StoredProcedureAdapter
    {
        public StoredProcedureAdapter(DatabaseConnection databaseConnection)
        {
            _DatabaseConnection = databaseConnection;
        }

        /// <summary>
        /// example stored procedure for testing
        /// </summary>
        public Applicant getApplicant()
        {
            Applicant a = new Applicant("rob", "jansen");
            
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

            return a;
        }


        private DatabaseConnection _DatabaseConnection { get; set; }
    }
}