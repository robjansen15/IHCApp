using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Database
{
    public class DatabaseConnection
    {
        public DatabaseConnection(string databaseConfigString)
        {
            Connection = new SqlConnection(ConfigurationManager.ConnectionStrings[databaseConfigString].ConnectionString);
        }


        /*
        Purpose: Connects the database connection
        Last Date Modified: 1/25
        Tested: True
        Explanation: 
        */
        public void Connect()
        {
            try
            {
                Connection.Open();
            }
            catch (Exception e)
            {
                Variables.GetInstance.Log.Print(e.ToString());
            }
        }


        /*
        Purpose: Disconnects the the database connection
        Last Date Modified: 1/25
        Tested: True
        Explanation: 
        */
        public void Disconnect()
        {
            try
            {
                Connection.Close();
            }
            catch (Exception e)
            {
                Variables.GetInstance.Log.Print(e.ToString());
            }
        }


        public SqlConnection Connection { get; private set; }
    }
}
