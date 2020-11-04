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
    public partial class frmPotDashBoard : System.Web.UI.Page
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

           
        }




        protected void lnkbtnHome_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["UserTypeId"] != null)
                {
                    if (ML_Common.string2int(Session["UserTypeId"]) == 3) //Administrator
                    {
                        Response.Redirect("~/frmLabDashBoard.aspx", false);
                    }
                    else if (ML_Common.string2int(Session["UserTypeId"]) == 2) //Admin
                    {
                        Response.Redirect("~/frmDashBoard.aspx", false);
                    }
                    else if (ML_Common.string2int(Session["UserTypeId"]) == 2) //User
                    {
                        Response.Redirect("frmLabDashBoard.aspx", false);
                    }
                    else if (ML_Common.string2int(Session["UserTypeId"]) == 5) //User
                    {
                        Response.Redirect("frmCSSDashBoard.aspx", false);
                    }
                    else if (ML_Common.string2int(Session["UserTypeId"]) == 6) //User
                    {
                        Response.Redirect("frmPotDashBoard.aspx", false);
                    }

                    else
                    {
                        
                        Response.Redirect("~/frmDashBoard.aspx", false);
                    }
                }
                else
                {
                    
                    Response.Redirect("~/frmDashBoard.aspx", false);
                }

            }
           catch (Exception ex)
            {
                Exception ext = ex;
            }
        }
    }
}