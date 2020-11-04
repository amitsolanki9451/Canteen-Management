using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using ModelLayer;
using System.Data;

namespace CMS
{
    public partial class Login : System.Web.UI.Page
    {
        #region Initialize the Object of the Class

        BusinessClass objBusinessClass = null;
        ML_UserName objML_UserName = null;


        #endregion

        public string _Id, _Name;
        public static readonly byte[] Key = new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 2, 3, 4, 5, 6 };

        protected void Page_Load(object sender, EventArgs e)
        {

            if (this.Page.User.Identity.IsAuthenticated)
            {
                Response.Redirect(FormsAuthentication.DefaultUrl); 
            }
        }



        protected void btnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                {
                    objBusinessClass = new BusinessLayer.BusinessClass();
                    objML_UserName = new ML_UserName();

                    objML_UserName = objBusinessClass.GetUserDetailsByLoginId(txtUserName.Text.Trim(), txtPassword.Text.Trim());

                    if (objML_UserName != null && objML_UserName.UserNameId > 0 && !string.IsNullOrEmpty(objML_UserName.UserName))
                    {
                        string _ID = objML_UserName.UserNameId.ToString().Trim();
                        _Name = objML_UserName.UserName.ToString().Trim();
                        Session["UserId"] = objML_UserName.Id;
                        Session["UserNameId"] = objML_UserName.UserNameId;
                        Session["UserName"] = objML_UserName.UserName;
                        Session["UserFullName"] = objML_UserName.FirstName + " " + objML_UserName.LastName;
                        Session["UserTypeId"] = objML_UserName.UserTypeId;
                        Session["UserType"] = objML_UserName.UserType;
                        Session["UserEmail"] = objML_UserName.Email;

                        FormsAuthentication.SetAuthCookie(objML_UserName.UserName, true);

                        // string strSession = Session.SessionID.ToString().Trim();


                        //if (!string.IsNullOrEmpty(Request.QueryString["ReturnUrl"]))
                        //{
                        //    Response.Redirect(Request.QueryString["ReturnUrl"]);
                        //}
                        //else
                        //{
                        //    FormsAuthentication.RedirectFromLoginPage(objML_UserName.UserName, true);
                        //}

                        //string ReturnUrl = Convert.ToString(Request.QueryString["url"]);
                        //if (!string.IsNullOrEmpty(ReturnUrl))
                        //{
                        //    Session["userid"] = "TM";
                        //    Response.Redirect(ReturnUrl);
                        //}
                        //else
                        //{
                        //    Response.Redirect("aboutmyself.aspx?msgs=" + "SuccessLogin");
                        //}


                        if (objML_UserName.UserTypeId == 1)
                        {

                            Response.Redirect("~/frmDashBoard.aspx");
                        }
                        else if (objML_UserName.UserTypeId == 2)
                        {
                            Response.Redirect("~/frmDashBoard.aspx");
                        }
                        else if (objML_UserName.UserTypeId == 3)
                        {
                            Response.Redirect("~/frmLabDashBoard.aspx");
                        }
                        else if (objML_UserName.UserTypeId == 5)
                        {
                            Response.Redirect("~/frmCSSDashBoard.aspx");
                            //Session["IsUserType"] = 5;
                            //Session["IsAdminType"] = null;
                            //FormsAuthentication.SetAuthCookie(objML_UserName.UserName, true);

                            //Server.Transfer("~/frmCSSDashBoard.aspx", false);

                        }
                        else if (objML_UserName.UserTypeId == 6)
                        {
                            Response.Redirect("~/frmPotDashBoard.aspx");
                            //Session["IsUserType"] = 6;
                            //Session["IsAdminType"] = null;
                            //FormsAuthentication.SetAuthCookie(objML_UserName.UserName, true);

                            //Server.Transfer("~/frmPotDashBoard.aspx", false);

                        }


                    }
                    {
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "Myscript", "alert('This LoginId does not exist. Please contact adminstrator.');", true);

                    }
                }
            }
           catch (Exception ex)
            {
                Exception exx = ex;
            }
        }



    }
}