using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceApp;

namespace ServiceRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            //This starts the process that the service would typically call
            //This is for debugging purposes
            new Runner().Run();

            Console.Read();
        }
    }
}
