using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataHandler.Controllers;

namespace DataHandler.Tests.Controllers
{
    [TestClass]
    public class AdminControllerTests
    {
        /// <summary>
        /// this means it failed the entire process
        /// </summary>
        [TestMethod]
        public void authenticateValidTest()
        {
            AdminController testController = new AdminController();

            if (testController.authenticate("username", "password").Contains("null") == true)
            {
                throw new Exception("failed to authenticate");
            }
        }



    }
}
