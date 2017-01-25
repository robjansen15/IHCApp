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


        public void Print(string msg)
        {
            Console.WriteLine(msg);

            /*additional logging can be placed here*/
        }

    }
}
