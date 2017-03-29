using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IHCApp
{
    public partial class AdminPortal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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


            List<List<String>> lists = new List<List<String>>();

            List<String> list = new List<String>();

            //<tr>
            //             <th><i class="icon_profile"></i> Full Name</th>
            //             <th><i class="icon_calendar"></i> Date</th>
            //             <th><i class="icon_mail_alt"></i> Email</th>
            //             <th><i class="icon_pin_alt"></i> City</th>
            //             <th><i class="icon_mobile"></i> Mobile</th>
            //             <th><i class="icon_cogs"></i> Action</th>
            //          </tr>


            List<String> headerList = new List<String>();

            headerList.Add("<th><i class=icon_profile'></i> Full Name</th>");
            headerList.Add("<th><i class='icon_calendar'></i> Date</th>");
            headerList.Add("<th><i class='icon_mail_alt'></i> Email</th>");
            headerList.Add("<th><i class=icon_profile'></i> Full Name</th>");
            headerList.Add("<th><i class=icon_profile'></i> Full Name</th>");
            headerList.Add("<th><i class=icon_profile'></i> Full Name</th>");


            list.Add("John");
            list.Add("Rob");
            list.Add("Jim");
            list.Add("Ahkil");

            lists.Add(list);
            lists.Add(list);

            quickSearch(lists);
        }

        protected void dashboardBtn_Click(object sender, EventArgs e)
        {
            this.exampleUpdateStudents.Visible = false;
            this.exampleUpdateFamily.Visible = false;
            this.exampleTable.Visible = false;
            this.exampleSearch.Visible = false;
            this.exampleDashboard.Visible = true;



        }

        protected void quickSearch(List<List<String>> rows)
        {
            /* <table class="table table-striped table-advance table-hover">
                <tbody>
                    <tr>
                        <th><i class="icon_profile"></i> Full Name</th>
                        <th><i class="icon_calendar"></i> Date</th>
                        <th><i class="icon_mail_alt"></i> Email</th>
                        <th><i class="icon_pin_alt"></i> City</th>
                        <th><i class="icon_mobile"></i> Mobile</th>
                    </tr>
                    <tr>
                        <td>Angeline Mcclain</td>
                        <td>2004-07-06</td>
                        <td>dale@chief.info</td>
                        <td>Rosser</td>
                        <td>176-026-5992</td>
                    </tr>
                    <tr>
            */

            this.exampleTable.ID = "quickSearch";
            this.exampleTable.Controls.Add(new LiteralControl("<table class='table table -striped table - advance table - hover'>"));

            List<String> header = rows.ElementAt(0);

            foreach (string column in header) { 


            }

            rows.RemoveAt(0);

            int counter = 0;

            foreach(List<String> row in rows) {

                this.exampleTable.Controls.Add(new LiteralControl("<tr Id='rowNum'" + counter + "'>"));

                foreach (string colInRow in row) {
                    this.exampleTable.Controls.Add(new LiteralControl("<td>" + colInRow + "</td>"));

                }

                this.exampleTable.Controls.Add(new LiteralControl("</tr>"));
                counter++;
            }

            this.exampleTable.Controls.Add(new LiteralControl("</table>"));
        }
    }

}