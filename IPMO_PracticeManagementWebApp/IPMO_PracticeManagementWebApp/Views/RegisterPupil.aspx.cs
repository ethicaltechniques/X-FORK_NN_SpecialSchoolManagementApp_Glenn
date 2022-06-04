using IPMO_PracticeManagementWebApp.DataLayer;
using IPMO_PracticeManagementWebApp.Model;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace IPMO_PracticeManagementWebApp.Views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DatabaseQueryManager databaseQueryManager = new DatabaseQueryManager();

            var data = databaseQueryManager.QueryToGetDatabaseFieldsForPupil();

            Table tab = new Table();
            tab.ID = "TableForParent1";

            foreach (DataRow row in data.Rows)
            {
                var columnName = row["COLUMN_NAME"].ToString();

                if (columnName.Contains("Parent1"))
                {

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
                }
                else if (columnName.Contains("Parent2"))
                {
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
                }
                else if (columnName.Contains("FamilyGuardian"))
                {
                    Label lbl = new Label();
                    lbl.Text = row["COLUMN_NAME"].ToString();

                    TextBox txt = new TextBox();
                    txt.ID = columnName;
                    txt.TextMode = TextBoxMode.MultiLine;

                    Setprompt(txt);

                    TableRow tr = new TableRow();
                    TableCell tc = new TableCell();
                    // tc.BorderStyle = BorderStyle.Solid;
                    tc.BorderWidth = Unit.Pixel(10);
                    tc.Controls.Add(lbl);
                    TableCell tc1 = new TableCell();
                    // tc1.BorderStyle = BorderStyle.Solid;
                    tc1.BorderWidth = Unit.Pixel(10);
                    tc1.Controls.Add(txt);
                    tr.Cells.Add(tc);
                    tr.Cells.Add(tc1);
                    tab.Rows.Add(tr);
                }
                else if (columnName.Contains("YouthProtector"))
                {
                    Label lbl = new Label();
                    lbl.Text = row["COLUMN_NAME"].ToString();

                    TextBox txt = new TextBox();
                    txt.ID = columnName;
                    txt.TextMode = TextBoxMode.MultiLine;

                    Setprompt(txt);

                    TableRow tr = new TableRow();
                    TableCell tc = new TableCell();
                    //tc.BorderStyle = BorderStyle.Solid;
                    tc.BorderWidth = Unit.Pixel(10);
                    tc.Controls.Add(lbl);
                    TableCell tc1 = new TableCell();
                    //tc1.BorderStyle = BorderStyle.Solid;
                    tc1.BorderWidth = Unit.Pixel(10);
                    tc1.Controls.Add(txt);
                    tr.Cells.Add(tc);
                    tr.Cells.Add(tc1);
                    tab.Rows.Add(tr);
                }
                else if (columnName.Contains("Others"))
                {
                    Label lbl = new Label();
                    lbl.Text = row["COLUMN_NAME"].ToString();

                    TextBox txt = new TextBox();
                    txt.ID = columnName;
                    txt.TextMode = TextBoxMode.MultiLine;

                    Setprompt(txt);

                    TableRow tr = new TableRow();
                    TableCell tc = new TableCell();
                    // tc.BorderStyle = BorderStyle.Solid;
                    tc.BorderWidth = Unit.Pixel(10);
                    tc.Controls.Add(lbl);
                    TableCell tc1 = new TableCell();
                    //tc1.BorderStyle = BorderStyle.Solid;
                    tc1.BorderWidth = Unit.Pixel(10);
                    tc1.Controls.Add(txt);
                    tr.Cells.Add(tc);
                    tr.Cells.Add(tc1);
                    tab.Rows.Add(tr);
                }
                else
                {
                    Label lbl = new Label();
                    lbl.Text = row["COLUMN_NAME"].ToString();

                    TextBox txt = new TextBox();
                    txt.ID = columnName;
                    txt.TextMode = TextBoxMode.MultiLine;

                    Setprompt(txt);

                    TableRow tr = new TableRow();
                    TableCell tc = new TableCell();
                    // tc.BorderStyle = BorderStyle.Solid;
                    tc.BorderWidth = Unit.Pixel(10);
                    tc.Controls.Add(lbl);
                    TableCell tc1 = new TableCell();
                    // tc1.BorderStyle = BorderStyle.Solid;
                    tc1.BorderWidth = Unit.Pixel(10);
                    tc1.Controls.Add(txt);
                    tr.Cells.Add(tc);
                    tr.Cells.Add(tc1);
                    tab.Rows.Add(tr);
                }
            }

            TableRow tr3 = new TableRow();
            TableCell tc3 = new TableCell();
            //tc3.BorderStyle = BorderStyle.Solid;
            tc3.BorderWidth = Unit.Pixel(10);
            Button button3 = new Button();
            button3.ID = "Register";
            button3.Text = "Register";
            button3.Click += register_Click;
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

            Panel1.Controls.Add(tab);
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

        protected void register_Click(object sender, EventArgs e)
        {
            Register();
        }

        public void Register()
        {
            PupilInformation pupilInfo = new PupilInformation();
            pupilInfo.FirstName = ((TextBox)Panel1.FindControl("FirstName")).Text;
            pupilInfo.SecondName = ((TextBox)Panel1.FindControl("SecondName")).Text; ;
            pupilInfo.Surname = ((TextBox)Panel1.FindControl("Surname")).Text; ;
            pupilInfo.AddressStreet = ((TextBox)Panel1.FindControl("AddressStreet")).Text; ;
            pupilInfo.HouseNumber = ((TextBox)Panel1.FindControl("HouseNumber")).Text; ;
            pupilInfo.Zip = ((TextBox)Panel1.FindControl("Zip")).Text; ;
            pupilInfo.City = ((TextBox)Panel1.FindControl("City")).Text; ;
            pupilInfo.Mobile = ((TextBox)Panel1.FindControl("Mobile")).Text; ;
            pupilInfo.Email = ((TextBox)Panel1.FindControl("Id")).Text; ;
            pupilInfo.Id = ((TextBox)Panel1.FindControl("FirstName")).Text; ;
            pupilInfo.PassportNumber = ((TextBox)Panel1.FindControl("PassportNumber")).Text; ;
            pupilInfo.FirstNameParent1 = ((TextBox)Panel1.FindControl("FirstNameParent1")).Text; ;
            pupilInfo.SurnameParent1 = ((TextBox)Panel1.FindControl("SurnameParent1")).Text; ;
            pupilInfo.AddressStreetParent1 = ((TextBox)Panel1.FindControl("AddressStreetParent1")).Text; ;
            pupilInfo.HouseNumberParent1 = ((TextBox)Panel1.FindControl("HouseNumberParent1")).Text; ;
            pupilInfo.ZipParent1 = ((TextBox)Panel1.FindControl("ZipParent1")).Text; ;
            pupilInfo.CityParent1 = ((TextBox)Panel1.FindControl("CityParent1")).Text; ;
            pupilInfo.MobileParent1 = ((TextBox)Panel1.FindControl("MobileParent1")).Text; ;
            pupilInfo.LandlineParent1 = ((TextBox)Panel1.FindControl("LandlineParent1")).Text; ;
            pupilInfo.IdParent1 = ((TextBox)Panel1.FindControl("IdParent1")).Text; ;
            pupilInfo.EmailParent1 = ((TextBox)Panel1.FindControl("EmailParent1")).Text; ;
            pupilInfo.PassportNumberParent1 = ((TextBox)Panel1.FindControl("PassportNumberParent1")).Text; ;
            pupilInfo.ParentalAuthorityParent1 = ((TextBox)Panel1.FindControl("ParentalAuthorityParent1")).Text; ;
            pupilInfo.FirstNameParent2 = ((TextBox)Panel1.FindControl("FirstNameParent2")).Text; ;
            pupilInfo.SurnameParent2 = ((TextBox)Panel1.FindControl("SurnameParent2")).Text; ;
            pupilInfo.AddressStreetParent2 = ((TextBox)Panel1.FindControl("AddressStreetParent2")).Text; ;
            pupilInfo.HouseNumberParent2 = ((TextBox)Panel1.FindControl("HouseNumberParent2")).Text; ;
            pupilInfo.ZipParent2 = ((TextBox)Panel1.FindControl("ZipParent2")).Text; ;
            pupilInfo.CityParent2 = ((TextBox)Panel1.FindControl("CityParent2")).Text; ;
            pupilInfo.MobileParent2 = ((TextBox)Panel1.FindControl("MobileParent2")).Text; ;
            pupilInfo.LandlineParent2 = ((TextBox)Panel1.FindControl("LandlineParent2")).Text; ;
            pupilInfo.IdParent2 = ((TextBox)Panel1.FindControl("IdParent2")).Text; ;
            pupilInfo.EmailParent2 = ((TextBox)Panel1.FindControl("EmailParent2")).Text; ;
            pupilInfo.PassportNumberParent2 = ((TextBox)Panel1.FindControl("PassportNumberParent2")).Text; ;
            pupilInfo.ParentalAuthorityParent2 = ((TextBox)Panel1.FindControl("ParentalAuthorityParent2")).Text;
            pupilInfo.FamilyGuardian = ((TextBox)Panel1.FindControl("FamilyGuardian")).Text; ;
            pupilInfo.NameFamilyGuardian = ((TextBox)Panel1.FindControl("NameFamilyGuardian")).Text; ;
            pupilInfo.OrganizationFamilyGuardian = ((TextBox)Panel1.FindControl("OrganizationFamilyGuardian")).Text; ;
            pupilInfo.EmailFamilyGuardian = ((TextBox)Panel1.FindControl("EmailFamilyGuardian")).Text; ;
            pupilInfo.MobilePhoneFamilyGuardian = ((TextBox)Panel1.FindControl("MobilePhoneFamilyGuardian")).Text; ;
            pupilInfo.YouthProtector = ((TextBox)Panel1.FindControl("YouthProtector")).Text; ;
            pupilInfo.NameYouthProtector = ((TextBox)Panel1.FindControl("NameYouthProtector")).Text; ;
            pupilInfo.OrganizationYouthProtector = ((TextBox)Panel1.FindControl("OrganizationYouthProtector")).Text; ;
            pupilInfo.EmailAddressYouthProtector = ((TextBox)Panel1.FindControl("EmailAddressYouthProtector")).Text; ;
            pupilInfo.MobileYouthProtector = ((TextBox)Panel1.FindControl("MobileYouthProtector")).Text; ;
            pupilInfo.ImportantInformationOthers = ((TextBox)Panel1.FindControl("ImportantInformationOthers")).Text; ;

            //DatabaseManager dbManager = new DatabaseManager();
            //var data = dbManager.AddData(pupilInfo);

            DatabaseQueryManager dbQueryManager = new DatabaseQueryManager();
            var data = dbQueryManager.QueryToAddUpdateDeleteDataForPupil(pupilInfo, "Add");

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
            ValidationPanel2.Controls.Add(tab);
        }
    }
}