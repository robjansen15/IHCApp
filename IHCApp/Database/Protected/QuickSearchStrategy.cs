using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IHCApp.Models;
using System.Data.SqlClient;
using System.Data;
using IHCApp.Database.Helper;

namespace IHCApp.Database.Protected
{
    public class QuickSearchStrategy
    {
        public QuickSearchStrategy(DatabaseConnection databaseConnection)
        {
            _DatabaseConnection = databaseConnection;
        }


        /// <summary>
        /// Get all students
        /// </summary>
        public DataTable GetAllStudents()
        {
            DataAccess da = new DataAccess(_DatabaseConnection);
            return da.GetData(new StoredProcedureObj("SPReadAllStudents", new List<SqlParameter>()));
        }


        /// <summary>
        /// Get all hosts
        /// </summary>
        public DataTable GetAllHosts()
        {
            DataAccess da = new DataAccess(_DatabaseConnection);
            return da.GetData(new StoredProcedureObj("SPViewAllFamilies", new List<SqlParameter>()));
        }


        /// <summary>
        /// Get active students
        /// </summary>
        public DataTable GetActiveStudents()
        {
            DataAccess da = new DataAccess(_DatabaseConnection);
            return da.GetData(new StoredProcedureObj("GetActiveStudents", new List<SqlParameter>()));
        }


        /// <summary>
        /// Get active hosts
        /// </summary>
        public DataTable GetActiveHosts()
        {
            DataAccess da = new DataAccess(_DatabaseConnection);
            return da.GetData(new StoredProcedureObj("GetActiveHosts", new List<SqlParameter>()));
        }


        /// <summary>
        /// Get "looking" students
        /// </summary>
        public DataTable GetLookingStudents()
        {
            DataAccess da = new DataAccess(_DatabaseConnection);
            return da.GetData(new StoredProcedureObj("GetLookingStudents", new List<SqlParameter>()));
        }


        /// <summary>
        /// Get "looking" hosts
        /// </summary>
        public DataTable GetLookingHosts()
        {
            DataAccess da = new DataAccess(_DatabaseConnection);
            return da.GetData(new StoredProcedureObj("GetLookingHosts", new List<SqlParameter>()));
        }


        private DatabaseConnection _DatabaseConnection { get; set; }
    }
}