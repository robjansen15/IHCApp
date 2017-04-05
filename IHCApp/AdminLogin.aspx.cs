using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IHCApp.Authentication;
using IHCApp.Models;

namespace IHCApp
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            //Creates a session variable 
            Session["token"] = new Authenticate().GetToken(this.username.Text, this.password.Text);

            Response.Redirect("AdminPortal.aspx");
        }
    }
}