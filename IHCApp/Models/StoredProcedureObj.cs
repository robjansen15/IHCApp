using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IHCApp.Models
{
    public class StoredProcedureObj
    {
        public StoredProcedureObj(string storedProcedure, List<SqlParameter> parameters)
        {
            _StoredProcedure = storedProcedure;
            _Parameters = parameters;
        }

        public string _StoredProcedure { get; set; }
        public List<SqlParameter> _Parameters { get; set; }      
    }
}