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
        public int InsertHost(Host host)
        {
            _DatabaseConnection.Connect();
            int famID = -1;

            try
            {
                SqlCommand command = new SqlCommand("SPInsertAndReturnFamilyId", _DatabaseConnection.GetActiveConnection());
                command.CommandType = CommandType.StoredProcedure;

                //Add as many parameters as you want
                command.Parameters.Add(new SqlParameter("@Time_ToCenter", host._TimeToCenter));
                command.Parameters.Add(new SqlParameter("@NoOfBathrooms", host._NumBathrooms));
                command.Parameters.Add(new SqlParameter("@NoOfDogs", host._NumDogs));
                command.Parameters.Add(new SqlParameter("@NoOfCats", host._NumCats));
                command.Parameters.Add(new SqlParameter("@NoOfRooms", host._NumRooms));
                command.Parameters.Add(new SqlParameter("@About", host._About));
                command.Parameters.Add(new SqlParameter("@Email", host._Email));
                command.Parameters.Add(new SqlParameter("@Street", host._Street));
                command.Parameters.Add(new SqlParameter("@HostState", host._State));
                command.Parameters.Add(new SqlParameter("@City", host._City));
                command.Parameters.Add(new SqlParameter("@Country", host._Country));
                command.Parameters.Add(new SqlParameter("@Zip", host._Zip));
                command.Parameters.Add(new SqlParameter("@PrimePh_no", host._PrimePhone));
                command.Parameters.Add(new SqlParameter("@SecPh_no", host._SecPhone));
                command.Parameters.Add(new SqlParameter("@Hobbies", host._Hobbies));
                command.Parameters.Add(new SqlParameter("@Looking", host._Looking));
                command.Parameters.Add(new SqlParameter("@Occupied", host._Occupied));
                command.Parameters.Add(new SqlParameter("@Note", host._Note));
                command.Parameters.Add(new SqlParameter("@ToAdmin", host._ToAdmin));
                command.Parameters.Add(new SqlParameter("@TransportationInfo", host._TransportationInfo));
                command.Parameters.Add(new SqlParameter("@AllowSmoking", host._AllowSmoking));
                command.Parameters.Add(new SqlParameter("@AllowDrinking", host._AllowDrinking));
                command.Parameters.Add(new SqlParameter("@DoesFamilySmoking", host._DoesFamilySmoke));
                command.Parameters.Add(new SqlParameter("@DoesFamilyDrinking", host._DoesFamilyDrink));
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

            return famID;
        }


        public void InsertFamilyMember(FamilyMember familyMember)
        {
            _DatabaseConnection.Connect();

            try
            {
                SqlCommand command = new SqlCommand("SPInsertFamily_members", _DatabaseConnection.GetActiveConnection());
                command.CommandType = CommandType.StoredProcedure;

                //Add as many parameters as you want
                command.Parameters.Add(new SqlParameter("@Family_Id", familyMember._HostId));
                command.Parameters.Add(new SqlParameter("@Member_FirstName", familyMember._FirstName));
                command.Parameters.Add(new SqlParameter("@Member_LastName", familyMember._LastName));
                command.Parameters.Add(new SqlParameter("@Member_Occupation", familyMember._Occupation));
                command.Parameters.Add(new SqlParameter("@Member_Age", familyMember._Age));
                command.Parameters.Add(new SqlParameter("@Member_Gender", familyMember._Gender));
                command.Parameters.Add(new SqlParameter("@Member_Language", familyMember._Language));
                command.Parameters.Add(new SqlParameter("@Member_RelationToHost", familyMember._RelationToHost));
                command.Parameters.Add(new SqlParameter("@IsHost", familyMember._IsHost));

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

        }


        /// <summary>
        /// Insert Applicant
        /// </summary>
        public void InsertApplicant(Applicant applicant)
        {
            _DatabaseConnection.Connect();
            try
            {

                SqlCommand command = new SqlCommand("SPInsertApplicant_Form", _DatabaseConnection.GetActiveConnection());
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
                command.Parameters.Add(new SqlParameter("@A_D.O.B", applicant._DOB));
                command.Parameters.Add(new SqlParameter("@A_PrimePh_no", applicant._PrimaryPhone));
                command.Parameters.Add(new SqlParameter("@A_SecPh_no", applicant._SecondaryPhone));
                command.Parameters.Add(new SqlParameter("@A_Hobbies", applicant._Hobbies));
                command.Parameters.Add(new SqlParameter("@A_About", applicant._About));
                command.Parameters.Add(new SqlParameter("@A_PayDate", applicant._Paydate));
                command.Parameters.Add(new SqlParameter("@A_DepositDate", applicant._DepositDate));
                command.Parameters.Add(new SqlParameter("@A_PaymentAmount", applicant._PaymentAmount));
                command.Parameters.Add(new SqlParameter("@OtherUniversity", applicant._OtherUniversity));
                command.Parameters.Add(new SqlParameter("@A_Email", applicant._Email));
                command.Parameters.Add(new SqlParameter("@A_EmergencyContact", applicant._EmergencyContact));
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                _DatabaseConnection.Disconnect();
            }

        }

        private DatabaseConnection _DatabaseConnection { get; set; }
    }
}