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
//using ClosedXML.Excel;
using System.Drawing;
using Microsoft.Reporting.WebForms;

namespace SCMakingCenterLine
{
    public partial class frmReportDetail : System.Web.UI.Page
    {
        #region Initialize the Object of the Class
        static string strSanitizationSGP125TDataId = string.Empty;
        BusinessClass objBusinessClass = null;
        ML_SanitizationSGP125TData objML_SanitizationSGP125TData = null;
        ML_SanitizationReport objML_SanitizationReport = null;

        public static Guid strSanitizationSGP125TDataGuid = Guid.Empty;
        public static string setStringFile = string.Empty;
        public static string strImgPath = string.Empty;
        int errNumber = int.MinValue;
        #endregion

        #region Page Event
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
               
                if (Session["UserName"] == null)
                {
                    Response.Redirect("Login.aspx", false); 
                }
                if (!IsPostBack)
                {
                    //WriteUserActivity("Enter Report Sumary", "Success");
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;
            }
        }
        #endregion

        #region Other Methods
        private DataTable BindGridView()
        {
            DataTable dtSanitizationSGP125TData = new DataTable("DtGrd");
            try
            {
                objBusinessClass = new BusinessClass();
                DataSet ds = objBusinessClass.GetSanitizationSGP125TDataDetail();
                if (ds.Tables.Count > 0)
                {
                    dtSanitizationSGP125TData = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;
            }
            return dtSanitizationSGP125TData;
        }

        private DataTable BindGridViewBySearch(ML_SanitizationReport objML_SanitizationReport)
        {
            DataTable dtSanitizationSGP125TData = new DataTable("GridSearch");
            try
            {
                DataSet ds = null;
                objBusinessClass = new BusinessLayer.BusinessClass();

                if (objML_SanitizationReport.ReportType=="")
                {

                }

                ds = objBusinessClass.GetSCSanitizationReportBySeacrh(objML_SanitizationReport);
                if (ds.Tables.Count > 0)
                {
                    dtSanitizationSGP125TData = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;
            }
            return dtSanitizationSGP125TData;
        }



        private int DeleteGridRowItem(long lngId)
        {
            int returnObj = 0;
            try
            {
                objBusinessClass = new BusinessLayer.BusinessClass();
                returnObj = objBusinessClass.DeleteSanitizationSGP125TData(lngId);
            }
            catch (Exception ex)
            {
                Exception exc = ex;
            }
            return returnObj;
        }

        private void FillGrid()
        {
            try
            {
                DataTable DtList = null;

                ML_SanitizationReport objML_SanitizationReportSearch = new ML_SanitizationReport();

                if (ddlReportTypeSearch.SelectedIndex > 0 && !string.IsNullOrEmpty(txtFromDateSearch.Text) && !string.IsNullOrEmpty(txtToDateSearch.Text))
                {
                        objML_SanitizationReportSearch.ReportType = ML_Common.GetDropDownValue(ddlReportTypeSearch, true);
                        objML_SanitizationReportSearch.TagStatus = null;
                       
                        DateTime FromDateSearch = ML_Common.ToDateTimeSafe(txtFromDateSearch.Text);
                        DateTime ToDateSearch = ML_Common.ToDateTimeSafe(txtToDateSearch.Text);
                         
                        var FromTimeSearch = TimeSpan.Parse("00:00:00");
                        var FromFullDt = FromDateSearch + FromTimeSearch; // 2010-06-26 01:16:50

                        var ToTimeSearch = TimeSpan.Parse("23:59:59");
                        var ToFullDt = ToDateSearch + ToTimeSearch; // 2010-06-26 01:16:50

                        var From24Hour = FromFullDt.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.CurrentCulture);
                        var To24Hour = ToFullDt.ToString("MM/dd/yyyy HH:mm:ss", CultureInfo.CurrentCulture);
                                            

                        objML_SanitizationReportSearch.FromDate = ML_Common.ToDateTimeSafeNull(From24Hour.ToString());
                        objML_SanitizationReportSearch.ToDate = ML_Common.ToDateTimeSafeNull(To24Hour.ToString());
                    
                    DtList = BindGridViewBySearch(objML_SanitizationReportSearch);
                }

                
                if (DtList != null)
                {
                    //DtList = (DataTable)ViewState["grdSanitizationReportTM"];
                    if (DtList.Rows.Count > 0)
                    {
                        grdSanitizationReport.DataSource = DtList;
                        grdSanitizationReport.DataBind();
                    }
                    else
                    {
                        DtList.Rows.Add(DtList.NewRow());
                        grdSanitizationReport.DataSource = DtList;
                        grdSanitizationReport.DataBind();

                        int TotalColumns = grdSanitizationReport.Rows[0].Cells.Count;
                        grdSanitizationReport.Rows[0].Cells.Clear();
                        grdSanitizationReport.Rows[0].Cells.Add(new TableCell());
                        grdSanitizationReport.Rows[0].Cells[0].ColumnSpan = TotalColumns;
                        grdSanitizationReport.Rows[0].Cells[0].Text = "No Record Found";
                    }
                    UpdatePanelGrid.Update();
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;
            }
        }



        private void FillObjectToForm(long lngId, bool IsEditFlag = true)
        {
            objBusinessClass = new BusinessLayer.BusinessClass();           
            try
            {
                if (ViewState["ReportType"] != null && ViewState["grdSanitizationReportId"] !=null)
                {
                    
                    string ReportType = ML_Common.string2string(ViewState["ReportType"].ToString());
                    lngId = ML_Common.string2Long(ViewState["grdSanitizationReportId"].ToString());

                   // string ReportType = ML_Common.GetDropDownValue(ddlReportTypeSearch, true);
                    ML_SanitizationReport objML_SanitizationReport = objBusinessClass.GetSCSanitizationResultByReportTypeandId(lngId, ReportType);

                    if (objML_SanitizationReport != null)
                    {
                        //ViewState["SanitizationResultId"] = objML_SanitizationReport.SanitizationResultId;
                        //ViewState["SanitizationStartDate"] = objML_SanitizationReport.SanitizationStartDate;
                        //ViewState["SanitizationEndDate"] = objML_SanitizationReport.SanitizationEndDate;
                        //FillGridForData();
                        ShowReport(objML_SanitizationReport.Id, objML_SanitizationReport.ReportType);
                    }
                    //UpdatePanelGridResult.Update();
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;
            }
        }


        public void FormFieldsClear()
        {
            //try
            //{
              

            //}
            //catch (Exception ex)
            //{
            //    Exception exc = ex;
            //}
        }



        #endregion

        #region Event GridView Result
        protected void grdSanitizationReport_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if ((e.Row.RowType == DataControlRowType.DataRow))// && (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate))
            {
                try
                {
                    #region fields
                    //Label lblDateAndTime = (Label)e.Row.FindControl("lblDateAndTime");
                    Label lblSanitizationStartDate = (Label)e.Row.FindControl("lblSanitizationStartDate");
                    Label lblSanitizationEndDate = (Label)e.Row.FindControl("lblSanitizationEndDate");                    

                    Label lblTagStatus = (Label)e.Row.FindControl("lblTagStatus");
                    Label lblHoldTimeInMinute = (Label)e.Row.FindControl("lblHoldTimeInMinute");

                    try
                    {
                        if (lblTagStatus != null && lblSanitizationEndDate != null && lblHoldTimeInMinute != null)
                        {
                            lblTagStatus.ForeColor = Color.White;
                            lblHoldTimeInMinute.ForeColor = Color.White;
                            if (ML_Common.string2Decimal(lblHoldTimeInMinute.Text) >= 5 && !string.IsNullOrEmpty(lblSanitizationEndDate.Text))
                            {
                                lblTagStatus.Text = "Pass";
                                e.Row.Cells[11].BackColor = Color.Green;
                                e.Row.Cells[12].BackColor = Color.Green;
                            }
                            else
                            {
                                lblTagStatus.Text = "Fail";
                                e.Row.Cells[11].BackColor = Color.Red;
                                e.Row.Cells[12].BackColor = Color.Red;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Exception exc = ex;
                    }


                    Label lblIsConfirm = (Label)e.Row.FindControl("lblIsConfirm");
                    if (lblIsConfirm != null)
                    {
                        try
                        {
                            if (!string.IsNullOrEmpty(lblIsConfirm.Text))
                            {
                                if (lblIsConfirm.Text.Trim() == "1" || lblIsConfirm.Text.Trim().ToLower() == "true")
                                {
                                    lblIsConfirm.ForeColor = Color.White;
                                    lblIsConfirm.Text = "Completed";
                                    e.Row.Cells[13].BackColor = Color.Green;
                                }
                                else
                                {
                                    lblIsConfirm.ForeColor = Color.White;
                                    lblIsConfirm.Text = "Pending";
                                    e.Row.Cells[13].BackColor = Color.Red;
                                }
                            }
                            else
                            {
                                lblIsConfirm.ForeColor = Color.White;
                                lblIsConfirm.Text = "Pending";
                                e.Row.Cells[13].BackColor = Color.Red;
                            }
                        }
                        catch (Exception ex)
                        {
                            Exception exc = ex;
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
                            Exception exc = ex;
                        }
                    }

                    #endregion



                }
                catch (Exception ex)
                {
                    Exception exc = ex;
                }
            }            
            
        }

        protected void grdSanitizationReport_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                // Guid  guid = ML_Common.String2Guid(grdSanitizationReport.DataKeys[e.RowIndex].Values[0].ToString()); 
                long lngId = ML_Common.string2Long(grdSanitizationReport.DataKeys[e.RowIndex].Values[0].ToString());
               
                DeleteGridRowItem(lngId);
                ViewState["grdSanitizationReport"] = null;
                FillGrid();
                FormFieldsClear();
                //PanelEditFormDisplay(false); 
               
                lblMsg.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Exception exc = ex;
            }
        }

        protected void grdSanitizationReport_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
               
                
                int lngId = ML_Common.string2int32(grdSanitizationReport.DataKeys[e.NewEditIndex].Values[0].ToString());
                if (lngId > 0)
                {


                    ViewState["grdSanitizationReportId"] = lngId;
                    grdSanitizationReport.EditIndex = -1;
                    e.Cancel = true;
                    //FormFieldsClear();
                    // FillObjectToForm(lngId, true);

                  //  UpdatePanelMsg.Update();
                   // ModalPopupExtenderMsg.Show();
                    
                }
                else
                {
                    lblMsg.Text = "Record is not exists?";
                   
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;
            }
        }

        protected void grdSanitizationReport_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                if (grdSanitizationReport.EditIndex != -1)
                {
                    e.Cancel = true;
                }
                else
                {
                    FillGrid();
                    grdSanitizationReport.PageIndex = e.NewPageIndex;
                    grdSanitizationReport.DataBind();
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;
            }
        }

        protected void grdSanitizationReport_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;  
                int lngId = ML_Common.string2int32(grdSanitizationReport.DataKeys[e.NewSelectedIndex].Values[0].ToString());
                string ReportType = ML_Common.string2string(grdSanitizationReport.DataKeys[e.NewSelectedIndex].Values[2].ToString());
                ViewState["grdSanitizationReportId"] = lngId;
                ViewState["ReportType"] = ReportType;
                if (lngId > 0)
                {

                    FillObjectToForm(lngId,false);                   
                   // ModalPopupExtenderView.Show();
                }
                else
                {
                    lblMsg.Text = "Record is not exists?";
                   
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;
            }
        }

        #endregion


        #region Other Methods Result

        private DataTable BindGridViewByResult(ML_SanitizationReport objML_SanitizationReport)
        {
            DataTable dtSanitizationSGP125TResult = new DataTable("GridSearch");
            try
            {
                objBusinessClass = new BusinessLayer.BusinessClass();
                DataSet ds = null;// objBusinessClass.GetSanitizationSGP125TResultBySeacrh(objML_SanitizationReport);
                if (ds.Tables.Count > 0)
                {
                    dtSanitizationSGP125TResult = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;
            }
            return dtSanitizationSGP125TResult;
        }

        private DataTable FillGridChild()
        {
            DataTable DtListResult = null;
            try
            {

                DataSet ds = null;
               
                objBusinessClass = new BusinessLayer.BusinessClass();

                if (ViewState["SanitizationResultId"] != null && ViewState["SanitizationStartDate"] != null && ViewState["SanitizationEndDate"] != null)
                {
                    long SanitizationResultId = (long)ViewState["SanitizationResultId"];
                    DateTime FromDate = (DateTime)ViewState["SanitizationStartDate"];
                    DateTime ToDate = (DateTime)ViewState["SanitizationEndDate"];

                    ds = objBusinessClass.GetSanitizationSGP125TDataBySanitizationResultIdnSanitizationStartDatenSanitizationEndDateDs(SanitizationResultId, FromDate, ToDate);
                    if (ds != null)
                    {
                        if (ds.Tables.Count > 0)
                        {
                            DtListResult = ds.Tables[0];
                        }
                    }
                }
                

            }
            catch (Exception ex)
            {
                Exception exx = ex;
            }

            return DtListResult;
        }

    
        #endregion

        protected void Show_Hide_OrdersGrid(object sender, EventArgs e)
        {
            ImageButton imgShowHide = (sender as ImageButton);
            GridViewRow row = (imgShowHide.NamingContainer as GridViewRow);
            if (imgShowHide.CommandArgument == "Show")
            {
                row.FindControl("pnlOrders").Visible = true;
                imgShowHide.CommandArgument = "Hide";
                imgShowHide.ImageUrl = "~/images/minus.png";

                //DataKey arr = grdSanitizationReport.DataKeys[row.RowIndex];

                //DataKeyArray arr2 = grdSanitizationReport.DataKeyNames

                string SanitizationResultId = grdSanitizationReport.DataKeys[row.RowIndex].Values[1].ToString();
                string SanitizationStartDate = grdSanitizationReport.DataKeys[row.RowIndex].Values[2].ToString();
                string SanitizationEndDate = grdSanitizationReport.DataKeys[row.RowIndex].Values[3].ToString();




                ViewState["SanitizationResultId"] = null;
                ViewState["SanitizationStartDate"] = null;
                ViewState["SanitizationEndDate"] = null;

               
               // long SanitizationResultId = (long)ViewState["SanitizationResultId"];
                ViewState["SanitizationResultId"] = ML_Common.string2Long(SanitizationResultId);
                ViewState["SanitizationStartDate"] = ML_Common.ToDateTimeSafe(SanitizationStartDate);
                ViewState["SanitizationEndDate"] = ML_Common.ToDateTimeSafe(SanitizationEndDate);
                
                GridView gvChild = row.FindControl("grdSanitizationSGP125TData") as GridView;
                BindChildGrid(gvChild);
            }
            else
            {
                row.FindControl("pnlOrders").Visible = false;
                imgShowHide.CommandArgument = "Show";
                imgShowHide.ImageUrl = "~/images/plus.png";
            }
        }


        private void BindChildGrid(GridView grdchild)
        {           
            grdchild.DataSource = FillGridChild();
            grdchild.DataBind();
        }

        #region Event GridView Data
      
        protected void grdSanitizationSGP125TData_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                GridView grdchild = (GridView)sender;
                if (grdchild != null)
                {
                   
                    grdchild.PageIndex = e.NewPageIndex;
                    grdchild.DataSource = FillGridChild();
                    grdchild.DataBind();
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;
            }
        }


        #endregion



        #region DML Method
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            lblMsg.Text = string.Empty;
            //lblMsgEdit.Text = string.Empty;
            try
            {
                lblMsg.Text = string.Empty;
                rptViewer.ShowReportBody = false;
                FillGrid();


               
            }
            catch (Exception ex)
            {
                Exception exc = ex;
            }
        }


        protected void btnRecordUpdate_Click(object sender, EventArgs e)
        {
            lblMsg.Text = string.Empty;
            // lblMsgEdit.Text = string.Empty;


            if (IsValid && ViewState["grdSanitizationReportId"] != null)
            {
                errNumber = -1;
                BusinessClass objBusinessClass = new BusinessLayer.BusinessClass();
                int lngId = Convert.ToInt32(ViewState["grdSanitizationReportId"]);
                ML_SanitizationSGP125TData objML_SanitizationSGP125TData = objBusinessClass.GetSanitizationSGP125TDataById(lngId);
                try
                {
                    if (objML_SanitizationSGP125TData != null)
                    {
                      

                        int obhReturn = objBusinessClass.UpdateUniqueSanitizationSGP125TData(objML_SanitizationSGP125TData);
                       
                        if (obhReturn == 1)
                        {
                           
                            lblMsg.Text = "Record Update Successfully";
                            //lblMsgEdit.Text = "Record Update Successfully";
                        }
                        else if (obhReturn == 2)
                        {
                            lblMsg.Text = "Record Already Exists!";
                            // lblMsgEdit.Text = "Record Already Exists!";
                           
                        }
                        else
                        {
                            lblMsg.Text = "Ooops!OtherIssue...";
                            // lblMsgEdit.Text = "Ooops!OtherIssue...";
                           
                        }
                        FillGrid();
                    }
                }
                catch (SqlException sqlExc)
                {
                    //LogManager.LogManager.WriteErrorLog(sqlExc); 
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
                    Exception exc = ex;
                }
            }
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            lblMsg.Text = string.Empty;
            //lblMsgEdit.Text = string.Empty;
            try
            {
                lblMsg.Text = string.Empty;
                 
                // grdSanitizationReport.EditIndex = -1; 
                FormFieldsClear();
                FillGrid();
            }
            catch (Exception ex)
            {
                Exception exc = ex;
            }
        }
        #endregion

        #region populate

        private void populateTagStatusSearchList()
        {
            //objBusinessClass = new BusinessLayer.BusinessClass();
            //DataSet ds = null;// objBusinessClass.GetTagStatusDetail();
            //try
            //{
            //    if (ds.Tables.Count > 0)
            //    {
            //        ddlTagStatusSearch.DataTextField = "TagStatus";
            //        ddlTagStatusSearch.DataValueField = "TagStatus";
            //        ddlTagStatusSearch.DataSource = ds;
            //        ddlTagStatusSearch.DataBind();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Exception exc = ex;
            //}
        }
        #endregion

        #region  BindDataTable
        private DataTable BindSanitizationSGP125TDataDataTable()
        {
            DataTable myDataTable = new DataTable("myDataTable");
            try
            {


                DataColumn ColumnId;
                ColumnId = new DataColumn();
                ColumnId.DataType = System.Type.GetType("System.String");
                ColumnId.ColumnName = "Id";
                myDataTable.Columns.Add(ColumnId);


                DataColumn ColumnSanitizationDataId;
                ColumnSanitizationDataId = new DataColumn();
                ColumnSanitizationDataId.DataType = System.Type.GetType("System.String");
                ColumnSanitizationDataId.ColumnName = "SanitizationDataId";
                myDataTable.Columns.Add(ColumnSanitizationDataId);


                DataColumn ColumnSanitizationData;
                ColumnSanitizationData = new DataColumn();
                ColumnSanitizationData.DataType = System.Type.GetType("System.String");
                ColumnSanitizationData.ColumnName = "SanitizationData";
                myDataTable.Columns.Add(ColumnSanitizationData);


                DataColumn ColumnGMT;
                ColumnGMT = new DataColumn();
                ColumnGMT.DataType = System.Type.GetType("System.String");
                ColumnGMT.ColumnName = "GMT";
                myDataTable.Columns.Add(ColumnGMT);


                DataColumn ColumnDateAndTime;
                ColumnDateAndTime = new DataColumn();
                ColumnDateAndTime.DataType = System.Type.GetType("System.String");
                ColumnDateAndTime.ColumnName = "DateAndTime";
                myDataTable.Columns.Add(ColumnDateAndTime);


                DataColumn ColumnPLCId;
                ColumnPLCId = new DataColumn();
                ColumnPLCId.DataType = System.Type.GetType("System.String");
                ColumnPLCId.ColumnName = "PLCId";
                myDataTable.Columns.Add(ColumnPLCId);


                DataColumn ColumnPLC;
                ColumnPLC = new DataColumn();
                ColumnPLC.DataType = System.Type.GetType("System.String");
                ColumnPLC.ColumnName = "PLC";
                myDataTable.Columns.Add(ColumnPLC);


                DataColumn ColumnAreaId;
                ColumnAreaId = new DataColumn();
                ColumnAreaId.DataType = System.Type.GetType("System.String");
                ColumnAreaId.ColumnName = "AreaId";
                myDataTable.Columns.Add(ColumnAreaId);


                DataColumn ColumnArea;
                ColumnArea = new DataColumn();
                ColumnArea.DataType = System.Type.GetType("System.String");
                ColumnArea.ColumnName = "Area";
                myDataTable.Columns.Add(ColumnArea);


                DataColumn ColumnSanitizationStartDate;
                ColumnSanitizationStartDate = new DataColumn();
                ColumnSanitizationStartDate.DataType = System.Type.GetType("System.String");
                ColumnSanitizationStartDate.ColumnName = "SanitizationStartDate";
                myDataTable.Columns.Add(ColumnSanitizationStartDate);


                DataColumn ColumnSanitizationEndDate;
                ColumnSanitizationEndDate = new DataColumn();
                ColumnSanitizationEndDate.DataType = System.Type.GetType("System.String");
                ColumnSanitizationEndDate.ColumnName = "SanitizationEndDate";
                myDataTable.Columns.Add(ColumnSanitizationEndDate);


                DataColumn ColumnStartDate;
                ColumnStartDate = new DataColumn();
                ColumnStartDate.DataType = System.Type.GetType("System.String");
                ColumnStartDate.ColumnName = "StartDate";
                myDataTable.Columns.Add(ColumnStartDate);


                DataColumn ColumnEndDate;
                ColumnEndDate = new DataColumn();
                ColumnEndDate.DataType = System.Type.GetType("System.String");
                ColumnEndDate.ColumnName = "EndDate";
                myDataTable.Columns.Add(ColumnEndDate);


                DataColumn ColumnSTARTBIT;
                ColumnSTARTBIT = new DataColumn();
                ColumnSTARTBIT.DataType = System.Type.GetType("System.String");
                ColumnSTARTBIT.ColumnName = "STARTBIT";
                myDataTable.Columns.Add(ColumnSTARTBIT);


                DataColumn ColumnSTOPBIT;
                ColumnSTOPBIT = new DataColumn();
                ColumnSTOPBIT.DataType = System.Type.GetType("System.String");
                ColumnSTOPBIT.ColumnName = "STOPBIT";
                myDataTable.Columns.Add(ColumnSTOPBIT);


                DataColumn ColumnTempSTARTBIT;
                ColumnTempSTARTBIT = new DataColumn();
                ColumnTempSTARTBIT.DataType = System.Type.GetType("System.String");
                ColumnTempSTARTBIT.ColumnName = "TempSTARTBIT";
                myDataTable.Columns.Add(ColumnTempSTARTBIT);


                DataColumn ColumnTempSTOPBIT;
                ColumnTempSTOPBIT = new DataColumn();
                ColumnTempSTOPBIT.DataType = System.Type.GetType("System.String");
                ColumnTempSTOPBIT.ColumnName = "TempSTOPBIT";
                myDataTable.Columns.Add(ColumnTempSTOPBIT);


                DataColumn ColumnTTTag1;
                ColumnTTTag1 = new DataColumn();
                ColumnTTTag1.DataType = System.Type.GetType("System.String");
                ColumnTTTag1.ColumnName = "TTTag1";
                myDataTable.Columns.Add(ColumnTTTag1);


                DataColumn ColumnTTTag2;
                ColumnTTTag2 = new DataColumn();
                ColumnTTTag2.DataType = System.Type.GetType("System.String");
                ColumnTTTag2.ColumnName = "TTTag2";
                myDataTable.Columns.Add(ColumnTTTag2);


                DataColumn ColumnTTTag3;
                ColumnTTTag3 = new DataColumn();
                ColumnTTTag3.DataType = System.Type.GetType("System.String");
                ColumnTTTag3.ColumnName = "TTTag3";
                myDataTable.Columns.Add(ColumnTTTag3);


                DataColumn ColumnTANKID;
                ColumnTANKID = new DataColumn();
                ColumnTANKID.DataType = System.Type.GetType("System.String");
                ColumnTANKID.ColumnName = "TANKID";
                myDataTable.Columns.Add(ColumnTANKID);


                DataColumn ColumnTagStatus;
                ColumnTagStatus = new DataColumn();
                ColumnTagStatus.DataType = System.Type.GetType("System.String");
                ColumnTagStatus.ColumnName = "TagStatus";
                myDataTable.Columns.Add(ColumnTagStatus);


                DataColumn ColumnRemarks;
                ColumnRemarks = new DataColumn();
                ColumnRemarks.DataType = System.Type.GetType("System.String");
                ColumnRemarks.ColumnName = "Remarks";
                myDataTable.Columns.Add(ColumnRemarks);


                DataColumn ColumnIsPass;
                ColumnIsPass = new DataColumn();
                ColumnIsPass.DataType = System.Type.GetType("System.String");
                ColumnIsPass.ColumnName = "IsPass";
                myDataTable.Columns.Add(ColumnIsPass);


                DataColumn ColumnDoneBy;
                ColumnDoneBy = new DataColumn();
                ColumnDoneBy.DataType = System.Type.GetType("System.String");
                ColumnDoneBy.ColumnName = "DoneBy";
                myDataTable.Columns.Add(ColumnDoneBy);


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


            }
            catch (Exception ex)
            {
                Exception exc = ex;
            }
            return myDataTable;
        }

        #endregion

       
         private void WriteUserActivity(string strActivity, string strLogStatus = "")
         {
             if (Session["UserName"] != null && Session["UserNameId"] != null && Session["UserTypeId"] != null && Session["UserType"] != null && Session["IPAddress"] != null && Session["hostName"] != null)
             {
                 ML_UserLog objML_UserLog = new ML_UserLog();
                 objBusinessClass = new BusinessLayer.BusinessClass();
                 try
                 {
                     objML_UserLog.UserLog = ML_Common.string2string(Session["UserName"]);
                     objML_UserLog.UserName = ML_Common.string2string(Session["UserName"]);
                     objML_UserLog.UserNameId = ML_Common.string2Long(Session["UserNameId"]);
                     objML_UserLog.Email = string.Empty;
                     objML_UserLog.UserTypeId = ML_Common.string2Long(Session["UserTypeId"]);
                     objML_UserLog.UserType = ML_Common.string2string(Session["UserType"]);
                     objML_UserLog.LogStatus = strLogStatus;
                     objML_UserLog.IPAddress = ML_Common.string2string(Session["IPAddress"]);
                     objML_UserLog.MachineHostName = ML_Common.string2string(Session["hostName"]);

                     objML_UserLog.UserActivity = strActivity;
                     objML_UserLog.Remarks = string.Empty;
                     objBusinessClass.AddUserLog(objML_UserLog);
                 }
                 catch { }

             }
             else
             {
                 Response.Redirect("Login.aspx", false);
             }

         }

        




        //Report

         private void ShowReport(long  Id, String ReportType)
         {
             rptViewer.ShowReportBody = true;
            //reset
             rptViewer.Reset();
            //DataSource
             DataTable dt = GetData(Id, ReportType);
             ReportDataSource rds = new ReportDataSource("HCDetailReport", dt);
             rptViewer.LocalReport.DataSources.Add(rds);

            //Path
             if (ReportType.Trim().ToLower() == "SGP125T".ToLower())
             {
                 rptViewer.LocalReport.ReportPath = "rptDetailSGP125T.rdlc";
             }
             else if (ReportType.Trim().ToLower() == "SGP4T".ToLower())
             {
                 rptViewer.LocalReport.ReportPath = "rptDetailSGP4T.rdlc";
             }           
            
             else
             {
                 rptViewer.LocalReport.ReportPath = "rptDetailwithChart.rdlc";
             }
                        
             //Parameters
             ReportParameter[] rptParams = new ReportParameter[] {
                 new ReportParameter("Id",Id.ToString()),
                 new ReportParameter("ReportType",ReportType)
             };
             rptViewer.LocalReport.SetParameters(rptParams);
             //refresh
             rptViewer.LocalReport.Refresh();
             rptViewer.Visible = true;

             
         }

        private DataTable GetData(long  Id, String ReportType)
        {
            DataTable dt = new DataTable();
            string constr = System.Configuration.ConfigurationManager.ConnectionStrings["ManualString"].ConnectionString;
            using(SqlConnection cn = new SqlConnection(constr))
            {
                //SqlCommand cmd = new SqlCommand("usp_GetSanitizationReportSummaryByReportTypeandId",cn);
               // SqlCommand cmd = new SqlCommand("usp_GetSanitizationSummaryonlyByReportTypeandId", cn);
                SqlCommand cmd = new SqlCommand("usp_GetSCSanitizationDetailReportByReportTypeandId", cn);

                
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Id", SqlDbType.BigInt).Value = Id;
                cmd.Parameters.Add("@ReportType", SqlDbType.NVarChar).Value = ReportType;

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

            }
            return dt;
        }

    }
}
#endregion