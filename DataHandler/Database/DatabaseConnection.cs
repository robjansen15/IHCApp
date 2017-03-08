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
            _SearchStrategy = new SearchStrategy(this);
            _TokenStrategy = new TokenStrategy(this);
            _UnauthenticatedStrategy = new UnauthenticatedStrategy(this);
            _FormStrategy = new FormStrategy(this);
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


        public FormStrategy _FormStrategy { get; set; }
        public UnauthenticatedStrategy _UnauthenticatedStrategy { get; set; }
        public TokenStrategy _TokenStrategy { get; set; }
        public SearchStrategy _SearchStrategy { get; set; }
        public SqlConnection _Connection { get; set; }
    }
}