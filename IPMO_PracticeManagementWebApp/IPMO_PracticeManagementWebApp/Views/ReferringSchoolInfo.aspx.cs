using IPMO_PracticeManagementWebApp.DataLayer;
using IPMO_PracticeManagementWebApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IPMO_PracticeManagementWebApp.Views
{
    public partial class ReferringSchoolInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ReferringSchoolInfoButton_Click(object sender, EventArgs e)
        {
            List<FieldModel> fieldModelList = new List<FieldModel>();
            List<string> ql = new List<string>();
            List<string> qt = new List<string>();

            foreach (Control ctrl in ReferringSchoolInfoPlaceHolder.Controls)
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
                fm.FormName = "Referring School Info"; ;
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

            if (!status.Contains("ERROR"))
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
            ValidationPanelForReferringSchoolInfo.Controls.Add(tab);
        }

        protected void ReferringSchoolInfoViewButton_Click(object sender, EventArgs e)
        {
            DatabaseQueryManager dqm = new DatabaseQueryManager();
            var data = dqm.QueryToGetDataForField(PassportNumberTextBox.Text.Trim(), "Referring School Info");

            PopulateData(data);
        }

        private void PopulateData(List<FieldModel> data)
        {
            foreach (var item in data)
            {
                switch (item.FieldName)
                {
                    case "School Name":
                        SchoolNameTextBox.Text = item.FieldValue;
                        break;
                    case "Address":
                        AddressTextArea.Text = item.FieldValue;
                        break;
                    case "Telephone Number":
                        TelephoneNumberTextBox.Text = item.FieldValue;
                        break;
                    case "Email":
                        EmailTextBox.Text = item.FieldValue;
                        break;
                    case "Contact Person":
                        ContactPersonTextBox.Text = item.FieldValue;
                        break;
                    case "Email Contact":
                        EmailContactTextBox.Text = item.FieldValue;
                        break;
                    case "Explain Agreement":
                        ExplainAgreementTextBox.Text = item.FieldValue;
                        break;
                    case "Referal Name":
                        ReferalNameTextBox.Text = item.FieldValue;
                        break;
                }
            }
        }

        protected void ReferringSchoolInfoUpdateButton_Click(object sender, EventArgs e)
        {
            List<FieldModel> fieldModelList = new List<FieldModel>();
            List<string> ql = new List<string>();
            List<string> qt = new List<string>();

            foreach (Control ctrl in ReferringSchoolInfoPlaceHolder.Controls)
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
                fm.FormName = "Referring School Info";
                fieldModelList.Add(fm);
            }

            DatabaseQueryManager dqm = new DatabaseQueryManager();
            var status = dqm.QueryToAddUpdateDeleteDataForField(fieldModelList, "Update");

            ValidationMessage(status);
        }
    }
}