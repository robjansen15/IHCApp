using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IHCApp.Models;
using IHCApp.Database;
using IHCApp.Database.Public;

namespace IHCApp
{
    public partial class HostForm : System.Web.UI.Page
    {
        /// <summary>
        /// Page loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            //re-add the family controls everytime!
            updateFamilyMembers(Convert.ToInt32(this.familyCnt.SelectedValue));

            if (ViewState["savedFamilyMembers"] != null)
            {
                this.familyListPanel = (Panel)ViewState["NameOfUser"];
            }
            else
            {
                ViewState.Add("savedFamilyMembers", this.familyListPanel.ToString());
            }

            //checks for postback
            if (IsPostBack != true)
            {
                //add counter for panel
                Session.Add("counter", 0);

                //display the first panel
                DisplayPanel(0);

                //enable everything
                familyPanel.Enabled = true;
                contactInfoPanel.Enabled = true;
                livingDetailsPanel.Enabled = true;
                moreInfoPanel.Enabled = true;
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
            //this returns if they have not checked the box
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
                Host host = new Host();

                host._About = about.Text;
                host._City = "Indianapolis";
                host._Country = "United States";
                host._Email = email.Text;
                host._Hobbies = hobbies.Text;
                host._Looking = "yes";
                host._Note = "N/A";
                host._NumBathrooms = 3;
                host._CatsYN = "yes";
                host._DogsYN = "yes";
                host._NumCats = 2;
                host._NumDogs = 1;
                host._NumRooms = 3;
                host._Occupied = "no";
                host._PrimePhone = phone1.Text;
                host._SecPhone = phone2.Text;
                host._State = "Indiana";
                host._Street = address.Text;
                host._Zip = "41235";
                host._TimeToCenter = "";
                host._ToAdmin = "";



                String familyID = new DatabaseConnection()._PublicStrategy._InsertStrategy.InsertHost(host);

                //Grab family members
                
                //create foreach

                new DatabaseConnection()._PublicStrategy._InsertStrategy.InsertFamilyMemeber(new FamilyMember(Convert.ToInt32(familyID), "John", "Baker", "Drug Dealer", DateTime.UtcNow, "Female", "Japanese", "Brother"), Convert.ToInt32(familyID));




            }
            catch
            {
                //notify the user
            }
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
                //formHTML.InnerHtml = new DirectDataBinding().GetFamilyFormInfo();

                termsOfServicePanel.Visible = true;
                familyPanel.Visible = false;
                contactInfoPanel.Visible = false;
                livingDetailsPanel.Visible = false;
                moreInfoPanel.Visible = false;
                confirmationPanel.Visible = false;


                continueButton.Visible = true;
                submitButton.Visible = false;
            }
            else if (value == 1)
            {
                termsOfServicePanel.Visible = false;
                familyPanel.Visible = true;
                contactInfoPanel.Visible = false;
                livingDetailsPanel.Visible = false;
                moreInfoPanel.Visible = false;
                confirmationPanel.Visible = false;


                continueButton.Visible = true;
                submitButton.Visible = false;
            }
            else if (value == 2)
            {
                termsOfServicePanel.Visible = false;
                familyPanel.Visible = false;
                contactInfoPanel.Visible = true;
                livingDetailsPanel.Visible = false;
                moreInfoPanel.Visible = false;
                confirmationPanel.Visible = false;

                continueButton.Visible = true;
                submitButton.Visible = false;
            }
            else if (value == 3)
            {
                termsOfServicePanel.Visible = false;
                familyPanel.Visible = false;
                contactInfoPanel.Visible = false;
                livingDetailsPanel.Visible = true;
                moreInfoPanel.Visible = false;
                confirmationPanel.Visible = false;


                continueButton.Visible = true;
                submitButton.Visible = false;
            }
            else if (value == 4)
            {
                termsOfServicePanel.Visible = false;
                familyPanel.Visible = false;
                contactInfoPanel.Visible = false;
                livingDetailsPanel.Visible = false;
                moreInfoPanel.Visible = true;
                confirmationPanel.Visible = false;

                continueButton.Visible = true;
                submitButton.Visible = false;
            }
            else if (value == 5)
            {
                termsOfServicePanel.Visible = false;
                familyPanel.Visible = false;
                contactInfoPanel.Visible = false;
                livingDetailsPanel.Visible = false;
                moreInfoPanel.Visible = false;
                confirmationPanel.Visible = true;


                continueButton.Visible = false;
                submitButton.Visible = true;

                populateConfirmationPanel();

            }
        }


        /// <summary>
        /// updates all of the family member after a post back
        /// </summary>
        /// <param name="count"></param>
        public void updateFamilyMembers(int count)
        {
            for (int id = 0; id < count; id++)
            {

                Panel panel = new Panel();
                panel.ID = "familyMember" + id;
                panel.Controls.Add(new LiteralControl("<h3>Family Member " + (id + 1) + "</h3>"));

                //first name              
                TextBox fName = new TextBox();
                fName.ID = "fName" + id;
                Label fNameLbl = new Label();
                fNameLbl.Text = "First Name: <br/>";
                fNameLbl.AssociatedControlID = "fName" + id;

                //last name
                TextBox lName = new TextBox();
                lName.ID = "lName" + id;
                Label lNameLbl = new Label();
                lNameLbl.Text = "Last Name: <br/>";
                lNameLbl.AssociatedControlID = "lName" + id;

                //DOB
                TextBox dob = new TextBox();
                Label dobLbl = new Label();
                dobLbl.Text = "Date of Birth: <br/>";
                dobLbl.AssociatedControlID = "lName" + id;

                //gender
                TextBox gender = new TextBox();
                gender.ID = "gender" + id;
                Label genderLbl = new Label();
                genderLbl.Text = "Gender: <br/>";
                genderLbl.AssociatedControlID = "lName" + id;

                //is host
                CheckBox isHost = new CheckBox();
                isHost.ID = "host" + id;
                Label isHostLbl = new Label();
                isHostLbl.Text = "Is this person a primary host? <br/>";
                isHostLbl.AssociatedControlID = "lName" + id;

                //occupation
                TextBox occupation = new TextBox();
                occupation.ID = "occupation" + id;
                Label occupationLbl = new Label();
                occupationLbl.Text = "Occupation: <br/>";
                occupationLbl.AssociatedControlID = "occupation" + id;

                //add controls
                panel.Controls.Add(fNameLbl);
                panel.Controls.Add(fName);
                panel.Controls.Add(new LiteralControl("<br/>"));

                panel.Controls.Add(lNameLbl);
                panel.Controls.Add(lName);
                panel.Controls.Add(new LiteralControl("<br/>"));

                panel.Controls.Add(dobLbl);
                panel.Controls.Add(dob);
                panel.Controls.Add(new LiteralControl("<br/>"));

                panel.Controls.Add(genderLbl);
                panel.Controls.Add(gender);
                panel.Controls.Add(new LiteralControl("<br/>"));

                panel.Controls.Add(isHostLbl);
                panel.Controls.Add(isHost);
                panel.Controls.Add(new LiteralControl("<br/>"));

                panel.Controls.Add(occupationLbl);
                panel.Controls.Add(occupation);
                panel.Controls.Add(new LiteralControl("<br/>"));
                panel.Controls.Add(new LiteralControl("<br/>"));

                this.familyListPanel.Controls.Add(panel);

            }
        }


        /// <summary>
        /// when the user changes the number of family members
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void familyCnt_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*EMPTY METHOD TO ENSURE POSTBACK*/
        }



        /// <summary>
        /// Populates the confirmation panel data.
        /// </summary>
        /// <param name="count"></param>
        private void populateConfirmationPanel()
        {

            //family panel
            confirmFamilyName.Text = familyName.Text;
            confirmfamilyCnt.Text = familyCnt.Text;



            //contact panel
            confirmAddress.Text = address.Text;
            confirmPhone1.Text = phone1.Text;
            confirmPhone2.Text = phone2.Text;
            confirmEmail.Text = email.Text;

            confirmAddress.Enabled = false;
            confirmPhone1.Enabled = false;
            confirmPhone2.Enabled = false;
            confirmEmail.Enabled = false;

            //living details panel
            confirmAllowSmoking.SelectedValue = allowSmoking.SelectedValue;
            confirmFamilySmoke.SelectedValue = familySmoke.SelectedValue;
            confirmDogs.SelectedValue = dogs.SelectedValue;
            confirmCats.SelectedValue = cats.SelectedValue;
            confirmInternet.SelectedValue = internet.SelectedValue;
            confirmBathrooms.SelectedValue = bathrooms.SelectedValue;
            confirmTransportation.Text = transportation.Text;

            confirmAllowSmoking.Enabled = false;
            confirmFamilySmoke.Enabled = false;
            confirmDogs.Enabled = false;
            confirmCats.Enabled = false;
            confirmInternet.Enabled = false;
            confirmBathrooms.Enabled = false;
            confirmTransportation.Enabled = false;


            //additional info panel

            confirmHobbies.Text = hobbies.Text;
            confirmAbout.Text = about.Text;

            confirmHobbies.Enabled = false;
            confirmAbout.Enabled = false;


        }

    }
}