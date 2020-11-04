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

    public partial class frmCanteenType : System.Web.UI.Page
    {
        #region Initialize the Object of the Class
        static string strId = string.Empty;
        public static string setStringFile = string.Empty;
        public static string strImgPath = string.Empty;
       // int errNumber = int.MinValue;
        BusinessClass objBusinessClass = null;
        ML_CokeType objML_CokeType = null;
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!this.Page.User.Identity.IsAuthenticated)
                {
                    FormsAuthentication.RedirectToLoginPage();
                }
                // Page.Form.Attributes.Add("enctype", "multipart//form-data");
                //if (!IsPostBack)
                //{
                    
                //}
                if (!IsPostBack)
                {
                    FillGrid();
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }

        

        #region Other Method
        private DataTable BindGridView()
        {
            DataTable dtActivityMaster = new DataTable("DtGrd");
            try
            {
                objBusinessClass = new BusinessClass();
                DataSet ds = objBusinessClass.GetCokeTypeDetail();
                if (ds.Tables.Count > 0)
                {
                    dtActivityMaster = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
            return dtActivityMaster;
        }

        private int DeleteGridRowItem(int lngId)
        {
            int returnObj = 0;
            try
            {
                objBusinessClass = new BusinessLayer.BusinessClass();
                returnObj = objBusinessClass.DeleteCokeType(lngId);
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
                DataTable DtList = BindGridView();
                if (DtList.Rows.Count > 0)
                {
                    grdCanteenMaster.DataSource = DtList;
                    grdCanteenMaster.DataBind();
                }
                else
                {
                    DtList.Rows.Add(DtList.NewRow());
                    grdCanteenMaster.DataSource = DtList;
                    grdCanteenMaster.DataBind();

                    int TotalColumns = grdCanteenMaster.Rows[0].Cells.Count;
                    grdCanteenMaster.Rows[0].Cells.Clear();
                    grdCanteenMaster.Rows[0].Cells.Add(new TableCell());
                    grdCanteenMaster.Rows[0].Cells[0].ColumnSpan = TotalColumns;
                    grdCanteenMaster.Rows[0].Cells[0].Text = "No Record Found";
                }
                UpdatePanel1.Update();
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
                //txtId.Text = string.Empty;
                //txtCokeTypeId.Text = string.Empty;
                //txtNewCanteenTypeName.Text = string.Empty;
                //txtNewRemarks.Text = string.Empty;
                //chkIsActive.Checked = true;
                //chkIsArchive.Checked = false;
                //txtCreatedByUserNameId.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }
        #endregion

        #region Event GridView
        protected void grdCanteenMaster_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if ((e.Row.RowType == DataControlRowType.DataRow) && (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate))
            {
                try
                {


                }
                catch (Exception ex)
                {
                    Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
                }
            }


            if ((e.Row.RowType == DataControlRowType.DataRow) && (e.Row.RowState == DataControlRowState.Edit || (e.Row.RowState == (DataControlRowState.Edit | DataControlRowState.Alternate))))
            {
                try
                {

                }
                catch (Exception ex)
                {
                    Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
                }
            }
        }
        protected void grdCanteenMaster_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int lngId = ML_Common.string2int(grdCanteenMaster.DataKeys[e.RowIndex].Values[0].ToString());
                DeleteGridRowItem(lngId);
                FillGrid();
                lblMsg.Visible = true;
                lblMsg.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }
        protected void grdCanteenMaster_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdCanteenMaster.EditIndex = e.NewEditIndex;
            FillGrid();
        }
        protected void grdCanteenMaster_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                if (grdCanteenMaster.EditIndex != -1)
                {
                    e.Cancel = true;
                }
                else
                {
                    FillGrid();
                    grdCanteenMaster.PageIndex = e.NewPageIndex;
                    grdCanteenMaster.DataBind();
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }
        protected void grdCanteenMaster_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }
        protected void grdCanteenMaster_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdCanteenMaster.EditIndex = -1;
            FillGrid();
        }
        protected void grdCanteenMaster_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            TextBox txtCanteenTypeNameEdit = (TextBox)grdCanteenMaster.Rows[e.RowIndex].FindControl("txtCanteenTypeNameEdit");
            //TextBox txtRemarksEdit = (TextBox)grdCanteenMaster.Rows[e.RowIndex].FindControl("txtRemarksEdit");
            CheckBox txtRemarksEdit = (CheckBox)grdCanteenMaster.Rows[e.RowIndex].FindControl("txtRemarksEdit");
            if (IsValid)
            {
                //errNumber = -1;
                BusinessClass objBusinessClass = new BusinessLayer.BusinessClass();
                int lngId = ML_Common.string2int(grdCanteenMaster.DataKeys[e.RowIndex].Values[0].ToString());
                ML_CokeType objML_CokeType = objBusinessClass.GetCokeTypeById(lngId);
                try
                {
                    if (objML_CokeType != null)
                    {


                        objML_CokeType.CokeType = ML_Common.clean(txtCanteenTypeNameEdit.Text);

                        objML_CokeType.Remarks = ML_Common.clean(txtRemarksEdit.Text);

                        int obhReturn = objBusinessClass.UpdateCokeType(objML_CokeType);
                        if (obhReturn == 1)
                        {
                            lblMsg.Visible = true;
                            lblMsg.Text = "Record Update Successfully";

                        }
                        else if (obhReturn == 2)
                        {
                            lblMsg.Text = "Ooops!OtherIssue...";
                            lblMsg.Visible = true;
                        }
                        else
                        {
                            lblMsg.Text = "Ooops!OtherIssue...";
                            lblMsg.Visible = true;
                        }
                        grdCanteenMaster.EditIndex = -1;
                        FillGrid();
                    }
                }
                catch (SqlException sqlExc)
                {
                    SqlException sqlEt = sqlExc;
                    return;
                }
                catch (Exception ex)
                {
                    Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
                }

            }
        }
        protected void grdCanteenMaster_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("ADD"))
            {

                TextBox txtNewCanteenTypeName = (TextBox)grdCanteenMaster.FooterRow.FindControl("txtNewCanteenTypeName");

                CheckBox txtNewRemarks = (CheckBox)grdCanteenMaster.FooterRow.FindControl("txtNewRemarks");
                if (IsValid)
                {
                    //errNumber = -1;
                    try
                    {
                        objBusinessClass = new BusinessLayer.BusinessClass();
                        objML_CokeType = new ML_CokeType();

                        objML_CokeType.CokeType = ML_Common.clean(txtNewCanteenTypeName.Text);
                        objML_CokeType.Remarks = ML_Common.clean(txtNewRemarks.Text);
                        objML_CokeType.IsActive = ML_Common.clean(ML_Common.bit2int(false).ToString());
                        objML_CokeType.IsArchive = ML_Common.clean(ML_Common.bit2int(false).ToString());
                        objML_CokeType.CreatedDate = ML_Common.ToDateTimeSafe(System.DateTime.Now.ToString());
                        objML_CokeType.CreatedBy = Session["UserName"].ToString();
                        objML_CokeType.ModifiedDate = ML_Common.ToDateTimeSafe(System.DateTime.Now.ToString());
                        objML_CokeType.ModifiedBy = ML_Common.clean(string.Empty);

                        int obhReturn = objBusinessClass.AddCokeType(objML_CokeType);

                        if (obhReturn == 1)
                        {
                            lblMsg.Visible = true;
                            lblMsg.Text = "Record Saved Successfully";
                            FillGrid();
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
                        SqlException sqlEt = sqlExc;
                        return;
                    }
                    catch (Exception ex)
                    {
                        Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                    }
                }

            }
        }

        #endregion
        
    }
}