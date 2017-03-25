using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using IHCApp.Database.Helper;
using IHCApp.Models;

namespace IHCApp.Database
{
    public class DatabaseConnection
    {
        public DatabaseConnection()
        {
            _Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HomestayDatabase"].ConnectionString);
            _PublicStrategy = new PublicStrategy(this);
        }


        public DatabaseConnection(Token token)
        {
            _Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HomestayDatabase"].ConnectionString);
            _ProtectedStrategy = new ProtectedStrategy(this, token);
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


        public SqlConnection GetActiveConnection()
        {
            return _Connection;
        }


        public PublicStrategy _PublicStrategy { get; set; }
        public ProtectedStrategy _ProtectedStrategy { get; set; }  

        private SqlConnection _Connection { get; set; }
    }
}