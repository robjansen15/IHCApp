using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IHCApp.Database;
using IHCApp.Models;
using IHCApp.Helper;

namespace IHCAppTests
{
    [TestClass]
    public class InsertionTests
    {
        [TestMethod]
        public void ApplicantInsertTest()
        {
            try
            {
                Applicant applicant = new Applicant();

                new DatabaseConnection()._PublicStrategy._InsertStrategy.InsertApplicant(applicant);
            }
            catch(Exception e)
            {
                var ex = e.ToString();
                throw new Exception("Test #1 failed" + ex);
            }
           
        }
    }
}
