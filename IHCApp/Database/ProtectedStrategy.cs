﻿using System;
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
                _DashboardStrategy = new DashboardStrategy(databaseConnection);
                _FormUpdateHTMLStrategy = new FormUpdateHTMLStrategy(databaseConnection);
                _QuickSearchStrategy = new QuickSearchStrategy(databaseConnection);
                _UpdateFormStrategy = new UpdateFormStrategy(databaseConnection);
            }
            else
            {
                throw new Exception("Invalid token!");
            }                
        }


        public DashboardStrategy _DashboardStrategy { get; set; }
        public FormUpdateHTMLStrategy _FormUpdateHTMLStrategy { get; set; }
        public QuickSearchStrategy _QuickSearchStrategy { get; set; }
        public UpdateFormStrategy _UpdateFormStrategy { get; set; }
    }  
}