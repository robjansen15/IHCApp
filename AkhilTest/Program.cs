using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHCApp.Database;
using IHCApp.Models;
using System.Data;

namespace AkhilTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> testString = new DatabaseConnection()._PublicStrategy._PublicDataStrategy.GetAllCountries();

            Token t = new Token("token", "email");

            DataTable dt = new DatabaseConnection(t)._ProtectedStrategy._QuickSearchStrategy.GetAllHosts();

            List<string> email = new List<string>();

            List<Host> host = new List<Host>();

            foreach (DataRow row in dt.Rows)
            {
                Host h = new Host();

                h._Email = row["F_Email"].ToString();

                //familyNmae.Add(row["F_Name"]).ToString();


                host.Add(h);


            }
            Console.Read();
        }
    }
}
