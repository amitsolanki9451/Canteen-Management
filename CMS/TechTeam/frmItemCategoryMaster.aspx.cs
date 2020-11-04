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
using BusinessLayer.BusinessClasses;

namespace CMS.TechTeam
{
    public partial class frmItemCategoryMaster : System.Web.UI.Page
    {
        #region Initialize the Object of the Class
        static string strId = string.Empty;
        public static string setStringFile = string.Empty;
        public static string strImgPath = string.Empty;
        // int errNumber = int.MinValue;
        BusinessClass objBusinessClass = null;
        ML_ItemCategoryMaster objML_ItemCategoryMaster = null;
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
                DataSet ds = objBusinessClass.GetItemMasterDetail();
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
                returnObj = objBusinessClass.DeleteItemMasterByItemCode(lngId);
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
                    grdItemCategoryMaster.DataSource = DtList;
                    grdItemCategoryMaster.DataBind();
                }
                else
                {
                    DtList.Rows.Add(DtList.NewRow());
                    grdItemCategoryMaster.DataSource = DtList;
                    grdItemCategoryMaster.DataBind();

                    int TotalColumns = grdItemCategoryMaster.Rows[0].Cells.Count;
                    grdItemCategoryMaster.Rows[0].Cells.Clear();
                    grdItemCategoryMaster.Rows[0].Cells.Add(new TableCell());
                    grdItemCategoryMaster.Rows[0].Cells[0].ColumnSpan = TotalColumns;
                    grdItemCategoryMaster.Rows[0].Cells[0].Text = "No Record Found";
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
            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }
        #endregion

        #region Event GridView
        protected void grdItemCategoryMaster_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if ((e.Row.RowType == DataControlRowType.DataRow) && (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate))
            {
                DataSet ds = null;
                try
                {
                    DropDownList ddlNewCategoryGroupCode = (DropDownList)e.Row.FindControl("ddlNewCategoryGroupCode");
                    DropDownList ddlCanteenName = (DropDownList)e.Row.FindControl("ddlCanteenName");
                    DropDownList ddlNewStartTime = (DropDownList)e.Row.FindControl("ddlNewStartTime");
                    DropDownList ddlNewEndTime = (DropDownList)e.Row.FindControl("ddlNewEndTime");

                    if (ViewState["CategoryGroup"] == null)
                    {
                        BL_CanteenMaster objBL_CanteenName = new BL_CanteenMaster();

                        ds = objBL_CanteenName.GetCanteenMaster(); ;

                        ViewState["CanteenName"] = ds;
                    }
                    if (ddlNewCategoryGroupCode.Items.Count > 0)
                    {
                        ddlNewCategoryGroupCode.Items.Clear();
                    }
                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        ddlNewCategoryGroupCode.DataTextField = "CanteenName";
                        ddlNewCategoryGroupCode.DataValueField = "CanteenCode";
                        ddlNewCategoryGroupCode.DataSource = ds;
                        ddlNewCategoryGroupCode.DataBind();
                    }
                    ddlNewCategoryGroupCode.Items.Insert(0, new ListItem("-- Select --", "-1"));

                    if (ViewState["CanteenName"] == null)
                    {
                        BL_CanteenMaster objBL_CanteenName = new BL_CanteenMaster();

                        ds = objBL_CanteenName.GetCanteenMaster(); ;

                        ViewState["CanteenName"] = ds;
                    }
                    if (ddlCanteenName.Items.Count > 0)
                    {
                        ddlCanteenName.Items.Clear();
                    }
                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        ddlCanteenName.DataTextField = "CanteenName";
                        ddlCanteenName.DataValueField = "CanteenCode";
                        ddlCanteenName.DataSource = ds;
                        ddlCanteenName.DataBind();
                    }
                    ddlCanteenName.Items.Insert(0, new ListItem("-- Select --", "-1"));

                    if (ViewState["StartTime"] == null)
                    {
                        BL_CanteenMaster objBL_CanteenName = new BL_CanteenMaster();

                        ds = objBL_CanteenName.GetCanteenMaster(); ;

                        ViewState["StartTime"] = ds;
                    }
                    if (ddlNewStartTime.Items.Count > 0)
                    {
                        ddlNewStartTime.Items.Clear();
                    }
                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        ddlNewStartTime.DataTextField = "CanteenName";
                        ddlNewStartTime.DataValueField = "CanteenCode";
                        ddlNewStartTime.DataSource = ds;
                        ddlNewStartTime.DataBind();
                    }
                    ddlNewStartTime.Items.Insert(0, new ListItem("-- Select --", "-1"));

                    if (ViewState["EndTime"] == null)
                    {
                        BL_CanteenMaster objBL_CanteenName = new BL_CanteenMaster();

                        ds = objBL_CanteenName.GetCanteenMaster(); ;

                        ViewState["EndTime"] = ds;
                    }
                    if (ddlNewEndTime.Items.Count > 0)
                    {
                        ddlNewEndTime.Items.Clear();
                    }
                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        ddlNewEndTime.DataTextField = "CanteenName";
                        ddlNewEndTime.DataValueField = "CanteenCode";
                        ddlNewEndTime.DataSource = ds;
                        ddlNewEndTime.DataBind();
                    }
                    ddlNewStartTime.Items.Insert(0, new ListItem("-- Select --", "-1"));
                }
                catch (Exception ex)
                {
                    Exception exc = ex;
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

        protected void grdItemCategoryMaster_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdItemCategoryMaster.EditIndex = e.NewEditIndex;
            FillGrid();
        }

        protected void grdItemCategoryMaster_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int lngId = ML_Common.string2int(grdItemCategoryMaster.DataKeys[e.RowIndex].Values[0].ToString());
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

        protected void grdItemCategoryMaster_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                if (grdItemCategoryMaster.EditIndex != -1)
                {
                    e.Cancel = true;
                }
                else
                {
                    FillGrid();
                    grdItemCategoryMaster.PageIndex = e.NewPageIndex;
                    grdItemCategoryMaster.DataBind();
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }

        }

        protected void grdItemCategoryMaster_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }

        protected void grdItemCategoryMaster_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdItemCategoryMaster.EditIndex = -1;
            FillGrid();
        }

        protected void grdItemCategoryMaster_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            DropDownList ddlNewCategoryGroupCode = (DropDownList)grdItemCategoryMaster.Rows[e.RowIndex].FindControl("ddlNewCategoryGroupCode");
            DropDownList ddlNewCanteenName = (DropDownList)grdItemCategoryMaster.Rows[e.RowIndex].FindControl("ddlNewCanteenName");

            TextBox txtNewItemCategoryName = (TextBox)grdItemCategoryMaster.Rows[e.RowIndex].FindControl("txtNewItemCategoryName");
            CheckBox ChStatusNew = (CheckBox)grdItemCategoryMaster.Rows[e.RowIndex].FindControl("ChStatusNew");

            DropDownList ddlNewStartTime = (DropDownList)grdItemCategoryMaster.Rows[e.RowIndex].FindControl("ddlNewStartTime");
            DropDownList ddlNewEndTime = (DropDownList)grdItemCategoryMaster.Rows[e.RowIndex].FindControl("ddlNewEndTime");
            if (IsValid)
            {
                //errNumber = -1;
                BusinessClass objBusinessClass = new BusinessLayer.BusinessClass();
                int lngId = ML_Common.string2int(grdItemCategoryMaster.DataKeys[e.RowIndex].Values[0].ToString());
                ML_ItemCategoryMaster objML_ItemCategoryMaster = objBusinessClass.GetItemCategoryMasterByItemCategoryCode(lngId);
                try
                {
                    if (objML_ItemCategoryMaster != null)
                    {

                        objML_ItemCategoryMaster.CategoryGroupCode = Convert.ToInt32(ML_Common.clean(ddlNewCategoryGroupCode.SelectedValue));
                        objML_ItemCategoryMaster.CanteenCode = Convert.ToInt32(ML_Common.clean(ddlNewCanteenName.SelectedValue));
                        objML_ItemCategoryMaster.ItemCategoryName = ML_Common.clean(txtNewItemCategoryName.Text);
                        objML_ItemCategoryMaster.StartTime = Convert.ToDateTime(ML_Common.clean(ddlNewStartTime.SelectedValue));
                        objML_ItemCategoryMaster.EndTime = Convert.ToDateTime(ML_Common.clean(ddlNewEndTime.Text));
                        if (ChStatusNew.Checked)
                        {
                            objML_ItemCategoryMaster.ItemCategoryActive = 1;
                        }
                        else { objML_ItemCategoryMaster.ItemCategoryActive = 0; }



                        int obhReturn = objBusinessClass.UpdateItemCategoryMaster(objML_ItemCategoryMaster);
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
                        grdItemCategoryMaster.EditIndex = -1;
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

        protected void grdItemCategoryMaster_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("ADD"))
            {
                DropDownList ddlNewCategoryGroupCode = (DropDownList)grdItemCategoryMaster.FooterRow.FindControl("ddlNewCategoryGroupCode");
                DropDownList ddlNewCanteenName = (DropDownList)grdItemCategoryMaster.FooterRow.FindControl("ddlNewCanteenName");

                TextBox txtNewItemCategoryName = (TextBox)grdItemCategoryMaster.FooterRow.FindControl("txtNewItemCategoryName");
                CheckBox ChStatusNew = (CheckBox)grdItemCategoryMaster.FooterRow.FindControl("ChStatusNew");

                DropDownList ddlNewStartTime = (DropDownList)grdItemCategoryMaster.FooterRow.FindControl("ddlNewStartTime");
                DropDownList ddlNewEndTime = (DropDownList)grdItemCategoryMaster.FooterRow.FindControl("ddlNewEndTime");

                if (IsValid)
                {
                    //errNumber = -1;
                    try
                    {
                        objBusinessClass = new BusinessLayer.BusinessClass();
                        objML_ItemCategoryMaster = new ML_ItemCategoryMaster();

                        objML_ItemCategoryMaster.CategoryGroupCode = Convert.ToInt32(ML_Common.clean(ddlNewCategoryGroupCode.SelectedValue));
                        objML_ItemCategoryMaster.CanteenCode = Convert.ToInt32(ML_Common.clean(ddlNewCanteenName.SelectedValue));
                        objML_ItemCategoryMaster.ItemCategoryName = ML_Common.clean(txtNewItemCategoryName.Text);
                        objML_ItemCategoryMaster.StartTime = Convert.ToDateTime(ML_Common.clean(ddlNewStartTime.SelectedValue));
                        objML_ItemCategoryMaster.EndTime = Convert.ToDateTime(ML_Common.clean(ddlNewEndTime.Text));
                        if (ChStatusNew.Checked)
                        {
                            objML_ItemCategoryMaster.ItemCategoryActive = 1;
                        }
                        else { objML_ItemCategoryMaster.ItemCategoryActive = 0; }

                        int obhReturn = objBusinessClass.AddItemCategoryMaster(objML_ItemCategoryMaster);

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