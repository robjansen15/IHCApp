using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IHCApp.Database.Protected
{
    public class DynamicSearchStrategy
    {
        public DynamicSearchStrategy(DatabaseConnection databaseConnection)
        {
            _DatabaseConnection = databaseConnection;
        }

        /// <summary>
        /// Logic for dynamic search will go here
        /// </summary>




        private DatabaseConnection _DatabaseConnection { get; set; }
    }
}