using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.Database
{
    public class DatabaseHelper
    {
        public DatabaseHelper(){ }


        /*
        Purpose: Sample read stored procedure
        Last Date Modified: 1/25
        Tested: True
        Explanation: 
        */
        public void ReadStoredProcedure(DatabaseConnection dbConnection)
        {
            dbConnection.Connect();

            try
            {
                SqlDataReader reader = null;
                SqlCommand command = new SqlCommand("procedure here", dbConnection.Connection);
                command.CommandType = CommandType.StoredProcedure;

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    /*Do what you need to do here for reading*/
                }
            }
            catch (Exception e)
            {
                Variables.GetInstance.Log.Print(e.ToString());
            }

            dbConnection.Disconnect();
        }


        /*
        Purpose: Sample write stored procedure
        Last Date Modified: 1/25
        Tested: False
        Explanation: 
        */
        public void WriteStoredProcedure(DatabaseConnection dbConnection, string value, string value1)
        {
            dbConnection.Connect();

            try
            {
                SqlCommand command = new SqlCommand("procedure here", dbConnection.Connection);
                command.CommandType = CommandType.StoredProcedure;

                //Add as many parameters as you want
                command.Parameters.Add(new SqlParameter("@param", value));
                command.Parameters.Add(new SqlParameter("@param1", value1));

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Variables.GetInstance.Log.Print(e.ToString());
            }

            dbConnection.Disconnect();
        }

    }
}
