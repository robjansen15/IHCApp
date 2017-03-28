using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using IHCApp.Models;

namespace IHCApp.Database.Public
{
    public class InsertStrategy
    {
        public InsertStrategy(DatabaseConnection databaseConnection)
        {
            _DatabaseConnection = databaseConnection;
        }

        /// <summary>
        /// Insert host application into tables
        /// </summary>
        public string InsertHost(Host host)
        {
            _DatabaseConnection.Connect();
            int famID = -1;

            try
            {
                SqlCommand command = new SqlCommand("SPInsertAndReturnFamilyId", _DatabaseConnection.GetActiveConnection());
                command.CommandType = CommandType.StoredProcedure;

                //Add as many parameters as you want
                command.Parameters.Add(new SqlParameter("@Time_ToCenter", host._TimeToCenter));
                command.Parameters.Add(new SqlParameter("@F_NoOfBathrooms", host._NumBathrooms));
                command.Parameters.Add(new SqlParameter("@F_Dogs", host._DogsYN));
                command.Parameters.Add(new SqlParameter("@F_Cats", host._CatsYN));
                command.Parameters.Add(new SqlParameter("@F_NoOfDogs", host._NumDogs));
                command.Parameters.Add(new SqlParameter("@F_NoOfCats", host._NumCats));
                command.Parameters.Add(new SqlParameter("@F_NoOfRooms", host._NumRooms));
                command.Parameters.Add(new SqlParameter("@F_About", host._About));
                command.Parameters.Add(new SqlParameter("@F_Email", host._Email));
                command.Parameters.Add(new SqlParameter("@F_Street", host._Street));
                command.Parameters.Add(new SqlParameter("@F_State", host._State));
                command.Parameters.Add(new SqlParameter("@F_City", host._City));
                command.Parameters.Add(new SqlParameter("@F_Country", host._Country));
                command.Parameters.Add(new SqlParameter("@F_Zip", host._Zip));
                command.Parameters.Add(new SqlParameter("@F_PrimePh_no", host._PrimePhone));
                command.Parameters.Add(new SqlParameter("@F_SecPh_no", host._SecPhone));
                command.Parameters.Add(new SqlParameter("@F_Hobbies", host._Hobbies));
                command.Parameters.Add(new SqlParameter("@F_Looking", host._Looking));
                command.Parameters.Add(new SqlParameter("@F_Occupied", host._Occupied));
                command.Parameters.Add(new SqlParameter("@F_Note", host._Note));
                command.Parameters.Add(new SqlParameter("@F_ToAdmin", host._ToAdmin));
                using (SqlDataReader rdr = command.ExecuteReader())
                {
                    ///gets the specific columns needed from the table

                    while (rdr.Read())
                    {
                        famID = rdr.GetInt32(0);
                    }
                }
            }
            catch (Exception e)
            {
                var x = e.ToString();
            }
            finally
            {
                _DatabaseConnection.Disconnect();
            }

            return famID.ToString();
        }


        public void InsertFamilyMemeber(FamilyMember familyMember, int hostID)
        {
            _DatabaseConnection.Connect();
            int _hostID = hostID;
            try
            {
                SqlCommand command = new SqlCommand("SPInserthost", _DatabaseConnection.GetActiveConnection());
                command.CommandType = CommandType.StoredProcedure;

                //Add as many parameters as you want
                command.Parameters.Add(new SqlParameter("@host_Id", _hostID));
                command.Parameters.Add(new SqlParameter("@Member_FirstName", familyMember._FirstName));
                command.Parameters.Add(new SqlParameter("@Member_LastName", familyMember._LastName));
                command.Parameters.Add(new SqlParameter("@Member_Occupation", familyMember._Occupation));
                command.Parameters.Add(new SqlParameter("@member_DOB", familyMember._Date));
                command.Parameters.Add(new SqlParameter("@Member_Gender", familyMember._Gender));
                command.Parameters.Add(new SqlParameter("@Member_Language", familyMember._Language));
                command.Parameters.Add(new SqlParameter("@Member_RelationToHost", familyMember._RelationToHost));

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                var x = e.ToString();
            }
            finally
            {
                _DatabaseConnection.Disconnect();
            }

            _DatabaseConnection.Disconnect();
        }


        /// <summary>
        /// Insert Applicant
        /// </summary>
        public void InsertApplicant(Applicant applicant)
        {
            _DatabaseConnection.Connect();
            try
            {

                SqlCommand command = new SqlCommand("SPInserthostAndReturnhostId", _DatabaseConnection.GetActiveConnection());
                command.CommandType = CommandType.StoredProcedure;

                //Add as many parameters as you want
                command.Parameters.Add(new SqlParameter("@A_FirstName", applicant._FirstName));
                command.Parameters.Add(new SqlParameter("@A_LastName", applicant._LastName));
                command.Parameters.Add(new SqlParameter("@A_ReqMovInDate", applicant._MoveInDate));
                command.Parameters.Add(new SqlParameter("@A_DurationOfStay", applicant._DurationOfStay));
                command.Parameters.Add(new SqlParameter("@A_Language", applicant._Language));
                command.Parameters.Add(new SqlParameter("@A_Gender", applicant._Gender));
                command.Parameters.Add(new SqlParameter("@A_Status", applicant._Status));
                command.Parameters.Add(new SqlParameter("@A_Nationality", applicant._Nationality));
                command.Parameters.Add(new SqlParameter("@A_Street", applicant._Street));
                command.Parameters.Add(new SqlParameter("@A_State", applicant._State));
                command.Parameters.Add(new SqlParameter("@A_City", applicant._City));
                command.Parameters.Add(new SqlParameter("@A_Country", applicant._Country));
                command.Parameters.Add(new SqlParameter("@A_FlightId", applicant._FlightID));
                command.Parameters.Add(new SqlParameter("@A_FlightDate", applicant._FlightDate));
                command.Parameters.Add(new SqlParameter("@A_FlightName", applicant._FlightName));
                command.Parameters.Add(new SqlParameter("@A_Dog", applicant._Dog));
                command.Parameters.Add(new SqlParameter("@A_Cat", applicant._Cat));
                command.Parameters.Add(new SqlParameter("@A_HealthIssues", applicant._HealthIssues));
                command.Parameters.Add(new SqlParameter("@A_DOB", applicant._DOB));
                command.Parameters.Add(new SqlParameter("@A_PrimePh_no", applicant._PrimePhone));
                command.Parameters.Add(new SqlParameter("@A_SecPh_no", applicant._SecondaryPhone));
                command.Parameters.Add(new SqlParameter("@A_Hobbies", applicant._Hobbies));
                command.Parameters.Add(new SqlParameter("@A_About", applicant._About));
                command.Parameters.Add(new SqlParameter("@A_PayDate", applicant._Paydate));
                command.Parameters.Add(new SqlParameter("@A_DepositDate", applicant._DepositDate));
                command.Parameters.Add(new SqlParameter("@A_PaymentAmount", applicant._PaymentAmount));
                command.Parameters.Add(new SqlParameter("@A_Id", applicant._ID));
                command.Parameters.Add(new SqlParameter("@A_OtherUniversity", applicant._OtherUniversity));
                command.Parameters.Add(new SqlParameter("@A_Email", applicant._Email));
                command.Parameters.Add(new SqlParameter("@A_EmergencyContact", applicant._EmergencyContact));
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                var x = e.ToString();
            }
            finally
            {
                _DatabaseConnection.Disconnect();
            }

            _DatabaseConnection.Disconnect();
        }

        private DatabaseConnection _DatabaseConnection { get; set; }
    }
}