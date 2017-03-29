using IHCApp.Database;
using IHCApp.Helper;
using IHCApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
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

        public void ClickQuickSearch()
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



        protected void handleQuickSearch(List<List<String>> rows)
        {
           if(rows != null)
            {
                this.exampleTable.ID = "quickSearch";
                this.exampleTable.Controls.Add(new LiteralControl("<table class='table table -striped table - advance table - hover'>"));

                List<String> header = rows.ElementAt(0);

                foreach (string column in header)
                {


                }

                rows.RemoveAt(0);

                int counter = 0;

                foreach (List<String> row in rows)
                {

                    this.exampleTable.Controls.Add(new LiteralControl("<tr Id='rowNum'" + counter + "'>"));

                    foreach (string colInRow in row)
                    {
                        this.exampleTable.Controls.Add(new LiteralControl("<td>" + colInRow + "</td>"));

                    }

                    this.exampleTable.Controls.Add(new LiteralControl("</tr>"));
                    counter++;
                }

                this.exampleTable.Controls.Add(new LiteralControl("</table>"));
            }
            else
            {
                this.exampleTable.Controls.Add(new LiteralControl("<h1>Error populating table</h1>"));
            }
        }



        /// <summary>
        /// QUICK SEARCH METHODS
        /// </summary>
    
        /*HOSTS*/
        protected void allHosts_Click(object sender, EventArgs e)
        {
            //go to this tab
            ClickQuickSearch();

            Token t = new Token("token", "email");

            DataTable dt = new DatabaseConnection(t)._ProtectedStrategy._QuickSearchStrategy.GetAllHosts();        
            List<Host> hosts = new TableParse<Host>().ParseHosts(dt);
            List<List<string>> table = new TableParse<Host>().ParseForDisplay(hosts);

            //this handles the HTML for you :)))
            handleQuickSearch(table);
        }


        protected void allActiveHosts_Click(object sender, EventArgs e)
        {
            //go to this tab
            ClickQuickSearch();

            Token t = new Token("token", "email");

            DataTable dt = new DatabaseConnection(t)._ProtectedStrategy._QuickSearchStrategy.GetActiveHosts();
            List<Host> hosts = new TableParse<Host>().ParseHosts(dt);
            List<List<string>> table = new TableParse<Host>().ParseForDisplay(hosts);

            //this handles the HTML for you :)))
            handleQuickSearch(table);
        }

        protected void lookingHosts_Click(object sender, EventArgs e)
        {
            //go to this tab
            ClickQuickSearch();

            Token t = new Token("token", "email");

            DataTable dt = new DatabaseConnection(t)._ProtectedStrategy._QuickSearchStrategy.GetLookingHosts();
            List<Host> hosts = new TableParse<Host>().ParseHosts(dt);
            List<List<string>> table = new TableParse<Host>().ParseForDisplay(hosts);

            //this handles the HTML for you :)))
            handleQuickSearch(table);
        }


        /*APPLICANTS*/
        protected void allApplicants_Click(object sender, EventArgs e)
        {
            //go to this tab
            ClickQuickSearch();

            Token t = new Token("token", "email");

            DataTable dt = new DatabaseConnection(t)._ProtectedStrategy._QuickSearchStrategy.GetAllApplicants();
            List<Applicant> applicant = new TableParse<Applicant>().ParseApplicant(dt);
            List<List<string>> table = new TableParse<Applicant>().ParseForDisplay(applicant);

            //this handles the HTML for you :)))
            handleQuickSearch(table);
        }

        protected void allActiveApplicants_Click(object sender, EventArgs e)
        {
            //go to this tab
            ClickQuickSearch();

            Token t = new Token("token", "email");

            DataTable dt = new DatabaseConnection(t)._ProtectedStrategy._QuickSearchStrategy.GetActiveApplicants();
            List<Applicant> applicant = new TableParse<Applicant>().ParseApplicant(dt);
            List<List<string>> table = new TableParse<Applicant>().ParseForDisplay(applicant);

            //this handles the HTML for you :)))
            handleQuickSearch(table);
        }

        protected void lookingApplicants_Click(object sender, EventArgs e)
        {
            //go to this tab
            ClickQuickSearch();

            Token t = new Token("token", "email");

            DataTable dt = new DatabaseConnection(t)._ProtectedStrategy._QuickSearchStrategy.GetLookingApplicants();
            List<Applicant> applicant = new TableParse<Applicant>().ParseApplicant(dt);
            List<List<string>> table = new TableParse<Applicant>().ParseForDisplay(applicant);

            //this handles the HTML for you :)))
            handleQuickSearch(table);
        }

       
    }

}