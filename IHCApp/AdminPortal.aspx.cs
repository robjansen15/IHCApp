using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IHCApp.Authentication;
using IHCApp.Models;
using IHCApp.Database;
using IHCApp.Helper;
using System.Data;

namespace IHCApp
{
    public partial class AdminPortal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool redirect = true;

            //hard coded
            redirect = false;
            Session.Add("token", new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123"));

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


            if (!Page.IsPostBack)
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

            applicantGrid.Visible = false;
        }

        protected void familyFormBtn_Click(object sender, EventArgs e)
        {
            this.exampleUpdateStudents.Visible = false;
            this.exampleUpdateFamily.Visible = true;
            this.exampleTable.Visible = false;
            this.exampleSearch.Visible = false;
            this.exampleDashboard.Visible = false;

            applicantGrid.Visible = false;
        }

        protected void studentFormBtn_Click(object sender, EventArgs e)
        {
            this.exampleUpdateStudents.Visible = true;
            this.exampleUpdateFamily.Visible = false;
            this.exampleTable.Visible = false;
            this.exampleSearch.Visible = false;
            this.exampleDashboard.Visible = false;
            this.applicantManagement.Visible = false;
            this.hostManagement.Visible = false;

            applicantGrid.Visible = false;
        }

        public void ClickQuickSearch()
        {
            this.exampleUpdateStudents.Visible = false;
            this.exampleUpdateFamily.Visible = false;
            this.exampleTable.Visible = true;
            this.exampleSearch.Visible = false;
            this.exampleDashboard.Visible = false;
            this.applicantManagement.Visible = false;
            this.hostManagement.Visible = false;

            applicantGrid.Visible = false;
        }

        protected void dashboardBtn_Click(object sender, EventArgs e)
        {
            this.exampleUpdateStudents.Visible = false;
            this.exampleUpdateFamily.Visible = false;
            this.exampleTable.Visible = false;
            this.exampleSearch.Visible = false;
            this.exampleDashboard.Visible = true;
            this.applicantManagement.Visible = false;
            this.hostManagement.Visible = false;

            applicantGrid.Visible = false;
        }
        protected void applicantManagementBtn_Click(object sender, EventArgs e)
        {
            this.exampleUpdateStudents.Visible = false;
            this.exampleUpdateFamily.Visible = false;
            this.exampleTable.Visible = false;
            this.exampleSearch.Visible = false;
            this.exampleDashboard.Visible = false;
            this.applicantManagement.Visible = true;
            this.hostManagement.Visible = false;

            getApplicants();
            PopulateCountriesDropDown();
            applicantGrid.Visible = true;
        }
        protected void hostManagementBtn__Click(object sender, EventArgs e)
        {
            this.exampleUpdateStudents.Visible = false;
            this.exampleUpdateFamily.Visible = false;
            this.exampleTable.Visible = false;
            this.exampleSearch.Visible = false;
            this.exampleDashboard.Visible = false;
            this.applicantManagement.Visible = false;
            this.hostManagement.Visible = true;

            applicantGrid.Visible = false;
        }

        protected void handleQuickSearch(List<List<String>> rows)
        {
            if (rows != null)
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

            //creates a token based off the credentials "Xiao" and "xiao123"
            Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");

            //This is the parser that helps convert the DataTable -> List<Hosts> -> List<List<string>>
            TableParse<Host> parser = new TableParse<Host>();

            //this converts DataTable -> List<Host>
            List<Host> hosts = parser.ParseHosts(new DatabaseConnection(token)._ProtectedStrategy._QuickSearchStrategy.GetAllHosts());

            //this converts List<Host> -> List<List<string>>
            List<List<string>> displayTables = parser.ParseForDisplay(hosts);

            //this handles the HTML for you :)))
            handleQuickSearch(displayTables);
        }


        protected void allActiveHosts_Click(object sender, EventArgs e)
        {
            //go to this tab
            ClickQuickSearch();

            //creates a token based off the credentials "Xiao" and "xiao123"
            Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");

            //This is the parser that helps convert the Datatables -> List<Hosts> -> List<List<string>>
            TableParse<Host> parser = new TableParse<Host>();

            //this converts DataTable -> List<Host>
            List<Host> hosts = parser.ParseHosts(new DatabaseConnection(token)._ProtectedStrategy._QuickSearchStrategy.GetActiveHosts());

            //this converts List<Host> -> List<List<string>>
            List<List<string>> displayTables = parser.ParseForDisplay(hosts);

            //this handles the HTML for you :)))
            handleQuickSearch(displayTables);
        }

        protected void lookingHosts_Click(object sender, EventArgs e)
        {
            //go to this tab
            ClickQuickSearch();

            //creates a token based off the credentials "Xiao" and "xiao123"
            Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");

            //This is the parser that helps convert the Datatables -> List<Hosts> -> List<List<string>>
            TableParse<Host> parser = new TableParse<Host>();

            //this converts DataTable -> List<Host>
            List<Host> hosts = parser.ParseHosts(new DatabaseConnection(token)._ProtectedStrategy._QuickSearchStrategy.GetLookingHosts());

            //this converts List<Host> -> List<List<string>>
            List<List<string>> displayTables = parser.ParseForDisplay(hosts);

            //this handles the HTML for you :)))
            handleQuickSearch(displayTables);
        }


        /*APPLICANTS*/
        protected void allApplicants_Click(object sender, EventArgs e)
        {
            //go to this tab
            ClickQuickSearch();

            //creates a token based off the credentials "Xiao" and "xiao123"
            Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");

            //This is the parser that helps convert the Datatables -> List<Applicant> -> List<List<string>>
            TableParse<Applicant> parser = new TableParse<Applicant>();

            //this converts DataTable -> List<Applicant>
            List<Applicant> applicants = parser.ParseApplicant(new DatabaseConnection(token)._ProtectedStrategy._QuickSearchStrategy.GetAllApplicants());

            //this converts List<Applicant> -> List<List<string>>
            List<List<string>> displayTables = parser.ParseForDisplay(applicants);

            //this handles the HTML for you :)))
            handleQuickSearch(displayTables);
        }

        protected void allActiveApplicants_Click(object sender, EventArgs e)
        {
            //go to this tab
            ClickQuickSearch();

            //creates a token based off the credentials "Xiao" and "xiao123"
            Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");

            //This is the parser that helps convert the Datatables -> List<Applicant> -> List<List<string>>
            TableParse<Applicant> parser = new TableParse<Applicant>();

            //this converts DataTable -> List<Applicant>
            List<Applicant> applicants = parser.ParseApplicant(new DatabaseConnection(token)._ProtectedStrategy._QuickSearchStrategy.GetActiveApplicants());

            //this converts List<Applicant> -> List<List<string>>
            List<List<string>> displayTables = parser.ParseForDisplay(applicants);

            //this handles the HTML for you :)))
            handleQuickSearch(displayTables);
        }


        protected void getApplicants()
        {
            Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");
            DataSet ds = new DataSet();
            DataTable applicants = new DatabaseConnection(token)._ProtectedStrategy._QuickSearchStrategy.GetActiveApplicants();


            ds.Tables.Add(applicants);

            if (ds.Tables[0].Rows.Count > 0)
            {
                applicantGrid.DataSource = ds;
                applicantGrid.DataBind();




                //hide unwanted grid columns

                this.applicantGrid.Columns[0].Visible = false;


                for (int index = 9; index < applicantGrid.Columns.Count -1; index++)
                {
                    this.applicantGrid.Columns[index].Visible = false;
                }

            }

        }

        protected void lookingApplicants_Click(object sender, EventArgs e)
        {
            //go to this tab
            ClickQuickSearch();

            //creates a token based off the credentials "Xiao" and "xiao123"
            Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");

            //This is the parser that helps convert the Datatables -> List<Applicant> -> List<List<string>>
            TableParse<Applicant> parser = new TableParse<Applicant>();

            //this converts DataTable -> List<Applicant>
            List<Applicant> applicants = parser.ParseApplicant(new DatabaseConnection(token)._ProtectedStrategy._QuickSearchStrategy.GetLookingApplicants());

            //this converts List<Applicant> -> List<List<string>>
            List<List<string>> displayTables = parser.ParseForDisplay(applicants);

            //this handles the HTML for you :)))
            handleQuickSearch(displayTables);
        }

        protected void saveFormApplicant_Click(object sender, EventArgs e)
        {
            try
            {
                Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");
                new DatabaseConnection(token)._ProtectedStrategy._FormUpdateHTMLStrategy.UpdateFormInfo(this.applicantEditor.Text, "APPLICANT");
            }
            catch
            {

            }
        }

        protected void rollBackFormApplicant_Click(object sender, EventArgs e)
        {
            try
            {
                Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");
                new DatabaseConnection(token)._ProtectedStrategy._FormUpdateHTMLStrategy.RollBackFormInfo("APPLICANT");
            }
            catch
            {

            }
        }

        protected void saveFormHost_Click(object sender, EventArgs e)
        {
            try
            {
                Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");
                new DatabaseConnection(token)._ProtectedStrategy._FormUpdateHTMLStrategy.UpdateFormInfo(this.hostEditor.Text, "HOST");
            }
            catch
            {

            }
        }

        protected void rollbackFormHost_Click(object sender, EventArgs e)
        {
            try
            {
                Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");
                new DatabaseConnection(token)._ProtectedStrategy._FormUpdateHTMLStrategy.RollBackFormInfo("HOST");
            }
            catch
            {

            }
        }

        /// <summary>
        /// Populate Countries
        /// </summary>
        private void PopulateCountriesDropDown()
        {
            List<string> countries = new DatabaseConnection()._PublicStrategy._PublicDataStrategy.GetAllCountries();
            this.Country.DataSource = countries;
            this.Country.DataBind();

            this.Country.Width = Unit.Pixel(200);
        }


        /// <summary>
        /// Edit Grid Row
        /// </summary>
        protected void applicantGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditRow")
            {
                // Retrieve the row index stored in the 
                // CommandArgument property.
                int index = Convert.ToInt32(e.CommandArgument);

                // Retrieve the row that contains the button 
                // from the Rows collection.
                GridViewRow row = applicantGrid.Rows[index];
                firstName.Text = row.Cells[1].Text;
                lastName.Text = row.Cells[2].Text;
                dateOfBirth.Text = row.Cells[3].Text;

                //Country ddl
                Country.ClearSelection();
                string CountryText = row.Cells[4].Text;
                ListItem gridSelectedCountry = Country.Items.FindByText(CountryText);

                if (gridSelectedCountry != null)
                {
                    Country.SelectedValue = gridSelectedCountry.Text;
                }

                firstLanguage.Text = row.Cells[5].Text;


                //gender radio
                gender.ClearSelection();
                string genderText = row.Cells[6].Text;
                gender.Items.FindByText(genderText).Selected = true;

                //martial status
                martialstatus.ClearSelection();
                string martialStatusText = row.Cells[7].Text;
                if(martialStatusText == "Married" || martialStatusText == "Unmarried")
                martialstatus.Items.FindByText(martialStatusText).Selected = true;

                address.Text = row.Cells[8].Text;

                phone1.Text = row.Cells[13].Text;
                phone2.Text = row.Cells[14].Text;
                allergies.Text = row.Cells[15].Text;
                hobbies.Text = row.Cells[16].Text;
                about.Text = row.Cells[17].Text;
                university.Text = row.Cells[18].Text;
                

                


                


                mp1.Show();






            }

        }

    }
}