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

            
                //Handle !ispostback

                if (!Page.IsPostBack && Session["IsApplicantPage"] != null)
                {
                    CommandEventArgs events = new CommandEventArgs("Active", "");
                    applicantManagementBtn_Click(sender, events);
                    Session["IsApplicantPage"] = null;
                }

                else if (!Page.IsPostBack && Session["isHostPage"] != null)
                {
                    CommandEventArgs events = new CommandEventArgs("Active", "");
                    hostManagementBtn__Click(sender, events);
                    Session["isHostPage"] = null;
                }

                else if(!Page.IsPostBack)
                    dashboardBtn_Click(sender, e);

                
            
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
            hostGrid.Visible = false;
        }

        protected void familyFormBtn_Click(object sender, EventArgs e)
        {
            this.exampleUpdateStudents.Visible = false;
            this.exampleUpdateFamily.Visible = true;
            this.exampleTable.Visible = false;
            this.exampleSearch.Visible = false;
            this.exampleDashboard.Visible = false;

            applicantGrid.Visible = false;
            hostGrid.Visible = false;
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
            hostGrid.Visible = false;
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
            hostGrid.Visible = false;
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
            hostGrid.Visible = false;
        }
        protected void applicantManagementBtn_Click(object sender, CommandEventArgs e)
        {
            bool isHistorical = false;

            this.exampleUpdateStudents.Visible = false;
            this.exampleUpdateFamily.Visible = false;
            this.exampleTable.Visible = false;
            this.exampleSearch.Visible = false;
            this.exampleDashboard.Visible = false;
            this.applicantManagement.Visible = true;
            this.hostManagement.Visible = false;


      
            if(e.CommandName == "Historical")
                isHistorical = true;


            getApplicants(isHistorical);

            PopulateCountriesDropDown();

            hostGrid.Visible = false;
            applicantGrid.Visible = true;

        }
        protected void hostManagementBtn__Click(object sender, CommandEventArgs e)
        {
            bool isHistorical = false;

            this.exampleUpdateStudents.Visible = false;
            this.exampleUpdateFamily.Visible = false;
            this.exampleTable.Visible = false;
            this.exampleSearch.Visible = false;
            this.exampleDashboard.Visible = false;
            this.applicantManagement.Visible = false;
            this.hostManagement.Visible = true;

            if (e.CommandName == "Historical")
                isHistorical = true;


            getHosts(isHistorical);

            applicantGrid.Visible = false;
            hostGrid.Visible = true;
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


        protected void getApplicants(bool isHistorical)
        {

            DataTable applicants = new DataTable();
            Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");
            DataSet ds = new DataSet();





            if (isHistorical)
                applicants = new DatabaseConnection(token)._ProtectedStrategy._QuickSearchStrategy.GetHistoricalApplicants();

            


            else
                applicants = new DatabaseConnection(token)._ProtectedStrategy._QuickSearchStrategy.GetActiveApplicants();



            ds.Tables.Add(applicants);

            if (ds.Tables[0].Rows.Count > 0)
            {
                applicantGrid.DataSource = ds;

                for (int x = 9; x < applicantGrid.Columns.Count - 1; x++)
                {
                    this.applicantGrid.Columns[x].Visible = true;
                }


                applicantGrid.DataBind();



                //hide unwanted grid columns

                this.applicantGrid.Columns[0].Visible = false;


                for (int index = 9; index < applicantGrid.Columns.Count -1; index++)
                {
                    this.applicantGrid.Columns[index].Visible = false;
                }

                //if historical hide archive button
                if (isHistorical)
                {
                    Button archiveButton = null;
                    foreach (GridViewRow row in applicantGrid.Rows)
                    {
                        if (row.RowType == DataControlRowType.DataRow)
                        {
                            archiveButton = row.FindControl("applicantRowArchive") as Button;
                        }

                        if (archiveButton != null)
                        {
                            archiveButton.Visible = false;
                        }

                    }
                }

            }

        }

        protected void getHosts(bool isHistorical)
        {
            DataTable hosts = new DataTable();
            Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");
            DataSet ds = new DataSet();

            if(isHistorical)
                hosts = new DatabaseConnection(token)._ProtectedStrategy._QuickSearchStrategy.GetHistoricalHosts();
            
            else
                hosts = new DatabaseConnection(token)._ProtectedStrategy._QuickSearchStrategy.GetActiveHosts();


            ds.Tables.Add(hosts);

            if (ds.Tables[0].Rows.Count > 0)
            {
                hostGrid.DataSource = ds;

                for (int x = 7; x < hostGrid.Columns.Count - 2; x++)
                {
                    this.hostGrid.Columns[x].Visible = true;
                }

                hostGrid.DataBind();



                //hide unwanted grid columns

                this.hostGrid.Columns[0].Visible = false;


                for (int index = 7; index < hostGrid.Columns.Count - 2; index++)
                {
                    this.hostGrid.Columns[index].Visible = false;
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
        /// Handle applicant grid row actions.
        /// </summary>
        protected void applicantGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = applicantGrid.Rows[index];


            if (e.CommandName == "EditRow")
            {

                for (int x = 1; x < applicantGrid.Columns.Count - 1; x++)
                {
                    this.applicantGrid.Columns[x].Visible = true;
                }

                applicantId.Text = row.Cells[0].Text;
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


                applicantModalWindow.Show();


                for (int x = 9; x < applicantGrid.Columns.Count - 1; x++)
                {
                    this.applicantGrid.Columns[x].Visible = false;
                }






            }

            else if (e.CommandName == "ArchiveRow")
            {
                Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");
                Applicant applicant = new Applicant();

                applicant._ApplicantID = Int32.Parse(row.Cells[0].Text);

                new DatabaseConnection(token)._ProtectedStrategy._UpdateFormStrategy.InActivateApplicant(applicant);

                Session.Add("IsApplicantPage", "true");
                Response.Redirect("AdminPortal.aspx");
            }

        }

        protected void hostGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = hostGrid.Rows[index];


            if (e.CommandName == "EditRow")
            {

                for (int x = 7; x < applicantGrid.Columns.Count - 2; x++)
                {
                    this.hostGrid.Columns[x].Visible = true;
                }


                familyId.Text = row.Cells[0].Text;

                hostAddress.Text = row.Cells[1].Text;
                hostPhone1.Text = row.Cells[2].Text;
                hostPhone2.Text = row.Cells[7].Text;


                familySmoke.ClearSelection();
                string familySmokeText = row.Cells[5].Text;
                familySmoke.Items.FindByText(familySmokeText).Selected = true;


                familyDrinking.ClearSelection();
                string familyDrinkingText = row.Cells[6].Text;
                familyDrinking.Items.FindByText(familyDrinkingText).Selected = true;

                allowSmoking.ClearSelection();
                string allowSmokingText = row.Cells[12].Text;
                allowSmoking.Items.FindByText(allowSmokingText).Selected = true;

                allowDrinking.ClearSelection();
                string allowDrinkingText = row.Cells[13].Text;
                allowDrinking.Items.FindByText(allowDrinkingText).Selected = true;


                dogs.ClearSelection();
                string dogText = row.Cells[10].Text;
                ListItem dogSelectedValue = dogs.Items.FindByText(dogText);

                if (dogSelectedValue != null)
                {
                    dogs.SelectedValue = dogSelectedValue.Text;
                }


                cats.ClearSelection();
                string catsText = row.Cells[11].Text;
                ListItem catSelectedValue = cats.Items.FindByText(catsText);

                if (catSelectedValue != null)
                {
                    cats.SelectedValue = catSelectedValue.Text;
                }

                internet.ClearSelection();
                string internetText = row.Cells[4].Text;
                ListItem interentSelectedValue = internet.Items.FindByText(internetText);

                if (interentSelectedValue != null)
                {
                    internet.SelectedValue = interentSelectedValue.Text;
                }

                bathrooms.ClearSelection();
                string bathroomText = row.Cells[9].Text;
                ListItem bathroomSelectedText = bathrooms.Items.FindByText(bathroomText);

                if (interentSelectedValue != null)
                {
                    bathrooms.SelectedValue = bathroomSelectedText.Text;
                }

                hostTransportation.Text = row.Cells[14].Text;
                hostAbout.Text = row.Cells[15].Text;
                hobbies.Text = row.Cells[16].Text;

                for (int x = 7; x < applicantGrid.Columns.Count - 2; x++)
                {
                    this.hostGrid.Columns[x].Visible = false;
                }

                hostModalWindow.Show();


            }

        }


        /// <summary>
        /// Update Applicant Row
        /// </summary>
        protected void applicantGrid_UpdateRow(object sender, EventArgs e)
        {

            try
            {
                Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");
                Applicant applicant = new Applicant();

                applicant._ApplicantID = Int32.Parse(applicantId.Text);

                applicant._FirstName = this.firstName.Text;
                applicant._LastName = this.lastName.Text;
                applicant._MoveInDate = DateTime.Now;
                applicant._DurationOfStay = "4";
                applicant._Language = this.firstLanguage.Text;
                applicant._Gender = gender.SelectedValue;
                applicant._Status = martialstatus.SelectedValue;
                applicant._Nationality = "nationality";
                applicant._Street = this.address.Text;
                applicant._State = "IN";
                applicant._City = "Indianapolis";
                applicant._Country = this.Country.Text;
                applicant._FlightID = "F29";
                applicant._FlightDate = DateTime.Now;
                applicant._FlightName = "flight name";
                applicant._Dog = "yes";
                applicant._Cat = "no";
                applicant._HealthIssues = this.allergies.Text;
                applicant._DOB = DateTime.Parse(dateOfBirth.Text);
                applicant._PrimaryPhone = this.phone1.Text;
                applicant._SecondaryPhone = this.phone2.Text;
                applicant._Hobbies = this.hobbies.Text;
                applicant._About = this.about.Text;
                applicant._Paydate = DateTime.Now;
                applicant._DepositDate = DateTime.Now;
                applicant._PaymentAmount = "300";
                applicant._OtherUniversity = "purdue";
                applicant._Email = 
                applicant._EmergencyContact = this.universityContactInfo.Text;

                new DatabaseConnection(token)._ProtectedStrategy._UpdateFormStrategy.UpdateApplicant(applicant);

            }
            catch (Exception ex)
            {
                var x = ex.ToString();
                //notify the user
            }


            applicantModalWindow.Hide();
            Session.Add("IsApplicantPage", "true");
            Response.Redirect("AdminPortal.aspx");




        }

        /// <summary>
        /// Update Applicant Row
        /// </summary>
        protected void hostGrid_UpdateRow(object sender, EventArgs e)
        {

            try
            {
                Token token = new DatabaseConnection()._PublicStrategy._TokenStrategy.ValidateCredentials("Xiao", "xiao123");
                Host host = new Host();

                host._FamilyID = Int32.Parse(familyId.Text);

                host._About = hostAbout.Text;
                host._City = "Indianapolis";
                host._Country = "United States";
                host._Email = hostEmail.Text;
                host._Hobbies = hostHobbies.Text;
                host._Looking = "yes";
                host._Note = "N/A";
                host._NumBathrooms = "3";
                host._NumCats = cats.Text;
                host._NumDogs = dogs.Text;
                host._NumRooms = "3";
                host._Occupied = "no";
                host._PrimePhone = hostPhone1.Text;
                host._SecPhone = hostPhone2.Text;
                host._State = "Indiana";
                host._Street = hostAddress.Text;
                host._Zip = "41235";
                host._TimeToCenter = 10;
                host._ToAdmin = "";
                host._TransportationInfo = hostTransportation.Text;
                host._AllowSmoking = allowSmoking.Text;
                host._AllowDrinking = allowDrinking.Text;
                host._DoesFamilySmoke = familySmoke.Text;
                host._DoesFamilyDrink = familyDrinking.Text;

                new DatabaseConnection(token)._ProtectedStrategy._UpdateFormStrategy.UpdateHost(host);


            }
            catch
            {
                //notify the user
            }


            hostModalWindow.Hide();

            Session.Add("isHostPage", "true");
            Response.Redirect("AdminPortal.aspx");




        }


        protected void applicantGrid_onPageIndexing(object sender, EventArgs e)
        {

          


        }


    }
}