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
    public partial class frmCokeSuplier : System.Web.UI.Page
    {
        #region Initialize the Object of the Class
        static string strId = string.Empty;
        public static string setStringFile = string.Empty;
        public static string strImgPath = string.Empty;
       // int errNumber = int.MinValue;
        BusinessClass objBusinessClass = null;
        ML_CokeSupplier objML_CokeSupplier = null;
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                // Page.Form.Attributes.Add("enctype", "multipart//form-data");
                if (!IsPostBack)
                {
                   
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }

        #region DML Method
        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                //errNumber = -1;
                try
                {
                    objBusinessClass = new BusinessLayer.BusinessClass();
                    objML_CokeSupplier = new ML_CokeSupplier();

                    objML_CokeSupplier.CokeSupplier = ML_Common.string2string(txtCokeSupplier.Text);
                    objML_CokeSupplier.Address1 = ML_Common.clean(txtAddress1.Text);
                    objML_CokeSupplier.Address2 = ML_Common.clean(txtAddress2.Text);
                    objML_CokeSupplier.Address3 = ML_Common.clean(txtAddress3.Text);
                    objML_CokeSupplier.CityName = string.Empty;// ML_Common.clean(txtCityName.Text);
                    objML_CokeSupplier.StateName = string.Empty;// ML_Common.clean(txtStateName.Text);
                    objML_CokeSupplier.PinCode = string.Empty;// ML_Common.clean(txtPinCode.Text);
                    objML_CokeSupplier.Title = string.Empty;//ML_Common.clean(txtTitle.Text);
                    objML_CokeSupplier.CountryName = string.Empty;//ML_Common.clean(txtCountryName.Text);
                    objML_CokeSupplier.ContactPerson = ML_Common.clean(txtContactPerson.Text);
                    objML_CokeSupplier.MobNo = ML_Common.clean(txtMobNo.Text);
                    objML_CokeSupplier.WebSite = string.Empty;// ML_Common.clean(txtWebSite.Text);
                    objML_CokeSupplier.Email = ML_Common.clean(txtEmail.Text);
                    objML_CokeSupplier.Remarks = ML_Common.clean(txtRemarks.Text);


                    objML_CokeSupplier.IsActive = ML_Common.clean(ML_Common.bit2int(true).ToString());
                    objML_CokeSupplier.IsArchive = ML_Common.clean(ML_Common.bit2int(false).ToString());
                    objML_CokeSupplier.CreatedDate = ML_Common.ToDateTimeSafe(System.DateTime.Now.ToString());
                    objML_CokeSupplier.CreatedBy = ML_Common.clean(string.Empty);
                    objML_CokeSupplier.ModifiedDate = ML_Common.ToDateTimeSafe(System.DateTime.Now.ToString());
                    objML_CokeSupplier.ModifiedBy = ML_Common.clean(string.Empty);
                    objML_CokeSupplier.CreatedByUserNameId = 1;// ML_Common.string2int(ML_Common.clean(txtCreatedByUserNameId.Text));
                    


                    int obhReturn = objBusinessClass.AddCokeSupplier(objML_CokeSupplier);

                    if (obhReturn == 1)
                    {                       
                        lblMsg.Text = "Record Saved Successfully";
                       FormFieldsClear();
                    }
                    else 
                    {
                        lblMsg.Text = "Record Already Exists!";                       
                        FormFieldsClear();
                    }
                }
                catch (SqlException sqlExc)
                {
                    lblMsg.Text = "Record Already Exists!";
                    SqlException sqlExt = sqlExc;
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
                txtAddress1.Text = string.Empty;
                txtAddress2.Text = string.Empty;
                txtAddress3.Text = string.Empty;
              
                txtContactPerson.Text = string.Empty;
                txtMobNo.Text = string.Empty;              
                txtEmail.Text = string.Empty;
                txtRemarks.Text = string.Empty;
               
                txtCokeSupplier.Text = string.Empty;
                txtRemarks.Text = string.Empty;
               
            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }
        #endregion
        #region populate
        #endregion
    }
}