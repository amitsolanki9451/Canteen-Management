using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModelLayer;
using BusinessLayer;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Configuration;

namespace CMS.LabOnly
{
    public partial class frmChangePassword : System.Web.UI.Page
    {
        #region Initialize the Object of the Class
        static string strId = string.Empty;
        public static string setStringFile = string.Empty;
        public static string strImgPath = string.Empty;
       // int errNumber = int.MinValue;
        BusinessClass objBusinessClass = null;
        ML_UserName objML_UserName = null;
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                try
                {


                    //if (Session["IsAdminType"] == null || Session["UserNameId"] == null || Session["UserName"] == null || ML_Common.string2int(Session["IsAdminType"]) != 1)
                    //{

                    //    Response.Redirect("Login.aspx", false);
                    //}
                    //txtUserName.Text = Session["UserEmail"].ToString();
                    txtUserName.Text = Session["UserName"].ToString();
                }
                catch (Exception ex)
                {
                    Exception exc = ex;
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;
            }
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                //errNumber = -1;
                try
                {
                    objBusinessClass = new BusinessLayer.BusinessClass();
                    objML_UserName = new ML_UserName();
                   


                    string UserName = ML_Common.clean(txtUserName.Text);
                    string oldPassword = ML_Common.clean(txtOldPassword.Text);
                    string newPassword = ML_Common.clean(txtNewPassword.Text);

                    int obhReturn = objBusinessClass.UpdatePassword(UserName, oldPassword, newPassword);

                    if (obhReturn == 1)
                    {
                        lblMsg.Visible = true;
                        lblMsg.Text = "Password changed Successfully";
                    }
                    else if (obhReturn == 2)
                    {
                        lblMsg.Text = "User Name/Password is not Correct!";
                        lblMsg.Visible = true;
                    }
                    else
                    {
                        lblMsg.Text = "There are some issue while Updating, Please enter correct old Password!";
                        lblMsg.Visible = true;
                    }
                }
                catch (SqlException sqlExc)
                {
                    SqlException sqlExt = sqlExc;
                    return;

                }
                catch (Exception ex)
                {
                    Exception exx = ex;
                }
            }
        }
    }
}