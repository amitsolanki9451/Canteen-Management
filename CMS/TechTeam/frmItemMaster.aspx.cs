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
    public partial class frmItemMaster : System.Web.UI.Page
    {
        #region Initialize the Object of the Class
        static string strId = string.Empty;
        public static string setStringFile = string.Empty;
        public static string strImgPath = string.Empty;
        // int errNumber = int.MinValue;
        BusinessClass objBusinessClass = null;
        ML_ItemMaster objML_ItemMaster = null;
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
                    grdItemMaster.DataSource = DtList;
                    grdItemMaster.DataBind();
                }
                else
                {
                    DtList.Rows.Add(DtList.NewRow());
                    grdItemMaster.DataSource = DtList;
                    grdItemMaster.DataBind();

                    int TotalColumns = grdItemMaster.Rows[0].Cells.Count;
                    grdItemMaster.Rows[0].Cells.Clear();
                    grdItemMaster.Rows[0].Cells.Add(new TableCell());
                    grdItemMaster.Rows[0].Cells[0].ColumnSpan = TotalColumns;
                    grdItemMaster.Rows[0].Cells[0].Text = "No Record Found";
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
        protected void grdItemMaster_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)  //&& (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate)
            {
                DataSet ds = null;
                try
                {
                    DropDownList ddlNewCanteenName = (DropDownList)e.Row.FindControl("ddlNewCanteenName");                    
                    DropDownList ddlNewCategoryGroupCode = (DropDownList)e.Row.FindControl("ddlNewCategoryGroupCode");                    
                    DropDownList ddlNewCategoryItemCode = (DropDownList)e.Row.FindControl("ddlNewCategoryItemCode");                   

                    if (ViewState["CanteenName"] == null)
                    {
                        BL_CanteenMaster objBL_CanteenName = new BL_CanteenMaster();

                        ds = objBL_CanteenName.GetCanteenMaster(); ;

                        ViewState["CanteenName"] = ds;
                    }

                    if (ddlNewCanteenName.Items.Count > 0)
                    {
                        ddlNewCanteenName.Items.Clear();
                    }
                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        ddlNewCanteenName.DataTextField = "CanteenName";
                        ddlNewCanteenName.DataValueField = "CanteenCode";
                        ddlNewCanteenName.DataSource = ds;
                        ddlNewCanteenName.DataBind();
                    }
                    ddlNewCanteenName.Items.Insert(0, new ListItem("-- Select --", "-1"));



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




                    if (ViewState["CategoryItemCode"] == null)
                    {
                        BL_CanteenMaster objBL_CanteenName = new BL_CanteenMaster();

                        ds = objBL_CanteenName.GetCanteenMaster(); ;

                        ViewState["CategoryItemCode"] = ds;
                    }

                    if (ddlNewCategoryItemCode.Items.Count > 0)
                    {
                        ddlNewCategoryItemCode.Items.Clear();
                    }
                    if (ds != null && ds.Tables[0].Rows.Count > 0)
                    {
                        ddlNewCategoryItemCode.DataTextField = "CanteenName";
                        ddlNewCategoryItemCode.DataValueField = "CanteenCode";
                        ddlNewCategoryItemCode.DataSource = ds;
                        ddlNewCategoryItemCode.DataBind();
                    }
                    ddlNewCategoryItemCode.Items.Insert(0, new ListItem("-- Select --", "-1"));
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

        protected void grdItemMaster_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdItemMaster.EditIndex = e.NewEditIndex;
            FillGrid();
        }

        protected void grdItemMaster_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int lngId = ML_Common.string2int(grdItemMaster.DataKeys[e.RowIndex].Values[0].ToString());
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

        protected void grdItemMaster_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                if (grdItemMaster.EditIndex != -1)
                {
                    e.Cancel = true;
                }
                else
                {
                    FillGrid();
                    grdItemMaster.PageIndex = e.NewPageIndex;
                    grdItemMaster.DataBind();
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }

        protected void grdItemMaster_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }

        protected void grdItemMaster_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdItemMaster.EditIndex = -1;
            FillGrid();
        }

        protected void grdItemMaster_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            DropDownList ddlCanteenName = (DropDownList)grdItemMaster.Rows[e.RowIndex].FindControl("ddlCanteenName");
            DropDownList ddlCategoryGroupCode = (DropDownList)grdItemMaster.Rows[e.RowIndex].FindControl("ddlCategoryGroupCode");
            DropDownList ddlCategoryItemCode = (DropDownList)grdItemMaster.Rows[e.RowIndex].FindControl("ddlCategoryItemCode");

            TextBox txtItemNameEdit = (TextBox)grdItemMaster.Rows[e.RowIndex].FindControl("txtItemNameEdit");
            TextBox txtItemEmployeeRateEdit = (TextBox)grdItemMaster.Rows[e.RowIndex].FindControl("txtItemEmployeeRateEdit");
            CheckBox ChStatusEdit = (CheckBox)grdItemMaster.Rows[e.RowIndex].FindControl("ChStatusEdit");
            if (IsValid)
            {
                //errNumber = -1;
                BusinessClass objBusinessClass = new BusinessLayer.BusinessClass();
                int lngId = ML_Common.string2int(grdItemMaster.DataKeys[e.RowIndex].Values[0].ToString());
                ML_ItemMaster objML_ItemMaster = objBusinessClass.GetItemMasterByItemCode(lngId);
                try
                {
                    if (objML_ItemMaster != null)
                    {
                        objML_ItemMaster.CanteenCode = Convert.ToInt32(ML_Common.clean(ddlCanteenName.SelectedValue));
                        objML_ItemMaster.CategoryGroupCode = Convert.ToInt32(ML_Common.clean(ddlCategoryGroupCode.SelectedValue));
                        objML_ItemMaster.ItemCategoryCode = Convert.ToInt32(ML_Common.clean(ddlCategoryItemCode.SelectedValue));
                        objML_ItemMaster.ItemName = ML_Common.clean(txtItemNameEdit.Text);
                        objML_ItemMaster.ItemEmployeeRate = Convert.ToDecimal(ML_Common.clean(txtItemEmployeeRateEdit.Text));
                        if (ChStatusEdit.Checked)
                        {
                            objML_ItemMaster.ItemActive = 1;
                        }
                        else { objML_ItemMaster.ItemActive = 0; }



                        int obhReturn = objBusinessClass.UpdateItemMaster(objML_ItemMaster);
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
                        grdItemMaster.EditIndex = -1;
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

        protected void grdItemMaster_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("ADD"))
            {
                DropDownList ddlNewCanteenName = (DropDownList)grdItemMaster.FooterRow.FindControl("ddlNewCanteenName");
                DropDownList ddlNewCategoryGroupCode = (DropDownList)grdItemMaster.FooterRow.FindControl("ddlNewCategoryGroupCode");
                DropDownList ddlNewCategoryItemCode = (DropDownList)grdItemMaster.FooterRow.FindControl("ddlNewCategoryItemCode");

                TextBox txtNewItemName = (TextBox)grdItemMaster.FooterRow.FindControl("txtNewItemName");
                TextBox txtNewItemEmployeeRate = (TextBox)grdItemMaster.FooterRow.FindControl("txtNewItemEmployeeRate");
                CheckBox ChStatusNew = (CheckBox)grdItemMaster.FooterRow.FindControl("ChStatusNew");
                if (IsValid)
                {
                    //errNumber = -1;
                    try
                    {
                        objBusinessClass = new BusinessLayer.BusinessClass();
                        objML_ItemMaster = new ML_ItemMaster();

                        objML_ItemMaster.CanteenCode = Convert.ToInt32(ML_Common.clean(ddlNewCanteenName.SelectedValue));
                        objML_ItemMaster.CategoryGroupCode = Convert.ToInt32(ML_Common.clean(ddlNewCategoryGroupCode.SelectedValue));
                        objML_ItemMaster.ItemCategoryCode = Convert.ToInt32(ML_Common.clean(ddlNewCategoryItemCode.SelectedValue));
                        objML_ItemMaster.ItemName = ML_Common.clean(txtNewItemName.Text);
                        objML_ItemMaster.ItemEmployeeRate = Convert.ToDecimal(ML_Common.clean(txtNewItemEmployeeRate.Text));
                        if (ChStatusNew.Checked)
                        {
                            objML_ItemMaster.ItemActive = 1;
                        }
                        else { objML_ItemMaster.ItemActive = 0; }

                        int obhReturn = objBusinessClass.AddItemMaster(objML_ItemMaster);

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