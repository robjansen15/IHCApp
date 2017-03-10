using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            string str = new Serializer<Person>().Serialize(p);
            Console.WriteLine(str);

            Console.Read();
        }
    }

    public class Person
    {
        public Person()
        {
            name = "rob";
            age = 22;
        }

        public string name { get; set; }
        public int age { get; set; }
    }
}
