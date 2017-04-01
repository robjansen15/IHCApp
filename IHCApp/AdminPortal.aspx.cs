﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IHCApp.Authentication;
using IHCApp.Models;

namespace IHCApp
{
    public partial class AdminPortal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool redirect = true;
            var x = (Token)Session["token"];

            if ((Token)Session["token"] == null)
            {
                Response.Redirect("AdminLogin.aspx");
            }
            else if (new Authenticate().ValidateToken((Token)Session["token"]))
            {
                redirect = false;
            }


            if (redirect)
            {
                Response.Redirect("AdminLogin.aspx");
            }


            if (Page.IsPostBack != true)
            {
                this.exampleUpdateStudents.Visible = false;
                this.exampleUpdateFamily.Visible = false;
                this.exampleTable.Visible = false;
                this.exampleSearch.Visible = false;
                this.exampleDashboard.Visible = true;
            }
        }


        /*THSE WILL BE UPDATED AND DYNAMIC, just for demo*/

        protected void Click_SearchBtn(object sender, EventArgs e)
        {
            this.exampleUpdateStudents.Visible = false;
            this.exampleUpdateFamily.Visible = false;
            this.exampleTable.Visible = false;
            this.exampleSearch.Visible = true;
            this.exampleDashboard.Visible = false;
        }

        protected void familyFormBtn_Click(object sender, EventArgs e)
        {
            this.exampleUpdateStudents.Visible = false;
            this.exampleUpdateFamily.Visible = true;
            this.exampleTable.Visible = false;
            this.exampleSearch.Visible = false;
            this.exampleDashboard.Visible = false;
        }

        protected void studentFormBtn_Click(object sender, EventArgs e)
        {
            this.exampleUpdateStudents.Visible = true;
            this.exampleUpdateFamily.Visible = false;
            this.exampleTable.Visible = false;
            this.exampleSearch.Visible = false;
            this.exampleDashboard.Visible = false;
        }

        protected void tableFormBtn_Click(object sender, EventArgs e)
        {
            this.exampleUpdateStudents.Visible = false;
            this.exampleUpdateFamily.Visible = false;
            this.exampleTable.Visible = true;
            this.exampleSearch.Visible = false;
            this.exampleDashboard.Visible = false;
        }

        protected void dashboardBtn_Click(object sender, EventArgs e)
        {
            this.exampleUpdateStudents.Visible = false;
            this.exampleUpdateFamily.Visible = false;
            this.exampleTable.Visible = false;
            this.exampleSearch.Visible = false;
            this.exampleDashboard.Visible = true;
        }
    }
}