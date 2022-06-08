using IPMO_PracticeManagementWebApp.DataLayer;
using IPMO_PracticeManagementWebApp.Model;
using IPMO_PracticeManagementWebApp.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IPMO_PracticeManagementWebApp.Views
{
    public partial class GoalMeans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static string SaveData(string allData)
        {
            var serializeData = JsonConvert.DeserializeObject<List<FieldModel>>(allData);
            var fieldList = serializeData.ToList<FieldModel>();
            DatabaseQueryManager dqm = new DatabaseQueryManager();
            var status = dqm.QueryToAddUpdateDeleteDataForField(fieldList, "Add");

            return status;
        }
    }
}