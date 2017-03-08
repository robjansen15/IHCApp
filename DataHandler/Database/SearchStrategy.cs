using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataHandler.Models;
using System.Data;
using System.Data.SqlClient;

namespace DataHandler.Database
{
    public class SearchStrategy
    {
        public SearchStrategy(DatabaseConnection databaseConnection)
        {
            _DatabaseConnection = databaseConnection;
        }

        /// <summary>
        /// get school names 
        /// </summary>
        /// <returns></returns>
        public List<string> getSchoolNames()
        {
            List<string> schools = new List<string>();

            schools.Add("IUPUI");
            schools.Add("BSU");

            /*
             Uncomment and use this framework. You need to connect and disconnect OUTSIDE of the try catch.

            _DatabaseConnection.Connect();

            try
            {
                
            }
            catch
            {

            }

            _DatabaseConnection.Disconnect();
            */

            return schools;
        }


        /// <summary>
        /// get applicants who are visiting a specific school
        /// </summary>
        public List<Applicant> getApplicantBySchool(string schoolName)
        {
            List<Applicant> applicants = new List<Applicant>();
            
            _DatabaseConnection.Connect();

            try
            {
                SqlCommand command = new SqlCommand("SPReadStudentBySchool", _DatabaseConnection._Connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@I_Name", schoolName));

                using (SqlDataReader rdr = command.ExecuteReader())
                {
                    ///gets the specific columns needed from the table
                    List<int> enumerations = new List<int>();
                    List <string> enumString = new Enumerations.EnumerationContainer()._GetStudentsBySchoolEnumeration.Split(';').ToList();
                    foreach(string str in enumString)
                    {
                        enumerations.Add(Convert.ToInt32(str));
                    }

                    while (rdr.Read())
                    {
                        var firstName = rdr.GetString(enumerations.ElementAt(0));
                        var lastName = rdr.GetString(enumerations.ElementAt(1));

                        applicants.Add(new Applicant(firstName, lastName));
                    }
                }
            }
            catch(Exception e)
            {
                var x = e.ToString();
            }
            finally
            {
                _DatabaseConnection.Disconnect();
            }

            return applicants;
        }

        /// <summary>
        /// Insert family application into tables
        /// </summary>
        public int insertFamilyValues(Family family)
        {
            _DatabaseConnection.Connect();
            int famID = 0;
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
            return famID;
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
        private DatabaseConnection _DatabaseConnection { get; set; }
    }
}