using System;
using System.Data;
using IPMO_PracticeManagementWebApp.DataLayer;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IPMO_PracticeManagementWebApp.Views
{
    public partial class SchoolResults : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseQueryManager dbQueryManager = new DatabaseQueryManager();
            var data = dbQueryManager.QueryToGetDatabaseFieldsForSchoolResults();

            Table tab = new Table();
            tab.ID = "TableForSchoolResults";

            foreach (DataRow row in data.Rows)
            {
                var columnName = row["COLUMN_NAME"].ToString();

                //if (columnName.Contains("Parent1"))
                //{

                Label lbl = new Label();
                lbl.Text = row["COLUMN_NAME"].ToString();

                TextBox txt = new TextBox();
                txt.ID = columnName;
                txt.TextMode = TextBoxMode.MultiLine;

                Setprompt(txt);

                TableRow tr = new TableRow();
                TableCell tc = new TableCell();
                //  tc.BorderStyle = BorderStyle.Solid;
                tc.BorderWidth = Unit.Pixel(10);
                tc.Controls.Add(lbl);
                TableCell tc1 = new TableCell();
                //tc1.BorderStyle = BorderStyle.Solid;
                tc1.BorderWidth = Unit.Pixel(10);
                tc1.Controls.Add(txt);
                tr.Cells.Add(tc);
                tr.Cells.Add(tc1);
                tab.Rows.Add(tr);
                //}
            }

            TableRow tr3 = new TableRow();
            TableCell tc3 = new TableCell();
            //tc3.BorderStyle = BorderStyle.Solid;
            tc3.BorderWidth = Unit.Pixel(10);
            Button button3 = new Button();
            button3.ID = "Submit";
            button3.Text = "Submit School Results";
            button3.Click += schoolResults_Click;
            button3.OnClientClick = "return ValidateForm();";
            //tc3.Controls.Add("");
            tr3.Cells.Add(tc3);
            tr3.Cells.Add(tc3);
            TableCell tc4 = new TableCell();
            tc3.Controls.Add(button3);
            tr3.Cells.Add(tc4);
            tr3.Cells.Add(tc4);

            Button button4 = new Button();
            button4.ID = "Print";
            button4.Text = "Print";
            //button4.Click += register_Click;
            button4.OnClientClick = "return window.print();";
            tc4.Controls.Add(button4);

            tab.Rows.Add(tr3);

            SchoolResultsPanel.Controls.Add(tab);
        }

        private void Setprompt(TextBox txt)
        {
            string onFocusAction = "if (this.value == \"{0}\") {{ this.value = \"\"; this.style.color = \"black\"; }} ";
            string onBlurAction = " if (this.value == \"\") {{ this.value = \"{0}\"; this.style.color = \"gray\"; }} else this.style.color = \"black\";";
            onBlurAction = string.Format(onBlurAction, txt.Text);
            onFocusAction = string.Format(onFocusAction, txt.Text);
            txt.Attributes["onblur"] = onBlurAction;
            txt.Attributes["onfocus"] = onFocusAction;
        }

        public void schoolResults_Click(object sender, EventArgs e)
        {
            SubmitSchoolResults();
        }

        public void SubmitSchoolResults()
        {
            IPMO_PracticeManagementWebApp.Model.SchoolResults schoolResults = new IPMO_PracticeManagementWebApp.Model.SchoolResults();

            schoolResults.PupilUniqueId = Convert.ToInt32(((TextBox)SchoolResultsPanel.FindControl("PupilUniqueId")).Text);
            schoolResults.CITO_group1first_READING = ((TextBox)SchoolResultsPanel.FindControl("CITO group1first READING")).Text;
            schoolResults.DLE_group1first_READING = ((TextBox)SchoolResultsPanel.FindControl("DLE group1first READING")).Text;
            schoolResults.CITO_group1second_READING = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup1second READING")).Text;
            schoolResults.DLE_group1second_READING = ((TextBox)SchoolResultsPanel.FindControl("DLE group1second READING")).Text;
            schoolResults.CITO_group2first_READING = ((TextBox)SchoolResultsPanel.FindControl("CITO group2first READING")).Text;
            schoolResults.DLE_group2first_READING = ((TextBox)SchoolResultsPanel.FindControl("DLE group2first  READING")).Text;
            schoolResults.CITO_group2second_READING = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup2second READING")).Text;
            schoolResults.DLE_group2second_READING = ((TextBox)SchoolResultsPanel.FindControl("DLE group2second READING")).Text;
            schoolResults.CITO_group3first_READING = ((TextBox)SchoolResultsPanel.FindControl("CITO group3first READING")).Text;
            schoolResults.DLE_group3first_READING = ((TextBox)SchoolResultsPanel.FindControl("DLE group3first READING")).Text;
            schoolResults.CITO_group3second_READING = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup3second READING")).Text;
            schoolResults.DLE_group3second_READING = ((TextBox)SchoolResultsPanel.FindControl("DLE group3second READING")).Text;
            schoolResults.CITO_group4first_READING = ((TextBox)SchoolResultsPanel.FindControl("CITO group4first READING")).Text;
            schoolResults.DLE_group4first_READING = ((TextBox)SchoolResultsPanel.FindControl("DLE group4first READING")).Text;
            schoolResults.CITO_group4second_READING = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup4second READING")).Text;
            schoolResults.DLE_group4second_READING = ((TextBox)SchoolResultsPanel.FindControl("DLE group4second READING")).Text;
            schoolResults.CITO_group5first_READING = ((TextBox)SchoolResultsPanel.FindControl("CITO group5first READING")).Text;
            schoolResults.DLE_group5first_READING = ((TextBox)SchoolResultsPanel.FindControl("DLE group5first READING")).Text;
            schoolResults.CITO_group5second_READING = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup5second READING")).Text;
            schoolResults.DLE_group5second_READING = ((TextBox)SchoolResultsPanel.FindControl("DLE group5second READING")).Text;
            //schoolResults.DLE_group5second_READING = ((TextBox)SchoolResultsPanel.FindControl("DLE group5second  ADING")).Text;
            schoolResults.CITO_group6first_READING = ((TextBox)SchoolResultsPanel.FindControl("CITO group6first READING")).Text;
            schoolResults.DLE_group6first_READING = ((TextBox)SchoolResultsPanel.FindControl("DLE group6first READING")).Text;
            schoolResults.CITO_group6second_READING = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup6second READING")).Text;
            schoolResults.DLE_group6second_READING = ((TextBox)SchoolResultsPanel.FindControl("DLE group6second READING")).Text;
            schoolResults.CITO_group7first_READING = ((TextBox)SchoolResultsPanel.FindControl("CITO group7first READING")).Text;
            schoolResults.DLE_group7first_READING = ((TextBox)SchoolResultsPanel.FindControl("DLE group7first READING")).Text;
            schoolResults.CITO_group7second_READING = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup7second READING")).Text;
            schoolResults.DLE_group7second_READING = ((TextBox)SchoolResultsPanel.FindControl("DLE group7second READING")).Text;
            schoolResults.CITO_group8first_READING = ((TextBox)SchoolResultsPanel.FindControl("CITO group8first READING")).Text;
            schoolResults.DLE_group8first_READING = ((TextBox)SchoolResultsPanel.FindControl("DLE group8first READING")).Text;
            schoolResults.CITO_group8second_READING = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup8second READING")).Text;
            schoolResults.DLE_group8second_READING = ((TextBox)SchoolResultsPanel.FindControl("DLE group8second READING")).Text;
            schoolResults.Summary_cito_or_dle_results_READING = ((TextBox)SchoolResultsPanel.FindControl("Summary cito or dle results WRITING")).Text;
            schoolResults.CITO_group1first_WRITING = ((TextBox)SchoolResultsPanel.FindControl("CITO group1first WRITING")).Text;
            schoolResults.DLE_group1first_WRITING = ((TextBox)SchoolResultsPanel.FindControl("DLE group1first WRITING")).Text;
            schoolResults.CITO_group1second_WRITING = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup1second WRITING")).Text;
            schoolResults.DLE_group1second_WRITING = ((TextBox)SchoolResultsPanel.FindControl("DLE group1second WRITING")).Text;
            schoolResults.CITO_group2first_WRITING = ((TextBox)SchoolResultsPanel.FindControl("CITO group2first WRITING")).Text;
            schoolResults.DLE_group2first_WRITING = ((TextBox)SchoolResultsPanel.FindControl("DLE group2first  WRITING")).Text;
            schoolResults.CITO_group2second_WRITING = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup2second WRITING")).Text;
            schoolResults.DLE_group2second_WRITING = ((TextBox)SchoolResultsPanel.FindControl("DLE group2second WRITING")).Text;
            schoolResults.CITO_group3first_WRITING = ((TextBox)SchoolResultsPanel.FindControl("CITO group3first WRITING")).Text;
            schoolResults.DLE_group3first_WRITING = ((TextBox)SchoolResultsPanel.FindControl("DLE group3first WRITING")).Text;
            schoolResults.CITO_group3second_WRITING = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup3second WRITING")).Text;
            schoolResults.DLE_group3second_WRITING = ((TextBox)SchoolResultsPanel.FindControl("DLE group3second WRITING")).Text;
            schoolResults.CITO_group4first_WRITING = ((TextBox)SchoolResultsPanel.FindControl("CITO group4first WRITING")).Text;
            schoolResults.DLE_group4first_WRITING = ((TextBox)SchoolResultsPanel.FindControl("DLE group4first WRITING")).Text;
            schoolResults.CITO_group4second_WRITING = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup4second WRITING")).Text;
            schoolResults.DLE_group4second_WRITING = ((TextBox)SchoolResultsPanel.FindControl("DLE group4second WRITING")).Text;
            schoolResults.CITO_group5first_WRITING = ((TextBox)SchoolResultsPanel.FindControl("CITO group5first WRITING")).Text;
            schoolResults.DLE_group5first_WRITING = ((TextBox)SchoolResultsPanel.FindControl("DLE group5first WRITING")).Text;
            schoolResults.CITO_group5second_WRITING = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup5second WRITING")).Text;
            schoolResults.DLE_group5second_WRITING = ((TextBox)SchoolResultsPanel.FindControl("DLE group5second WRITING")).Text;
            schoolResults.CITO_group6first_WRITING = ((TextBox)SchoolResultsPanel.FindControl("CITO group6first WRITING")).Text;
            schoolResults.DLE_group6first_WRITING = ((TextBox)SchoolResultsPanel.FindControl("DLE group6first WRITING")).Text;
            schoolResults.CITO_group6second_WRITING = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup6second WRITING")).Text;
            schoolResults.DLE_group6second_WRITING = ((TextBox)SchoolResultsPanel.FindControl("DLE group6second WRITING")).Text;
            schoolResults.CITO_group7first_WRITING = ((TextBox)SchoolResultsPanel.FindControl("CITO group7first WRITING")).Text;
            schoolResults.DLE_group7first_WRITING = ((TextBox)SchoolResultsPanel.FindControl("DLE group7first WRITING")).Text;
            schoolResults.CITO_group7second_WRITING = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup7second WRITING")).Text;
            schoolResults.DLE_group7second_WRITING = ((TextBox)SchoolResultsPanel.FindControl("DLE group7second WRITING")).Text;
            schoolResults.CITO_group8first_WRITING = ((TextBox)SchoolResultsPanel.FindControl("CITO group8first WRITING")).Text;
            schoolResults.DLE_group8first_WRITING = ((TextBox)SchoolResultsPanel.FindControl("DLE group8first WRITING")).Text;
            schoolResults.CITO_group8second_WRITING = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup8second WRITING")).Text;
            schoolResults.DLE_group8second_WRITING = ((TextBox)SchoolResultsPanel.FindControl("DLE group8second WRITING")).Text;
            schoolResults.Summary_cito_or_dle_results_WRITING = ((TextBox)SchoolResultsPanel.FindControl("Summary cito or dle results WRITING")).Text;
            schoolResults.CITO_group1first_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("CITO group1first ARITHMETIC")).Text;
            schoolResults.DLE_group1first_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("DLE group1first ARITHMETIC")).Text;
            schoolResults.CITO_group1second_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup1second ARITHMETIC")).Text;
            schoolResults.DLE_group1second_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("DLE group1second ARITHMETIC")).Text;
            schoolResults.CITO_group2first_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("CITO group2first ARITHMETIC")).Text;
            schoolResults.DLE_group2first_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("DLE group2first  ARITHMETIC")).Text;
            schoolResults.CITO_group2second_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup2second ARITHMETIC")).Text;
            schoolResults.DLE_group2second_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("DLE group2second ARITHMETIC")).Text;
            schoolResults.CITO_group3first_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("CITO group3first ARITHMETIC")).Text;
            schoolResults.DLE_group3first_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("DLE group3first ARITHMETIC")).Text;
            schoolResults.CITO_group3second_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup3second ARITHMETIC")).Text;
            schoolResults.DLE_group3second_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("DLE group3second ARITHMETIC")).Text;
            schoolResults.CITO_group4first_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("CITO group4first ARITHMETIC")).Text;
            schoolResults.DLE_group4first_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("DLE group4first ARITHMETIC")).Text;
            schoolResults.CITO_group4second_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup4second ARITHMETIC")).Text;
            schoolResults.DLE_group4second_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("DLE group4second ARITHMETIC")).Text;
            schoolResults.CITO_group5first_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("CITO group5first ARITHMETIC")).Text;
            schoolResults.DLE_group5first_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("DLE group5first ARITHMETIC")).Text;
            schoolResults.CITO_group5second_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup5second ARITHMETIC")).Text;
            schoolResults.DLE_group5second_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("DLE group5second ARITHMETIC")).Text;
            schoolResults.CITO_group6first_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("CITO group6first ARITHMETIC")).Text;
            schoolResults.DLE_group6first_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("DLE group6first ARITHMETIC")).Text;
            schoolResults.CITO_group6second_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup6second ARITHMETIC")).Text;
            schoolResults.DLE_group6second_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("DLE group6second ARITHMETIC")).Text;
            schoolResults.CITO_group7first_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("CITO group7first ARITHMETIC")).Text;
            schoolResults.DLE_group7first_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("DLE group7first ARITHMETIC")).Text;
            schoolResults.CITO_group7second_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup7second ARITHMETIC")).Text;
            schoolResults.DLE_group7second_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("DLE group7second ARITHMETIC")).Text;
            schoolResults.CITO_group8first_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("CITO group8first ARITHMETIC")).Text;
            schoolResults.DLE_group8first_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("DLE group8first ARITHMETIC")).Text;
            schoolResults.CITO_group8second_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("CITOgroup8second ARITHMETIC")).Text;
            schoolResults.DLE_group8second_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("DLE group8second ARITHMETIC")).Text;
            schoolResults.Summary_cito_or_dle_results_ARITHMETIC = ((TextBox)SchoolResultsPanel.FindControl("Summary cito or dle results WRITING")).Text;
            schoolResults.Integrative_summary_writing_reading_arithmetic = ((TextBox)SchoolResultsPanel.FindControl("Integrative summary writing reading arithmetic")).Text;
            schoolResults.School_advice_previous_school = ((TextBox)SchoolResultsPanel.FindControl("School advice previoius school")).Text;
            schoolResults.Any_particulars = ((TextBox)SchoolResultsPanel.FindControl("Any particulars")).Text;

            DatabaseQueryManager dbQueryManager = new DatabaseQueryManager();
            var data = dbQueryManager.QueryToAddUpdateDeleteDataForSchoolResults(schoolResults, "Add");

            Label lbl = new Label();
            lbl.Text = data;

            if (!data.Contains("ERROR"))
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
            ValidationPanelForSchoolResults.Controls.Add(tab);
        }
    }
}