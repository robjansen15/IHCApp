using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserWebApp
{
    public partial class StudentForm : System.Web.UI.Page
    {
        /// <summary>
        /// Page loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

            //checks for postback
            if (!IsPostBack)
            {
                //add counter for panel
                Session.Add("counter", 0);

                //display the first panel
                DisplayPanel(0);

                //enable everything
                personalInfoPanel.Enabled = true;
                contactInfoPanel.Enabled = true;
                conditionsPreferencesPanel.Enabled = true;
                universityInfoPanel.Enabled = true;

                if (this.SelectedDate == DateTime.MinValue)
                {
                    this.PopulateYear();
                    this.PopulateMonth();
                    this.PopulateDay();
                }
            }
            else
            {
                if (Request.Form[ddlDay.UniqueID] != null)
                {
                    this.PopulateDay();
                    ddlDay.ClearSelection();
                    ddlDay.Items.FindByValue(Request.Form[ddlDay.UniqueID]).Selected = true;
                }
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

                personalInfoPanel.Visible = true;
                contactInfoPanel.Visible = false;
                conditionsPreferencesPanel.Visible = false;
                universityInfoPanel.Visible = false;
            }
            else if (value == 1)
            {
                personalInfoPanel.Visible = false;
                contactInfoPanel.Visible = true;
                conditionsPreferencesPanel.Visible = false;
                universityInfoPanel.Visible = false;
            }
            else if (value == 2)
            {
                personalInfoPanel.Visible = false;
                contactInfoPanel.Visible = false;
                conditionsPreferencesPanel.Visible = true;
                universityInfoPanel.Visible = false;
            }
            else if (value == 3)
            {
                personalInfoPanel.Visible = false;
                contactInfoPanel.Visible = false;
                conditionsPreferencesPanel.Visible = false;
                universityInfoPanel.Visible = true;
            }
        }


        /// <summary>
        /// DOB day selector
        /// </summary>
        /// <param name="count"></param>
        private int Day
        {
            get
            {
                if (Request.Form[ddlDay.UniqueID] != null)
                {
                    return int.Parse(Request.Form[ddlDay.UniqueID]);
                }
                else
                {
                    return int.Parse(ddlDay.SelectedItem.Value);
                }
            }
            set
            {
                this.PopulateDay();
                ddlDay.ClearSelection();
                ddlDay.Items.FindByValue(value.ToString()).Selected = true;
            }
        }

        /// <summary>
        /// DOB month selector
        /// </summary>
        /// <param name="count"></param>
        private int Month
        {
            get
            {
                return int.Parse(ddlMonth.SelectedItem.Value);
            }
            set
            {
                this.PopulateMonth();
                ddlMonth.ClearSelection();
                ddlMonth.Items.FindByValue(value.ToString()).Selected = true;
            }
        }

        /// <summary>
        /// DOB year selector
        /// </summary>
        /// <param name="count"></param>
        private int Year
        {
            get
            {
                return int.Parse(ddlYear.SelectedItem.Value);
            }
            set
            {
                this.PopulateYear();
                ddlYear.ClearSelection();
                ddlYear.Items.FindByValue(value.ToString()).Selected = true;
            }
        }

        /// <summary>
        /// DOB selected Date concatenation
        /// </summary>
        /// <param name="count"></param>
        public DateTime SelectedDate
        {
            get
            {
                try
                {
                    return DateTime.Parse(this.Month + "/" + this.Day + "/" + this.Year);
                }
                catch
                {
                    return DateTime.MinValue;
                }
            }
            set
            {
                if (!value.Equals(DateTime.MinValue))
                {
                    this.Year = value.Year;
                    this.Month = value.Month;
                    this.Day = value.Day;
                }
            }
        }
        /// <summary>
        /// DOB day populate
        /// </summary>
        /// <param name="count"></param>
        private void PopulateDay()
        {
            ddlDay.Items.Clear();
            ListItem lt = new ListItem();
            lt.Text = "DD";
            lt.Value = "0";
            ddlDay.Items.Add(lt);
            int days = DateTime.DaysInMonth(this.Year, this.Month);
            for (int i = 1; i <= days; i++)
            {
                lt = new ListItem();
                lt.Text = i.ToString();
                lt.Value = i.ToString();
                ddlDay.Items.Add(lt);
            }
            ddlDay.Items.FindByValue(DateTime.Now.Day.ToString()).Selected = true;
        }


        /// <summary>
        /// DOB month populate
        /// </summary>
        /// <param name="count"></param>
        private void PopulateMonth()
        {
            ddlMonth.Items.Clear();
            ListItem lt = new ListItem();
            lt.Text = "MM";
            lt.Value = "0";
            ddlMonth.Items.Add(lt);
            for (int i = 1; i <= 12; i++)
            {
                lt = new ListItem();
                lt.Text = Convert.ToDateTime(i.ToString() + "/1/1900").ToString("MMMM");
                lt.Value = i.ToString();
                ddlMonth.Items.Add(lt);
            }
            ddlMonth.Items.FindByValue(DateTime.Now.Month.ToString()).Selected = true;
        }

        /// <summary>
        /// DOB year populate
        /// </summary>
        /// <param name="count"></param>
        private void PopulateYear()
        {
            ddlYear.Items.Clear();
            ListItem lt = new ListItem();
            lt.Text = "YYYY";
            lt.Value = "0";
            ddlYear.Items.Add(lt);
            for (int i = DateTime.Now.Year; i >= 1950; i--)
            {
                lt = new ListItem();
                lt.Text = i.ToString();
                lt.Value = i.ToString();
                ddlYear.Items.Add(lt);
            }
            ddlYear.Items.FindByValue(DateTime.Now.Year.ToString()).Selected = true;

        }

    }
}