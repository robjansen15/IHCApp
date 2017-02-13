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

        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }


        protected void backButon_OnClick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Session["panelCounter"].ToString()) > 0)
            {
                Session["panelCounter"] = Convert.ToInt32(Session["panelCounter"].ToString()) - 1;
            }

            DisplayPanel(Convert.ToInt32(Session["panelCounter"].ToString()));
        }


        protected void continueButton_OnClick(object sender, EventArgs e)
        {
            if (Session["panelCounter"] == null)
            {
                Session["panelCounter"] = 0;
            }

            DisplayPanel(Convert.ToInt32(Session["panelCounter"].ToString()));
        }

        public void DisplayPanel(int value)
        {
            if (value == 0)
            {
                familyPanel.Enabled = true;
                contactInfoPanel.Enabled = false;
                livingDetailsPanel.Enabled = false;
                moreInfoPanel.Enabled = false;
            }
            else if (value == 1)
            {
                familyPanel.Enabled = false;
                contactInfoPanel.Enabled = true;
                livingDetailsPanel.Enabled = false;
                moreInfoPanel.Enabled = false;
            }
            else if (value == 2)
            {
                familyPanel.Enabled = false;
                contactInfoPanel.Enabled = false;
                livingDetailsPanel.Enabled = true;
                moreInfoPanel.Enabled = false;
            }
            else if (value == 3)
            {
                familyPanel.Enabled = false;
                contactInfoPanel.Enabled = false;
                livingDetailsPanel.Enabled = false;
                moreInfoPanel.Enabled = true;
            }
        }

        //string firstName = "Jeff";
        //string lastName = "Smith";
        //string city = "Seattle";

        //// Save to session state in a Web Forms page class.
        //Session["FirstName"] = firstName;
        //Session["LastName"] = lastName;
        //Session["City"] = city;

        //// Read from session state in a Web Forms page class.
        //firstName = (string) (Session["FirstName"]);
        //lastName = (string) (Session["LastName"]);
        //city = (string) (Session["City"]);

        //// Outside of Web Forms page class, use HttpContext.Current.
        //HttpContext context = HttpContext.Current;
        //        context.Session["FirstName"] = firstName;
        //firstName = (string) (context.Session["FirstName"]);
    }
}