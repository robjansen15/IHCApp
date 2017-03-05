using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataHandler.Models
{
    public class DynamicSearchObj
    {
        public DynamicSearchObj()
        {
            backgroundChecks = new List<BackgroundCheck>();
        }

        //will have all attributes

        //--student attributes

        //--family attributes
            //--include background check list
        public string familyName { get; set; }
        public List<BackgroundCheck> backgroundChecks { get; set; }

        //--institution attributes

        //
    }

    public class BackgroundCheck
    {
        public BackgroundCheck()
        {

        }

        public string familyName { get; set; }
        public string familyMemberName { get; set; }
        public bool status { get; set; }
    }
}