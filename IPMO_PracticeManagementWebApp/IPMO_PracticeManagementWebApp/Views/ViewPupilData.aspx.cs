using IPMO_PracticeManagementWebApp.DataLayer;
using System;
using System.Data;
using System.Text;
using System.Web.UI.WebControls;

namespace IPMO_PracticeManagementWebApp.Views
{
    public partial class ViewPupilData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                RetrieveAllPupilData();
            }
        }
        private void RetrieveAllPupilData()
        {
            DatabaseQueryManager databaseQueryManager = new DatabaseQueryManager();
            //Populating a DataTable from database.
            DataTable dtPupilInfo = databaseQueryManager.QueryToRetrieveDataFromPupilRegistration();
            PopulateDataFromDataTable(dtPupilInfo, "Pupil Information");

            DataTable dtSchoolResults = databaseQueryManager.QueryToRetrieveDataFromSchoolResults();
            PopulateDataFromDataTable(dtSchoolResults, "School Results");

            DataTable dtRiskFactors = databaseQueryManager.QueryToRetrieveDataFromRiskFactors();
            PopulateDataFromDataTable(dtRiskFactors, "Risk Factors");
        }
        private void PopulateDataFromDataTable(DataTable dt, string section)
        {
            //Building an HTML string.
            StringBuilder html = new StringBuilder();

            //Table start.
            html.Append("<table border = '1'>");

            //Building the Header row.
            html.Append("<tr>");
            foreach (DataColumn column in dt.Columns)
            {
                if (!column.ColumnName.Equals("UniqueId"))
                {
                    html.Append("<th>");
                    html.Append(column.ColumnName);
                    html.Append("</th>");
                }
            }
            html.Append("</tr>");

            //Building the Data rows.
            foreach (DataRow row in dt.Rows)
            {
                html.Append("<tr>");
                foreach (DataColumn column in dt.Columns)
                {
                    if (!column.ColumnName.Equals("UniqueId"))
                    {
                        html.Append("<td>");
                        html.Append(row[column.ColumnName]);
                        html.Append("</td>");
                    }
                }
                html.Append("</tr>");
            }

            //Table end.
            html.Append("</table>");

            if (section.Equals("Pupil Information"))
            {
                //Append the HTML string to Placeholder.
                PlaceHolderForPupilRegistration.Controls.Add(new Literal { Text = html.ToString() });
            }
            else if (section.Equals("School Results"))
            {
                //Append the HTML string to Placeholder.
                PlaceHolderForSchoolResults.Controls.Add(new Literal { Text = html.ToString() });
            }
            else if (section.Equals("Risk Factors"))
            {
                //Append the HTML string to Placeholder.
                PlaceHolderForRiskFactors.Controls.Add(new Literal { Text = html.ToString() });
            }
        }
    }
}