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
    public partial class frmCokeDynamicResult : System.Web.UI.Page
    {
        #region Initialize the Object of the Class
        static string strId = string.Empty;
        public static string setStringFile = string.Empty;
        public static string strImgPath = string.Empty;
       // int errNumber = int.MinValue;
        BusinessClass objBusinessClass = null;
        ML_CokeDynamicResult objML_CokeDynamicResult = null;
        #endregion 
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
               // Page.Form.Attributes.Add("enctype", "multipart//form-data");
                if (!IsPostBack)
                {
                    //populatePotNoIdList();
                    //populateCokeTypeList();
                    //populateAnalysisTypeList();
                    //// populateCokeSupplierIdList(); 
                    //populateCokeSupplierList();
                    ViewState["grdCokeDynamicResult"] = null;

                    FillGrid();
                    
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
            } 
        }

        #region Event GridView
        protected void grdCokeDynamicResult_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if ((e.Row.RowType == DataControlRowType.DataRow) && (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate))
            {

            }


            if ((e.Row.RowType == DataControlRowType.DataRow) && (e.Row.RowState == DataControlRowState.Edit || (e.Row.RowState == (DataControlRowState.Edit | DataControlRowState.Alternate))))
            {

            }
        }
        protected void grdCokeDynamicResult_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                lblMsg.Visible = false;

                int lngId = ML_Common.string2int32(grdCokeDynamicResult.DataKeys[e.NewEditIndex].Values[0].ToString());
                if (lngId > 0)
                {
                    ViewState["grdCokeDynamicResultViewId"] = lngId;
                    grdCokeDynamicResult.EditIndex = -1;
                    e.Cancel = true;
                    // PanelMainDisplay(false); 
                    FormFieldsClear();
                    //PanelEditFormDisplay(true); 
                    //FillObjectToForm(lngId, true);
                    //UpdatePanelEdit.Update();
                    //ModalPopupExtenderEdit.Show();
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
        protected void grdCokeDynamicResult_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                if (grdCokeDynamicResult.EditIndex != -1)
                {
                    e.Cancel = true;
                }
                else
                {
                   
                    ViewState["grdCokeDynamicResult"] = null;
                    FillGrid();
                    grdCokeDynamicResult.PageIndex = e.NewPageIndex;
                    grdCokeDynamicResult.DataBind();
                   
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }
        #endregion
        #region DML Method
        protected void btnSave_Click(object sender, EventArgs e)
        {

            if (IsValid )
            {
                //errNumber = -1;
                try
                {
                    objBusinessClass = new BusinessLayer.BusinessClass();
                    objML_CokeDynamicResult = new ML_CokeDynamicResult();
                   


                  
                   
                    ML_CokeDynamic objML_CokeDynamic = null;// new ML_KeysPointChk();
                    objBusinessClass = new BusinessClass();

                    int CokeDynamicId = -1;
                    int obhReturn = 0;

                    DateTime dtDateandTime = System.DateTime.Now;
                    if (ddlCokeType.SelectedIndex > 0)
                    {


                        foreach (GridViewRow row in grdCokeDynamicResult.Rows)
                        {

                            objML_CokeDynamic = new ML_CokeDynamic();
                            string txtCokeDynamicResult = string.Empty;
                           




                            TextBox mytxtCokeDynamicResult = (TextBox)row.FindControl("txtCokeDynamicResult");
                            if (mytxtCokeDynamicResult != null)
                            {
                                txtCokeDynamicResult = mytxtCokeDynamicResult.Text;
                            }





                            Label lblCokeDynamicId = (Label)row.FindControl("lblCokeDynamicId");
                            if (lblCokeDynamicId != null)
                            {
                                CokeDynamicId = ML_Common.string2int(lblCokeDynamicId.Text);

                                objML_CokeDynamic = objBusinessClass.GetCokeDynamicByCokeDynamicId(CokeDynamicId);

                                objML_CokeDynamicResult = new ML_CokeDynamicResult();

                              
                                objML_CokeDynamicResult.CokeDynamicResult = objML_CokeDynamic.CokeDynamic;


                                objML_CokeDynamicResult.CokeTypeId = ML_Common.string2int32(ML_Common.GetDropDownValue(ddlCokeType, true));
                                objML_CokeDynamicResult.CokeType = ML_Common.string2string(ML_Common.GetDropDownValue(ddlCokeType, false));

                                objML_CokeDynamicResult.CokeSupplierId = ML_Common.string2int32(ML_Common.GetDropDownValue(ddlCokeSupplierName, true));
                                objML_CokeDynamicResult.CokeSupplier = ML_Common.string2string(ML_Common.GetDropDownValue(ddlCokeSupplierName, false));

                                objML_CokeDynamicResult.AnalysisTypeId = ML_Common.string2int32(ML_Common.GetDropDownValue(ddlAnalysisType, true));
                                objML_CokeDynamicResult.AnalysisType = ML_Common.string2string(ML_Common.GetDropDownValue(ddlAnalysisType, false));

                                objML_CokeDynamicResult.CokeDynamicId = objML_CokeDynamicResult.CokeDynamicId;
                                objML_CokeDynamicResult.CokeDynamic = objML_CokeDynamic.CokeDynamic;


                                objML_CokeDynamicResult.FieldSize = objML_CokeDynamic.FieldSize;
                                objML_CokeDynamicResult.FieldUnit = objML_CokeDynamic.FieldUnit;
                                objML_CokeDynamicResult.FieldSpec = objML_CokeDynamic.FieldSpec;
                                objML_CokeDynamicResult.MinValue = objML_CokeDynamic.MinValue;
                                objML_CokeDynamicResult.MaxValue = objML_CokeDynamic.MaxValue;
                              


                          

                                //objML_CokeDynamicResult.CokeDynamicId = ML_Common.string2string(txtCokeDynamicResult);


                                objML_CokeDynamicResult.CokeTypeId = ML_Common.string2int32(ML_Common.GetDropDownValue(ddlCokeType, true));
                                objML_CokeDynamicResult.CokeType = ML_Common.string2string(ML_Common.GetDropDownValue(ddlCokeType, false));

                                objML_CokeDynamicResult.CokeSupplierId = ML_Common.string2int32(ML_Common.GetDropDownValue(ddlCokeSupplierName, true));
                                objML_CokeDynamicResult.CokeSupplier = ML_Common.string2string(ML_Common.GetDropDownValue(ddlCokeSupplierName, false));


                                objML_CokeDynamicResult.AnalysisTypeId = ML_Common.string2int32(ML_Common.GetDropDownValue(ddlAnalysisType, true));
                                objML_CokeDynamicResult.AnalysisType = ML_Common.string2string(ML_Common.GetDropDownValue(ddlAnalysisType, false));

                                    objML_CokeDynamicResult.FieldSize = ML_Common.clean(objML_CokeDynamicResult.FieldSize);
                             
                                
                                    objML_CokeDynamicResult.FieldUnit = ML_Common.clean(objML_CokeDynamicResult.FieldUnit);
                                     objML_CokeDynamicResult.FieldSpec = ML_Common.clean(objML_CokeDynamicResult.FieldSpec);
                                      objML_CokeDynamicResult.MinValue = ML_Common.clean(objML_CokeDynamicResult.MinValue);
                                     objML_CokeDynamicResult.MaxValue = ML_Common.clean(objML_CokeDynamicResult.MaxValue);
                                
                              
                                obhReturn = objBusinessClass.AddCokeDynamicResult(objML_CokeDynamicResult);
                            }

                        }
                        if (obhReturn == 1)
                        {
                            lblMsg.Visible = true;
                            lblMsg.Text = "Record Saved Successfully";
                        }

                        FormFieldsClear();
                    }
                }

                catch (SqlException sqlExc)
                {
                    SqlException sqlExt = sqlExc;
                    return;

                }
                catch (Exception ex)
                {
                    Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                }
            }

         



            //if (IsValid )
            //{
            //    //errNumber = -1;
            //    try
            //    {
            //        objBusinessClass = new BusinessLayer.BusinessClass();
            //        objML_CokeDynamicResult = new ML_CokeDynamicResult();
            //        string strAdminLoginName = string.Empty;
            //        if (Session["UserName"] != null)
            //        {
            //            strAdminLoginName = Session["UserName"].ToString();
            //        }


                   
                 

            //        objML_CokeDynamicResult.Id = ML_Common.string2Long(ML_Common.clean(txtId.Text));
            //        objML_CokeDynamicResult.CokeDynamicResultId = ML_Common.string2Long(ML_Common.clean(txtCokeDynamicResultId.Text));
            //        objML_CokeDynamicResult.CokeDynamicResult = ML_Common.clean(txtCokeDynamicResult.Text);
            //        objML_CokeDynamicResult.CokeDynamicId = ML_Common.string2int32(ML_Common.clean(txtCokeDynamicId.Text));
            //        objML_CokeDynamicResult.CokeDynamic = ML_Common.clean(txtCokeDynamic.Text);
            //        objML_CokeDynamicResult.CPCokeId = ML_Common.string2int32(ML_Common.clean(txtCPCokeId.Text));
            //        objML_CokeDynamicResult.CPCokeName = ML_Common.clean(txtCPCokeName.Text);
            //        objML_CokeDynamicResult.CokeTypeId = ML_Common.string2int32(ML_Common.clean(txtCokeTypeId.Text));
            //        objML_CokeDynamicResult.CokeType = ML_Common.clean(txtCokeType.Text);
            //        objML_CokeDynamicResult.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(txtCokeSupplierId.Text));
            //        objML_CokeDynamicResult.CokeSupplier = ML_Common.clean(txtCokeSupplier.Text);
            //        objML_CokeDynamicResult.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(txtAnalysisTypeId.Text));
            //        objML_CokeDynamicResult.AnalysisType = ML_Common.clean(txtAnalysisType.Text);
            //        objML_CokeDynamicResult.FieldSize = ML_Common.clean(txtFieldSize.Text);
            //        objML_CokeDynamicResult.FieldUnit = ML_Common.clean(txtFieldUnit.Text);
            //        objML_CokeDynamicResult.FieldSpec = ML_Common.clean(txtFieldSpec.Text);
            //        objML_CokeDynamicResult.MinValue = ML_Common.clean(txtMinValue.Text);
            //        objML_CokeDynamicResult.MaxValue = ML_Common.clean(txtMaxValue.Text);


            //        // objML_CokeDynamicResult.IsActive = ML_Common.clean(ML_Common.bit2int(chkIsActive.Checked).ToString()); 
            //        // objML_CokeDynamicResult.IsArchive = ML_Common.clean(ML_Common.bit2int(chkIsArchive.Checked).ToString()); 
            //        // objML_CokeDynamicResult.CreatedDate = ML_Common.ToDateTimeSafe(System.DateTime.Now.ToString()); 
            //        // objML_CokeDynamicResult.CreatedBy = ML_Common.clean(string.Empty); 
            //        // objML_CokeDynamicResult.ModifiedDate = ML_Common.ToDateTimeSafe(System.DateTime.Now.ToString()); 
            //        // objML_CokeDynamicResult.ModifiedBy = ML_Common.clean(string.Empty); 

            //        int obhReturn = objBusinessClass.AddCokeDynamicResult(objML_CokeDynamicResult);

            //        if (obhReturn == 1)
            //        {
            //            lblMsg.Visible = true;
            //            lblMsg.Text = "Record Saved Successfully";
            //        }
            //        else if (obhReturn == 2)
            //        {
            //            lblMsg.Text = "Record Already Exists!";
            //            lblMsg.Visible = true;
            //        }
            //    }
            //    catch (SqlException sqlExc)
            //    {
            //        // LogManager.LogManager.WriteErrorLog(sqlExc); 
            //        foreach (SqlError error in sqlExc.Errors)
            //        {
            //            errNumber = error.Number;
            //        }
            //        if (errNumber == 50000)
            //        {
            //        }
            //        return;
            //    }
            //    catch (Exception ex)
            //    {
            //        Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
            //    }
            //}
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

        private DataTable BindGridView()
        {
            DataTable dtCokeDynamicResult = new DataTable("DtGrd");
            try
            {
                objBusinessClass = new BusinessClass();
                dtCokeDynamicResult = objBusinessClass.GetCokeDynamicResultDetail();
               
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
            return dtCokeDynamicResult;
        }
        private DataTable BindGridViewBySearch(ML_CokeDynamic objML_CokeDynamic)
        {
            DataTable dtCokeDynamicResult = new DataTable("GridSearch");
            try
            {
                objBusinessClass = new BusinessLayer.BusinessClass();
                dtCokeDynamicResult = objBusinessClass.GetCokeDynamicBySeacrh(objML_CokeDynamic);
               
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
            return dtCokeDynamicResult;
        }
        private int DeleteGridRowItem(long lngId)
        {
            int returnObj = 0;
            try
            {
                objBusinessClass = new BusinessLayer.BusinessClass();
                returnObj = objBusinessClass.DeleteCokeDynamic(lngId);
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
                DataTable DtList =null;// BindGridView();

                if (ViewState["grdCokeDynamicResult"] == null)
                {
                   
                    DtList = BindGridView();
                    ViewState["grdCokeDynamicResult"] = DtList;
                }
                else
                {
                    DtList = (DataTable)ViewState["grdCokeDynamicResult"];
                }

                if (DtList != null)
                {
                   
                    if (DtList.Rows.Count > 0)
                    {
                        grdCokeDynamicResult.DataSource = DtList;
                        grdCokeDynamicResult.DataBind();
                    }
                    else
                    {
                        DtList.Rows.Add(DtList.NewRow());
                        grdCokeDynamicResult.DataSource = DtList;
                        grdCokeDynamicResult.DataBind();

                        int TotalColumns = grdCokeDynamicResult.Rows[0].Cells.Count;
                        grdCokeDynamicResult.Rows[0].Cells.Clear();
                        grdCokeDynamicResult.Rows[0].Cells.Add(new TableCell());
                        grdCokeDynamicResult.Rows[0].Cells[0].ColumnSpan = TotalColumns;
                        grdCokeDynamicResult.Rows[0].Cells[0].Text = "No Record Found";
                    }
                    //UpdatePanelGrid.Update();
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
                //txtId.Text = string.Empty;
                //txtCokeDynamicResultId.Text = string.Empty;
                //txtCokeDynamicResult.Text = string.Empty;
                //txtCokeDynamicId.Text = string.Empty;
                //txtCokeDynamic.Text = string.Empty;
                //txtCPCokeId.Text = string.Empty;
                //txtCPCokeName.Text = string.Empty;
                //txtCokeTypeId.Text = string.Empty;
                //txtCokeType.Text = string.Empty;
                //txtCokeSupplierId.Text = string.Empty;
                //txtCokeSupplier.Text = string.Empty;
                //txtAnalysisTypeId.Text = string.Empty;
                //txtAnalysisType.Text = string.Empty;
                //txtFieldSize.Text = string.Empty;
                //txtFieldUnit.Text = string.Empty;
                //txtFieldSpec.Text = string.Empty;
                //txtMinValue.Text = string.Empty;
                //txtMaxValue.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }
        #endregion
        //#region populate
        //private void populateCokeTypeList()
        //{
        //    objBusinessClass = new BusinessLayer.BusinessClass();
        //    DataTable  ds = null;// objBusinessClass.GetCokeTypeDetail();
        //    try
        //    {

        //        if (ViewState["CokeType"] == null)
        //        {
        //            ds = objBusinessClass.GetCokeTypeDetail();
        //            ViewState["CokeType"] = ds;
        //        }
        //        else
        //        {
        //            ds = (DataTable)ViewState["CokeType"];
        //        }


        //        if (ds.Rows.Count > 0)
        //        {
        //            if (ddlCokeType.Items.Count > 0)
        //            {
        //                ddlCokeType.Items.Clear();
        //            }

        //            ddlCokeType.DataTextField = "CokeType";
        //            ddlCokeType.DataValueField = "CokeTypeId";
        //            ddlCokeType.DataSource = ds;
        //            ddlCokeType.DataBind();
        //        }
        //        ddlCokeType.Items.Insert(0, new ListItem("-- Select --", "-1"));
        //    }
        //    catch (Exception ex)
        //    {
        //        Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //    }
        //}

        //private void populateCokeSupplierList()
        //{
        //    objBusinessClass = new BusinessLayer.BusinessClass();
        //    DataTable ds = null;// objBusinessClass.GetCokeSupplierDetail();
        //    try
        //    {
        //        if (ViewState["CokeSupplier"] == null)
        //        {
        //            ds = objBusinessClass.GetCokeSupplierDetail();
        //            ViewState["CokeSupplier"] = ds;
        //        }
        //        else
        //        {
        //            ds = (DataTable)ViewState["CokeSupplier"];
        //        }
        //        if (ddlCokeSupplierName.Items.Count > 0)
        //        {
        //            ddlCokeSupplierName.Items.Clear();
        //        }

        //        if (ds.Rows.Count > 0)
        //        {
        //            ddlCokeSupplierName.DataTextField = "CokeSupplier";
        //            ddlCokeSupplierName.DataValueField = "CokeSupplierId";
        //            ddlCokeSupplierName.DataSource = ds.DefaultView;
        //            ddlCokeSupplierName.DataBind();
        //        }
        //        ddlCokeSupplierName.Items.Insert(0, new ListItem("-- Select --", "-1"));
        //    }
        //    catch (Exception ex)
        //    {
        //        Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //    }
        //}

        ////private void populateAnalysisTypeList()
        ////{
        ////    objBusinessClass = new BusinessLayer.BusinessClass();
        ////    DataTable  ds = null;// objBusinessClass.GetCokeSupplierDetail();
        ////    try
        ////    {
        ////        if (ViewState["AnalysisType"] == null)
        ////        {
        ////            ds = objBusinessClass.GetAnalysisTypeDetail();
        ////            ViewState["AnalysisType"] = ds;
        ////        }
        ////        else
        ////        {
        ////            ds = (DataTable)ViewState["AnalysisType"];
        ////        }
        ////        if (ddlAnalysisType.Items.Count > 0)
        ////        {
        ////            ddlAnalysisType.Items.Clear();
        ////        }

        ////        if (ds.Rows.Count > 0)
        ////        {
        ////            ddlAnalysisType.DataTextField = "AnalysisType";
        ////            ddlAnalysisType.DataValueField = "AnalysisTypeId";
        ////            ddlAnalysisType.DataSource = ds.DefaultView;
        ////            ddlAnalysisType.DataBind();
        ////        }
        ////        ddlAnalysisType.Items.Insert(0, new ListItem("-- Select --", "-1"));
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        ////    }
        ////}
        //#endregion

        protected void ddlCokeType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}