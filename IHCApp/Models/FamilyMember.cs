using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IHCApp.Models
{
    public class FamilyMember
    {
        public FamilyMember() { }
        public FamilyMember(int FamilyID, string FirstName, string LastName, string occupation, string Age, string Gender, string Language, string RelationToHost, bool? IsHost)
        {
            _HostId = FamilyID;
            _FirstName = FirstName;
            _LastName = LastName;
            _Occupation = occupation;
            _Age = Age;
            _Gender = Gender;
            _Language = Language;
            _RelationToHost = RelationToHost;
            _IsHost = IsHost;

        }

        public int _HostId { get; set; }
        public string _FirstName { get; set; }
        public string _LastName { get; set; }
        public string _Occupation { get; set; }
        public string _Age { get; set; }
        public string _Gender { get; set; }
        public string _Language { get; set; }
        public string _RelationToHost { get; set; }
        public bool? _IsHost { get; set; }
    }
}