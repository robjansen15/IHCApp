using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApp.ErrorHandling
{
    public class Logging
    {
        public Logging() { }


        /*
        Purpose: This method is used for outputing messages to the console or windows event log
        Last Date Modified: 1/25
        Tested: True
        Explanation: 
        */
        public void Print(string msg)
        {
            Console.WriteLine(msg);

            /*additional logging can be placed here*/
        }

    }
}
