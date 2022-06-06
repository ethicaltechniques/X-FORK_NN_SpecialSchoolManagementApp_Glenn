using IPMO_PracticeManagementWebApp.DataLayer;
using IPMO_PracticeManagementWebApp.Model;
using IPMO_PracticeManagementWebApp.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IPMO_PracticeManagementWebApp.Views
{
    public partial class PupilSchoolHistory : System.Web.UI.Page
    {
        //List<TableRow> tableRows = new List<TableRow>();

        //A global variable that will hold the current number of Rows
        //We set the values to 1 so that it will generate a default Row when the page loads
        private int numOfRows = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Generate the Rows on Initial Load
            if (!Page.IsPostBack)
            {
                GenerateTable(numOfRows);
            }
        }

        //protected override void OnInit(EventArgs e)
        //{
        //    //base.OnInit(e);
        //    foreach (TableRow row in tableRows)
        //    {
        //        DynamicTable.Rows.Add(row);
        //    }
        //}

        //protected void On_Init(object sender, EventArgs e)
        //{
        //    foreach (TableRow row in tableRows)
        //    {
        //        DynamicTable.Rows.Add(row);
        //    }
        //}
        protected void AddFieldButton_Click(object sender, EventArgs e)
        {
            //UiUtility uUtil = new UiUtility();
            //var result = uUtil.CreateDynamicTextboxAndTextArea(/*"txt_1"*/);
            //PupilSchoolHistoryPlaceHolder.Controls.Add(result);

            if (ViewState["RowsCount"] != null)
            {
                numOfRows = Convert.ToInt32(ViewState["RowsCount"].ToString());
                GenerateTable(numOfRows);
            }

            //ViewState["RowsCount"] = null;

            //TableRow row1 = new TableRow();

            //TableCell tableCell1 = new TableCell();
            //TextBox textBox1 = new TextBox();

            //TableCell tableCell2 = new TableCell();
            //TextBox textBox2 = new TextBox();
            //textBox2.TextMode = TextBoxMode.MultiLine;

            //tableCell1.Controls.Add(textBox1);
            //tableCell2.Controls.Add(textBox2);
            //row1.Controls.Add(tableCell1);
            //row1.Controls.Add(tableCell2);

            //DynamicTable.Rows.Add(row1);

            //tableRows.Add(row1);
            //OnInit(e);
        }

        private void SetPreviousData(int rowsCount, int colsCount)
        {
            Table table = (Table)Page.FindControl("Table1");

            if (table != null)
            {
                for (int i = 0; i < rowsCount; i++)
                {
                    for (int j = 0; j < colsCount; j++)
                    {
                        //Extracting the Dynamic Controls from the Table
                        TextBox tb = (TextBox)table.Rows[i].Cells[j].FindControl("TextBoxRow_" + i + "Col_" + j);

                        //Use Request objects for getting the previous data of the dynamic textbox
                        tb.Text = Request.Form["TextBoxRow_" + i + "Col_" + j];
                    }
                }
            }
        }

        private void GenerateTable(int rowsCount)
        {
            ////Creat the Table and Add it to the Page
            //Table table = new Table();
            //table.ID = "Table1";
            ////Page.Form.Controls.Add(table);
            //PupilSchoolHistoryPlaceHolder.Controls.Add(table);

            //The number of Columns to be generated
            const int colsCount = 2;//You can changed the value of 3 based on you requirements

            // Now iterate through the table and add your controls
            for (int i = 0; i < rowsCount; i++)
            {
                TableRow row = new TableRow();
                for (int j = 0; j < colsCount; j++)
                {
                    if (j == 0)
                    {
                        TableCell cell = new TableCell();
                        TextBox tb = new TextBox();

                        // Set a unique ID for each TextBox added
                        tb.ID = "TextBoxRow_" + i;// + "Col_" + j;

                        // Add the control to the TableCell
                        cell.Controls.Add(tb);

                        // Add the TableCell to the TableRow
                        row.Cells.Add(cell);
                    }
                    else if (j == 1)
                    {
                        TableCell cell = new TableCell();
                        TextBox tb = new TextBox();

                        // Set a unique ID for each TextBox added
                        tb.ID = "TextBoxRow_" + i; //+ "Col_" + j;

                        // Set text area control
                        tb.TextMode = TextBoxMode.MultiLine;

                        // Add the control to the TableCell
                        cell.Controls.Add(tb);

                        // Add the TableCell to the TableRow
                        row.Cells.Add(cell);
                    }
                }

                // And finally, add the TableRow to the Table
                table.Rows.Add(row);
            }

            //Set Previous Data on PostBacks
            SetPreviousData(rowsCount, colsCount);

            //Sore the current Rows Count in ViewState
            rowsCount++;

            ViewState["RowsCount"] = rowsCount;

        }

        protected void PupilSchoolHistoryButton_Click(object sender, EventArgs e)
        {
            List<FieldModel> fieldModelList = new List<FieldModel>();
            List<string> ql = new List<string>();
            List<string> qt = new List<string>();

            int num = Convert.ToInt32(ViewState["RowsCount"]); // your count goes here
            TextBox tb = new TextBox();
            for (int i = 0; i < num; i++)
            {
                tb = (TextBox)table.FindControl("TextBoxRow_" + i.ToString() /*+ "Col_" + j.ToString()*/);
                string value = tb != null ? tb.Text : ""; //You have the data now
            }

            foreach (Control ctrl in PupilSchoolHistoryPlaceHolder.Controls)
            {
                //if (ctrl is Label)
                //{
                //    Label lbl = ((System.Web.UI.WebControls.Label)ctrl);
                //    ql.Add(lbl.Text);
                //}
                if (ctrl is TextBox)
                {
                    TextBox txtbox = ((System.Web.UI.WebControls.TextBox)ctrl);
                    if ((txtbox.TextMode).ToString().Equals("MultiLine"))
                    {
                        ql.Add(txtbox.Text);
                    }
                    else
                    {
                        qt.Add(txtbox.Text);
                    }
                }
            }

            var dic = ql.Zip(qt, (k, v) => new { k, v })
              .ToDictionary(x => x.k, x => x.v);

            foreach (var item in dic)
            {
                FieldModel fm = new FieldModel();
                fm.FieldName = item.Key;
                fm.FieldValue = item.Value;
                fm.StudentUniqueId = PassportNumberTextBox.Text;
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
            ValidationPanelForPupilSchoolHistory.Controls.Add(tab);

            if (ViewState["RowsCount"] != null)
            {
                numOfRows = Convert.ToInt32(ViewState["RowsCount"].ToString());
                GenerateTable(numOfRows);
            }
        }
    }
}