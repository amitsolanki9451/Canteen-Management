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

namespace CMS.TechTeam
{
    public partial class frmUser : System.Web.UI.Page
    {
        #region Initialize the Object of the Class
        static string strId = string.Empty;
        public static string setStringFile = string.Empty;
        public static string strImgPath = string.Empty;
       // int errNumber = int.MinValue;
        BusinessClass objBusinessClass = null;
        ML_UserName objML_UserName = null;
        #endregion

        #region Page Event
        protected void AsyncFileUpload1_UploadedComplete(object sender, AjaxControlToolkit.AsyncFileUploadEventArgs e)
        {

        }

        protected void btnPreview_Click(object sender, EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (!IsPostBack)
                {

                    populateUserTypeList();

                }
            }
            catch (Exception ex)
            {
                Exception exx = ex;
            }
        }


        #endregion

        #region DML Method
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                //errNumber = -1;
                try
                {
                    objBusinessClass = new BusinessLayer.BusinessClass();
                    objML_UserName = new ML_UserName();
                   

                    objML_UserName.UserName = ML_Common.clean(txtUserName.Text);
                    objML_UserName.FirstName = ML_Common.clean(txtFirstName.Text);
                    objML_UserName.LastName = ML_Common.clean(txtLastName.Text);
                    objML_UserName.Email = ML_Common.clean(txtEmail.Text);
                    objML_UserName.Telephone = ML_Common.clean(txtTelephone.Text);
                    objML_UserName.Mobile = ML_Common.clean(txtMobile.Text);
                    objML_UserName.Password = ML_Common.clean(txtPassword.Text);


                    objML_UserName.UserTypeId = ML_Common.string2int32(ML_Common.GetDropDownValue(ddlUserType, true));
                    objML_UserName.UserType = ML_Common.string2string(ML_Common.GetDropDownValue(ddlUserType, false));

                    objML_UserName.ReTryAttempt = 3;// ML_Common.string2int32(ML_Common.clean(txtReTryAttempt.Text));
                    objML_UserName.IsLocked = false;// ML_Common.string2Boolean(ML_Common.clean(txtIsLocked.Text));
                    objML_UserName.LockedDateTime = ML_Common.ToDateTimeSafe(System.DateTime.Now.ToString());
                    objML_UserName.IsActive = ML_Common.clean(ML_Common.bit2int(true).ToString());
                    objML_UserName.IsArchive = ML_Common.clean(ML_Common.bit2int(false).ToString());
                    objML_UserName.CreatedDate = ML_Common.ToDateTimeSafe(System.DateTime.Now.ToString());

                    objML_UserName.ModifiedDate = ML_Common.ToDateTimeSafe(System.DateTime.Now.ToString());


                    if (Session["UserName"] != null && Session["UserNameId"] != null)
                    {
                        objML_UserName.CreatedBy = ML_Common.clean(Session["UserName"]);
                        objML_UserName.ModifiedBy = ML_Common.clean(Session["UserName"]);
                        objML_UserName.CreatedByUserNameId = ML_Common.string2int32(ML_Common.clean(Session["UserNameId"]));
                    }


                    int obhReturn = objBusinessClass.AddUserName(objML_UserName);

                    if (obhReturn == 1)
                    {
                        lblMsg.Visible = true;
                        lblMsg.Text = "Record Saved Successfully";
                        FormFieldsClear();


                    }
                    else if (obhReturn == 2)
                    {
                        lblMsg.Text = "Record Already Exists!";
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


        protected void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                FormFieldsClear();
            }
            catch (Exception ex)
            {
                Exception exx = ex;
            }
        }
        #endregion

        #region Other Method
        public void FormFieldsClear()
        {
            try
            {
                lblMsg.Text = string.Empty;

                ML_Common.SetDropDownValue(ddlUserType, -1);

                txtUserName.Text = string.Empty;
                txtFirstName.Text = string.Empty;
                txtLastName.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtTelephone.Text = string.Empty;
                txtMobile.Text = string.Empty;

                txtPassword.Text = string.Empty;
                txtRePassword.Text = string.Empty;

            }
            catch (Exception ex)
            {
                Exception exx = ex;
            }
        }
        #endregion

        #region populate

        private void populateUserTypeList()
        {
            objBusinessClass = new BusinessLayer.BusinessClass();
            //  DataSet ds = objBusinessClass.GetUserTypeDetail();
            DataTable ds = null;
            // check view state is not null  
            if (ViewState["UserTypeList"] != null)
            {
                ds = (DataTable)ViewState["UserTypeList"];
            }
            else
            {
                ds = objBusinessClass.GetUserTypeDetail();
                ViewState["UserTypeList"] = ds;
            }
            try
            {
                if (ddlUserType.Items.Count > 0)
                {
                    ddlUserType.Items.Clear();
                }

                if (ds.Rows.Count > 0)
                {
                    ddlUserType.DataTextField = "UserType";
                    ddlUserType.DataValueField = "UserTypeId";
                    ddlUserType.DataSource = ds.DefaultView;
                    ddlUserType.DataBind();
                }
                ddlUserType.Items.Insert(0, new ListItem("-- Select --", "-1"));
            }
            catch (Exception ex)
            {
                Exception exx = ex;
            }
        }
        #endregion
    }
}