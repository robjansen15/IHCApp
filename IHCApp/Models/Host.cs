using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IHCApp.Models
{
    public class Host
    {
        public Host(string timeToCenter, int numBathrooms, string dogsYN, string catsYN, int numDogs,
            int numCats, int numRooms, string about, string email, string street, string state, string city,
            string country, string zip, string primePhone, string secPhone, string hobbies, string looking, string occupied,
            string note, string toadmin)
        {
            _TimeToCenter = timeToCenter;
            _NumBathrooms = numBathrooms;
            _DogsYN = dogsYN;
            _CatsYN = catsYN;
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
            _ToAdmin = toadmin;

        }

        public string _TimeToCenter { get; set; }
        public int _NumBathrooms { get; set; }
        public string _DogsYN { get; set; }
        public string _CatsYN { get; set; }
        public int _NumDogs { get; set; }
        public int _NumCats { get; set; }
        public int _NumRooms { get; set; }
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
    }
}