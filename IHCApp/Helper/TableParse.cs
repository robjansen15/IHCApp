using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IHCApp.Models;

namespace IHCApp.Helper
{
    public class TableParse<T>
    {
        public TableParse() { }


        public List<List<string>> Parse(List<T> obj)
        {
            List<List<string>> myList = new List<List<string>>();
         
            //each ROW
            foreach(var o in obj)
            {
                List<string> row = new List<string>();
                //each COLUMN
                foreach (var property in obj.GetType().GetProperties())
                {
                    if (property != null)
                    {
                        row.Add(property.GetValue(obj.GetType()).ToString());
                    }
                }

                myList.Add(row);
            }
            
            return myList;
        }
    }
}