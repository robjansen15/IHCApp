using System;
using System.Collections.Generic;
using IHCApp.Database;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHCApp.Models;
using System.Data;
using IHCApp.Helper;

namespace IHCApp.Helper
{
    public class TableParse<T>
    {
        public TableParse() { }


        public List<List<string>> ParseForDisplay(List<T> obj)
        {
            List<List<string>> myList = new List<List<string>>();
         
            //each ROW
            foreach(var o in obj)
            {
                List<string> row = new List<string>();
                //each COLUMN
                foreach (var property in obj.GetType().GetProperties())
                {
                    if (property != null)
                    {

                        row.Add(property.GetValue(obj.GetType()).ToString());
                    }
                }

                myList.Add(row);
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
                    _NumBathrooms = row.Field<int?>("F_NoOfBathrooms"),
                    _DogsYN = row.Field<string>("F_Dogs"),
                    _CatsYN = row.Field<string>("F_Cats"),
                    _NumDogs = row.Field<int?>("F_noOfDogs"),
                    _NumCats = row.Field<int?>("F_noOfCats"),
                    _NumRooms = row.Field<int?>("F_NoOfRooms"),
                    _About = row.Field<string>("F_about"),
                    _Email = row.Field<string>("F_Email"),
                    _Street = row.Field<string>("F_Street"),
                    _State = row.Field<string>("F_state"),
                    _City = row.Field<string>("F_city"),
                    _Country = row.Field<string>("F_Country"),
                    _Zip = row.Field<string>("F_Zip"),
                    _PrimePhone = row.Field<string>("F_PrimePh_no"),
                    _SecPhone = row.Field<string>("F_SecPh_no"),
                    _Hobbies = row.Field<string>("F_Hobbies"),
                    _Looking = row.Field<string>("F_looking"),
                    _Occupied = row.Field<string>("F_occupied"),
                    _Note = row.Field<string>("F_note"),
                    _ToAdmin = row.Field<string>("F_ToAdmin"),

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
                    _DurationOfStay = row.Field<int?>("A_DurationOfStay"),
                    _Language = row.Field<string>("A_Language"),
                    _Gender = row.Field<string>("A_Gender"),
                    _Status = row.Field<string>("A_Status"),
                    _Nationality = row.Field<string>("A_Nationality"),
                    _Street = row.Field<string>("A_Street"),
                    _State = row.Field<string>("A_State"),
                    _City = row.Field<string>("A_City"),
                    _Country = row.Field<string>("A_Country"),
                    _FlightID = row.Field<string>("A_FlightId"),
                    _FlightTime = row.Field<DateTime>("A_FlightTime"),
                    _FlightDate = row.Field<DateTime>("A_FlightDate"),
                    _FlightName = row.Field<string>("A_FlightName"),
                    _Dog = row.Field<string>("A_Dog"),
                    _Cat = row.Field<string>("A_Cat"),
                    _HealthIssues = row.Field<string>("A_HealthIssues"),
                    _DOB = row.Field<DateTime>("A_D.O.B."),
                    _PrimePhone = row.Field<string>("A_PrimePh_no"),
                    _SecondaryPhone = row.Field<string>("A_SecPh_no"),
                    _Hobbies = row.Field<string>("A_Hobbies"),
                    _About = row.Field<string>("A_About"),
                    _Paydate = row.Field<DateTime>("A_Paydate"),
                    _DepositDate = row.Field<DateTime>("A_DepositDate"),
                    _PaymentAmount = row.Field<int?>("A_PaymentAmount"),
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
                    _FamilyID = row.Field<int>("Family_Id"),
                    _FirstName = row.Field<string>("Member_FirstName"),
                    _LastName = row.Field<string>("Member_LastName"),
                    _Occupation = row.Field<string>("Member_Occupation"),
                    _Date = row.Field<DateTime>("Member_D.O.B"),
                    _Gender = row.Field<string>("Member_Gender"),
                    _Language = row.Field<string>("Member_Language"),
                    _RelationToHost = row.Field<string>("Member_RelationToHost"),
                    _UUID = row.Field<int>("F_UUID"),

                }).ToList();
            return hostmember;
        }
    }
}