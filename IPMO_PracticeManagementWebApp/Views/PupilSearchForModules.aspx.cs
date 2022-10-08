using IPMO_PracticeManagementWebApp.DataLayer;
using IPMO_PracticeManagementWebApp.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace IPMO_PracticeManagementWebApp.Views
{
    public partial class PupilSearchForModules : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static List<PupilInformation> SearchData(string allData)
        {
            var serializeData = JsonConvert.DeserializeObject<List<SearchModel>>(allData);
            var fieldList = serializeData.ToList<SearchModel>();

            List<FieldModel> fmList = new List<FieldModel>();

            DatabaseQueryManager dqm = new DatabaseQueryManager();
            var searchTerm = fieldList.FirstOrDefault().SearchValue.Trim();

            PupilInformation pInfo = new PupilInformation();
            List<PupilInformation> pInfoList = new List<PupilInformation>();

            if (!searchTerm.Equals(String.Empty))
            {
                //Change 1
                var formName = fieldList.FirstOrDefault().FormName.Trim();
                fmList = dqm.QueryToSearchData(searchTerm, formName /*"General Pupil Info"*/);

                var fmGroup = fmList.GroupBy(x => x.StudentUniqueId).ToList();

                foreach (var val in fmGroup)
                {

                    foreach (var res in val)
                    {
                        if (res.FieldName.Equals("First Name"))
                        {
                            pInfo.FirstName = res.FieldValue;
                            pInfo.PassportNumber = res.StudentUniqueId;
                        }
                        //if (res.FieldName.Equals("Passport Number"))
                        //{
                        //    pInfo.PassportNumber = res.FieldValue;
                        //}
                        //if (res.FieldName.Equals("Mobile"))
                        //{
                        //    pInfo.Mobile = res.FieldValue;
                        //}
                        //if (res.FieldName.Equals("Email"))
                        //{
                        //    pInfo.Email = res.FieldValue;
                        //}
                    }

                    pInfoList.Add(pInfo);
                }
            }

            return pInfoList;
        }

        [WebMethod]
        public static List<FieldModel> SearchFormData(string allData)
        {
            var serializeData = JsonConvert.DeserializeObject<List<SearchModel>>(allData);
            var fieldList = serializeData.ToList<SearchModel>();

            List<FieldModel> fmList = new List<FieldModel>();

            DatabaseQueryManager dqm = new DatabaseQueryManager();
            var searchTerm = fieldList.FirstOrDefault().SearchValue.Trim();
            var formName = fieldList.FirstOrDefault().FormName.Trim();

            PupilInformation pInfo = new PupilInformation();
            List<PupilInformation> pInfoList = new List<PupilInformation>();

            if (!searchTerm.Equals(String.Empty))
            {
                fmList = dqm.QueryToSearchFormData(searchTerm, formName);

                HttpContext.Current.Session["fmList"] = fmList;
            }

            return fmList;
        }
    }
}