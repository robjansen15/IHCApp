using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IHCApp.Database.Protected;
using IHCApp.Models;
using IHCApp.Authentication;


namespace IHCApp.Database
{
    public class ProtectedStrategy
    {
        public ProtectedStrategy(DatabaseConnection databaseConnection, Token token)
        {
            if(new Authenticate().ValidateToken(token))
            {
                _DynamicSearchStrategy = new DynamicSearchStrategy(databaseConnection);
                _FormUpdateHTMLStrategy = new FormUpdateHTMLStrategy(databaseConnection);
                _QuickSearchStrategy = new QuickSearchStrategy(databaseConnection);
            }
            else
            {
                throw new Exception("Invalid token!");
            }                
        }


        public DynamicSearchStrategy _DynamicSearchStrategy { get; set; }
        public FormUpdateHTMLStrategy _FormUpdateHTMLStrategy { get; set; }
        public QuickSearchStrategy _QuickSearchStrategy { get; set; }
    }  
}