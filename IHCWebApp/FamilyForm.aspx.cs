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
                //add 1 person
                addMember(0, new FamilyMember());

                //add counter for panel
                Session.Add("counter", 0);
                Session.Add("familyMembers", new List<FamilyMember>());

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
        /// add a family new family memeber panel to control
        /// </summary>
        public void addMember(int id, FamilyMember member)
        {     
            //create a new family member
            Panel panel = new Panel();
            panel.ID = "familyMember" + id;
            panel.Controls.Add(new LiteralControl(""));

            //first name
            TextBox fName = new TextBox();
            fName.ID = "fName" + id;
            fName.Text = member.firstName;

            //last name
            TextBox lName = new TextBox();
            lName.ID = "lName" + id;
            lName.Text = member.lastName;

            //DOB
            TextBox dob = new TextBox();
            dob.ID = "dob" + id;
            dob.Text = member.dob;

            //gender
            TextBox gender = new TextBox();
            gender.ID = "gender" + id;
            gender.Text = member.gender;

            //is host
            CheckBox isHost = new CheckBox();
            isHost.ID = "host" + id;
            isHost.Checked = member.isHost;

            //occupation
            TextBox occupation = new TextBox();
            occupation.ID = "occupation" + id;

            //add the controls to the new panel
            panel.Controls.Add(fName);
            panel.Controls.Add(lName);
            panel.Controls.Add(dob);
            panel.Controls.Add(gender);
            panel.Controls.Add(isHost);
            panel.Controls.Add(occupation);


            //add the family memeber to the family panel
            familyListPanel.Controls.Add(panel);
        }


        /// <summary>
        /// updates all of the family member after a post back
        /// </summary>
        /// <param name="count"></param>
        public void updateFamilyMembers(int count)
        {
            //counter of the members added
            int c = 0;

            foreach(var member in (List<FamilyMember>)Session["familyMembers"])
            {
                //if there are less rows selected than people
                if (c > count)
                {
                    for (int i = c; i < count; i++)
                    {
                        addMember(i, new FamilyMember());
                    }


                    c = count;
                    break;
                }


                addMember(c, member);

                c++;
            }

            //add more rows if they need more
            for(int i = c; i < count; i++)
            {
                addMember(i, new FamilyMember());
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


        /// <summary>
        /// class that holds the family members
        /// </summary>
        public class FamilyMember
        {
            public FamilyMember()
            {
                firstName = "";
                lastName = "";
                dob = "";
                gender = "";
                isHost = false;
                occupation = "";
            }


            public FamilyMember(string fName, string lName, string DOB, string Gender, bool IsHost, string Occupation)
            {
                firstName = fName;
                lastName = lName;
                dob = DOB;
                gender = Gender;
                isHost = IsHost;
                occupation = Occupation;
            }


            public string firstName { get; set; }
            public string lastName { get; set; }
            public string dob { get; set; }
            public string gender { get; set; }
            public bool isHost { get; set; }
            public string occupation { get; set; }
        }

    }
}