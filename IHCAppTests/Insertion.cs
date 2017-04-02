using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IHCApp.Database;
using IHCApp.Models;
using IHCApp.Helper;
using System.Collections.Generic;

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
                throw new Exception("Failed to insert Applicant" + ex);
            }
           
        }



        [TestMethod]
        public void HostInsertTest()
        {
            try
            {
                Host host = new Host(-1, 15, 2, "yes", "no", 1, 2, 3, "about", "email", "street address", "IN", "Greenwood", "USA", "46142", "phone", "secPhone", "hoobies", "islooking", "occupied", "notes", "toadmin");
                int famUID = new DatabaseConnection()._PublicStrategy._InsertStrategy.InsertHost(host);

                List<FamilyMember> familyMembers = new List<FamilyMember>();
                familyMembers.Add(new FamilyMember(famUID, "rob", "jansen", "occupation", DateTime.Now, "male", "english", "son"));              
            }
            catch (Exception e)
            {
                var ex = e.ToString();
                throw new Exception("Failed to Insert Host" + ex);
            }

        }
    }
}
