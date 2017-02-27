using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataHandler.Controllers;
using DataHandler.Models;


namespace DataHandler.Tests.Controllers
{
    [TestClass]
    public class SearchControllerTests
    {
        [TestMethod]
        public void searchBySchoolValidTest()
        {
            SearchController testController = new SearchController();

            string str = testController.getApplicantsBySchool("token");       
        }
    }
}
