using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using IHCApp.Database;
using IHCApp.Models;
using IHCApp.Authentication;
using IHCApp.Helper;
using System.Data;
using System.Collections.Generic;

namespace IHCAppTests
{
    [TestClass]
    public class Retrieval
    {
        /// <summary>
        /// HOSTS
        /// </summary>
        [TestMethod]
        public void GetAllHosts()
        {
            //creates a token based off the credentials "Xiao" and "xiao123"
            Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");

            //This is the parser that helps convert the DataTable -> List<Hosts> -> List<List<string>>
            TableParse<Host> parser = new TableParse<Host>();

            //this converts DataTable -> List<Host>
            List<Host> hosts = parser.ParseHosts(new DatabaseConnection(token)._ProtectedStrategy._QuickSearchStrategy.GetAllHosts());

            //this converts List<Host> -> List<List<string>>
            List<List<string>> displayTables = parser.ParseForDisplay(hosts);
        }


        [TestMethod]
        public void GetActiveHosts()
        {
            //creates a token based off the credentials "Xiao" and "xiao123"
            Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");

            //This is the parser that helps convert the Datatables -> List<Hosts> -> List<List<string>>
            TableParse<Host> parser = new TableParse<Host>();

            //this converts DataTable -> List<Host>
            List<Host> hosts = parser.ParseHosts(new DatabaseConnection(token)._ProtectedStrategy._QuickSearchStrategy.GetActiveHosts());

            //this converts List<Host> -> List<List<string>>
            List<List<string>> displayTables = parser.ParseForDisplay(hosts);
        }


        [TestMethod]
        public void GetLookingHosts()
        {
            //creates a token based off the credentials "Xiao" and "xiao123"
            Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");

            //This is the parser that helps convert the Datatables -> List<Hosts> -> List<List<string>>
            TableParse<Host> parser = new TableParse<Host>();

            //this converts DataTable -> List<Host>
            List<Host> hosts = parser.ParseHosts(new DatabaseConnection(token)._ProtectedStrategy._QuickSearchStrategy.GetLookingHosts());

            //this converts List<Host> -> List<List<string>>
            List<List<string>> displayTables = parser.ParseForDisplay(hosts);
        }


        /// <summary>
        /// APPLICANTS
        /// </summary>
        [TestMethod]
        public void GetAllApplicants()
        {
            //creates a token based off the credentials "Xiao" and "xiao123"
            Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");

            //This is the parser that helps convert the Datatables -> List<Applicant> -> List<List<string>>
            TableParse<Applicant> parser = new TableParse<Applicant>();

            //this converts DataTable -> List<Applicant>
            List<Applicant> applicants = parser.ParseApplicant(new DatabaseConnection(token)._ProtectedStrategy._QuickSearchStrategy.GetAllApplicants());

            //this converts List<Applicant> -> List<List<string>>
            List<List<string>> displayTables = parser.ParseForDisplay(applicants);
        }

        public void GetActiveApplicants()
        {
            //creates a token based off the credentials "Xiao" and "xiao123"
            Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");

            //This is the parser that helps convert the Datatables -> List<Applicant> -> List<List<string>>
            TableParse<Applicant> parser = new TableParse<Applicant>();

            //this converts DataTable -> List<Applicant>
            List<Applicant> applicants = parser.ParseApplicant(new DatabaseConnection(token)._ProtectedStrategy._QuickSearchStrategy.GetActiveApplicants());

            //this converts List<Applicant> -> List<List<string>>
            List<List<string>> displayTables = parser.ParseForDisplay(applicants);
        }


        public void GetAllLookingApplicants()
        {
            //creates a token based off the credentials "Xiao" and "xiao123"
            Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");

            //This is the parser that helps convert the Datatables -> List<Applicant> -> List<List<string>>
            TableParse<Applicant> parser = new TableParse<Applicant>();

            //this converts DataTable -> List<Applicant>
            List<Applicant> applicants = parser.ParseApplicant(new DatabaseConnection(token)._ProtectedStrategy._QuickSearchStrategy.GetLookingApplicants());

            //this converts List<Applicant> -> List<List<string>>
            List<List<string>> displayTables = parser.ParseForDisplay(applicants);
        }



        /// <summary>
        /// EXTRA TODO LATER
        /// </summary>
        [TestMethod]
        public void GetApplicantWhoNeedPayments()
        {

        }

    }
}
