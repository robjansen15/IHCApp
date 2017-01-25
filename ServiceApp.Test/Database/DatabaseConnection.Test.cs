using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;


namespace ServiceApp.Test.Database
{
    [TestClass]
    public class DatabaseConnectionTest
    {
        [TestMethod]
        public void ConnectionTest()
        {
            ServiceApp.Database.DatabaseConnection target = new ServiceApp.Database.DatabaseConnection("TestDatabase");

            ConnectTest(target);
            DisconnectTest(target);
        }


        [TestMethod]
        public void ConnectTest(ServiceApp.Database.DatabaseConnection target)
        {
            target.Connect();
            Assert.IsTrue((target.Connection.State & ConnectionState.Open) != 0);
        }


        [TestMethod]
        public void DisconnectTest(ServiceApp.Database.DatabaseConnection target)
        {
            target.Disconnect();
            Assert.IsTrue((target.Connection.State & ConnectionState.Closed) != 0);
        }


    }
}
