using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataHandler.Database;
using DataHandler.Models;

namespace DataHandler.Controllers
{
    public class FormController : Controller
    {
        [HttpPost]
        public void InsertStudent(string serializedObject)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
         
            try
            {
                Student std = new Serializer<Student>().Deserialize(serializedObject);
                databaseConnection._FormStrategy.insertStudent(new Serializer<Student>().Deserialize(serializedObject));         
            }
            catch(Exception e)
            {
                var err = e.ToString();
            }
            finally
            {

            }
        }


        [HttpPost]
        public void InsertFamily(string serializedObject)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();

            try
            {



            }
            catch
            {

            }
        }


        [HttpPost]
        public void InsertFamilyMember(string serializedObject)
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();

            try
            {


            }
            catch
            {

            }
        }



    }
}