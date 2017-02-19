using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
            if (IsPostBack != true)
            {
                DisplayPanel(0);
            }
        }


        /// <summary>
        /// back to previous panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void backButon_OnClick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.counter.Text) > 0)
            {
                this.counter.Text = (Convert.ToInt32(this.counter.Text) - 1).ToString();
            }

            DisplayPanel(Convert.ToInt32(this.counter.Text));
        }


        /// <summary>
        /// continue to next panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void continueButton_OnClick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(this.counter.Text) < 3)
            {
                this.counter.Text = (Convert.ToInt32(this.counter.Text) + 1).ToString();
            }

            DisplayPanel(Convert.ToInt32(this.counter.Text));
        }


        /// <summary>
        /// display a given panel
        /// </summary>
        /// <param name="value"></param>
        public void DisplayPanel(int value)
        {
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
        /// add a family memeber
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void addFamilyMember_Click(object sender, EventArgs e)
        {
            int familyCnt = Convert.ToInt32(this.familyCount.Text) + 1;
            this.familyCount.Text = (familyCnt).ToString();

            //create a new family member
            Panel panel = new Panel();
            panel.ID = "familyMember" + familyCnt;

            //first name
            TextBox fName = new TextBox();
            fName.ID = "fName";

            //last name
            TextBox lName = new TextBox();
            lName.ID = "lName";

            //DOB
            TextBox dob = new TextBox();
            dob.ID = "dob";

            //gender
            TextBox gender = new TextBox();
            gender.ID = "gender";

            //is host
            CheckBox isHost = new CheckBox();
            isHost.ID = "host";

            //occupation
            TextBox occupation = new TextBox();
            occupation.ID = "occupation";


            //add the controls to the new panel
            panel.Controls.Add(fName);
            panel.Controls.Add(lName);
            panel.Controls.Add(dob);
            panel.Controls.Add(gender);
            panel.Controls.Add(isHost);
            panel.Controls.Add(occupation);
            panel.Controls.Add(new LiteralControl("<br />"));


            //add the family memeber to the family panel
            familyPanel.Controls.Add(panel);

        }


        //remove a family member from the panel
        protected void removeFamilyMember_Click(object sender, EventArgs e)
        {
            int familyCnt = Convert.ToInt32(this.familyCount.Text);
            this.familyCount.Text = (familyCnt - 1).ToString();

            //removes a list of items based on a filter
            var removeItems = familyPanel.Controls.Cast<Control>().Where(x => x.ID.Contains(("familyMember" + familyCnt).ToString())).ToList();

            foreach(var item in removeItems)
            {
                familyPanel.Controls.Remove(item);
            }
            
        }
    }
}