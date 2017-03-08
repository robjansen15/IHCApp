using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataHandler.Models
{
    public class FamilyMember
    {
        public FamilyMember(int FamilyID, string FirstName, string LastName, string Occupation, DateTime Date, string Gender, string Language, string RelationToHost)
        {
            _FamilyID = FamilyID;
            _FirstName = FirstName;
            _LastName = LastName;
            _Occupation = Occupation;
            _Date = Date;
            _Gender = Gender;
            _Language = Language;
            _RelationToHost = RelationToHost;


        }

        public int _FamilyID { get; set; }
        public string _FirstName { get; set; }
        public string _LastName { get; set; }
        public string _Occupation { get; set; }
        public DateTime _Date { get; set; }
        public string _Gender { get; set; }
        public string _Language { get; set; }
        public string _RelationToHost { get; set; }
    }
}