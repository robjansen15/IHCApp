using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DataHandler.Models
{
    public class Student
    {
        public Student(string firstName, string lastName)
        {
            _FirstName = firstName;
            _LastName = lastName;
        }

        public string _FirstName { get; set; }
        public string _LastName { get; set; }
    }
}