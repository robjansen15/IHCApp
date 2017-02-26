using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandler.Database
{
    public class DatabaseConnection
    {
        public DatabaseConnection()
        {
            _Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HomestayDatabase"].ConnectionString);
            _StoredProcedureAdapter = new StoredProcedureAdapter(this);
            _LoginValidationAdapter = new LoginValidationAdapter(this);
        }


        public void Connect()
        {
            try
            {
                _Connection.Open();
            }
            catch (Exception e)
            {
               
            }
        }


        public void Disconnect()
        {
            try
            {
                _Connection.Close();
            }
            catch (Exception e)
            {
             
            }
        }


        public LoginValidationAdapter _LoginValidationAdapter { get; set; }
        public StoredProcedureAdapter _StoredProcedureAdapter { get; set; }
        public SqlConnection _Connection { get; set; }
    }
}