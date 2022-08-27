using System;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace IPMO_PracticeManagementWebApp.Utility
{
    public class UiUtility
    {
        public HtmlGenericControl CreateDynamicTextbox(string _TextBoxId)
        {
            HtmlGenericControl tr = new HtmlGenericControl("tr");
            HtmlGenericControl td1 = new HtmlGenericControl("td");

            Label lbl = new Label();
            lbl.ID = "lbl" + _TextBoxId.Replace(" ", "").ToLower();
            lbl.Text = _TextBoxId;
            td1.Controls.Add(lbl);
            tr.Controls.Add(td1);

            HtmlGenericControl td2 = new HtmlGenericControl("td");
            TextBox txtBox = new TextBox();
            txtBox.ID = _TextBoxId.Replace(" ", "").ToLower();
            td2.Controls.Add(txtBox);
            tr.Controls.Add(td2);

            return tr;
        }
        public HtmlGenericControl CreateDynamicTextboxAndTextArea(/*string _TextBoxId*/)
        {
            HtmlGenericControl tr = new HtmlGenericControl("tr");
            HtmlGenericControl td1 = new HtmlGenericControl("td");

            TextBox lbl = new TextBox();
            //lbl.ID = "lbl" + _TextBoxId.Replace(" ", "").ToLower();
            // lbl.Text = _TextBoxId;
            td1.Controls.Add(lbl);
            tr.Controls.Add(td1);

            HtmlGenericControl td2 = new HtmlGenericControl("td");
            TextBox txtBox = new TextBox();
            //txtBox.ID = _TextBoxId.Replace(" ", "").ToLower();
            txtBox.TextMode = TextBoxMode.MultiLine;
            txtBox.Rows = 2;
            txtBox.Columns = 20;
            td2.Controls.Add(txtBox);
            tr.Controls.Add(td2);

            return tr;
        }

        public HtmlGenericControl CreateDynamicDropdownList(string _ddlId)
        {
            HtmlGenericControl tr = new HtmlGenericControl("tr");
            HtmlGenericControl td1 = new HtmlGenericControl("td");

            Label lbl = new Label();
            lbl.ID = "ddl" + _ddlId.Replace(" ", "").ToLower();
            lbl.Text = _ddlId;
            td1.Controls.Add(lbl);
            tr.Controls.Add(td1);

            HtmlGenericControl td2 = new HtmlGenericControl("td");
            DropDownList ddl = new DropDownList();
            ddl.ID = _ddlId.Replace(" ", "").ToLower();
            ddl.SelectedIndexChanged += ddl_SelectedIndexChanged;
            ddl.AutoPostBack = true;
            ddl.Items.Add(new ListItem("--Select--", "--Select--"));
            ddl.Items.Add(new ListItem("Opt1", "Opt1 Value"));
            ddl.Items.Add(new ListItem("Opt2", "Opt2 Value"));
            td2.Controls.Add(ddl);
            tr.Controls.Add(td2);

            return tr;
        }

        private void ddl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ddl = (DropDownList)sender;
            if (ddl.SelectedIndex > 0)
            {
                //Write your logic
            }
        }
    }
}