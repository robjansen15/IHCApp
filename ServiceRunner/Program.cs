using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceRunner
{
    class Program
    {
        static void Main(string[] args)
        { 

            Runner r = new Runner();

            r.Run();

            //so you can view output
            Console.Read();
        }
    }
}
