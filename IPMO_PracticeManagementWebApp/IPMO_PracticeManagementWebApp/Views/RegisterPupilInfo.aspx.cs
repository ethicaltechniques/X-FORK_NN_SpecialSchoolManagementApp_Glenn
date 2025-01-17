﻿using IPMO_PracticeManagementWebApp.DataLayer;
using IPMO_PracticeManagementWebApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IPMO_PracticeManagementWebApp.Views
{
    public partial class RegisterPupilInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void RegisterPupilInfoButton_Click(object sender, EventArgs e)
        {
            List<FieldModel> fieldModelList = new List<FieldModel>();
            List<string> ql = new List<string>();
            List<string> qt = new List<string>();

            foreach (Control ctrl in RegisterPupilInfoPlaceHolder.Controls)
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
                fm.FormName = "Register Pupil Info";
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
            ValidationPanelForRegisterPupilInfo.Controls.Add(tab);
        }

        protected void RegisterPupilInfoViewButton_Click(object sender, EventArgs e)
        {
            DatabaseQueryManager dqm = new DatabaseQueryManager();
            var data = dqm.QueryToGetDataForField(PassportNumberTextBox.Text.Trim(), "Register Pupil Info");

            if (data.Count > 0)
            {
                PopulateData(data);
            }
            else
            {
                ValidationMessage("Error: Registered Pupil Info with the Passport Number Provided was Not Found");
            }
        }

        private void PopulateData(List<FieldModel> data)
        {
            foreach (var item in data)
            {
                switch (item.FieldName)
                {
                    case "Id Number":
                        IdNumberTextBox.Text = item.FieldValue;
                        break;
                    case "Insurance Org":
                        InsuranceOrgTextBox.Text = item.FieldValue;
                        break;
                    case "Insurance Number":
                        InsuranceNumberTextBox.Text = item.FieldValue;
                        break;
                    case "Mother/Caretaker":
                        MotherTextBox.Text = item.FieldValue;
                        break;
                    case "Father/Caretaker":
                        FatherTextBox.Text = item.FieldValue;
                        break;
                    case "Mobile Mother":
                        MobileMotherTextBox.Text = item.FieldValue;
                        break;
                    case "Mobile Father":
                        MobileFatherTextBox.Text = item.FieldValue;
                        break;
                    case "Email Caretaker":
                        EmailCaretakerTextBox.Text = item.FieldValue;
                        break;
                }
            }
        }

        protected void RegisterPupilInfoUpdateButton_Click(object sender, EventArgs e)
        {
            List<FieldModel> fieldModelList = new List<FieldModel>();
            List<string> ql = new List<string>();
            List<string> qt = new List<string>();

            foreach (Control ctrl in RegisterPupilInfoPlaceHolder.Controls)
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
                fm.FormName = "Register Pupil Info";
                fieldModelList.Add(fm);
            }

            DatabaseQueryManager dqm = new DatabaseQueryManager();
            var status = dqm.QueryToAddUpdateDeleteDataForField(fieldModelList, "Update");

            ValidationMessage(status);
        }
    }
}