using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using IHCApp.Models;

namespace IHCApp.Database.Helper
{
    public class DataAccess
    {
        public DataAccess(DatabaseConnection databaseConnection)
        {
            _DatabaseConnection = databaseConnection;
        }

        /// <summary>
        /// Get any data table in a generic way 
        /// </summary>

        public DataTable GetData(StoredProcedureObj storedProcedureObj)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            _DatabaseConnection.Connect();
            try
            {
                cmd = new SqlCommand(storedProcedureObj._StoredProcedure, _DatabaseConnection.GetActiveConnection());

                //adds the parameters
                storedProcedureObj._Parameters.ForEach(x => cmd.Parameters.Add(x));
                cmd.CommandType = CommandType.StoredProcedure;
                da.SelectCommand = cmd;
                da.Fill(dt);
            }
            catch(Exception e)
            {
                var x = e.ToString();
            }
            finally
            {
                _DatabaseConnection.Disconnect();
            }

            return dt;
        }


        private DatabaseConnection _DatabaseConnection { get; set; }
    }
}