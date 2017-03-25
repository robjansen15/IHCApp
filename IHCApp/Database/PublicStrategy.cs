using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IHCApp.Database.Public;

namespace IHCApp.Database
{
    public class PublicStrategy
    {
        public PublicStrategy(DatabaseConnection databaseConnection)
        {
            _InsertStrategy = new InsertStrategy(databaseConnection);
            _PublicDataStrategy = new PublicDataStrategy(databaseConnection);
            _TokenStrategy = new TokenStrategy(databaseConnection);
        }

        public InsertStrategy _InsertStrategy { get; set; }
        public PublicDataStrategy _PublicDataStrategy { get; set; }
        public TokenStrategy _TokenStrategy { get; set; }
    }
}