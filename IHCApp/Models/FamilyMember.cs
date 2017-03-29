using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IHCApp.Models
{
    public class FamilyMember
    {
        public FamilyMember() { }
        public FamilyMember(int FamilyID, string FirstName, string LastName, string occupation, DateTime Date, string Gender, string Language, string RelationToHost, int uuid)
        {
            _FamilyID = FamilyID;
            _FirstName = FirstName;
            _LastName = LastName;
            _Occupation = occupation;
            _Date = Date;
            _Gender = Gender;
            _Language = Language;
            _RelationToHost = RelationToHost;
            _UUID = uuid;
        }

        public int _FamilyID { get; set; }
        public string _FirstName { get; set; }
        public string _LastName { get; set; }
        public string _Occupation { get; set; }
        public DateTime _Date { get; set; }
        public string _Gender { get; set; }
        public string _Language { get; set; }
        public string _RelationToHost { get; set; }
        public int _UUID { get; set; }
    }
}