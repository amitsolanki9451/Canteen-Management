using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CMS
{

    public partial class frmLabDashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {           

            if (!IsPostBack)
            {
                if (Session["UserFullName"] != null)
                {
                    litAdminName.Text = Convert.ToString(Session["UserFullName"]);
                }
                else if (Session["UserName"] != null)
                {
                    litAdminName.Text = Convert.ToString(Session["UserName"]);
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


       

        protected void lnkbtnHome_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["UserTypeId"] != null)
                {
                    if (ML_Common.string2int(Session["UserTypeId"]) == 3) //Lab
                    {
                        Server.Transfer("~/frmLabDashBoard.aspx", false);
                    }
                    else if (ML_Common.string2int(Session["UserTypeId"]) == 2) //TeachTeam
                    {
                        Server.Transfer("~/frmDashBoard.aspx", false);
                    }
                    else if (ML_Common.string2int(Session["UserTypeId"]) == 1) //Admin
                    {
                        Server.Transfer("~/frmDashBoard.aspx", false);
                    }
                    else
                    {
                        Response.Redirect("~/SignedOff.html");
                    }
                }
                else
                {
                    Response.Redirect("~/SignedOff.html");
                }

            }
            catch (Exception ex)
            {
                Exception exx = ex;
            }
        }
    }
}