using System;
using System.Collections.Generic;
using IHCApp.Database;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHCApp.Models;
using System.Data;
using IHCApp.Helper;
using System.Reflection;

namespace IHCApp.Helper
{
    public class TableParse<T>
    {
        public TableParse() { }


        public List<List<string>> ParseForDisplay(List<T> obj)
        {
            List<List<string>> myList = new List<List<string>>();

            foreach(var o in obj)
            {
                var stringProps = o.GetType().GetProperties().Where(p => p.PropertyType == typeof(string));
                var intProps = o.GetType().GetProperties().Where(p => p.PropertyType == typeof(Nullable<Int32>));

                List<string> list = new List<string>();

                foreach (var prop in stringProps)
                {
                    string val = (string)prop.GetValue(o);
                    list.Add(val);
                }

                foreach (var prop in intProps)
                {
                    Nullable<Int32> val = (Nullable<Int32>)prop.GetValue(o);

                    if(val != null)
                    {
                        list.Add(val.ToString());
                    }
                    else
                    {
                        list.Add("");
                    }
                }

                myList.Add(list);
            }
            
            return myList;
        }


        public List<Host> ParseHosts(DataTable dt)
        {
            List<Host> hosts = dt.AsEnumerable().Select(row =>
                new Host
                {
                    _FamilyID = row.Field<int?>("Family_Id"),
                    _TimeToCenter = row.Field<int?>("Time_toCenter"),
                    _NumBathrooms = row.Field<string>("NoOfBathrooms"),
                    _NumDogs = row.Field<string>("NoOfDogs"),
                    _NumCats = row.Field<string>("NoOfCats"),
                    _NumRooms = row.Field<string>("NoOfRooms"),
                    _About = row.Field<string>("About"),
                    _Email = row.Field<string>("Email"),
                    _Street = row.Field<string>("Street"),
                    _State = row.Field<string>("HostState"),
                    _City = row.Field<string>("City"),
                    _Country = row.Field<string>("Country"),
                    _Zip = row.Field<string>("Zip"),
                    _PrimePhone = row.Field<string>("PrimePh_no"),
                    _SecPhone = row.Field<string>("SecPh_no"),
                    _Hobbies = row.Field<string>("Hobbies"),
                    _Looking = row.Field<string>("Looking"),
                    _Occupied = row.Field<string>("Occupied"),
                    _Note = row.Field<string>("Note"),
                    _ToAdmin = row.Field<string>("ToAdmin"),

                }).ToList();
            return hosts;
        }


        public List<Applicant> ParseApplicant(DataTable dt)
        {
            List<Applicant> applicants = dt.AsEnumerable().Select(row =>
                new Applicant
                {
                    _ApplicantID = row.Field<int>("A_id"),
                    _FirstName = row.Field<string>("A_FirstName"),
                    _LastName = row.Field<string>("A_LastName"),
                    _MoveInDate = row.Field<DateTime>("A_ReqMovInDate"),
                    _DurationOfStay = row.Field<string>("A_DurationOfStay"),
                    _Language = row.Field<string>("A_Language"),
                    _Gender = row.Field<string>("A_Gender"),
                    _Status = row.Field<string>("A_Status"),
                    _Nationality = row.Field<string>("A_Nationality"),
                    _Street = row.Field<string>("A_Street"),
                    _State = row.Field<string>("A_State"),
                    _City = row.Field<string>("A_City"),
                    _Country = row.Field<string>("A_Country"),
                    _FlightID = row.Field<string>("A_FlightId"),
                    //_FlightTime = row.Field<string>("A_FlightTime"),
                    _FlightDate = row.Field<DateTime>("A_FlightDate"),
                    _FlightName = row.Field<string>("A_FlightName"),
                    _Dog = row.Field<string>("A_Dog"),
                    _Cat = row.Field<string>("A_Cat"),
                    _HealthIssues = row.Field<string>("A_HealthIssues"),
                    _DOB = row.Field<DateTime>("A_D.O.B"),
                    _PrimaryPhone = row.Field<string>("A_PrimePh_no"),
                    _SecondaryPhone = row.Field<string>("A_SecPh_no"),
                    _Hobbies = row.Field<string>("A_Hobbies"),
                    _About = row.Field<string>("A_About"),
                    _Paydate = row.Field<DateTime>("A_Paydate"),
                    _DepositDate = row.Field<DateTime>("A_DespositDate"),
                    _PaymentAmount = row.Field<string>("A_PaymentAmount"),
                    _ID = row.Field<int?>("I_Id"),
                    _OtherUniversity = row.Field<string>("OtherUniversity"),
                    _Email = row.Field<string>("A_Email"),
                    _EmergencyContact = row.Field<string>("A_EmergencyContact")

                }).ToList();
            return applicants;
        }


        public List<FamilyMember> ParseHostMember(DataTable dt)
        {
            List<FamilyMember> hostmember = dt.AsEnumerable().Select(row =>
                new FamilyMember
                {
                    _HostId = row.Field<int>("Family_Id"),
                    _FirstName = row.Field<string>("Member_FirstName"),
                    _LastName = row.Field<string>("Member_LastName"),
                    _Occupation = row.Field<string>("Member_Occupation"),
                    _Age = row.Field<string>("Member_Age"),
                    _Gender = row.Field<string>("Member_Gender"),
                    _Language = row.Field<string>("Member_Language"),
                    _RelationToHost = row.Field<string>("Member_RelationToHost"),
                    _IsHost = row.Field<bool?>("IsHost")

                }).ToList();
            return hostmember;
        }
    }
}