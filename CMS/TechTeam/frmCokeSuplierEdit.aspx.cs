#region Edit Page Class
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
using System.Web.Security;
namespace CMS.TechTeam
{
    public partial class frmCokeSuplierEdit : System.Web.UI.Page
    {
        #region Initialize the Object of the Class
        static string strCokeSupplierId = string.Empty;
        BusinessClass objBusinessClass = null;
        ML_CokeSupplier objML_CokeSupplier = null;
        public static Guid strCokeSupplierGuid = Guid.Empty;
        public static string setStringFile = string.Empty;
        public static string strImgPath = string.Empty;
       // int errNumber = int.MinValue;
        #endregion

        #region Page Event
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Page.Form.Attributes.Add("enctype", "multipart/form-data"); 
                 if (!this.Page.User.Identity.IsAuthenticated)
                {
                    FormsAuthentication.RedirectToLoginPage();
                }
                if (!IsPostBack)
                {
                    // Form.Enctype = "multipart/form-data";                   
                    populateCokeSupplierList();
                    FillGrid();
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }
        #endregion

        #region Other Methods
        private DataTable BindGridView()
        {
            DataTable dtCokeSupplier = new DataTable("DtGrd");
            try
            {
                objBusinessClass = new BusinessClass();
                dtCokeSupplier = objBusinessClass.GetCokeSupplierDetail();
                
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
            return dtCokeSupplier;
        }

        private DataTable BindGridViewBySearch(ML_CokeSupplier objML_CokeSupplier)
        {
            DataTable dtCokeSupplier = new DataTable("GridSearch");
            try
            {
                objBusinessClass = new BusinessLayer.BusinessClass();
                dtCokeSupplier = objBusinessClass.GetCokeSupplierBySeacrh(objML_CokeSupplier);
               
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
            return dtCokeSupplier;
        }



        private int DeleteGridRowItem(int lngId)
        {
            int returnObj = 0;
            try
            {
                objBusinessClass = new BusinessLayer.BusinessClass();
                returnObj = objBusinessClass.DeleteCokeSupplier(lngId);
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
            return returnObj;
        }

        private void FillGrid()
        {
           
            try
            {
                DataTable DtList = null;
                if (ViewState["grdCokeSupplier"] == null)
                {

                ML_CokeSupplier objML_CokeSupplierh = new ML_CokeSupplier();
                objML_CokeSupplierh.CokeSupplier = ML_Common.clean(txtCokeSupplierSearch.Text);
                objBusinessClass = new BusinessLayer.BusinessClass();
                DtList = objBusinessClass.GetCokeSupplierBySeacrh(objML_CokeSupplierh);

              
                    ViewState["grdCokeSupplier"] = DtList;
                   
                }
                else
                {
                    DtList = (DataTable)ViewState["grdCokeSupplier"];
                }
               
                if (DtList != null)
                {
                    // DtList = (DataTable)ViewState["grdPitchType"];
                    if (DtList.Rows.Count > 0)
                    {
                        grdCokeSupplier.DataSource = DtList;
                        grdCokeSupplier.DataBind();
                    }
                    else
                    {
                        DtList.Rows.Add(DtList.NewRow());
                        grdCokeSupplier.DataSource = DtList;
                        grdCokeSupplier.DataBind();

                        int TotalColumns = grdCokeSupplier.Rows[0].Cells.Count;
                        grdCokeSupplier.Rows[0].Cells.Clear();
                        grdCokeSupplier.Rows[0].Cells.Add(new TableCell());
                        grdCokeSupplier.Rows[0].Cells[0].ColumnSpan = TotalColumns;
                        grdCokeSupplier.Rows[0].Cells[0].Text = "No Record Found";
                    }
                    UpdatePanelGrid.Update();
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }



        private void FillObjectToForm(int lngId, bool IsEditFlag = true)
        {
            objBusinessClass = new BusinessLayer.BusinessClass();
            ML_CokeSupplier objML_CokeSupplier = objBusinessClass.GetCokeSupplierById(lngId);
            try
            {
                if (objML_CokeSupplier != null)
                {
                    if (IsEditFlag)
                    {
                        //txtIdEdit.Text = ML_Common.clean(objML_CokeSupplier.Id);
                        //txtCokeSupplierIdEdit.Text = ML_Common.clean(objML_CokeSupplier.CokeSupplierId);
                        txtCokeSupplierEdit.Text = ML_Common.clean(objML_CokeSupplier.CokeSupplier);
                        txtAddress1Edit.Text = ML_Common.clean(objML_CokeSupplier.Address1);
                        txtAddress2Edit.Text = ML_Common.clean(objML_CokeSupplier.Address2);
                        txtAddress3Edit.Text = ML_Common.clean(objML_CokeSupplier.Address3);
                        //txtCityNameEdit.Text = ML_Common.clean(objML_CokeSupplier.CityName);
                        //txtStateNameEdit.Text = ML_Common.clean(objML_CokeSupplier.StateName);
                        //txtPinCodeEdit.Text = ML_Common.clean(objML_CokeSupplier.PinCode);
                        //txtTitleEdit.Text = ML_Common.clean(objML_CokeSupplier.Title);
                        //txtCountryNameEdit.Text = ML_Common.clean(objML_CokeSupplier.CountryName);
                        txtContactPersonEdit.Text = ML_Common.clean(objML_CokeSupplier.ContactPerson);
                        txtMobNoEdit.Text = ML_Common.clean(objML_CokeSupplier.MobNo);
                       // txtWebSiteEdit.Text = ML_Common.clean(objML_CokeSupplier.WebSite);
                        txtEmailEdit.Text = ML_Common.clean(objML_CokeSupplier.Email);
                        txtRemarksEdit.Text = ML_Common.clean(objML_CokeSupplier.Remarks);
                        //txtIsActiveEdit.Text = ML_Common.clean(objML_CokeSupplier.IsActive);
                        //txtIsArchiveEdit.Text = ML_Common.clean(objML_CokeSupplier.IsArchive);
                        //txtCreatedDateEdit.Text = ML_Common.clean(objML_CokeSupplier.CreatedDate);
                        //txtCreatedByEdit.Text = ML_Common.clean(objML_CokeSupplier.CreatedBy);
                        //txtModifiedDateEdit.Text = ML_Common.clean(objML_CokeSupplier.ModifiedDate);
                        //txtModifiedByEdit.Text = ML_Common.clean(objML_CokeSupplier.ModifiedBy);
                        //txtCreatedByUserNameIdEdit.Text = ML_Common.clean(objML_CokeSupplier.CreatedByUserNameId);

                    }
                    else
                    {
                        //lblId.Text = ML_Common.clean(objML_CokeSupplier.Id);
                        //lblCokeSupplierId.Text = ML_Common.clean(objML_CokeSupplier.CokeSupplierId);
                        lblCokeSupplier.Text = ML_Common.clean(objML_CokeSupplier.CokeSupplier);
                        lblAddress1.Text = ML_Common.clean(objML_CokeSupplier.Address1);
                        lblAddress2.Text = ML_Common.clean(objML_CokeSupplier.Address2);
                        lblAddress3.Text = ML_Common.clean(objML_CokeSupplier.Address3);
                        //lblCityName.Text = ML_Common.clean(objML_CokeSupplier.CityName);
                        //lblStateName.Text = ML_Common.clean(objML_CokeSupplier.StateName);
                        //lblPinCode.Text = ML_Common.clean(objML_CokeSupplier.PinCode);
                        //lblTitle.Text = ML_Common.clean(objML_CokeSupplier.Title);
                        //lblCountryName.Text = ML_Common.clean(objML_CokeSupplier.CountryName);
                        lblContactPerson.Text = ML_Common.clean(objML_CokeSupplier.ContactPerson);
                        lblMobNo.Text = ML_Common.clean(objML_CokeSupplier.MobNo);
                        lblWebSite.Text = ML_Common.clean(objML_CokeSupplier.WebSite);
                        lblEmail.Text = ML_Common.clean(objML_CokeSupplier.Email);
                        lblRemarks.Text = ML_Common.clean(objML_CokeSupplier.Remarks);
                        //lblIsActive.Text = ML_Common.clean(objML_CokeSupplier.IsActive);
                        //lblIsArchive.Text = ML_Common.clean(objML_CokeSupplier.IsArchive);
                        //lblCreatedDate.Text = ML_Common.clean(objML_CokeSupplier.CreatedDate);
                        //lblCreatedBy.Text = ML_Common.clean(objML_CokeSupplier.CreatedBy);
                        //lblModifiedDate.Text = ML_Common.clean(objML_CokeSupplier.ModifiedDate);
                        //lblModifiedBy.Text = ML_Common.clean(objML_CokeSupplier.ModifiedBy);
                        //lblCreatedByUserNameId.Text = ML_Common.clean(objML_CokeSupplier.CreatedByUserNameId);

                    }

                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }


        public void FormFieldsClear()
        {
            try
            {
                //txtIdEdit.Text = string.Empty;
                //txtCokeSupplierIdEdit.Text = string.Empty;
                txtCokeSupplierEdit.Text = string.Empty;
                txtAddress1Edit.Text = string.Empty;
                txtAddress2Edit.Text = string.Empty;
                txtAddress3Edit.Text = string.Empty;
                //txtCityNameEdit.Text = string.Empty;
                //txtStateNameEdit.Text = string.Empty;
                //txtPinCodeEdit.Text = string.Empty;
                //txtTitleEdit.Text = string.Empty;
                //txtCountryNameEdit.Text = string.Empty;
                txtContactPersonEdit.Text = string.Empty;
                txtMobNoEdit.Text = string.Empty;
               // txtWebSiteEdit.Text = string.Empty;
                txtEmailEdit.Text = string.Empty;
                txtRemarksEdit.Text = string.Empty;
                //chkIsActiveEdit.Checked = true;
                //chkIsArchiveEdit.Checked = false;
                //txtCreatedByUserNameIdEdit.Text = string.Empty;

            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }


    
        #endregion

        #region Event GridView
        protected void grdCokeSupplier_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if ((e.Row.RowType == DataControlRowType.DataRow) && (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate))
            {
                try
                {
                    

                    Label lblCokeSupplier = (Label)e.Row.FindControl("lblCokeSupplier");
                    if (lblCokeSupplier != null)
                    {
                        try
                        {
                            lblCokeSupplier.Text = ML_Common.string2Eclips(lblCokeSupplier.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblCokeSupplier.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblAddress1 = (Label)e.Row.FindControl("lblAddress1");
                    if (lblAddress1 != null)
                    {
                        try
                        {
                            lblAddress1.Text = ML_Common.string2Eclips(lblAddress1.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblAddress1.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblAddress2 = (Label)e.Row.FindControl("lblAddress2");
                    if (lblAddress2 != null)
                    {
                        try
                        {
                            lblAddress2.Text = ML_Common.string2Eclips(lblAddress2.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblAddress2.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblAddress3 = (Label)e.Row.FindControl("lblAddress3");
                    if (lblAddress3 != null)
                    {
                        try
                        {
                            lblAddress3.Text = ML_Common.string2Eclips(lblAddress3.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblAddress3.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblCityName = (Label)e.Row.FindControl("lblCityName");
                    if (lblCityName != null)
                    {
                        try
                        {
                            lblCityName.Text = ML_Common.string2Eclips(lblCityName.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblCityName.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblStateName = (Label)e.Row.FindControl("lblStateName");
                    if (lblStateName != null)
                    {
                        try
                        {
                            lblStateName.Text = ML_Common.string2Eclips(lblStateName.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblStateName.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblPinCode = (Label)e.Row.FindControl("lblPinCode");
                    if (lblPinCode != null)
                    {
                        try
                        {
                            lblPinCode.Text = ML_Common.string2Eclips(lblPinCode.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblPinCode.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblTitle = (Label)e.Row.FindControl("lblTitle");
                    if (lblTitle != null)
                    {
                        try
                        {
                            lblTitle.Text = ML_Common.string2Eclips(lblTitle.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblTitle.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblCountryName = (Label)e.Row.FindControl("lblCountryName");
                    if (lblCountryName != null)
                    {
                        try
                        {
                            lblCountryName.Text = ML_Common.string2Eclips(lblCountryName.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblCountryName.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblContactPerson = (Label)e.Row.FindControl("lblContactPerson");
                    if (lblContactPerson != null)
                    {
                        try
                        {
                            lblContactPerson.Text = ML_Common.string2Eclips(lblContactPerson.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblContactPerson.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblMobNo = (Label)e.Row.FindControl("lblMobNo");
                    if (lblMobNo != null)
                    {
                        try
                        {
                            lblMobNo.Text = ML_Common.string2Eclips(lblMobNo.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblMobNo.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblWebSite = (Label)e.Row.FindControl("lblWebSite");
                    if (lblWebSite != null)
                    {
                        try
                        {
                            lblWebSite.Text = ML_Common.string2Eclips(lblWebSite.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblWebSite.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblEmail = (Label)e.Row.FindControl("lblEmail");
                    if (lblEmail != null)
                    {
                        try
                        {
                            lblEmail.Text = ML_Common.string2Eclips(lblEmail.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblEmail.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblRemarks = (Label)e.Row.FindControl("lblRemarks");
                    if (lblRemarks != null)
                    {
                        try
                        {
                            lblRemarks.Text = ML_Common.string2Eclips(lblRemarks.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblRemarks.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    
                }
                catch (Exception ex)
                {
                    Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
                }
            }           
        }

        protected void grdCokeSupplier_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                // Guid  guid = ML_Common.String2Guid(grdCokeSupplier.DataKeys[e.RowIndex].Values[0].ToString()); 
                int lngId = ML_Common.string2int(grdCokeSupplier.DataKeys[e.RowIndex].Values[0].ToString());
                DeleteGridRowItem(lngId);
                ViewState["grdCokeSupplier"] = null;
                FillGrid();
                FormFieldsClear();
                //PanelEditFormDisplay(false); 
                lblMsg.Visible = true;
                lblMsg.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }

        protected void grdCokeSupplier_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                lblMsg.Visible = false;
                //grdCokeSupplier.EditIndex = -1; 
                //grdCokeSupplier.EditIndex = e.NewEditIndex; 
                // Guid  guid = ML_Common.String2Guid(grdCokeSupplier.DataKeys[e.NewEditIndex].Values[0].ToString()); 
                //int lngId = ML_Common.string2int(grdCokeSupplier.DataKeys[e.NewEditIndex].Values[0].ToString()); 
                int lngId = ML_Common.string2int32(grdCokeSupplier.DataKeys[e.NewEditIndex].Values[0].ToString());
                if (lngId > 0)
                {
                    ViewState["grdCokeSupplierId"] = lngId;
                    grdCokeSupplier.EditIndex = -1;
                    e.Cancel = true;
                    FormFieldsClear();
                    FillObjectToForm(lngId, true);
                     UpdatePanelEdit.Update(); 
                    ModalPopupExtenderEdit.Show(); 
                }
                else
                {
                    lblMsg.Text = "Record is not exists?";
                    lblMsg.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }

        protected void grdCokeSupplier_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                if (grdCokeSupplier.EditIndex != -1)
                {
                    e.Cancel = true;
                }
                else
                {
                    FillGrid();
                    grdCokeSupplier.PageIndex = e.NewPageIndex;
                    grdCokeSupplier.DataBind();
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }

        protected void grdCokeSupplier_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                lblMsg.Visible = false;
               
                int lngId = ML_Common.string2int32(grdCokeSupplier.DataKeys[e.NewSelectedIndex].Values[0].ToString());
                ViewState["grdCokeSupplierId"] = lngId;
                if (lngId > 0)
                {
                    FormFieldsClear();
                    FillObjectToForm(lngId, false);
                     UpdatePanelView.Update(); 
                    ModalPopupExtenderView.Show(); 
                }
                else
                {
                    lblMsg.Text = "Record is not exists?";
                    lblMsg.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }

        #endregion


        #region DML Method
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            lblMsg.Text = string.Empty;
            lblMsgEdit.Text = string.Empty;
            try
            {
               
               ViewState["grdCokeSupplier"] =null;
                FillGrid();
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }


        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            lblMsg.Text = string.Empty;
            lblMsgEdit.Text = string.Empty;
           
            if (IsValid)
            {
                //errNumber = -1;
                BusinessClass objBusinessClass = new BusinessLayer.BusinessClass();
                int lngId = Convert.ToInt32(ViewState["grdCokeSupplierId"]);
                ML_CokeSupplier objML_CokeSupplier = objBusinessClass.GetCokeSupplierById(lngId);
                try
                {
                    if (objML_CokeSupplier != null)
                    {
                       
                      //  objML_CokeSupplier.Id = ML_Common.string2int32(ML_Common.clean(txtIdEdit.Text));
                 
                       // objML_CokeSupplier.CokeSupplierId = ML_Common.string2int32(ML_Common.GetDropDownValue(ddlCokeSupplierEdit, true));
                        objML_CokeSupplier.CokeSupplier = ML_Common.string2string(txtCokeSupplierEdit.Text);
                        objML_CokeSupplier.Address1 = ML_Common.clean(txtAddress1Edit.Text);
                        objML_CokeSupplier.Address2 = ML_Common.clean(txtAddress2Edit.Text);
                        objML_CokeSupplier.Address3 = ML_Common.clean(txtAddress3Edit.Text);
                        objML_CokeSupplier.CityName = string.Empty;//ML_Common.clean(txtCityNameEdit.Text);
                        objML_CokeSupplier.StateName = string.Empty;// ML_Common.clean(txtStateNameEdit.Text);
                        objML_CokeSupplier.PinCode = string.Empty;//ML_Common.clean(txtPinCodeEdit.Text);
                        objML_CokeSupplier.Title = string.Empty;// ML_Common.clean(txtTitleEdit.Text);
                        objML_CokeSupplier.CountryName = string.Empty;// ML_Common.clean(txtCountryNameEdit.Text);
                        objML_CokeSupplier.ContactPerson = ML_Common.clean(txtContactPersonEdit.Text);
                        objML_CokeSupplier.MobNo = ML_Common.clean(txtMobNoEdit.Text);
                        objML_CokeSupplier.WebSite = string.Empty;// ML_Common.clean(txtWebSiteEdit.Text);
                        objML_CokeSupplier.Email = ML_Common.clean(txtEmailEdit.Text);
                        objML_CokeSupplier.Remarks = ML_Common.clean(txtRemarksEdit.Text);                                             


                         objML_CokeSupplier.IsActive = ML_Common.clean(ML_Common.bit2int(true).ToString()); 
                         objML_CokeSupplier.IsArchive = ML_Common.clean(ML_Common.bit2int(false).ToString()); 
                         objML_CokeSupplier.CreatedDate = ML_Common.ToDateTimeSafe(System.DateTime.Now.ToString()); 
                         objML_CokeSupplier.CreatedBy = ML_Common.clean(string.Empty); 
                         objML_CokeSupplier.ModifiedDate = ML_Common.ToDateTimeSafe(System.DateTime.Now.ToString()); 
                         objML_CokeSupplier.ModifiedBy = ML_Common.clean(string.Empty); 
                         objML_CokeSupplier.CreatedByUserNameId =1;// ML_Common.string2int(ML_Common.clean(txtCreatedByUserNameIdEdit.Text));

                        //  int obhReturn = objBusinessClass.UpdateUniqueCokeSupplier(objML_CokeSupplier); 
                        int obhReturn = objBusinessClass.UpdateCokeSupplier(objML_CokeSupplier);
                        if (obhReturn == 1)
                        {
                            lblMsg.Visible = true;
                            lblMsg.Text = "Record Update Successfully";
                            lblMsgEdit.Text = "Record Update Successfully";
                            ModalPopupExtenderEdit.Hide();
                            lblMsgEdit.Text = string.Empty;
                            
                        }
                        else if (obhReturn == 2)
                        {
                            lblMsg.Text = "Record Already Exists!";
                            lblMsgEdit.Text = "Record Already Exists!";
                            lblMsg.Visible = true;
                            ModalPopupExtenderEdit.Hide();
                        }
                        else
                        {
                            lblMsg.Text = "Ooops!OtherIssue...";
                            lblMsgEdit.Text = "Ooops!OtherIssue...";
                            lblMsg.Visible = true;
                        }
                        FillGrid();
                    }
                }
                catch (SqlException sqlExc)
                {
                    SqlException sqlExt = sqlExc;
                     return;

                }
                catch (Exception ex)
                {
                    Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
                }
            }
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            lblMsg.Text = string.Empty;
            lblMsgEdit.Text = string.Empty;
            try
            {
                lblMsg.Text = string.Empty;
                lblMsg.Visible = false;
                // grdCokeSupplier.EditIndex = -1; 
                FormFieldsClear();
                FillGrid();
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }
        #endregion

        #region populate
       
        private void populateCokeSupplierList()
        {
            //objBusinessClass = new BusinessLayer.BusinessClass();
            //DataSet ds = objBusinessClass.GetCokeSupplierDetail();
            //try
            //{
            //    if (ds.Tables.Count > 0)
            //    {
            //        ddlCokeSupplier.DataTextField = "CokeSupplier";
            //        ddlCokeSupplier.DataValueField = "CokeSupplierId";
            //        ddlCokeSupplier.DataSource = ds;
            //        ddlCokeSupplier.DataBind();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            //}
        }
        #endregion
        
        #region  BindDataTable
        private DataTable BindCokeSupplierDataTable()
        {
            DataTable myDataTable = new DataTable("myDataTable");
            try
            {


                DataColumn ColumnId;
                ColumnId = new DataColumn();
                ColumnId.DataType = System.Type.GetType("System.String");
                ColumnId.ColumnName = "Id";
                myDataTable.Columns.Add(ColumnId);


                DataColumn ColumnCokeSupplierId;
                ColumnCokeSupplierId = new DataColumn();
                ColumnCokeSupplierId.DataType = System.Type.GetType("System.String");
                ColumnCokeSupplierId.ColumnName = "CokeSupplierId";
                myDataTable.Columns.Add(ColumnCokeSupplierId);


                DataColumn ColumnCokeSupplier;
                ColumnCokeSupplier = new DataColumn();
                ColumnCokeSupplier.DataType = System.Type.GetType("System.String");
                ColumnCokeSupplier.ColumnName = "CokeSupplier";
                myDataTable.Columns.Add(ColumnCokeSupplier);


                DataColumn ColumnAddress1;
                ColumnAddress1 = new DataColumn();
                ColumnAddress1.DataType = System.Type.GetType("System.String");
                ColumnAddress1.ColumnName = "Address1";
                myDataTable.Columns.Add(ColumnAddress1);


                DataColumn ColumnAddress2;
                ColumnAddress2 = new DataColumn();
                ColumnAddress2.DataType = System.Type.GetType("System.String");
                ColumnAddress2.ColumnName = "Address2";
                myDataTable.Columns.Add(ColumnAddress2);


                DataColumn ColumnAddress3;
                ColumnAddress3 = new DataColumn();
                ColumnAddress3.DataType = System.Type.GetType("System.String");
                ColumnAddress3.ColumnName = "Address3";
                myDataTable.Columns.Add(ColumnAddress3);


                DataColumn ColumnCityName;
                ColumnCityName = new DataColumn();
                ColumnCityName.DataType = System.Type.GetType("System.String");
                ColumnCityName.ColumnName = "CityName";
                myDataTable.Columns.Add(ColumnCityName);


                DataColumn ColumnStateName;
                ColumnStateName = new DataColumn();
                ColumnStateName.DataType = System.Type.GetType("System.String");
                ColumnStateName.ColumnName = "StateName";
                myDataTable.Columns.Add(ColumnStateName);


                DataColumn ColumnPinCode;
                ColumnPinCode = new DataColumn();
                ColumnPinCode.DataType = System.Type.GetType("System.String");
                ColumnPinCode.ColumnName = "PinCode";
                myDataTable.Columns.Add(ColumnPinCode);


                DataColumn ColumnTitle;
                ColumnTitle = new DataColumn();
                ColumnTitle.DataType = System.Type.GetType("System.String");
                ColumnTitle.ColumnName = "Title";
                myDataTable.Columns.Add(ColumnTitle);


                DataColumn ColumnCountryName;
                ColumnCountryName = new DataColumn();
                ColumnCountryName.DataType = System.Type.GetType("System.String");
                ColumnCountryName.ColumnName = "CountryName";
                myDataTable.Columns.Add(ColumnCountryName);


                DataColumn ColumnContactPerson;
                ColumnContactPerson = new DataColumn();
                ColumnContactPerson.DataType = System.Type.GetType("System.String");
                ColumnContactPerson.ColumnName = "ContactPerson";
                myDataTable.Columns.Add(ColumnContactPerson);


                DataColumn ColumnMobNo;
                ColumnMobNo = new DataColumn();
                ColumnMobNo.DataType = System.Type.GetType("System.String");
                ColumnMobNo.ColumnName = "MobNo";
                myDataTable.Columns.Add(ColumnMobNo);


                DataColumn ColumnWebSite;
                ColumnWebSite = new DataColumn();
                ColumnWebSite.DataType = System.Type.GetType("System.String");
                ColumnWebSite.ColumnName = "WebSite";
                myDataTable.Columns.Add(ColumnWebSite);


                DataColumn ColumnEmail;
                ColumnEmail = new DataColumn();
                ColumnEmail.DataType = System.Type.GetType("System.String");
                ColumnEmail.ColumnName = "Email";
                myDataTable.Columns.Add(ColumnEmail);


                DataColumn ColumnRemarks;
                ColumnRemarks = new DataColumn();
                ColumnRemarks.DataType = System.Type.GetType("System.String");
                ColumnRemarks.ColumnName = "Remarks";
                myDataTable.Columns.Add(ColumnRemarks);


                DataColumn ColumnIsActive;
                ColumnIsActive = new DataColumn();
                ColumnIsActive.DataType = System.Type.GetType("System.String");
                ColumnIsActive.ColumnName = "IsActive";
                myDataTable.Columns.Add(ColumnIsActive);


                DataColumn ColumnIsArchive;
                ColumnIsArchive = new DataColumn();
                ColumnIsArchive.DataType = System.Type.GetType("System.String");
                ColumnIsArchive.ColumnName = "IsArchive";
                myDataTable.Columns.Add(ColumnIsArchive);


                DataColumn ColumnCreatedDate;
                ColumnCreatedDate = new DataColumn();
                ColumnCreatedDate.DataType = System.Type.GetType("System.String");
                ColumnCreatedDate.ColumnName = "CreatedDate";
                myDataTable.Columns.Add(ColumnCreatedDate);


                DataColumn ColumnCreatedBy;
                ColumnCreatedBy = new DataColumn();
                ColumnCreatedBy.DataType = System.Type.GetType("System.String");
                ColumnCreatedBy.ColumnName = "CreatedBy";
                myDataTable.Columns.Add(ColumnCreatedBy);


                DataColumn ColumnModifiedDate;
                ColumnModifiedDate = new DataColumn();
                ColumnModifiedDate.DataType = System.Type.GetType("System.String");
                ColumnModifiedDate.ColumnName = "ModifiedDate";
                myDataTable.Columns.Add(ColumnModifiedDate);


                DataColumn ColumnModifiedBy;
                ColumnModifiedBy = new DataColumn();
                ColumnModifiedBy.DataType = System.Type.GetType("System.String");
                ColumnModifiedBy.ColumnName = "ModifiedBy";
                myDataTable.Columns.Add(ColumnModifiedBy);


                DataColumn ColumnCreatedByUserNameId;
                ColumnCreatedByUserNameId = new DataColumn();
                ColumnCreatedByUserNameId.DataType = System.Type.GetType("System.String");
                ColumnCreatedByUserNameId.ColumnName = "CreatedByUserNameId";
                myDataTable.Columns.Add(ColumnCreatedByUserNameId);


            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
            return myDataTable;
        }
        #endregion

        protected void btnCokeSupplierEditCancelPopup_Click(object sender, EventArgs e)
        {
            ModalPopupExtenderEdit.Hide();
        }

        protected void btnCokeSupplierViewCancelPopup_Click(object sender, EventArgs e)
        {
            ModalPopupExtenderView.Hide();
        }
    }
}
#endregion