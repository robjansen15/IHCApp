using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataHandler.Controllers;

namespace DataHandler.Tests.Controllers
{
    [TestClass]
    public class AdminControllerTests
    {
        [TestMethod]
        public void tokenGeneratorValidTest()
        {
            AdminController testController = new AdminController();

            if(testController.tokenGenerator("username", "password").Contains("null") == true)
            {
                throw new Exception("failed to generate a token");
            }
        }

        [TestMethod]
        public void tokenSaveValidTest()
        {
            AdminController testController = new AdminController();

            if(testController.tokenSave("token") == false)
            {
                throw new Exception("failed to save token");
            }
        }

        [TestMethod]
        public void validateValidTest()
        {
            AdminController testController = new AdminController();

            if (testController.validate("username", "password") == false)
            {
                throw new Exception("failed to save token");
            }
        }

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
