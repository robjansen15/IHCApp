using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace UserWebApp
{
    public partial class FamilyForm : System.Web.UI.Page
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
            if ((int)Session["counter"] < 3)
            {
                Session["counter"] = ((int)Session["counter"] + 1);
            }

            DisplayPanel((int)Session["counter"]);
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
                familyPanel.Visible = true;
                contactInfoPanel.Visible = false;
                livingDetailsPanel.Visible = false;
                moreInfoPanel.Visible = false;
            }
            else if (value == 1)
            {
                familyPanel.Visible = false;
                contactInfoPanel.Visible = true;          
                livingDetailsPanel.Visible = false;
                moreInfoPanel.Visible = false;
            }
            else if (value == 2)
            {
                familyPanel.Visible = false;
                contactInfoPanel.Visible = false;
                livingDetailsPanel.Visible = true;
                moreInfoPanel.Visible = false;
            }
            else if (value == 3)
            {
                familyPanel.Visible = false;
                contactInfoPanel.Visible = false;
                livingDetailsPanel.Visible = false;
                moreInfoPanel.Visible = true;
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
                panel.Controls.Add(new LiteralControl("<h3>Family Member " + (id + 1)+ "</h3>"));

                //first name              
                TextBox fName = new TextBox();
                fName.ID = "fName" + id;
                Label fNameLbl = new Label();
                fNameLbl.Text = "First Name? ";
                fNameLbl.AssociatedControlID = "fName" + id;

                //last name
                TextBox lName = new TextBox();
                lName.ID = "lName" + id;
                Label lNameLbl = new Label();
                lNameLbl.Text = "Last Name? ";
                lNameLbl.AssociatedControlID = "lName" + id;

                //DOB
                TextBox dob = new TextBox();
                Label dobLbl = new Label();
                dobLbl.Text = "Date of Birth? ";
                dobLbl.AssociatedControlID = "lName" + id;

                //gender
                TextBox gender = new TextBox();
                gender.ID = "gender" + id;
                Label genderLbl = new Label();
                genderLbl.Text = "Gender? ";
                genderLbl.AssociatedControlID = "lName" + id;

                //is host
                CheckBox isHost = new CheckBox();
                isHost.ID = "host" + id;
                Label isHostLbl = new Label();
                isHostLbl.Text = "Is this person a primary host? ";
                isHostLbl.AssociatedControlID = "lName" + id;

                //occupation
                TextBox occupation = new TextBox();
                occupation.ID = "occupation" + id;
                Label occupationLbl = new Label();
                occupation.Text = "Occupation? ";
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

    }
}