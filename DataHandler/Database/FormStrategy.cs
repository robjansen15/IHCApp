using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataHandler.Models;
using System.Data;
using System.Data.SqlClient;

namespace DataHandler.Database
{
    public class FormStrategy
    {
        public FormStrategy(DatabaseConnection databaseConnection)
        {
            _DatabaseConnection = databaseConnection;
        }

        /// <summary>
        /// Insert family application into tables
        /// </summary>
        public string insertFamilyValues(Family family)
        {
            _DatabaseConnection.Connect();
            int famID = -1;

            try
            {

                SqlCommand command = new SqlCommand("SPInsertFamilyAndReturnFamilyId", _DatabaseConnection._Connection);
                command.CommandType = CommandType.StoredProcedure;

                //Add as many parameters as you want
                command.Parameters.Add(new SqlParameter("@Time_ToCenter", family._TimeToCenter));
                command.Parameters.Add(new SqlParameter("@F_NoOfBathrooms", family._NumBathrooms));
                command.Parameters.Add(new SqlParameter("@F_Dogs", family._DogsYN));
                command.Parameters.Add(new SqlParameter("@F_Cats", family._CatsYN));
                command.Parameters.Add(new SqlParameter("@F_NoOfDogs", family._NumDogs));
                command.Parameters.Add(new SqlParameter("@F_NoOfCats", family._NumCats));
                command.Parameters.Add(new SqlParameter("@F_NoOfRooms", family._NumRooms));
                command.Parameters.Add(new SqlParameter("@F_About", family._About));
                command.Parameters.Add(new SqlParameter("@F_Email", family._Email));
                command.Parameters.Add(new SqlParameter("@F_Street", family._Street));
                command.Parameters.Add(new SqlParameter("@F_State", family._State));
                command.Parameters.Add(new SqlParameter("@F_City", family._City));
                command.Parameters.Add(new SqlParameter("@F_Country", family._Country));
                command.Parameters.Add(new SqlParameter("@F_Zip", family._Zip));
                command.Parameters.Add(new SqlParameter("@F_PrimePh_no", family._PrimePhone));
                command.Parameters.Add(new SqlParameter("@F_SecPh_no", family._SecPhone));
                command.Parameters.Add(new SqlParameter("@F_Hobbies", family._Hobbies));
                command.Parameters.Add(new SqlParameter("@F_Looking", family._Looking));
                command.Parameters.Add(new SqlParameter("@F_Occupied", family._Occupied));
                command.Parameters.Add(new SqlParameter("@F_Note", family._Note));
                command.Parameters.Add(new SqlParameter("@F_ToAdmin", family._ToAdmin));
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


        public void insertFamilyMember(FamilyMember famMemb, int familyID)
        {
            _DatabaseConnection.Connect();
            int _familyID = familyID;
            try
            {

                SqlCommand command = new SqlCommand("SPInsertFamily", _DatabaseConnection._Connection);
                command.CommandType = CommandType.StoredProcedure;

                //Add as many parameters as you want
                command.Parameters.Add(new SqlParameter("@Family_Id", _familyID));
                command.Parameters.Add(new SqlParameter("@Member_FirstName", famMemb._FirstName));
                command.Parameters.Add(new SqlParameter("@Member_LastName", famMemb._LastName));
                command.Parameters.Add(new SqlParameter("@Member_Occupation", famMemb._Occupation));
                command.Parameters.Add(new SqlParameter("@member_DOB", famMemb._Date));
                command.Parameters.Add(new SqlParameter("@Member_Gender", famMemb._Gender));
                command.Parameters.Add(new SqlParameter("@Member_Language", famMemb._Language));
                command.Parameters.Add(new SqlParameter("@Member_RelationToHost", famMemb._RelationToHost));

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


        public void insertStudent(Student studentToInsert)
        {
            _DatabaseConnection.Connect();
            try
            {

                SqlCommand command = new SqlCommand("SPInsertFamilyAndReturnFamilyId", _DatabaseConnection._Connection);
                command.CommandType = CommandType.StoredProcedure;

                //Add as many parameters as you want
                command.Parameters.Add(new SqlParameter("@A_FirstName", studentToInsert._FirstName));
                command.Parameters.Add(new SqlParameter("@A_LastName", studentToInsert._LastName));
                command.Parameters.Add(new SqlParameter("@A_ReqMovInDate", studentToInsert._MoveInDate));
                command.Parameters.Add(new SqlParameter("@A_DurationOfStay", studentToInsert._DurationOfStay));
                command.Parameters.Add(new SqlParameter("@A_Language", studentToInsert._Language));
                command.Parameters.Add(new SqlParameter("@A_Gender", studentToInsert._Gender));
                command.Parameters.Add(new SqlParameter("@A_Status", studentToInsert._Status));
                command.Parameters.Add(new SqlParameter("@A_Nationality", studentToInsert._Nationality));
                command.Parameters.Add(new SqlParameter("@A_Street", studentToInsert._Street));
                command.Parameters.Add(new SqlParameter("@A_State", studentToInsert._State));
                command.Parameters.Add(new SqlParameter("@A_City", studentToInsert._City));
                command.Parameters.Add(new SqlParameter("@A_Country", studentToInsert._Country));
                command.Parameters.Add(new SqlParameter("@A_FlightId", studentToInsert._FlightID));
                command.Parameters.Add(new SqlParameter("@A_FlightDate", studentToInsert._FlightDate));
                command.Parameters.Add(new SqlParameter("@A_FlightName", studentToInsert._FlightName));
                command.Parameters.Add(new SqlParameter("@A_Dog", studentToInsert._Dog));
                command.Parameters.Add(new SqlParameter("@A_Cat", studentToInsert._Cat));
                command.Parameters.Add(new SqlParameter("@A_HealthIssues", studentToInsert._HealthIssues));
                command.Parameters.Add(new SqlParameter("@A_DOB", studentToInsert._DOB));
                command.Parameters.Add(new SqlParameter("@A_PrimePh_no", studentToInsert._PrimePhone));
                command.Parameters.Add(new SqlParameter("@A_SecPh_no", studentToInsert._SecondaryPhone));
                command.Parameters.Add(new SqlParameter("@A_Hobbies", studentToInsert._Hobbies));
                command.Parameters.Add(new SqlParameter("@A_About", studentToInsert._About));
                command.Parameters.Add(new SqlParameter("@A_PayDate", studentToInsert._Paydate));
                command.Parameters.Add(new SqlParameter("@A_DepositDate", studentToInsert._DepositDate));
                command.Parameters.Add(new SqlParameter("@A_PaymentAmount", studentToInsert._PaymentAmount));
                command.Parameters.Add(new SqlParameter("@A_Id", studentToInsert._ID));
                command.Parameters.Add(new SqlParameter("@A_OtherUniversity", studentToInsert._OtherUniversity));
                command.Parameters.Add(new SqlParameter("@A_Email", studentToInsert._Email));
                command.Parameters.Add(new SqlParameter("@A_EmergencyContact", studentToInsert._EmergencyContact));
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