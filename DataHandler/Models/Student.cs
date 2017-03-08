using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DataHandler.Models
{
    public class Student
    {
        public Student(string firstname, string lastname, DateTime moveindate, int durationofstay, string language, string gender, string status,
            string nationality, string street, string state, string city, string country, string flightID, DateTime flighttime, DateTime flightdate,
            string flightname, string dog, string cat, string healthissues, DateTime dob, string primephone, string secondaryphone, string hobbies,
            string about, DateTime paydate, DateTime depositdate, int paymentamount, int id, string otheruniversity, string email, string emergencycontact)
        {
            _FirstName = firstname;
            _LastName = lastname;
            _MoveInDate = moveindate;
            _DurationOfStay = durationofstay;
            _Language = language;
            _Gender = gender;
            _Status = status;
            _Nationality = nationality;
            _Street = street;
            _City = city;
            _Country = country;
            _FlightID = flightID;
            _FlightTime = flighttime;
            _FlightDate = flightdate;
            _FlightName = flightname;
            _Dog = dog;
            _Cat = cat;
            _HealthIssues = healthissues;
            _DOB = dob;
            _PrimePhone = primephone;
            _SecondaryPhone = secondaryphone;
            _Hobbies = hobbies;
            _About = about;
            _Paydate = paydate;
            _DepositDate = depositdate;
            _PaymentAmount = paymentamount;
            _ID = id;
            _OtherUniversity = otheruniversity;
            _Email = email;
            _EmergencyContact = emergencycontact;
        }

        public string _FirstName { get; set; }
        public string _LastName { get; set; }
        public DateTime _MoveInDate { get; set; }
        public int _DurationOfStay { get; set; }
        public string _Language { get; set; }
        public string _Gender { get; set; }
        public string _Status { get; set; }
        public string _Nationality { get; set; }
        public string _Street { get; set; }
        public string _State { get; set; }
        public string _City { get; set; }
        public string _Country { get; set; }
        public string _FlightID { get; set; }
        public DateTime _FlightTime { get; set; }
        public DateTime _FlightDate { get; set; }
        public string _FlightName { get; set; }
        public string _Dog { get; set; }
        public string _Cat { get; set; }
        public string _HealthIssues { get; set; }
        public DateTime _DOB { get; set; }
        public string _PrimePhone { get; set; }
        public string _SecondaryPhone { get; set; }
        public string _Hobbies { get; set; }
        public string _About { get; set; }
        public DateTime _Paydate { get; set; }
        public DateTime _DepositDate { get; set; }
        public int _PaymentAmount { get; set; }
        public int _ID { get; set; }
        public string _OtherUniversity { get; set; }
        public string _Email { get; set; }
        public string _EmergencyContact { get; set; }
        /*
         * @A_FirstName varchar(50),
        @A_LastName varchar(50),
        @A_ReqMovInDate date,
        @A_DurationOfStay int,
        @A_Language varchar(20),
        @A_Gender varchar(6),
        @A_Status varchar(12),
        @A_Nationality varchar(50),
        @A_Street nvarchar(50),
        @A_State varchar(50),
        @A_City varchar(50),
        @A_Country varchar(50),
        @A_FlightId nvarchar(20),
        @A_FlightTime time(7),
        @A_FlightDate date,
        @A_FlightName nvarchar(50),
        @A_Dog varchar(3),
        @A_Cat varchar(3),
        @A_HealthIssues varchar(max),
        @A_DOB date,
        @A_PrimePh_no nvarchar(20),
        @A_SecPh_no nvarchar(20),
        @A_Hobbies nvarchar(max),
        @A_About varchar(max),
        @A_PayDate date,
        @A_DepositDate date,
        @A_PaymentAmount int,
        @A_Id int,
        @A_OtherUniversity varchar(50),
        @A_Email nvarchar(320),
        @A_EmergencyContact nvarchar(20) 
        */
    }

}