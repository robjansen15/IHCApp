using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace UserWebApp
{
    public class DirectDataBinding
    {

        public DirectDataBinding()
        {
            _Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HomestayDatabase"].ConnectionString);
        }


        public string GetFamilyFormInfo()
        {
            string html = "";

            try
            {
                Connect();

                SqlCommand command = new SqlCommand("SPGetFormHTML", _Connection);
                command.CommandType = CommandType.StoredProcedure;

                //Add as many parameters as you want
                command.Parameters.Add(new SqlParameter("@ID", "FAMILY"));

                using (SqlDataReader rdr = command.ExecuteReader())
                {               
                    while (rdr.Read())
                    {
                        html += rdr.GetString(2);
                        break;
                    }
                }
            }
            catch(Exception e)
            {
                html += "You must be connected to the database to populate this field";
            }
            finally
            {
                Disconnect();
            }

            return html;
        }


        public string GetApplicantFormInfo()
        {
            string html = "";

            try
            {
                Connect();

                SqlCommand command = new SqlCommand("SPGetFormHTML", _Connection);
                command.CommandType = CommandType.StoredProcedure;

                //Add as many parameters as you want
                command.Parameters.Add(new SqlParameter("@ID", "APPLICANT"));

                using (SqlDataReader rdr = command.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        html += rdr.GetString(2);
                        break;
                    }
                }
            }
            catch(Exception e)
            {
                html += "You must be connected to the database to populate this field";
            }
            finally
            {
                Disconnect();
            }

            return html;
        }


        public List<string> GetDays()
        {
            List<string> days = new List<string>();

            try
            {
                Connect();
            }
            catch
            {

            }
            finally
            {
                Disconnect();
            }

            return days;
        }


        public List<string> GetMonths()
        {
            List<string> months = new List<string>();

            try
            {
                Connect();
            }
            catch
            {

            }
            finally
            {
                Disconnect();
            }

            return months;
        }


        public List<string> GetYears()
        {
            List<string> years = new List<string>();

            try
            {
                Connect();
            }
            catch
            {

            }
            finally
            {
                Disconnect();
            }

            return years;
        }


        public List<string> GetCountries()
        {
            List<string> countries = new List<string>();

            try
            {
                Connect();
                SqlCommand command = new SqlCommand("SPGetDisplayData", _Connection);
                command.CommandType = CommandType.StoredProcedure;

                //Add as many parameters as you want
                command.Parameters.Add(new SqlParameter("@Discriminator", "Country"));
                      
                using (SqlDataReader rdr = command.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        countries.Add(rdr.GetString(1));
                    }
                }
            }
            catch
            {

            }
            finally
            {
                Disconnect();
            }

            return countries;
        }


        public List<string> GetSchools()
        {
            List<string> schools = new List<string>();

            try
            {
                Connect();
            }
            catch
            {

            }
            finally
            {
                Disconnect();
            }

            return schools;
        }


        private void Connect()
        {
            try
            {
                _Connection.Open();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        private void Disconnect()
        {
            try
            {
                _Connection.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public SqlConnection _Connection { get; set; }
    }
}