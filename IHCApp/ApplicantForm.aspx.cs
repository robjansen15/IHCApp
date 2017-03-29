using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IHCApp.Database;
using IHCApp.Models;

namespace IHCApp
{
    public partial class ApplicantForm : System.Web.UI.Page
    {
        /// <summary>
        /// Page loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

            //checks for postback
            if (!IsPostBack)
            {
                //add counter for panel
                Session.Add("counter", 0);

                //display the first panel
                DisplayPanel(0);

                //enable everything
                termsOfServicePanel.Enabled = true;
                personalInfoPanel.Enabled = true;
                contactInfoPanel.Enabled = true;
                conditionsPreferencesPanel.Enabled = true;
                universityInfoPanel.Enabled = true;
                confirmationPanel.Enabled = true;

                if (this.SelectedDate == DateTime.MinValue)
                {
                    this.PopulateYear();
                    this.PopulateMonth();
                    this.PopulateDay();
                }
            }
            else
            {
                if (Request.Form[ddlDay.UniqueID] != null)
                {
                    this.PopulateDay();
                    ddlDay.ClearSelection();
                    ddlDay.Items.FindByValue(Request.Form[ddlDay.UniqueID]).Selected = true;
                }
            }
        }


        /// <summary>
        /// back to previous panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void backButon_OnClick(object sender, EventArgs e)
        {
            if ((int)Session["counter"] > 0)
            {
                Session["counter"] = ((int)Session["counter"] - 1);
            }

            DisplayPanel((int)Session["counter"]);
        }


        /// <summary>
        /// continue to next panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void continueButton_OnClick(object sender, EventArgs e)
        {
            //This returns if they have not checked the box
            if ((int)Session["counter"] == 0)
            {
                if (termsOfServiceCheckbox.Checked == false)
                {
                    labelForTOS.BackColor = System.Drawing.Color.Yellow;
                    return;
                }
            }

            if ((int)Session["counter"] < 5)
            {
                Session["counter"] = ((int)Session["counter"] + 1);
            }

            DisplayPanel((int)Session["counter"]);
        }

        /// <summary>
        /// submits the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void submitButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                Applicant applicant = new Applicant();

                applicant._FirstName = this.firstName.Text;
                applicant._LastName = this.lastName.Text;
                applicant._MoveInDate = DateTime.Now;
                applicant._DurationOfStay = 4;
                applicant._Language = this.firstLanguage.Text;
                applicant._Gender = this.gender.Text;
                applicant._Status = "status";
                applicant._Nationality = "nationality";
                applicant._Street = this.address.Text;
                applicant._State = "IN";
                applicant._City = "Indianapolis";
                applicant._Country = this.Country.Text;
                applicant._FlightID = "F29";
                applicant._FlightDate = DateTime.Now;
                applicant._FlightName = "flight name";
                applicant._Dog = "yes";
                applicant._Cat = "no";
                applicant._HealthIssues = this.allergies.Text;
                applicant._DOB = DateTime.Now;
                applicant._PrimaryPhone = this.phone1.Text;
                applicant._SecondaryPhone = this.phone2.Text;
                applicant._Hobbies = this.hobbies.Text;
                applicant._About = this.about.Text;
                applicant._Paydate = DateTime.Now;
                applicant._DepositDate = DateTime.Now;
                applicant._PaymentAmount = 300;
                applicant._ID = 20;
                applicant._OtherUniversity = "purdue";
                applicant._Email = this.email.Text;
                applicant._EmergencyContact = this.universityContactInfo.Text;


                new DatabaseConnection()._PublicStrategy._InsertStrategy.InsertApplicant(applicant);
            }
            catch(Exception ex)
            {
                var x = ex.ToString();
                //notify the user
            }

            Response.Redirect("Home.aspx");
        }


        /// <summary>
        /// display a given panel
        /// </summary>
        /// <param name="value"></param>
        public void DisplayPanel(int value)
        {
            //change the view
            if (value == 0)
            {
                //TODO
                formHTML.InnerHtml = new DatabaseConnection()._PublicStrategy._PublicDataStrategy.GetApplicantFormInfo();

                termsOfServicePanel.Visible = true;
                personalInfoPanel.Visible = false;
                contactInfoPanel.Visible = false;
                conditionsPreferencesPanel.Visible = false;
                universityInfoPanel.Visible = false;
                confirmationPanel.Visible = false;

                continueButton.Visible = true;
                submitButton.Visible = false;
            }
            if (value == 1)
            {
                termsOfServicePanel.Visible = false;
                personalInfoPanel.Visible = true;
                contactInfoPanel.Visible = false;
                conditionsPreferencesPanel.Visible = false;
                universityInfoPanel.Visible = false;
                confirmationPanel.Visible = false;

                continueButton.Visible = true;
                submitButton.Visible = false;
            }
            else if (value == 2)
            {
                termsOfServicePanel.Visible = false;
                personalInfoPanel.Visible = false;
                contactInfoPanel.Visible = true;
                conditionsPreferencesPanel.Visible = false;
                universityInfoPanel.Visible = false;
                confirmationPanel.Visible = false;

                continueButton.Visible = true;
                submitButton.Visible = false;
            }
            else if (value == 3)
            {
                termsOfServicePanel.Visible = false;
                personalInfoPanel.Visible = false;
                contactInfoPanel.Visible = false;
                conditionsPreferencesPanel.Visible = true;
                universityInfoPanel.Visible = false;
                confirmationPanel.Visible = false;

                continueButton.Visible = true;
                submitButton.Visible = false;
            }
            else if (value == 4)
            {
                termsOfServicePanel.Visible = false;
                personalInfoPanel.Visible = false;
                contactInfoPanel.Visible = false;
                conditionsPreferencesPanel.Visible = false;
                universityInfoPanel.Visible = true;
                confirmationPanel.Visible = false;

                continueButton.Visible = true;
                submitButton.Visible = false;
            }
            else if (value == 5)
            {
                termsOfServicePanel.Visible = false;
                personalInfoPanel.Visible = false;
                contactInfoPanel.Visible = false;
                conditionsPreferencesPanel.Visible = false;
                universityInfoPanel.Visible = false;
                confirmationPanel.Visible = true;

                continueButton.Visible = false;
                submitButton.Visible = true;

                populateConfirmationPanel();
            }
        }


        /// <summary>
        /// DOB day selector
        /// </summary>
        /// <param name="count"></param>
        private int Day
        {
            get
            {
                if (Request.Form[ddlDay.UniqueID] != null)
                {
                    return int.Parse(Request.Form[ddlDay.UniqueID]);
                }
                else
                {
                    return int.Parse(ddlDay.SelectedItem.Value);
                }
            }
            set
            {
                this.PopulateDay();
                ddlDay.ClearSelection();
                ddlDay.Items.FindByValue(value.ToString()).Selected = true;
            }
        }

        /// <summary>
        /// DOB month selector
        /// </summary>
        /// <param name="count"></param>
        private int Month
        {
            get
            {
                return int.Parse(ddlMonth.SelectedItem.Value);
            }
            set
            {
                this.PopulateMonth();
                ddlMonth.ClearSelection();
                ddlMonth.Items.FindByValue(value.ToString()).Selected = true;
            }
        }

        /// <summary>
        /// DOB year selector
        /// </summary>
        /// <param name="count"></param>
        private int Year
        {
            get
            {
                return int.Parse(ddlYear.SelectedItem.Value);
            }
            set
            {
                this.PopulateYear();
                ddlYear.ClearSelection();
                ddlYear.Items.FindByValue(value.ToString()).Selected = true;
            }
        }

        /// <summary>
        /// DOB selected Date concatenation
        /// </summary>
        /// <param name="count"></param>
        public DateTime SelectedDate
        {
            get
            {
                try
                {
                    return DateTime.Parse(this.Month + "/" + this.Day + "/" + this.Year);
                }
                catch
                {
                    return DateTime.MinValue;
                }
            }
            set
            {
                if (!value.Equals(DateTime.MinValue))
                {
                    this.Year = value.Year;
                    this.Month = value.Month;
                    this.Day = value.Day;
                }
            }
        }
        /// <summary>
        /// DOB day populate
        /// </summary>
        /// <param name="count"></param>
        private void PopulateDay()
        {
            ddlDay.Items.Clear();
            ListItem lt = new ListItem();
            lt.Text = "DD";
            lt.Value = "0";
            ddlDay.Items.Add(lt);
            int days = DateTime.DaysInMonth(this.Year, this.Month);
            for (int i = 1; i <= days; i++)
            {
                lt = new ListItem();
                lt.Text = i.ToString();
                lt.Value = i.ToString();
                ddlDay.Items.Add(lt);
            }
            ddlDay.Items.FindByValue(DateTime.Now.Day.ToString()).Selected = true;
        }


        /// <summary>
        /// DOB month populate
        /// </summary>
        /// <param name="count"></param>
        private void PopulateMonth()
        {
            ddlMonth.Items.Clear();
            ListItem lt = new ListItem();
            lt.Text = "MM";
            lt.Value = "0";
            ddlMonth.Items.Add(lt);
            for (int i = 1; i <= 12; i++)
            {
                lt = new ListItem();
                lt.Text = Convert.ToDateTime(i.ToString() + "/1/1900").ToString("MMMM");
                lt.Value = i.ToString();
                ddlMonth.Items.Add(lt);
            }
            ddlMonth.Items.FindByValue(DateTime.Now.Month.ToString()).Selected = true;
        }

        /// <summary>
        /// DOB year populate
        /// </summary>
        /// <param name="count"></param>
        private void PopulateYear()
        {
            ddlYear.Items.Clear();
            ListItem lt = new ListItem();
            lt.Text = "YYYY";
            lt.Value = "0";
            ddlYear.Items.Add(lt);
            for (int i = DateTime.Now.Year; i >= 1950; i--)
            {
                lt = new ListItem();
                lt.Text = i.ToString();
                lt.Value = i.ToString();
                ddlYear.Items.Add(lt);
            }
            ddlYear.Items.FindByValue(DateTime.Now.Year.ToString()).Selected = true;

        }



        /// <summary>
        /// Populates the confirmation panel data.
        /// </summary>
        /// <param name="count"></param>
        private void populateConfirmationPanel()
        {

            //personal panel
            confirmLastName.Text = lastName.Text;
            confirmFirstName.Text = firstName.Text;
            confirmDDLYear.Text = ddlYear.SelectedValue;
            confirmDDLMonth.Text = ddlMonth.SelectedValue;
            confirmDDLDay.Text = confirmDDLDay.SelectedValue;
            confirmCountry.Text = Country.SelectedValue;
            confirmFirstLanguage.Text = firstLanguage.Text;
            confirmGender.SelectedValue = gender.SelectedValue;
            confirmMartialStatus.SelectedValue = martialstatus.SelectedValue;

            confirmLastName.Enabled = false;
            confirmFirstName.Enabled = false;
            confirmDDLYear.Enabled = false;
            confirmDDLMonth.Enabled = false;
            confirmDDLDay.Enabled = false;
            confirmCountry.Enabled = false;
            confirmFirstLanguage.Enabled = false;
            confirmGender.Enabled = false;
            confirmMartialStatus.Enabled = false;

            //contact panel
            confirmAddress.Text = address.Text;
            confirmPhone1.Text = phone1.Text;
            confirmPhone2.Text = phone2.Text;
            confirmEmail.Text = email.Text;

            confirmAddress.Enabled = false;
            confirmPhone1.Enabled = false;
            confirmPhone2.Enabled = false;
            confirmEmail.Enabled = false;

            //conditions & preferences panel
            confirmTransportation.Text = transportation.Text;
            confirmAllergies.Text = allergies.Text;
            confirmHobbies.Text = hobbies.Text;
            confirmAbout.Text = about.Text;

            confirmTransportation.Enabled = false;
            confirmAllergies.Enabled = false;
            confirmHobbies.Enabled = false;
            confirmAbout.Enabled = false;

            //university info panel
            confirmUniversity.Text = university.Text;
            confirmUniversityAddress.Text = universityAddress.Text;
            confirmMajor.Text = major.Text;
            confirmUniversityContactInfo.Text = universityContactInfo.Text;
            confirmHomestayDuration.Text = homestayDuration.Text;
            confirmFlightInfo.Text = flightInfo.Text;

            confirmUniversity.Enabled = false;
            confirmUniversityAddress.Enabled = false;
            confirmMajor.Enabled = false;
            confirmUniversityContactInfo.Enabled = false;
            confirmHomestayDuration.Enabled = false;
            confirmFlightInfo.Enabled = false;


        }

    }
}