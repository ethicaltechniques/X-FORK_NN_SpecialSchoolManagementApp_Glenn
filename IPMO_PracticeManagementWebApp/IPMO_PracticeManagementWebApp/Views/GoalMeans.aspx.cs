using IPMO_PracticeManagementWebApp.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IPMO_PracticeManagementWebApp.Views
{
    public partial class GoalMeans : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FieldsButton_Click(object sender, EventArgs e)
        {
            UiUtility uUtil = new UiUtility();
            var result = uUtil.CreateDynamicTextbox("txt_1");
            GoalMeansPlaceHolder.Controls.Add(result);
        }
    }
}