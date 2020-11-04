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
    public partial class frmCategoryGroupMaster : System.Web.UI.Page
    {
        #region Initialize the Object of the Class
        static string strId = string.Empty;
        public static string setStringFile = string.Empty;
        public static string strImgPath = string.Empty;
        int errNumber = int.MinValue;
        BusinessClass objBusinessClass = null;
        ML_CategoryGroupMaster objML_CategoryGroupMaster = null;
        #endregion
        #region Page Event
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Page.Form.Attributes.Add("enctype", "multipart//form-data");
                if (!IsPostBack)
                {
                    Form.Enctype = "multipart//form-data";
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }
        #endregion
        #region DML Method
        protected void btnSave_Click(object sender, EventArgs e)
        {

            if (IsValid)
            {
                errNumber = -1;
                try
                {
                    objBusinessClass = new BusinessLayer.BusinessClass();
                    objML_CategoryGroupMaster = new ML_CategoryGroupMaster();
                    string strAdminLoginName = string.Empty;
                    if (Session["AdminLoginName"] != null)
                    {
                        strAdminLoginName = Session["AdminLoginName"].ToString();
                    }


                   


                   // objML_CategoryGroupMaster.CategoryGroupCode = ML_Common.string2int32(ML_Common.clean(txtCategoryGroupCode.Text));
                    objML_CategoryGroupMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(txtCanteenCode.Text));
                    objML_CategoryGroupMaster.CategoryGroupName = ML_Common.clean(txtCategoryGroupName.Text);
                   // objML_CategoryGroupMaster.CategoryGroupActive = ML_Common.string2int32(ML_Common.clean(txtCategoryGroupActive.Text));


                    // objML_CategoryGroupMaster.IsActive = ML_Common.clean(ML_Common.bit2int(chkIsActive.Checked).ToString()); 
                    // objML_CategoryGroupMaster.IsArchive = ML_Common.clean(ML_Common.bit2int(chkIsArchive.Checked).ToString()); 
                    // objML_CategoryGroupMaster.CreatedDate = ML_Common.ToDateTimeSafe(System.DateTime.Now.ToString()); 
                    // objML_CategoryGroupMaster.CreatedBy = ML_Common.clean(string.Empty); 
                    // objML_CategoryGroupMaster.ModifiedDate = ML_Common.ToDateTimeSafe(System.DateTime.Now.ToString()); 
                    // objML_CategoryGroupMaster.ModifiedBy = ML_Common.clean(string.Empty); 

                    int obhReturn = objBusinessClass.AddCategoryGroupMaster(objML_CategoryGroupMaster);

                    if (obhReturn == 1)
                    {
                        lblMsg.Visible = true;
                        lblMsg.Text = "Record Saved Successfully";
                    }
                    else if (obhReturn == 2)
                    {
                        lblMsg.Text = "Record Already Exists!";
                        lblMsg.Visible = true;
                    }
                }
                catch (SqlException sqlExc)
                {
                    // LogManager.LogManager.WriteErrorLog(sqlExc); 
                    foreach (SqlError error in sqlExc.Errors)
                    {
                        errNumber = error.Number;
                    }
                    if (errNumber == 50000)
                    {
                    }
                    return;
                }
                catch (Exception ex)
                {
                    Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
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
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }
        #endregion
        #region Other Method
        public void FormFieldsClear()
        {
            try
            {
                //txtCategoryGroupCode.Text = string.Empty;
                txtCanteenCode.Text = string.Empty;
                txtCategoryGroupName.Text = string.Empty;
                //txtCategoryGroupActive.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }
        #endregion
        
    }
}