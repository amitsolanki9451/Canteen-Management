using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HindalcoCarbon.TechTeam
{
    public partial class LabAdminSite : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserFullName"] != null)
                {
                    FirstName.Text = Session["UserFullName"].ToString();
                }
            }
        }
        protected void lnkbtnLogout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            HttpCookie cooke1 = new HttpCookie(FormsAuthentication.FormsCookieName, string.Empty);
            cooke1.Expires = DateTime.Now.AddSeconds(-1);
            Response.Redirect("frmlogin1.aspx", false);
            // Response.Redirect(FormsAuthentication.GetRedirectUrl(Session["UserName"].ToString(), false));
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            HttpCookie cooke1 = new HttpCookie(FormsAuthentication.FormsCookieName, string.Empty);
            cooke1.Expires = DateTime.Now.AddSeconds(-1);
            Response.Redirect("../frmlogin1.aspx", false);
        }

    }
}