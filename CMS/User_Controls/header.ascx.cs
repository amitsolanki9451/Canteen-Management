using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MakingCenterLine.User_Controls
{
    public partial class header : System.Web.UI.UserControl
    {
        #region[Private variables]
        private string _user_name = string.Empty;
        private bool _is_pre_login = false;
        #endregion;

        #region[Properties]
        public bool IsPreLogin
        {
            get
            {
                return _is_pre_login;
            }
            set
            {
                _is_pre_login = value;
            }
        }
        #endregion;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Convert.ToString(Session["UserName"])) && !IsPreLogin)
            {
                _user_name = Convert.ToString(Session["UserName"]);
                spnUsername.InnerHtml = "Welcome " + _user_name + "!";
            }
        }
    }
}