using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IHCApp.Authentication;
using IHCApp.Models;
using System.Net.Mail;
using System.Net;

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
            //Session["token"] = new Authenticate().GetToken(this.username.Text, this.password.Text);

            var token = new Authenticate().GetToken(this.username.Text, this.password.Text);

            Session.Add("token", token);

            Response.Redirect("AdminPortal.aspx");
        }


        protected void forgotBtn_Click(object sender, EventArgs e)
        {
            //ihcapplication123
            //ihcapplication

            string username = this.username.Text;

            List<string> userParams = new Database.DatabaseConnection()._PublicStrategy._PublicDataStrategy.ResetPasswsord(username);

            

            try
            {
                string email = userParams[1];
                string password = userParams[0];

                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("ihcapplication123@gmail.com", "ihcapplication"),
                    EnableSsl = true
                };

                client.Send("ForgotPW@IHC.com", email, "Forgot Password", "Your current password is: " + password);
            }
            catch(Exception ex)
            {

            }
            
            

        }
    }
}