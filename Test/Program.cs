using System;
using System.Collections.Generic;
using IHCApp.Database;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHCApp.Models;
using System.Data;
using IHCApp.Helper;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> testString = new DatabaseConnection()._PublicStrategy._PublicDataStrategy.GetAllCountries();

            Token t = new Token("token", "email");

            DataTable dt1 = new DatabaseConnection(t)._ProtectedStrategy._QuickSearchStrategy.GetAllHosts();
            DataTable dt2 = new DatabaseConnection(t)._ProtectedStrategy._QuickSearchStrategy.GetActiveStudents();
            DataTable dt3 = new DatabaseConnection(t)._ProtectedStrategy._QuickSearchStrategy.GetAllHosts();
            DataTable dt4 = new DatabaseConnection(t)._ProtectedStrategy._QuickSearchStrategy.GetAllStudents();
            DataTable dt5 = new DatabaseConnection(t)._ProtectedStrategy._QuickSearchStrategy.GetLookingHosts();
            DataTable dt6 = new DatabaseConnection(t)._ProtectedStrategy._QuickSearchStrategy.GetLookingStudents();


            List<Host> hosts = new List<Host>();

            //foreach (DataRow row in dt.Rows)
            //{
            //    Host h = new Host();

            //    h._Email = row["F_Email"].ToString();
            //    h._About = row["A_About"].ToString();

            //    hosts.Add(h);             
            //}

            Host h = new Host();

            h._Email = "rob@gmail.com";
            h._About = "about me";

            hosts.Add(h);
            hosts.Add(h);

            List<List<string>> table = new TableParse<Host>().Parse(hosts);



            //Quick Search

            /*Applicant
                 [A_id]               INT            IDENTITY (1, 1) NOT NULL,
                [A_FirstName]        VARCHAR (50)   NOT NULL,
                [A_LastName]         VARCHAR (50)   NOT NULL,
                [A_ReqMovInDate]     DATE           NOT NULL,
                [A_DurationOfStay]   INT            NOT NULL,
                [A_Language]         VARCHAR (20)   NOT NULL,
                [A_Gender]           VARCHAR (6)    NULL,
                [A_Status]           VARCHAR (12)   NULL,
                [A_Nationality]      VARCHAR (50)   NULL,
                [A_Street]           NVARCHAR (50)  NOT NULL,
                [A_State]            VARCHAR (50)   NOT NULL,
                [A_City]             VARCHAR (50)   NOT NULL,
                [A_Country]          VARCHAR (50)   NOT NULL,
                [A_FlightId]         NVARCHAR (20)  NOT NULL,
                [A_FlightTime]       TIME (7)       NOT NULL,
                [A_FlightDate]       DATE           NOT NULL,
                [A_FlightName]       NVARCHAR (50)  NULL,
                [A_Dog]              VARCHAR (3)    NOT NULL,
                [A_Cat]              VARCHAR (3)    NOT NULL,
                [A_HealthIssues]     VARCHAR (MAX)  NOT NULL,
                [A_D.O.B]            DATE           NOT NULL,
                [A_PrimePh_no]       NVARCHAR (20)  NOT NULL,
                [A_secPh_no]         NVARCHAR (20)  NULL,
                [A_Hobbies]          NVARCHAR (MAX) NOT NULL,
                [A_About]            VARCHAR (MAX)  NOT NULL,
                [A_Paydate]          DATE           NOT NULL,
                [A_DespositDate]     DATE           NOT NULL,
                [A_PaymentAmount]    INT            NOT NULL,
                [I_Id]               INT            NULL,
                [OtherUniversity]    VARCHAR (50)   NULL,
                [A_Email]            NVARCHAR (320) NOT NULL,
                [A_EmergencyContact] NVARCHAR (20)  NULL,              
             */

            /* FAMILY
              [Family_Id]       INT            IDENTITY (1, 1) NOT NULL,
                [Time_toCenter]   INT            NOT NULL,
                [F_NoOfBathrooms] INT            NOT NULL,
                [F_Dogs]          VARCHAR (3)    NULL,
                [F_Cats]          VARCHAR (3)    NULL,
                [F_noOfDogs]      INT            NULL,
                [F_noOfCats]      INT            NULL,
                [F_NoOfRooms]     INT            NULL,
                [F_about]         VARCHAR (MAX)  NOT NULL,
                [F_Email]         NVARCHAR (320) NOT NULL,
                [F_Street]        NVARCHAR (50)  NOT NULL,
                [F_state]         VARCHAR (50)   NOT NULL,
                [F_city]          VARCHAR (50)   NOT NULL,
                [F_Country]       VARCHAR (50)   NOT NULL,
                [F_Zip]           NVARCHAR (20)  NOT NULL,
                [F_PrimePh_no]    NVARCHAR (20)  NOT NULL,
                [F_SecPh_no]      NVARCHAR (20)  NULL,
                [F_Hobbies]       NVARCHAR (MAX) NOT NULL,
                [F_looking]       VARCHAR (3)    NOT NULL,
                [F_occupied]      VARCHAR (3)    NOT NULL,
                [F_note]          NVARCHAR (MAX) NULL,
                [F_ToAdmin]       NVARCHAR (MAX) NULL,
             */

            ///Have a HOST and leave properties null if you don't use them



            Console.Read();
        }

        ///Method that can look through an object such as a HOST
        ///Search through all of the properies and if a property is null skip it...
        ///

 
    }
}
