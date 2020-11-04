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
    public partial class frmCanteenTypeEdit : System.Web.UI.Page
    {
        #region Initialize the Object of the Class
        static string strCokeTypeId = string.Empty;
        BusinessClass objBusinessClass = null;
        ML_CokeType objML_CokeType = null;
        public static Guid strCokeTypeGuid = Guid.Empty;
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
               

                //if (string.IsNullOrEmpty(Convert.ToString(Session["userid"])))
                //{
                //    Response.Redirect("login.aspx?url=" + Server.UrlEncode(Request.Url.AbsoluteUri));
                //}

                if (!IsPostBack)
                {
                    // Form.Enctype = "multipart/form-data"; 
                    //populateCokeTypeList();
                   // FillGrid();
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }
        #endregion

        //#region Other Methods
        //private DataTable BindGridView()
        //{
        //    DataTable dtCokeType = new DataTable("DtGrd");
        //    try
        //    {
        //        objBusinessClass = new BusinessClass();
        //        dtCokeType = objBusinessClass.GetCokeTypeDetail();
                
        //    }
        //    catch (Exception ex)
        //    {
        //        Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //    }
        //    return dtCokeType;
        //}

        //private DataTable BindGridViewBySearch(ML_CokeType objML_CokeType)
        //{
        //    DataTable dtCokeType = new DataTable("GridSearch");
        //    try
        //    {
        //        objBusinessClass = new BusinessLayer.BusinessClass();
        //        dtCokeType = objBusinessClass.GetCokeTypeBySeacrh(objML_CokeType);
                
        //    }
        //    catch (Exception ex)
        //    {
        //        Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //    }
        //    return dtCokeType;
        //}



        //private int DeleteGridRowItem(int lngId)
        //{
        //    int returnObj = 0;
        //    try
        //    {
        //        objBusinessClass = new BusinessLayer.BusinessClass();
        //        returnObj = objBusinessClass.DeleteCokeType(lngId);
        //    }
        //    catch (Exception ex)
        //    {
        //        Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //    }
        //    return returnObj;
        //}

        //private void FillGrid()
        //{
        //    try
        //    {
        //        DataTable DtList = null;

        //        if (ViewState["grdCokeType"] == null)
        //        {
        //            ML_CokeType objML_CokeTypeSearch = new ML_CokeType();
        //            objML_CokeTypeSearch.CokeType = ML_Common.clean(txtCokeTypeSearch.Text);

        //            objBusinessClass = new BusinessLayer.BusinessClass();
        //            DtList = objBusinessClass.GetCokeTypeBySeacrh(objML_CokeTypeSearch);

        //            ViewState["grdCokeType"] = DtList;
        //        }
        //        else
        //        {
        //            DtList = (DataTable)ViewState["grdCokeType"];
        //        }
               
        //        if (DtList != null)
        //        {
        //            // DtList = (DataTable)ViewState["grdPitchType"];
        //            if (DtList.Rows.Count > 0)
        //            {
        //                grdCokeType.DataSource = DtList;
        //                grdCokeType.DataBind();
        //            }
        //            else
        //            {
        //                DtList.Rows.Add(DtList.NewRow());
        //                grdCokeType.DataSource = DtList;
        //                grdCokeType.DataBind();

        //                int TotalColumns = grdCokeType.Rows[0].Cells.Count;
        //                grdCokeType.Rows[0].Cells.Clear();
        //                grdCokeType.Rows[0].Cells.Add(new TableCell());
        //                grdCokeType.Rows[0].Cells[0].ColumnSpan = TotalColumns;
        //                grdCokeType.Rows[0].Cells[0].Text = "No Record Found";
        //            }
        //            UpdatePanelGrid.Update();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //    }
        //}



        //private void FillObjectToForm(int lngId, bool IsEditFlag = true)
        //{
        //    objBusinessClass = new BusinessLayer.BusinessClass();
        //    ML_CokeType objML_CokeType = objBusinessClass.GetCokeTypeById(lngId);
        //    try
        //    {
        //        if (objML_CokeType != null)
        //        {
        //            if (IsEditFlag)
        //            {
        //                //                 txtIdEdit.Text = ML_Common.clean(objML_CokeType.Id); 
        //                //txtCokeTypeIdEdit.Text = ML_Common.clean(objML_CokeType.CokeTypeId); 
        //                txtCokeTypeEdit.Text = ML_Common.clean(objML_CokeType.CokeType);
        //                txtRemarksEdit.Text = ML_Common.clean(objML_CokeType.Remarks);
        //                //txtIsActiveEdit.Text = ML_Common.clean(objML_CokeType.IsActive); 
        //                //txtIsArchiveEdit.Text = ML_Common.clean(objML_CokeType.IsArchive); 
        //                //txtCreatedDateEdit.Text = ML_Common.clean(objML_CokeType.CreatedDate); 
        //                //txtCreatedByEdit.Text = ML_Common.clean(objML_CokeType.CreatedBy); 
        //                //txtModifiedDateEdit.Text = ML_Common.clean(objML_CokeType.ModifiedDate); 
        //                //txtModifiedByEdit.Text = ML_Common.clean(objML_CokeType.ModifiedBy); 
        //                //txtCreatedByUserNameIdEdit.Text = ML_Common.clean(objML_CokeType.CreatedByUserNameId); 

        //            }
        //            else
        //            {
        //                //                 lblId.Text = ML_Common.clean(objML_CokeType.Id); 
        //                //lblCokeTypeId.Text = ML_Common.clean(objML_CokeType.CokeTypeId); 
        //                lblCokeType.Text = ML_Common.clean(objML_CokeType.CokeType);
        //                lblRemarks.Text = ML_Common.clean(objML_CokeType.Remarks);
        //                //lblIsActive.Text = ML_Common.clean(objML_CokeType.IsActive); 
        //                //lblIsArchive.Text = ML_Common.clean(objML_CokeType.IsArchive); 
        //                //lblCreatedDate.Text = ML_Common.clean(objML_CokeType.CreatedDate); 
        //                //lblCreatedBy.Text = ML_Common.clean(objML_CokeType.CreatedBy); 
        //                //lblModifiedDate.Text = ML_Common.clean(objML_CokeType.ModifiedDate); 
        //                //lblModifiedBy.Text = ML_Common.clean(objML_CokeType.ModifiedBy); 
        //                //lblCreatedByUserNameId.Text = ML_Common.clean(objML_CokeType.CreatedByUserNameId); 

        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //    }
        //}


        //public void FormFieldsClear()
        //{
        //    try
        //    {
        //        //txtIdEdit.Text = string.Empty;
        //        //txtCokeTypeIdEdit.Text = string.Empty;
        //        txtCokeTypeEdit.Text = string.Empty;
        //        txtRemarksEdit.Text = string.Empty;
        //        //chkIsActiveEdit.Checked = true;
        //        //chkIsArchiveEdit.Checked = false;
        //        //txtCreatedByUserNameIdEdit.Text = string.Empty;

        //    }
        //    catch (Exception ex)
        //    {
        //        Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //    }
        //}


      
        //#endregion

        //#region Event GridView
        //protected void grdCokeType_RowDataBound(object sender, GridViewRowEventArgs e)
        //{
        //    if ((e.Row.RowType == DataControlRowType.DataRow) && (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate))
        //    {
        //        try
        //        {
                   

        //            Label lblCokeType = (Label)e.Row.FindControl("lblCokeType");
        //            //if (lblCokeType != null)
        //            //{
        //            //    try
        //            //    {
        //            //        lblCokeType.Text = ML_Common.string2Eclips(lblCokeType.Text, 30);
        //            //    }
        //            //    catch (Exception ex)
        //            //    {
        //            //        lblCokeType.Text = string.Empty;
        //            //        Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //            //    }
        //            //}


        //            //Label lblRemarks = (Label)e.Row.FindControl("lblRemarks");
        //            //if (lblRemarks != null)
        //            //{
        //            //    try
        //            //    {
        //            //        lblRemarks.Text = ML_Common.string2Eclips(lblRemarks.Text, 30);
        //            //    }
        //            //    catch (Exception ex)
        //            //    {
        //            //        lblRemarks.Text = string.Empty;
        //            //        Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //            //    }
        //            //}


                   
        //        }
        //        catch (Exception ex)
        //        {
        //            Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //        }
        //    }
                      
        //}

        //protected void grdCokeType_RowDeleting(object sender, GridViewDeleteEventArgs e)
        //{
        //    try
        //    {
        //        // Guid  guid = ML_Common.String2Guid(grdCokeType.DataKeys[e.RowIndex].Values[0].ToString()); 
        //        int lngId = ML_Common.string2int(grdCokeType.DataKeys[e.RowIndex].Values[0].ToString());
        //        DeleteGridRowItem(lngId);
        //        ViewState["grdCokeType"] = null;
        //        FillGrid();
        //        FormFieldsClear();
        //        //PanelEditFormDisplay(false); 
        //        lblMsg.Visible = true;
        //        lblMsg.Text = string.Empty;
        //    }
        //    catch (Exception ex)
        //    {
        //        Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //    }
        //}

        //protected void grdCokeType_RowEditing(object sender, GridViewEditEventArgs e)
        //{
        //    try
        //    {
        //        lblMsg.Text = string.Empty;
        //        lblMsg.Visible = false;
        //        //grdCokeType.EditIndex = -1; 
        //        //grdCokeType.EditIndex = e.NewEditIndex; 
        //        // Guid  guid = ML_Common.String2Guid(grdCokeType.DataKeys[e.NewEditIndex].Values[0].ToString()); 
        //        //int lngId = ML_Common.string2int(grdCokeType.DataKeys[e.NewEditIndex].Values[0].ToString()); 
        //        int lngId = ML_Common.string2int32(grdCokeType.DataKeys[e.NewEditIndex].Values[0].ToString());
        //        if (lngId > 0)
        //        {
        //            ViewState["grdCokeTypeId"] = lngId;
        //            grdCokeType.EditIndex = -1;
        //            e.Cancel = true;
        //            FormFieldsClear();
        //            FillObjectToForm(lngId, true);
        //            UpdatePanelEdit.Update(); 
        //            ModalPopupExtenderEdit.Show(); 
        //        }
        //        else
        //        {
        //            lblMsg.Text = "Record is not exists?";
        //            lblMsg.Visible = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //    }
        //}

        //protected void grdCokeType_PageIndexChanging(object sender, GridViewPageEventArgs e)
        //{
        //    try
        //    {
        //        if (grdCokeType.EditIndex != -1)
        //        {
        //            e.Cancel = true;
        //        }
        //        else
        //        {
        //            FillGrid();
        //            grdCokeType.PageIndex = e.NewPageIndex;
        //            grdCokeType.DataBind();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //    }
        //}

        //protected void grdCokeType_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        //{
        //    try
        //    {
        //        lblMsg.Text = string.Empty;
        //        lblMsg.Visible = false;
              
        //        int lngId = ML_Common.string2int32(grdCokeType.DataKeys[e.NewSelectedIndex].Values[0].ToString());
        //        ViewState["grdCokeTypeId"] = lngId;
        //        if (lngId > 0)
        //        {
        //            FormFieldsClear();
        //            FillObjectToForm(lngId, false);
        //             UpdatePanelView.Update(); 
        //            ModalPopupExtenderView.Show(); 
        //        }
        //        else
        //        {
        //            lblMsg.Text = "Record is not exists?";
        //            lblMsg.Visible = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //    }
        //}

        //#endregion


        //#region DML Method
        //protected void btnSearch_Click(object sender, EventArgs e)
        //{
        //    lblMsg.Text = string.Empty;
        //    lblMsgEdit.Text = string.Empty;
            
        //    ViewState["grdCokeType"] =null;
        //    FillGrid();
        //}


        //protected void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    lblMsg.Text = string.Empty;
        //    lblMsgEdit.Text = string.Empty;
          

        //    if (IsValid)
        //    {
        //        //errNumber = -1; 
        //        BusinessClass objBusinessClass = new BusinessLayer.BusinessClass();
        //        int lngId = Convert.ToInt32(ViewState["grdCokeTypeId"]);
        //        ML_CokeType objML_CokeType = objBusinessClass.GetCokeTypeById(lngId);
        //        try
        //        {
        //            if (objML_CokeType != null)
        //            {
                       
                       

        //                objML_CokeType.CokeType = ML_Common.string2string(txtCokeTypeEdit.Text);
        //                objML_CokeType.Remarks = ML_Common.clean(txtRemarksEdit.Text);
        //                objML_CokeType.IsActive = ML_Common.clean(ML_Common.bit2int(true).ToString());
        //                objML_CokeType.IsArchive = ML_Common.clean(ML_Common.bit2int(false).ToString());
        //                objML_CokeType.CreatedDate = ML_Common.ToDateTimeSafe(System.DateTime.Now.ToString());
        //                objML_CokeType.CreatedBy = ML_Common.clean(string.Empty);
        //                objML_CokeType.ModifiedDate = ML_Common.ToDateTimeSafe(System.DateTime.Now.ToString());
        //                objML_CokeType.ModifiedBy = ML_Common.clean(string.Empty);
        //                int obhReturn = objBusinessClass.UpdateCokeType(objML_CokeType);
        //                if (obhReturn == 1)
        //                {
        //                    lblMsg.Visible = true;
        //                    lblMsg.Text = "Record Update Successfully";
        //                    lblMsgEdit.Text = "Record Update Successfully";
        //                    ModalPopupExtenderEdit.Hide();
        //                    lblMsgEdit.Text = string.Empty;
                            
        //                }
        //                else if (obhReturn == 2)
        //                {
        //                    lblMsg.Text = "Record Already Exists!";
        //                    lblMsgEdit.Text = "Record Already Exists!";
        //                    lblMsg.Visible = true;
        //                    ModalPopupExtenderEdit.Hide();
        //                    lblMsgEdit.Text = string.Empty;
                            
        //                }
        //                else
        //                {
        //                    lblMsg.Text = "Ooops!OtherIssue...";
        //                    lblMsgEdit.Text = "Ooops!OtherIssue...";
        //                    lblMsg.Visible = true;
        //                }
        //                FillGrid();
        //            }
        //        }
        //        catch (SqlException sqlExc)
        //        {
        //            SqlException sqlExt = sqlExc;
        //             return;

        //        }
        //        catch (Exception ex)
        //        {
        //            Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //        }
        //    }
        //}
        //protected void btnCancel_Click(object sender, EventArgs e)
        //{
        //    lblMsg.Text = string.Empty;
        //    lblMsgEdit.Text = string.Empty;
        //    try
        //    {
        //        lblMsg.Text = string.Empty;
        //        lblMsg.Visible = false;
        //        // grdCokeType.EditIndex = -1; 
        //        FormFieldsClear();
        //        FillGrid();
        //    }
        //    catch (Exception ex)
        //    {
        //        Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //    }
        //}
        //#endregion

        //#region populate
        //private void populateCokeTypeList()
        //{
        //    //objBusinessClass = new BusinessLayer.BusinessClass();
        //    //DataSet ds = objBusinessClass.GetCokeTypeDetail();
        //    //try
        //    //{
        //    //    if (ds.Tables.Count > 0)
        //    //    {
        //    //        ddlCokeType.DataTextField = "CokeType";
        //    //        ddlCokeType.DataValueField = "CokeTypeId";
        //    //        ddlCokeType.DataSource = ds;
        //    //        ddlCokeType.DataBind();
        //    //    }
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //    //}
        //}
        //#endregion
        
        //#region  BindDataTable
        //private DataTable BindCokeTypeDataTable()
        //{
        //    DataTable myDataTable = new DataTable("myDataTable");
        //    try
        //    {


        //        DataColumn ColumnId;
        //        ColumnId = new DataColumn();
        //        ColumnId.DataType = System.Type.GetType("System.String");
        //        ColumnId.ColumnName = "Id";
        //        myDataTable.Columns.Add(ColumnId);


        //        DataColumn ColumnCokeTypeId;
        //        ColumnCokeTypeId = new DataColumn();
        //        ColumnCokeTypeId.DataType = System.Type.GetType("System.String");
        //        ColumnCokeTypeId.ColumnName = "CokeTypeId";
        //        myDataTable.Columns.Add(ColumnCokeTypeId);


        //        DataColumn ColumnCokeType;
        //        ColumnCokeType = new DataColumn();
        //        ColumnCokeType.DataType = System.Type.GetType("System.String");
        //        ColumnCokeType.ColumnName = "CokeType";
        //        myDataTable.Columns.Add(ColumnCokeType);


        //        DataColumn ColumnRemarks;
        //        ColumnRemarks = new DataColumn();
        //        ColumnRemarks.DataType = System.Type.GetType("System.String");
        //        ColumnRemarks.ColumnName = "Remarks";
        //        myDataTable.Columns.Add(ColumnRemarks);


        //        DataColumn ColumnIsActive;
        //        ColumnIsActive = new DataColumn();
        //        ColumnIsActive.DataType = System.Type.GetType("System.String");
        //        ColumnIsActive.ColumnName = "IsActive";
        //        myDataTable.Columns.Add(ColumnIsActive);


        //        DataColumn ColumnIsArchive;
        //        ColumnIsArchive = new DataColumn();
        //        ColumnIsArchive.DataType = System.Type.GetType("System.String");
        //        ColumnIsArchive.ColumnName = "IsArchive";
        //        myDataTable.Columns.Add(ColumnIsArchive);


        //        DataColumn ColumnCreatedDate;
        //        ColumnCreatedDate = new DataColumn();
        //        ColumnCreatedDate.DataType = System.Type.GetType("System.String");
        //        ColumnCreatedDate.ColumnName = "CreatedDate";
        //        myDataTable.Columns.Add(ColumnCreatedDate);


        //        DataColumn ColumnCreatedBy;
        //        ColumnCreatedBy = new DataColumn();
        //        ColumnCreatedBy.DataType = System.Type.GetType("System.String");
        //        ColumnCreatedBy.ColumnName = "CreatedBy";
        //        myDataTable.Columns.Add(ColumnCreatedBy);


        //        DataColumn ColumnModifiedDate;
        //        ColumnModifiedDate = new DataColumn();
        //        ColumnModifiedDate.DataType = System.Type.GetType("System.String");
        //        ColumnModifiedDate.ColumnName = "ModifiedDate";
        //        myDataTable.Columns.Add(ColumnModifiedDate);


        //        DataColumn ColumnModifiedBy;
        //        ColumnModifiedBy = new DataColumn();
        //        ColumnModifiedBy.DataType = System.Type.GetType("System.String");
        //        ColumnModifiedBy.ColumnName = "ModifiedBy";
        //        myDataTable.Columns.Add(ColumnModifiedBy);


        //        DataColumn ColumnCreatedByUserNameId;
        //        ColumnCreatedByUserNameId = new DataColumn();
        //        ColumnCreatedByUserNameId.DataType = System.Type.GetType("System.String");
        //        ColumnCreatedByUserNameId.ColumnName = "CreatedByUserNameId";
        //        myDataTable.Columns.Add(ColumnCreatedByUserNameId);


        //    }
        //    catch (Exception ex)
        //    {
        //        Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //    }
        //    return myDataTable;
        //}
        //#endregion

        //protected void btnCokeTypeEditCancelPopup_Click(object sender, EventArgs e)
        //{
        //    ModalPopupExtenderEdit.Hide();
        //}

        //protected void btnCokeTypeViewCancelPopup_Click(object sender, EventArgs e)
        //{
        //    ModalPopupExtenderView.Hide();
        //}
    }
}
#endregion