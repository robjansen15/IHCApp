using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataHandler.Enumerations
{
    public class EnumerationContainer
    {
        public EnumerationContainer()
        {
            //firstName;lastName
            _GetStudentsBySchoolEnumeration = "1;2";
        }

        public string _GetStudentsBySchoolEnumeration { get; set; }
    }
}