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
    public partial class frmUserEdit : System.Web.UI.Page
    {
        #region Initialize the Object of the Class
        static string strUserNameId = string.Empty;
        BusinessClass objBusinessClass = null;
        ML_UserName objML_UserName = null;
        public static Guid strUserNameGuid = Guid.Empty;
        public static string setStringFile = string.Empty;
        public static string strImgPath = string.Empty;
       // int errNumber = int.MinValue;
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                 if (!this.Page.User.Identity.IsAuthenticated)
                {
                    FormsAuthentication.RedirectToLoginPage();
                }
                if (!IsPostBack)
                {
                    //setGlobalLabel();
                    populateUserTypeList();
                    //  FillGrid();
                }
            }
            catch (Exception ex)
            {
                Exception exx = ex;
            }
        }

        #region Other Methods
        private DataTable BindGridView()
        {
            DataTable dtUserName = new DataTable("DtGrd");
            try
            {
                objBusinessClass = new BusinessClass();
                dtUserName = objBusinessClass.GetUserNameDetail();
                
            }
            catch (Exception ex)
            {
                Exception exx = ex;
            }
            return dtUserName;
        }

        private DataTable BindGridViewBySearch(ML_UserName objML_UserName)
        {
            DataTable dtUserName = new DataTable("GridSearch");
            try
            {
                objBusinessClass = new BusinessLayer.BusinessClass();
                dtUserName = objBusinessClass.GetUserNameBySeacrh(objML_UserName);
                
            }
            catch (Exception ex)
            {
                Exception exx = ex;
            }
            return dtUserName;
        }



        private int DeleteGridRowItem(int lngId)
        {
            int returnObj = 0;
            try
            {
                objBusinessClass = new BusinessLayer.BusinessClass();
                returnObj = objBusinessClass.DeleteUserName(lngId);
            }
            catch (Exception ex)
            {
                Exception exx = ex;
            }
            return returnObj;
        }

        private void FillGrid()
        {
            try
            {
                DataTable DtList = null;
               

                    if (ViewState["grdUserName"] == null)
                    {
                        if (ddlUserTypeSearch.SelectedIndex > 0)
                        {
                            objML_UserName.UserTypeId = ML_Common.string2int32(ML_Common.GetDropDownValue(ddlUserTypeSearch, true));
                            objML_UserName.UserType = ML_Common.string2string(ML_Common.GetDropDownValue(ddlUserTypeSearch, false));

                            DtList = BindGridViewBySearch(objML_UserName);
                            ViewState["grdUserName"] = DtList;
                        }                    
                    }
                    else
                    {
                     DtList =(DataTable) ViewState["grdUserName"];
                    }

                    if (DtList !=null)
                    { 
                    if (DtList.Rows.Count > 0)
                    {
                        grdUserName.DataSource = DtList;
                        grdUserName.DataBind();
                    }
                    else
                    {
                        DtList.Rows.Add(DtList.NewRow());
                        grdUserName.DataSource = DtList;
                        grdUserName.DataBind();

                        int TotalColumns = grdUserName.Rows[0].Cells.Count;
                        grdUserName.Rows[0].Cells.Clear();
                        grdUserName.Rows[0].Cells.Add(new TableCell());
                        grdUserName.Rows[0].Cells[0].ColumnSpan = TotalColumns;
                        grdUserName.Rows[0].Cells[0].Text = "No Record Found";
                    }

                    UpdatePanelGrid.Update();
                    }
                
            }
            catch (Exception ex)
            {
                Exception exx = ex;
            }
        }



        private void FillObjectToForm(int lngId, bool IsEditFlag = true)
        {
            objBusinessClass = new BusinessLayer.BusinessClass();
            ML_UserName objML_UserName = objBusinessClass.GetUserNameById(lngId);
            try
            {
                if (objML_UserName != null)
                {
                    if (IsEditFlag)
                    {
                        txtUserNameEdit.Text = ML_Common.clean(objML_UserName.UserName);
                        txtFirstNameEdit.Text = ML_Common.clean(objML_UserName.FirstName);
                        txtLastNameEdit.Text = ML_Common.clean(objML_UserName.LastName);
                        txtEmailEdit.Text = ML_Common.clean(objML_UserName.Email);

                        txtMobileEdit.Text = ML_Common.clean(objML_UserName.Mobile);


                        lblUserType.Text = ML_Common.clean(objML_UserName.UserType);


                    }
                    else
                    {

                        lblUserName.Text = ML_Common.clean(objML_UserName.UserName);
                        lblFirstName.Text = ML_Common.clean(objML_UserName.FirstName);
                        lblLastName.Text = ML_Common.clean(objML_UserName.LastName);
                        lblEmail.Text = ML_Common.clean(objML_UserName.Email);
                        lblMobile.Text = ML_Common.clean(objML_UserName.Mobile);
                        lblUserType.Text = ML_Common.clean(objML_UserName.UserType);
                    }

                }
            }
            catch (Exception ex)
            {
                Exception exx = ex;
            }
        }


        public void FormFieldsClear()
        {
            try
            {

                lblUserName.Text = string.Empty;
                lblFirstName.Text = string.Empty;
                lblLastName.Text = string.Empty;
                lblEmail.Text = string.Empty;

                lblMobile.Text = string.Empty;


                lblUserType.Text = string.Empty;


            }
            catch (Exception ex)
            {
                Exception exx = ex;
            }
        }






        #endregion

        #region Event GridView
        protected void grdUserName_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if ((e.Row.RowType == DataControlRowType.DataRow) && (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate))
            {
                try
                {
                    Label lblId = (Label)e.Row.FindControl("lblId");
                    if (lblId != null)
                    {
                        try
                        {
                            lblId.Text = ML_Common.string2Eclips(lblId.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblId.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblUserNameId = (Label)e.Row.FindControl("lblUserNameId");
                    if (lblUserNameId != null)
                    {
                        try
                        {
                            lblUserNameId.Text = ML_Common.string2Eclips(lblUserNameId.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblUserNameId.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblUserName = (Label)e.Row.FindControl("lblUserName");
                    if (lblUserName != null)
                    {
                        try
                        {
                            lblUserName.Text = ML_Common.string2Eclips(lblUserName.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblUserName.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblFirstName = (Label)e.Row.FindControl("lblFirstName");
                    if (lblFirstName != null)
                    {
                        try
                        {
                            lblFirstName.Text = ML_Common.string2Eclips(lblFirstName.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblFirstName.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblLastName = (Label)e.Row.FindControl("lblLastName");
                    if (lblLastName != null)
                    {
                        try
                        {
                            lblLastName.Text = ML_Common.string2Eclips(lblLastName.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblLastName.Text = string.Empty;
                            Exception exx = ex;
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
                            Exception exx = ex;
                        }
                    }


                    Label lblTelephone = (Label)e.Row.FindControl("lblTelephone");
                    if (lblTelephone != null)
                    {
                        try
                        {
                            lblTelephone.Text = ML_Common.string2Eclips(lblTelephone.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblTelephone.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblMobile = (Label)e.Row.FindControl("lblMobile");
                    if (lblMobile != null)
                    {
                        try
                        {
                            lblMobile.Text = ML_Common.string2Eclips(lblMobile.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblMobile.Text = string.Empty;
                            Exception exx = ex;
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
                            Exception exx = ex;
                        }
                    }


                    Label lblPassword = (Label)e.Row.FindControl("lblPassword");
                    if (lblPassword != null)
                    {
                        try
                        {
                            lblPassword.Text = ML_Common.string2Eclips(lblPassword.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblPassword.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblUserTypeId = (Label)e.Row.FindControl("lblUserTypeId");
                    if (lblUserTypeId != null)
                    {
                        try
                        {
                            lblUserTypeId.Text = ML_Common.string2Eclips(lblUserTypeId.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblUserTypeId.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblUserType = (Label)e.Row.FindControl("lblUserType");
                    if (lblUserType != null)
                    {
                        try
                        {
                            lblUserType.Text = ML_Common.string2Eclips(lblUserType.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblUserType.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblReTryAttempt = (Label)e.Row.FindControl("lblReTryAttempt");
                    if (lblReTryAttempt != null)
                    {
                        try
                        {
                            lblReTryAttempt.Text = ML_Common.string2Eclips(lblReTryAttempt.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblReTryAttempt.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblIsLocked = (Label)e.Row.FindControl("lblIsLocked");
                    if (lblIsLocked != null)
                    {
                        try
                        {
                            lblIsLocked.Text = ML_Common.string2Eclips(lblIsLocked.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblIsLocked.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblLockedDateTime = (Label)e.Row.FindControl("lblLockedDateTime");
                    if (lblLockedDateTime != null)
                    {
                        try
                        {
                            lblLockedDateTime.Text = ML_Common.string2Eclips(lblLockedDateTime.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblLockedDateTime.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblIsActive = (Label)e.Row.FindControl("lblIsActive");
                    if (lblIsActive != null)
                    {
                        try
                        {
                            lblIsActive.Text = ML_Common.string2Eclips(lblIsActive.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblIsActive.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblIsArchive = (Label)e.Row.FindControl("lblIsArchive");
                    if (lblIsArchive != null)
                    {
                        try
                        {
                            lblIsArchive.Text = ML_Common.string2Eclips(lblIsArchive.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblIsArchive.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblCreatedDate = (Label)e.Row.FindControl("lblCreatedDate");
                    if (lblCreatedDate != null)
                    {
                        try
                        {
                            lblCreatedDate.Text = ML_Common.string2Eclips(lblCreatedDate.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblCreatedDate.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblCreatedBy = (Label)e.Row.FindControl("lblCreatedBy");
                    if (lblCreatedBy != null)
                    {
                        try
                        {
                            lblCreatedBy.Text = ML_Common.string2Eclips(lblCreatedBy.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblCreatedBy.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblModifiedDate = (Label)e.Row.FindControl("lblModifiedDate");
                    if (lblModifiedDate != null)
                    {
                        try
                        {
                            lblModifiedDate.Text = ML_Common.string2Eclips(lblModifiedDate.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblModifiedDate.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblModifiedBy = (Label)e.Row.FindControl("lblModifiedBy");
                    if (lblModifiedBy != null)
                    {
                        try
                        {
                            lblModifiedBy.Text = ML_Common.string2Eclips(lblModifiedBy.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblModifiedBy.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Exception exx = ex;
                }
            }


            if ((e.Row.RowType == DataControlRowType.DataRow) && (e.Row.RowState == DataControlRowState.Edit || (e.Row.RowState == (DataControlRowState.Edit | DataControlRowState.Alternate))))
            {
                try
                {
                    Label lblIdEdit = (Label)e.Row.FindControl("lblIdEdit");
                    if (lblIdEdit != null)
                    {
                        try
                        {
                            lblIdEdit.Text = ML_Common.string2Eclips(lblIdEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblIdEdit.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblUserNameIdEdit = (Label)e.Row.FindControl("lblUserNameIdEdit");
                    if (lblUserNameIdEdit != null)
                    {
                        try
                        {
                            lblUserNameIdEdit.Text = ML_Common.string2Eclips(lblUserNameIdEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblUserNameIdEdit.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblUserNameEdit = (Label)e.Row.FindControl("lblUserNameEdit");
                    if (lblUserNameEdit != null)
                    {
                        try
                        {
                            lblUserNameEdit.Text = ML_Common.string2Eclips(lblUserNameEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblUserNameEdit.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblFirstNameEdit = (Label)e.Row.FindControl("lblFirstNameEdit");
                    if (lblFirstNameEdit != null)
                    {
                        try
                        {
                            lblFirstNameEdit.Text = ML_Common.string2Eclips(lblFirstNameEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblFirstNameEdit.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblLastNameEdit = (Label)e.Row.FindControl("lblLastNameEdit");
                    if (lblLastNameEdit != null)
                    {
                        try
                        {
                            lblLastNameEdit.Text = ML_Common.string2Eclips(lblLastNameEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblLastNameEdit.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblEmailEdit = (Label)e.Row.FindControl("lblEmailEdit");
                    if (lblEmailEdit != null)
                    {
                        try
                        {
                            lblEmailEdit.Text = ML_Common.string2Eclips(lblEmailEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblEmailEdit.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblTelephoneEdit = (Label)e.Row.FindControl("lblTelephoneEdit");
                    if (lblTelephoneEdit != null)
                    {
                        try
                        {
                            lblTelephoneEdit.Text = ML_Common.string2Eclips(lblTelephoneEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblTelephoneEdit.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblMobileEdit = (Label)e.Row.FindControl("lblMobileEdit");
                    if (lblMobileEdit != null)
                    {
                        try
                        {
                            lblMobileEdit.Text = ML_Common.string2Eclips(lblMobileEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblMobileEdit.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblRemarksEdit = (Label)e.Row.FindControl("lblRemarksEdit");
                    if (lblRemarksEdit != null)
                    {
                        try
                        {
                            lblRemarksEdit.Text = ML_Common.string2Eclips(lblRemarksEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblRemarksEdit.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblPasswordEdit = (Label)e.Row.FindControl("lblPasswordEdit");
                    if (lblPasswordEdit != null)
                    {
                        try
                        {
                            lblPasswordEdit.Text = ML_Common.string2Eclips(lblPasswordEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblPasswordEdit.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblUserTypeIdEdit = (Label)e.Row.FindControl("lblUserTypeIdEdit");
                    if (lblUserTypeIdEdit != null)
                    {
                        try
                        {
                            lblUserTypeIdEdit.Text = ML_Common.string2Eclips(lblUserTypeIdEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblUserTypeIdEdit.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblUserTypeEdit = (Label)e.Row.FindControl("lblUserTypeEdit");
                    if (lblUserTypeEdit != null)
                    {
                        try
                        {
                            lblUserTypeEdit.Text = ML_Common.string2Eclips(lblUserTypeEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblUserTypeEdit.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblReTryAttemptEdit = (Label)e.Row.FindControl("lblReTryAttemptEdit");
                    if (lblReTryAttemptEdit != null)
                    {
                        try
                        {
                            lblReTryAttemptEdit.Text = ML_Common.string2Eclips(lblReTryAttemptEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblReTryAttemptEdit.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblIsLockedEdit = (Label)e.Row.FindControl("lblIsLockedEdit");
                    if (lblIsLockedEdit != null)
                    {
                        try
                        {
                            lblIsLockedEdit.Text = ML_Common.string2Eclips(lblIsLockedEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblIsLockedEdit.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblLockedDateTimeEdit = (Label)e.Row.FindControl("lblLockedDateTimeEdit");
                    if (lblLockedDateTimeEdit != null)
                    {
                        try
                        {
                            lblLockedDateTimeEdit.Text = ML_Common.string2Eclips(lblLockedDateTimeEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblLockedDateTimeEdit.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblIsActiveEdit = (Label)e.Row.FindControl("lblIsActiveEdit");
                    if (lblIsActiveEdit != null)
                    {
                        try
                        {
                            lblIsActiveEdit.Text = ML_Common.string2Eclips(lblIsActiveEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblIsActiveEdit.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblIsArchiveEdit = (Label)e.Row.FindControl("lblIsArchiveEdit");
                    if (lblIsArchiveEdit != null)
                    {
                        try
                        {
                            lblIsArchiveEdit.Text = ML_Common.string2Eclips(lblIsArchiveEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblIsArchiveEdit.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblCreatedDateEdit = (Label)e.Row.FindControl("lblCreatedDateEdit");
                    if (lblCreatedDateEdit != null)
                    {
                        try
                        {
                            lblCreatedDateEdit.Text = ML_Common.string2Eclips(lblCreatedDateEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblCreatedDateEdit.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblCreatedByEdit = (Label)e.Row.FindControl("lblCreatedByEdit");
                    if (lblCreatedByEdit != null)
                    {
                        try
                        {
                            lblCreatedByEdit.Text = ML_Common.string2Eclips(lblCreatedByEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblCreatedByEdit.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblModifiedDateEdit = (Label)e.Row.FindControl("lblModifiedDateEdit");
                    if (lblModifiedDateEdit != null)
                    {
                        try
                        {
                            lblModifiedDateEdit.Text = ML_Common.string2Eclips(lblModifiedDateEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblModifiedDateEdit.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }


                    Label lblModifiedByEdit = (Label)e.Row.FindControl("lblModifiedByEdit");
                    if (lblModifiedByEdit != null)
                    {
                        try
                        {
                            lblModifiedByEdit.Text = ML_Common.string2Eclips(lblModifiedByEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblModifiedByEdit.Text = string.Empty;
                            Exception exx = ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Exception exx = ex;
                }
            }
        }

        protected void grdUserName_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int lngId = ML_Common.string2int32(grdUserName.DataKeys[e.RowIndex].Values[0].ToString());
                DeleteGridRowItem(lngId);

                FormFieldsClear();

                lblMsg.Visible = true;
                lblMsg.Text = string.Empty;
                ViewState["grdUserNameEdit"] = null;
                FillGrid();
            }
            catch (Exception ex)
            {
                Exception exx = ex;
            }
        }

        protected void grdUserName_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                lblMsgEdit.Text = string.Empty;
                lblMsg.Visible = false;
                lblMsgEdit.Visible = false;
                int lngId = ML_Common.string2int32(grdUserName.DataKeys[e.NewEditIndex].Values[0].ToString());
                if (lngId > 0)
                {
                    ViewState["grdUserNameEditId"] = lngId;
                    grdUserName.EditIndex = -1;
                    e.Cancel = true;
                    FormFieldsClear();
                    FillObjectToForm(lngId, true);
                    UpdatePanelEdit.Update();
                    ModalPopupExtenderEdit.Show();
                }
                else
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Record is not exists?";
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;
            }
        }

        protected void grdUserName_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                if (grdUserName.EditIndex != -1)
                {
                    e.Cancel = true;
                }
                else
                {
                    FillGrid();
                    grdUserName.PageIndex = e.NewPageIndex;
                    grdUserName.DataBind();
                }
            }
            catch (Exception ex)
            {
                Exception exx = ex;
            }
        }

        protected void grdUserName_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                lblMsg.Visible = false;
                int lngId = ML_Common.string2int32(grdUserName.DataKeys[e.NewSelectedIndex].Values[0].ToString());
                ViewState["UserNameViewId"] = lngId;

                if (lngId > 0)
                {
                    // e.Cancel = true;

                    FormFieldsClear();

                    FillObjectToForm(lngId, false);
                    UpdatePanelView.Update();
                    ModalPopupExtenderView.Show();
                }
                else
                {
                    lblMsg.Visible = true;
                    lblMsg.Text = "Record is not exists?";
                }

            }
            catch (Exception ex)
            {
                Exception exx = ex;
            }
        }

        #endregion


        #region DML Method
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            objML_UserName = new ML_UserName();
            try
            {
                lblMsg.Text = string.Empty;
                lblMsg.Visible = false;
                lblMsgEdit.Text = string.Empty;
                lblMsgEdit.Visible = false;
                ViewState["grdUserName"] =null;

                FillGrid();

            }
            catch (Exception ex)
            {
                Exception exx = ex;
            }
        }


        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            lblMsg.Text = string.Empty;
            lblMsgEdit.Text = string.Empty;
            if (IsValid)
            {
                //errNumber = -1;
                try
                {
                    BusinessClass objBusinessClass = new BusinessLayer.BusinessClass();
                    int lngId = Convert.ToInt32(ViewState["UserNameViewId"]);
                    ML_UserName objML_UserName = objBusinessClass.GetUserNameById(lngId);

                    objML_UserName.UserName = ML_Common.clean(txtUserNameEdit.Text);
                    objML_UserName.FirstName = ML_Common.clean(txtFirstNameEdit.Text);
                    objML_UserName.LastName = ML_Common.clean(txtLastNameEdit.Text);
                    objML_UserName.Email = ML_Common.clean(txtEmailEdit.Text);
                    objML_UserName.Telephone = ML_Common.clean(txtTelephoneEdit.Text);
                    objML_UserName.Mobile = ML_Common.clean(txtMobileEdit.Text);
                    objML_UserName.Remarks = ML_Common.clean(txtRemarksEdit.Text);

                    objML_UserName.IsActive = ML_Common.clean(ML_Common.bit2int(true).ToString());
                    objML_UserName.IsArchive = ML_Common.clean(ML_Common.bit2int(false).ToString());
                    objML_UserName.CreatedDate = ML_Common.ToDateTimeSafe(System.DateTime.Now.ToString());
                    objML_UserName.CreatedBy = ML_Common.clean(string.Empty);
                    objML_UserName.ModifiedDate = ML_Common.ToDateTimeSafe(System.DateTime.Now.ToString());
                    objML_UserName.ModifiedBy = ML_Common.clean(string.Empty);

                    if (Session["UserName"] != null && Session["UserNameId"] != null)
                    {
                        objML_UserName.CreatedBy = ML_Common.clean(Session["UserName"]);
                        objML_UserName.ModifiedBy = ML_Common.clean(Session["UserName"]);
                        objML_UserName.CreatedByUserNameId = ML_Common.string2int32(ML_Common.clean(Session["UserNameId"]));
                    }



                    int obhReturn = objBusinessClass.UpdateUserName(objML_UserName);
                    if (obhReturn == 1)
                    {

                        lblMsg.Text = "Record Update Successfully";
                        lblMsgEdit.Text = "Record Update Successfully";
                        FormFieldsClear();


                    }
                    else if (obhReturn == 2)
                    {
                        lblMsg.Text = "Record Already Exists!";


                        lblMsgEdit.Text = "Record Already Exists!";

                    }
                    else
                    {
                        lblMsg.Text = "There are some issue while Updating!";


                        lblMsgEdit.Text = "There are some issue while Updating!";

                    }
                    UpdatePanelEdit.Update();
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
                lblMsg.Text = string.Empty;
                lblMsg.Visible = false;

                FillGrid();
                FormFieldsClear();


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
            DataTable  ds = null;
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
                if (ddlUserTypeSearch.Items.Count > 0)
                {
                    ddlUserTypeSearch.Items.Clear();
                }

                if (ds.Rows.Count > 0)
                {
                    ddlUserTypeSearch.DataTextField = "UserType";
                    ddlUserTypeSearch.DataValueField = "UserTypeId";
                    ddlUserTypeSearch.DataSource = ds.DefaultView;
                    ddlUserTypeSearch.DataBind();
                }
                ddlUserTypeSearch.Items.Insert(0, new ListItem("-- Select --", "-1"));
            }
            catch (Exception ex)
            {
                Exception exx = ex;
            }
        }
        #endregion

        protected void ddlUserTypeSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnUserTypeEditCancelPopup_Click(object sender, EventArgs e)
        {
            ModalPopupExtenderEdit.Hide();
        }

        protected void btnUserTypeViewCancelPopup_Click(object sender, EventArgs e)
        {
            ModalPopupExtenderView.Hide();
        }
    }
}