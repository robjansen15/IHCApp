using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IHCApp.Models
{
    public class Host
    {
        public Host() { }

        public Host(int? familyid, int? timeToCenter, string numBathrooms, string numDogs,
            string numCats, string numRooms, string about, string email, string street, string state, string city,
            string country, string zip, string primePhone, string secPhone, string hobbies, string looking, string occupied,
            string note, string toAdmin, string transportationInfo, string allowSmoking, string allowDrinking, string doesFamilySmoke, string doesFamilyDrink)
        {
            _FamilyID = familyid;
            _TimeToCenter = timeToCenter;
            _NumBathrooms = numBathrooms;
            _NumDogs = numDogs;
            _NumCats = numCats;
            _NumRooms = numRooms;
            _About = about;
            _Email = email;
            _Street = street;
            _State = state;
            _City = city;
            _Country = country;
            _Zip = zip;
            _PrimePhone = primePhone;
            _SecPhone = secPhone;
            _Hobbies = hobbies;
            _Looking = looking;
            _Occupied = occupied;
            _Note = note;
            _ToAdmin = toAdmin;
            _TransportationInfo = transportationInfo;
            _AllowSmoking = allowSmoking;
            _AllowDrinking = allowDrinking;
            _DoesFamilySmoke = doesFamilySmoke;
            _DoesFamilyDrink = doesFamilyDrink;


        public int? _FamilyID { get; set; }
        public int? _TimeToCenter { get; set; }
        public string _NumBathrooms { get; set; }
        public string _NumDogs { get; set; }
        public string _NumCats { get; set; }
        public string _NumRooms { get; set; }
        public string _About { get; set; }
        public string _Email { get; set; }
        public string _Street { get; set; }
        public string _State { get; set; }
        public string _City { get; set; }
        public string _Country { get; set; }
        public string _Zip { get; set; }
        public string _PrimePhone { get; set; }
        public string _SecPhone { get; set; }
        public string _Hobbies { get; set; }
        public string _Looking { get; set; }
        public string _Occupied { get; set; }
        public string _Note { get; set; }
        public string _ToAdmin { get; set; }
        public string _TransportationInfo { get; set; }
        public string _AllowSmoking { get; set; }
        public string _AllowDrinking { get; set; }
        public string _DoesFamilySmoke { get; set; }
        public string _DoesFamilyDrink { get; set; }
    }
}