using IPMO_PracticeManagementWebApp.DataLayer;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace IPMO_PracticeManagementWebApp.Views
{
    public partial class RiskFactors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseQueryManager dbQueryManager = new DatabaseQueryManager();
            var data = dbQueryManager.QueryToGetDatabaseFieldsForRiskFactors();

            Table tab = new Table();
            tab.ID = "TableForRiskFactors";

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
            button3.Text = "Submit Risk Factor";
            button3.Click += riskFactor_Click;
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

            RiskFactorPanel.Controls.Add(tab);
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

        public void riskFactor_Click(object sender, EventArgs e)
        {
            SubmitRiskFactors();
        }

        public void SubmitRiskFactors()
        {
            IPMO_PracticeManagementWebApp.Model.RiskFactors riskFactors = new IPMO_PracticeManagementWebApp.Model.RiskFactors();

            riskFactors.PupilUniqueId = Convert.ToInt32(((TextBox)RiskFactorPanel.FindControl("PupilUniqueId")).Text);
            riskFactors.Cognitive_strength_1 = ((TextBox)RiskFactorPanel.FindControl("Cognitive strength 1")).Text;
            riskFactors.Cognitive_strength_2 = ((TextBox)RiskFactorPanel.FindControl("Cognitive strength 2")).Text;
            riskFactors.Cognitive_strength_3 = ((TextBox)RiskFactorPanel.FindControl("Cognitive strength 3")).Text;
            riskFactors.Cognitive_strenght_4 = ((TextBox)RiskFactorPanel.FindControl("Cognitive strenght 4")).Text;
            riskFactors.Cognitive_weakness_1 = ((TextBox)RiskFactorPanel.FindControl("Cognitive weakness 1")).Text;
            riskFactors.Cognitive_weakness_2 = ((TextBox)RiskFactorPanel.FindControl("Cognitive weakness 2")).Text;
            riskFactors.Cognitive_weakness_3 = ((TextBox)RiskFactorPanel.FindControl("Cognitive weakness 3")).Text;
            riskFactors.Cognitive_weakness_4 = ((TextBox)RiskFactorPanel.FindControl("Cognitive weakness 4")).Text;
            riskFactors.Positive_learning_attitude_1 = ((TextBox)RiskFactorPanel.FindControl("Positive learning attitude 1")).Text;
            riskFactors.Positive_learning_attitude_2 = ((TextBox)RiskFactorPanel.FindControl("Positive learning attitude 2")).Text;
            riskFactors.Negative_learning_attitude_1 = ((TextBox)RiskFactorPanel.FindControl("Negative learning attitude 1")).Text;
            riskFactors.Negative_learning_attitude_2 = ((TextBox)RiskFactorPanel.FindControl("Negative learning attitude 2")).Text;
            riskFactors.Social_strength_1 = ((TextBox)RiskFactorPanel.FindControl("Social strength 1")).Text;
            riskFactors.Socia_strenght_2 = ((TextBox)RiskFactorPanel.FindControl("Socia strenght 2")).Text;
            riskFactors.Social_weakness_1 = ((TextBox)RiskFactorPanel.FindControl("Social weakness 1")).Text;
            riskFactors.Social_weakness_2 = ((TextBox)RiskFactorPanel.FindControl("Social weakness 2")).Text;
            riskFactors.Communicatie_strength_1 = ((TextBox)RiskFactorPanel.FindControl("Communicatie strength 1")).Text;
            riskFactors.Communicatie_strength_2 = ((TextBox)RiskFactorPanel.FindControl("Communicatie strength 2")).Text;
            riskFactors.Communicative_weakness_1 = ((TextBox)RiskFactorPanel.FindControl("Communicative weakness 1")).Text;
            riskFactors.Communicative_weakness_2 = ((TextBox)RiskFactorPanel.FindControl("Communicative weakness 2")).Text;
            riskFactors.Behavioral_strengths_1 = ((TextBox)RiskFactorPanel.FindControl("Behavioral strengths 1")).Text;
            riskFactors.Behavioral_strength_2 = ((TextBox)RiskFactorPanel.FindControl("Behavioral strength 2")).Text;
            riskFactors.Behavioral_strengths_3 = ((TextBox)RiskFactorPanel.FindControl("Behavioral strengths 3")).Text;
            riskFactors.Behavioral_weakness_1 = ((TextBox)RiskFactorPanel.FindControl("Behavioral weakness 1")).Text;
            riskFactors.Behavioral_weakness_2 = ((TextBox)RiskFactorPanel.FindControl("Behaviora weakness 2")).Text;
            riskFactors.Behavioral_weakness_3 = ((TextBox)RiskFactorPanel.FindControl("Behavioral weakness 3")).Text;
            riskFactors.Emotional_strength_1 = ((TextBox)RiskFactorPanel.FindControl("Emotional strength 1")).Text;
            riskFactors.Emotional_strength_2 = ((TextBox)RiskFactorPanel.FindControl("Emotional strength 2")).Text;
            riskFactors.Emotional_strength_3 = ((TextBox)RiskFactorPanel.FindControl("Emotional strength 3")).Text;
            riskFactors.Emotional_weakness_1 = ((TextBox)RiskFactorPanel.FindControl("Emotional weakness 1")).Text;
            riskFactors.Emotional_weakness_2 = ((TextBox)RiskFactorPanel.FindControl("Emotional weakness 2")).Text;
            riskFactors.Emotional_weakness_3 = ((TextBox)RiskFactorPanel.FindControl("Emotional weakness 3")).Text;
            riskFactors.Moral_strength_1 = ((TextBox)RiskFactorPanel.FindControl("Moral strength 1")).Text;
            riskFactors.Moral_strength_2 = ((TextBox)RiskFactorPanel.FindControl("Moral strength 2")).Text;
            riskFactors.Moral_risk_factor_1 = ((TextBox)RiskFactorPanel.FindControl("Moral risk factor 1")).Text;
            riskFactors.Moral_risk_factor_2 = ((TextBox)RiskFactorPanel.FindControl("Moral risk factor 2")).Text;
            riskFactors.Motor_or_sportive_strength_1 = ((TextBox)RiskFactorPanel.FindControl("Motor or sportive strength 1")).Text;
            riskFactors.Mottor_or_sportive_strength_2 = ((TextBox)RiskFactorPanel.FindControl("Mottor or sportive strength 2")).Text;
            riskFactors.Motor_or_sportive_weakness_1 = ((TextBox)RiskFactorPanel.FindControl("Motor or sportive weakness 1")).Text;
            riskFactors.Motor_or_sportive_weakness_2 = ((TextBox)RiskFactorPanel.FindControl("Motor or sportive weakness 2")).Text;
            riskFactors.CREATIVE_or_ART_STRENGTHS = ((TextBox)RiskFactorPanel.FindControl("CREATIVE or ART STRENGTHS")).Text;
            riskFactors.CREATIVE_or_ART_WEAKNESSES = ((TextBox)RiskFactorPanel.FindControl("CREATIVE or ART WEAKNESSES")).Text;
            riskFactors.LEISURE_ACTVITIY_PRESENT = ((TextBox)RiskFactorPanel.FindControl("LEISURE ACTVITIY PRESENT")).Text;
            riskFactors.LEISURE_ACTIVITY_NOT_PRESENT = ((TextBox)RiskFactorPanel.FindControl("LEISURE ACTIVITY NOT PRESENT")).Text;
            riskFactors.DAILY_STRUCTURE_PRESENT = ((TextBox)RiskFactorPanel.FindControl("DAILY STRUCTURE PRESENT")).Text;
            riskFactors.DAILY_STRUCTURE_NOT_PRESENT = ((TextBox)RiskFactorPanel.FindControl("DAILY STRUCTURE NOT PRESENT")).Text;
            riskFactors.PROTECTIVE_FAMILY_FACTORS = ((TextBox)RiskFactorPanel.FindControl("PROTECTIVE FAMILY FACTORS")).Text;
            riskFactors.RISK_FAMILY_FACTORS = ((TextBox)RiskFactorPanel.FindControl("RISK FAMILY FACTORS")).Text;
            riskFactors.Integrative_summary_of_the_pupil = ((TextBox)RiskFactorPanel.FindControl("Integrative summary of the pupil")).Text;


            DatabaseQueryManager dbQueryManager = new DatabaseQueryManager();
            var data = dbQueryManager.QueryToAddUpdateDeleteDataForRiskFactors(riskFactors, "Add");

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
            ValidationPanelForRiskFactor.Controls.Add(tab);
        }
    }
}