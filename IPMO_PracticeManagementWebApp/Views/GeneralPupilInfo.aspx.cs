using IPMO_PracticeManagementWebApp.DataLayer;
using IPMO_PracticeManagementWebApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IPMO_PracticeManagementWebApp.Views
{
    public partial class GeneralPupilInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.Session["fmList"] != null)
                PopulateData((List<FieldModel>)HttpContext.Current.Session["fmList"]);
        }

        protected void Unnamed1_SelectionChanged(object sender, EventArgs e)
        {
            DateOfBirthTextBox.Text = DOBCalendar.SelectedDate.ToString();
        }

        protected void GeneralPupilInfoButton_Click(object sender, EventArgs e)
        {
            List<FieldModel> fieldModelList = new List<FieldModel>();
            List<string> ql = new List<string>();
            List<string> qt = new List<string>();

            foreach (Control ctrl in GeneralPupilInfoPlaceHolder.Controls)
            {
                if (ctrl is Label)
                {
                    Label lbl = ((System.Web.UI.WebControls.Label)ctrl);
                    ql.Add(lbl.Text);
                }
                if (ctrl is TextBox)
                {
                    TextBox txtbox = ((System.Web.UI.WebControls.TextBox)ctrl);
                    qt.Add(txtbox.Text);
                }
            }

            var dic = ql.Zip(qt, (k, v) => new { k, v })
              .ToDictionary(x => x.k, x => x.v);

            foreach (var item in dic)
            {
                FieldModel fm = new FieldModel();
                fm.FieldName = item.Key;
                fm.FieldValue = item.Value;
                fm.StudentUniqueId = PassportNumberTextBox.Text.Trim();
                fm.FormName = "General Pupil Info";
                fieldModelList.Add(fm);
            }

            DatabaseQueryManager dqm = new DatabaseQueryManager();
            var status = dqm.QueryToAddUpdateDeleteDataForField(fieldModelList, "Add");

            ValidationMessage(status);
        }

        private void ValidationMessage(string status)
        {
            Label lbl = new Label();
            lbl.Text = status;

            if (!status.Contains("Error"))
            {
                lbl.ForeColor = System.Drawing.Color.DarkGreen;
                lbl.CssClass = "alert alert-success";
            }
            else
            {
                lbl.ForeColor = System.Drawing.Color.Red;
                lbl.CssClass = "alert alert-danger";
            }

            Table tab = new Table();
            TableRow tr = new TableRow();
            TableCell tc = new TableCell();

            tc.Controls.Add(lbl);

            tr.Cells.Add(tc);
            tab.Rows.Add(tr);
            ValidationPanelForGeneralPupilInfo.Controls.Add(tab);
        }

        protected void GeneralPupilInfoViewButton_Click(object sender, EventArgs e)
        {
            DatabaseQueryManager dqm = new DatabaseQueryManager();
            var data = dqm.QueryToGetDataForField(PassportNumberTextBox.Text.Trim(), "General Pupil Info");

            if (data.Count > 0)
            {
                PopulateData(data);
            }
            else
            {
                ValidationMessage("Error: General Pupil Info with the Passport Number Provided was Not Found");
            }
        }

        private void PopulateData(List<FieldModel> data)
        {
            foreach (var item in data)
            {
                switch (item.FieldName)
                {
                    case "First Name":
                        FirstNameTextBox.Text = item.FieldValue;
                        break;
                    case "Initials":
                        InitialsTextBox.Text = item.FieldValue;
                        break;
                    case "Date Of Birth":
                        DateOfBirthTextBox.Text = item.FieldValue;
                        break;
                    case "Country":
                        CountryTextBox.Text = item.FieldValue;
                        break;
                    case "Address":
                        AddressTextArea.Text = item.FieldValue;
                        break;
                    case "City":
                        CityTextBox.Text = item.FieldValue;
                        break;
                    case "Mobile":
                        MobileTextBox.Text = item.FieldValue;
                        break;
                    case "Email":
                        EmailTextBox.Text = item.FieldValue;
                        break;
                    case "Passport Number":
                        PassportNumberTextBox.Text = item.FieldValue;
                        break;
                }
            }
        }

        protected void GeneralPupilInfoUpdateButton_Click(object sender, EventArgs e)
        {
            List<FieldModel> fieldModelList = new List<FieldModel>();
            List<string> ql = new List<string>();
            List<string> qt = new List<string>();

            foreach (Control ctrl in GeneralPupilInfoPlaceHolder.Controls)
            {
                if (ctrl is Label)
                {
                    Label lbl = ((System.Web.UI.WebControls.Label)ctrl);
                    ql.Add(lbl.Text);
                }
                if (ctrl is TextBox)
                {
                    TextBox txtbox = ((System.Web.UI.WebControls.TextBox)ctrl);
                    qt.Add(txtbox.Text);
                }
            }

            var dic = ql.Zip(qt, (k, v) => new { k, v })
              .ToDictionary(x => x.k, x => x.v);

            foreach (var item in dic)
            {
                FieldModel fm = new FieldModel();
                fm.FieldName = item.Key;
                fm.FieldValue = item.Value;
                fm.StudentUniqueId = PassportNumberTextBox.Text.Trim();
                fm.FormName = "General Pupil Info";
                fieldModelList.Add(fm);
            }

            DatabaseQueryManager dqm = new DatabaseQueryManager();
            var status = dqm.QueryToAddUpdateDeleteDataForField(fieldModelList, "Update");

            ValidationMessage(status);
        }
    }
}