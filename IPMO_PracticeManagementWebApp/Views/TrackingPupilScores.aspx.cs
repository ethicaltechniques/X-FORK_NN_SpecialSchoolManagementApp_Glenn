using IPMO_PracticeManagementWebApp.DataLayer;
using IPMO_PracticeManagementWebApp.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace IPMO_PracticeManagementWebApp.Views
{
    public partial class TrackingPupilScores : System.Web.UI.Page
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

        [WebMethod]
        public static List<FieldModel> GetData(string allData)
        {
            var serializeData = JsonConvert.DeserializeObject<List<FieldModel>>(allData);
            var fieldList = serializeData.ToList<FieldModel>();

            List<FieldModel> fmList = new List<FieldModel>();

            DatabaseQueryManager dqm = new DatabaseQueryManager();
            var passportNumber = fieldList.FirstOrDefault().FieldName == "Passport Number" ? fieldList.FirstOrDefault().FieldValue : string.Empty;
            fmList = dqm.QueryToGetDataForField(passportNumber, "Tracking Pupil Scores");

            return fmList;
        }

        [WebMethod]
        public static string UpdateData(string allData)
        {
            var serializeData = JsonConvert.DeserializeObject<List<FieldModel>>(allData);
            var fieldList = serializeData.ToList<FieldModel>();
            DatabaseQueryManager dqm = new DatabaseQueryManager();
            var status = dqm.QueryToAddUpdateDeleteDataForField(fieldList, "Update");

            return status;
        }

        [WebMethod]
        public static List<FieldModel> GetSessionData(string allData)
        {
            return (List<FieldModel>)HttpContext.Current.Session["fmList"];
        }

    }
}