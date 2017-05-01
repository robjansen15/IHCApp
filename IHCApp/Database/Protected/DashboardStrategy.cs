using IHCApp.Database.Helper;
using IHCApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IHCApp.Database.Protected
{
    public class DashboardStrategy
    {
        public DashboardStrategy(DatabaseConnection databaseConnection)
        {
            _DatabaseConnection = databaseConnection;
        }

        /// <summary>
        /// Logic for dynamic search will go here
        /// </summary>

        public string ActiveHosts()
        {
            string count = "0";

            DataAccess da = new DataAccess(_DatabaseConnection);
            List<SqlParameter> parameters = new List<SqlParameter>();
        

            DataTable dt = da.GetData(new StoredProcedureObj("Active_Hosts", parameters));

            foreach (DataRow row in dt.Rows)
            {
                count = row["CNT"].ToString();             
            }

            return count;
        }


        public string ActiveApplicants()
        {
            string count = "0";

            DataAccess da = new DataAccess(_DatabaseConnection);
            List<SqlParameter> parameters = new List<SqlParameter>();


            DataTable dt = da.GetData(new StoredProcedureObj("Active_Applicants", parameters));

            foreach (DataRow row in dt.Rows)
            {
                count = row["CNT"].ToString();
            }

            return count;
        }


        public string TotalApplicants()
        {
            string count = "0";

            DataAccess da = new DataAccess(_DatabaseConnection);
            List<SqlParameter> parameters = new List<SqlParameter>();


            DataTable dt = da.GetData(new StoredProcedureObj("Total_Applicants", parameters));

            foreach (DataRow row in dt.Rows)
            {
                count = row["CNT"].ToString();
            }

            return count;
        }



        private DatabaseConnection _DatabaseConnection { get; set; }
    }
}