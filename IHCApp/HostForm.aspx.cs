using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
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
                host._NumBathrooms = "3";
                host._NumCats = "2";
                host._NumDogs = "1";
                host._NumRooms = "3";
                host._Occupied = "no";
                host._PrimePhone = phone1.Text;
                host._SecPhone = phone2.Text;
                host._State = "Indiana";
                host._Street = address.Text;
                host._Zip = "41235";
                host._TimeToCenter = 10;
                host._ToAdmin = "";
                host._TransportationInfo = transportation.Text;
                host._AllowSmoking = allowSmoking.Text;
                host._AllowDrinking = allowDrinking.Text;
                host._DoesFamilySmoke = "yes";
                host._DoesFamilyDrink = "yes";
                host._IsActive = 1;



                int familyID = new DatabaseConnection()._PublicStrategy._InsertStrategy.InsertHost(host);

                //Grab family members
                int count = Convert.ToInt32(this.familyCnt.SelectedValue);



                SaveFamilyMembers(familyID);


                //Display success message.  

                string message = "Your details have been saved successfully.";
                string script = "window.onload = function(){ alert('";
                script += message;
                script += "')};";
                ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);

            }
            catch
            {
                //notify the user
            }


            Response.Write("<script language='javascript'>alert('Saved Sucessfully!');</script>");
            Server.Transfer("home.aspx", true);
        }


        public void SaveFamilyMembers(int familyId)
        {
            List<FamilyMember> familyMembers = new List<FamilyMember>();
            int count = Convert.ToInt32(this.familyCnt.SelectedValue);

            for (int id = 1; id < count + 1; id++)
            {
                FamilyMember familyMember = new FamilyMember();

                string concatId = id.ToString();
                TextBox firstName = (TextBox)FindControl("fname" + concatId);
                TextBox lastName = (TextBox)FindControl("lname" + concatId);
                TextBox age = (TextBox)FindControl("age" + concatId);
                TextBox language = (TextBox)FindControl("language" + concatId);
                DropDownList relationToHost = (DropDownList)FindControl("relationToHost" + concatId);
                RadioButtonList gender = (RadioButtonList)FindControl("gender" + concatId);
                CheckBox isHost = (CheckBox)FindControl("host" + concatId);
                TextBox occupation = (TextBox)FindControl("occupation" + concatId);


                familyMember._HostId = familyId;
                familyMember._FirstName = firstName.Text;
                familyMember._LastName = lastName.Text;
                familyMember._Age = age.Text;
                familyMember._Language = language.Text;
                familyMember._RelationToHost = relationToHost.SelectedValue;
                familyMember._Gender = gender.Text;
                familyMember._Occupation = occupation.Text;
                familyMember._IsHost = isHost.Checked;

                familyMembers.Add(familyMember);

            }

            familyMembers.ForEach(x => new DatabaseConnection()._PublicStrategy._InsertStrategy.InsertFamilyMember(x));


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
                formHTML.InnerHtml = new DatabaseConnection()._PublicStrategy._PublicDataStrategy.GetHostInformation();

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

            Panel panel = new Panel();

            for (int id = 1; id < count + 1; id++)
            {

                panel.ID = "familyMember" + id;
                panel.Controls.Add(new LiteralControl("<h3>Family Member " + id + "</h3>"));

                //first name         
                TextBox fName = new TextBox();
                fName.ID = "fName" + id;

                Label fNameLbl = new Label();
                RequiredFieldValidator fnameValidator = new RequiredFieldValidator();
                fnameValidator.ControlToValidate = "fName" + id;
                fnameValidator.ErrorMessage = "You must provide a first name for family member " + id + ".";
                fnameValidator.ForeColor = Color.Red;

                fnameValidator.Text = "*";
                fNameLbl.Text = "First Name: <br/>";
                fNameLbl.AssociatedControlID = "fName" + id;

                //last name
                TextBox lName = new TextBox();
                lName.ID = "lName" + id;
                Label lNameLbl = new Label();


                RequiredFieldValidator lnameValidator = new RequiredFieldValidator();
                lnameValidator.ControlToValidate = "lName" + id;
                lnameValidator.ErrorMessage = "You must provide a last name for family member " + id + ".";
                lnameValidator.ForeColor = Color.Red;

                lnameValidator.Text = "*";
                lNameLbl.Text = "Last Name: <br/>";
                lNameLbl.AssociatedControlID = "lName" + id;

                //DOB
                TextBox age = new TextBox();
                Label ageLbl = new Label();
                age.ID = "age" + id;
                RequiredFieldValidator ageValidator = new RequiredFieldValidator();
                ageValidator.ControlToValidate = "age" + id;
                ageValidator.ErrorMessage = "You must provide an age for family member " + id + ".";
                ageValidator.ForeColor = Color.Red;

                ageValidator.Text = "*";
                ageLbl.Text = "Age: <br/>";
                ageLbl.AssociatedControlID = "age" + id;

                //Language
                TextBox language = new TextBox();
                Label languageLbl = new Label();
                language.ID = "language" + id;

                languageLbl.Text = "Other Language: <br/>";
                languageLbl.AssociatedControlID = "language" + id;

                //RelationToHost
                DropDownList relationToHost = new DropDownList();
                Label relationToHostLbl = new Label();
                relationToHost.ID = "relationToHost" + id;
                relationToHostLbl.Text = "Relation To Host: <br/>";
                relationToHostLbl.AssociatedControlID = "relationToHost" + id;
                relationToHost.DataSource = PopulateRelationToHostDropDownList();
                relationToHost.DataBind();
                relationToHost.Width = Unit.Pixel(200);

                //gender
                RadioButtonList gender = new RadioButtonList();
                gender.ID = "gender" + id;
                Label genderLbl = new Label();
                genderLbl.Text = "Gender: <br/>";
                genderLbl.AssociatedControlID = "gender" + id;
                ListItem male = new ListItem();
                ListItem female = new ListItem();
                male.Text = "Male";
                female.Text = "Female";
                gender.Items.Add(male);
                gender.Items.Add(female);
                gender.RepeatLayout = RepeatLayout.Flow;
                gender.SelectedIndex = 0;


                //is host
                CheckBox isHost = new CheckBox();
                isHost.ID = "host" + id;
                Label isHostLbl = new Label();
                isHostLbl.Text = "Is this person a primary host? <br/>";
                isHostLbl.AssociatedControlID = "host" + id;

                //occupation
                TextBox occupation = new TextBox();
                occupation.ID = "occupation" + id;
                RequiredFieldValidator occupationValidator = new RequiredFieldValidator();
                occupationValidator.ControlToValidate = "occupation" + id;
                occupationValidator.ErrorMessage = "You must provide an occupation for family member " + id + ".";
                occupationValidator.ForeColor = Color.Red;
                occupationValidator.Text = "*";
                Label occupationLbl = new Label();
                occupationLbl.Text = "Occupation: <br/>";
                occupationLbl.AssociatedControlID = "occupation" + id;

                //add controls


                //validation controls
                panel.Controls.Add(fnameValidator);
                panel.Controls.Add(fNameLbl);
                panel.Controls.Add(fName);
                panel.Controls.Add(new LiteralControl("<br/>"));

                panel.Controls.Add(lnameValidator);
                panel.Controls.Add(lNameLbl);
                panel.Controls.Add(lName);
                panel.Controls.Add(new LiteralControl("<br/>"));

                panel.Controls.Add(ageValidator);
                panel.Controls.Add(ageLbl);
                panel.Controls.Add(age);
                panel.Controls.Add(new LiteralControl("<br/>"));

                panel.Controls.Add(languageLbl);
                panel.Controls.Add(language);
                panel.Controls.Add(new LiteralControl("<br/>"));

                panel.Controls.Add(relationToHostLbl);
                panel.Controls.Add(relationToHost);
                panel.Controls.Add(new LiteralControl("<br/>"));



                panel.Controls.Add(genderLbl);
                panel.Controls.Add(gender);
                panel.Controls.Add(new LiteralControl("<br/>"));

                panel.Controls.Add(isHostLbl);
                panel.Controls.Add(isHost);
                panel.Controls.Add(new LiteralControl("<br/>"));


                panel.Controls.Add(occupationValidator);
                panel.Controls.Add(occupationLbl);
                panel.Controls.Add(occupation);
                panel.Controls.Add(new LiteralControl("<br/>"));
                panel.Controls.Add(new LiteralControl("<br/>"));

                this.familyListPanel.Controls.Add(panel);

            }
        }


        /// <summary>
        /// confirm family members
        /// </summary>
        /// <param name="count"></param>
        public void confirmFamilyMembers(int count)
        {

            Panel panel = new Panel();

            for (int id = 1; id < count + 1; id++)
            {

                string concatId = id.ToString();
                TextBox firstName = (TextBox)FindControl("fname" + concatId);
                TextBox lastName = (TextBox)FindControl("lname" + concatId);
                TextBox confirmAge = (TextBox)FindControl("age" + concatId);
                DropDownList confirmRelationToHost = (DropDownList)FindControl("relationToHost" + id);
                RadioButtonList confirmGender = (RadioButtonList)FindControl("gender" + concatId);
                CheckBox confirmIsHost = (CheckBox)FindControl("host" + concatId);
                TextBox confirmOccupation = (TextBox)FindControl("occupation" + concatId);

                panel.ID = "confirm-FamilyMember" + id;
                panel.Controls.Add(new LiteralControl("<h3>Family Member " + id + "</h3>"));

                //first name         
                TextBox fName = new TextBox();
                fName.ID = "confirm-fName" + id;
                fName.Text = firstName.Text;
                fName.Enabled = false;
                Label fNameLbl = new Label();
                fNameLbl.Text = "First Name: <br/>";
                fNameLbl.AssociatedControlID = "confirm-fName" + id;

                //last name
                TextBox lName = new TextBox();
                lName.ID = "confirm-lName" + id;
                lName.Text = lastName.Text;
                lName.Enabled = false;
                Label lNameLbl = new Label();
                lNameLbl.Text = "Last Name: <br/>";
                lNameLbl.AssociatedControlID = "confirm-lName" + id;

                //age
                TextBox age = new TextBox();
                Label ageLbl = new Label();
                age.ID = "confirm-age" + id;
                age.Text = confirmAge.Text;
                age.Enabled = false;   
                ageLbl.Text = "Age: <br/>";
                ageLbl.AssociatedControlID = "confirm-age" + id;

                //relation to host
                DropDownList relationToHost = new DropDownList();
                Label relationToHostLbl = new Label();
                relationToHost.ID = "confirm-relationToHost" + id;
                relationToHostLbl.Text = "Relation To Host: <br/>";
                relationToHostLbl.AssociatedControlID = "confirm-relationToHost" + id;
                relationToHost.DataSource = PopulateRelationToHostDropDownList();
                relationToHost.DataBind();
                relationToHost.Width = Unit.Pixel(200);
                relationToHost.SelectedValue = confirmRelationToHost.SelectedValue;


                //gender
                RadioButtonList gender = new RadioButtonList();
                gender.ID = "confirm-gender" + id;
                gender.Text = confirmGender.Text;
                gender.Enabled = false;
                Label genderLbl = new Label();
                genderLbl.Text = "Gender: <br/>";
                genderLbl.AssociatedControlID = "confirm-gender" + id;
                ListItem male = new ListItem();
                ListItem female = new ListItem();
                male.Text = "Male";
                female.Text = "Female";
                gender.Items.Add(male);
                gender.Items.Add(female);
                gender.RepeatLayout = RepeatLayout.Flow;
                gender.SelectedIndex = confirmGender.SelectedIndex;


                //is host
                CheckBox isHost = new CheckBox();
                isHost.ID = "confirm-host" + id;
                isHost.Checked = confirmIsHost.Checked;
                isHost.Enabled = false;
                Label isHostLbl = new Label();
                isHostLbl.Text = "Is this person a primary host? <br/>";
                isHostLbl.AssociatedControlID = "confirm-host" + id;

                //occupation
                TextBox occupation = new TextBox();
                occupation.ID = "confirm-occupation" + id;
                occupation.Text = confirmOccupation.Text;
                occupation.Enabled = false;
                Label occupationLbl = new Label();
                occupationLbl.Text = "Occupation: <br/>";
                occupationLbl.AssociatedControlID = "confirm-occupation" + id;

                //validation controls
                panel.Controls.Add(fNameLbl);
                panel.Controls.Add(fName);
                panel.Controls.Add(new LiteralControl("<br/>"));

                panel.Controls.Add(lNameLbl);
                panel.Controls.Add(lName);
                panel.Controls.Add(new LiteralControl("<br/>"));

                panel.Controls.Add(ageLbl);
                panel.Controls.Add(age);
                panel.Controls.Add(new LiteralControl("<br/>"));

                panel.Controls.Add(relationToHostLbl);
                panel.Controls.Add(relationToHost);
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

                this.confirmFamilyMembersPanel.Controls.Add(panel);

            }
        }

        /// <summary>
        /// Relation to host dropdown
        /// </summary>
        private List<string> PopulateRelationToHostDropDownList()
        {
            List<string> relationsToHost = new DatabaseConnection()._PublicStrategy._PublicDataStrategy.RelationToHostDatasource();

            return relationsToHost;
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

        private void populateConfirmationPanel()
        {
            int count = Convert.ToInt32(this.familyCnt.SelectedValue);
            //family panel
            confirmFamilyName.Text = familyName.Text;
            confirmfamilyCnt.Text = familyCnt.Text;
            confirmFamilyMembers(count);

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
            confirmAllowDrinking.SelectedValue = allowDrinking.SelectedValue; 
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