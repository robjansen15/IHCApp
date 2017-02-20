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
            this.familyListPanel.Controls.Clear();

            for(int id = 0; id < count; id++)
            {
                Panel panel = new Panel();
                panel.ID = "familyMember" + id;
                panel.Controls.Add(new LiteralControl(""));

                //first name
                TextBox fName = new TextBox();
                fName.ID = "fName" + id;

                //last name
                TextBox lName = new TextBox();
                lName.ID = "lName" + id;

                //DOB
                TextBox dob = new TextBox();
                dob.ID = "dob" + id;

                //gender
                TextBox gender = new TextBox();
                gender.ID = "gender" + id;

                //is host
                CheckBox isHost = new CheckBox();
                isHost.ID = "host" + id;

                //occupation
                TextBox occupation = new TextBox();

                panel.Controls.Add(fName);
                panel.Controls.Add(lName);
                panel.Controls.Add(dob);
                panel.Controls.Add(gender);
                panel.Controls.Add(isHost);
                panel.Controls.Add(occupation);

                this.familyListPanel.Controls.Add(panel);
            }
        }


        /// <summary>
        /// when the user changes the number of family memebers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void familyCnt_SelectedIndexChanged(object sender, EventArgs e)
        {          
            //clear the controls before adding items with the same name!
            if(familyListPanel != null)
            {
                familyListPanel.Controls.Clear();
            }

            //repopulate the number of family members
            updateFamilyMembers(Convert.ToInt32(this.familyCnt.SelectedValue));                               
        }

    }
}