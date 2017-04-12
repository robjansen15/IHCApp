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
        /// Get all applicants
        /// </summary>
        public DataTable GetAllApplicants()
        {
            DataAccess da = new DataAccess(_DatabaseConnection);
            return da.GetData(new StoredProcedureObj("SPReadAllStudents", new List<SqlParameter>()));
        }


        /// <summary>
        /// Get active applicants
        /// </summary>
        public DataTable GetActiveApplicants()
        {
            DataAccess da = new DataAccess(_DatabaseConnection);
            return da.GetData(new StoredProcedureObj("SPReadAllActiveApplicants", new List<SqlParameter>()));
        }

        /// <summary>
        /// Get historical applicants
        /// </summary>
        public DataTable GetHistoricalApplicants()
        {
            DataAccess da = new DataAccess(_DatabaseConnection);
            return da.GetData(new StoredProcedureObj("SPReadHistoricalApplicants", new List<SqlParameter>()));
        }


        /// <summary>
        /// Get "looking" applicants
        /// </summary>
        public DataTable GetLookingApplicants()
        {
            DataAccess da = new DataAccess(_DatabaseConnection);
            return da.GetData(new StoredProcedureObj("SPReadAllLookingApplicants", new List<SqlParameter>()));
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
        /// Get active hosts
        /// </summary>
        public DataTable GetActiveHosts()
        {
            DataAccess da = new DataAccess(_DatabaseConnection);
            return da.GetData(new StoredProcedureObj("SPReadAllActiveHosts", new List<SqlParameter>()));
        }

        /// <summary>
        /// Get historical hosts
        /// </summary>
        public DataTable GetHistoricalHosts()
        {
            DataAccess da = new DataAccess(_DatabaseConnection);
            return da.GetData(new StoredProcedureObj("SPReadHistoricalHosts", new List<SqlParameter>()));
        }


        /// <summary>
        /// Get "looking" hosts
        /// </summary>
        public DataTable GetLookingHosts()
        {
            DataAccess da = new DataAccess(_DatabaseConnection);
            return da.GetData(new StoredProcedureObj("SPReadAllLookingHosts", new List<SqlParameter>()));
        }


        private DatabaseConnection _DatabaseConnection { get; set; }
    }
}