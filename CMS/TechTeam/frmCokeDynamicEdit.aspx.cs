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
    public partial class frmCokeDynamicEdit : System.Web.UI.Page
    {
        #region Initialize the Object of the Class
        static string strCokeDynamicId = string.Empty;
        BusinessClass objBusinessClass = null;
        ML_CokeDynamic objML_CokeDynamic = null;
        public static Guid strCokeDynamicGuid = Guid.Empty;
        public static string setStringFile = string.Empty;
        public static string strImgPath = string.Empty;
       // int errNumber = int.MinValue;
        #endregion 
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
                  //  Form.Enctype = "multipart/form-data";
                    //populateCokeTypeList();
                    //populateCokeSupplierList();
                    //populateAnalysisTypeList();

                    //populateCokeTypeListEdit();
                    //populateCokeSupplierListEdit();
                    //populateAnalysisTypeListEdit();
                   
                    //ViewState["grdCokeDynamicEdit"] = null;
                    //PanelMainDisplay(true);
              
                    FillGrid();

                    
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            } 
        }

        #region Other Methods
        private DataTable BindGridView()
        {
            DataTable dtCokeDynamic = new DataTable("DtGrd");
            try
            {
                objBusinessClass = new BusinessClass();
                dtCokeDynamic = objBusinessClass.GetCokeDynamicDetail();
               
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
            return dtCokeDynamic;
        }

        private DataTable BindGridViewBySearch(ML_CokeDynamic objML_CokeDynamic)
        {
            DataTable dtCokeDynamic = new DataTable("GridSearch");
            try
            {
                objBusinessClass = new BusinessLayer.BusinessClass();
                dtCokeDynamic = objBusinessClass.GetCokeDynamicBySeacrh(objML_CokeDynamic);
               
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
            return dtCokeDynamic;
        }

        //private int DeleteGridRowItem(Guid guid)
        //{
        //    int returnObj = 0;
        //    try
        //    {
        //        objBusinessClass = new BusinessLayer.BusinessClass();
        //        returnObj = objBusinessClass.DeleteCokeDynamic(guid);
        //    }
        //    catch (Exception ex)
        //    {
        //        Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //    }
        //    return returnObj;
        //}

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
                DataTable DtList = null;  // BindGridView();
                if (ViewState["grdCokeDynamicEdit"] == null)
                {

                ML_CokeDynamic objML_CokeDynamicSearch = new ML_CokeDynamic();
                objML_CokeDynamicSearch.CokeType = null;
                objML_CokeDynamicSearch.CokeSupplier = null;
                objML_CokeDynamicSearch.AnalysisType = null;

                if (ddlCokeTypeSearch.SelectedIndex>0)
                {
                    objML_CokeDynamicSearch.CokeTypeId = ML_Common.string2int(ddlCokeTypeSearch.SelectedValue);
                    objML_CokeDynamicSearch.CokeType = ML_Common.clean(ML_Common.GetDropDownValue(ddlCokeTypeSearch, false));
                }
               
                if (ddlCokeSupplierSearch.SelectedIndex > 0)
                {
                    objML_CokeDynamicSearch.CokeSupplierId = ML_Common.string2int(ddlCokeSupplierSearch.SelectedValue);
                    objML_CokeDynamicSearch.CokeSupplier = ML_Common.clean(ML_Common.GetDropDownValue(ddlCokeSupplierSearch, false));
                }              

                if (ddlAnalysisTypeSearch.SelectedIndex > 0)
                {
                    objML_CokeDynamicSearch.AnalysisTypeId = ML_Common.string2int(ddlAnalysisTypeSearch.SelectedValue);
                    objML_CokeDynamicSearch.AnalysisType = ML_Common.clean(ML_Common.GetDropDownValue(ddlAnalysisTypeSearch, false));
                }
               
              
               
                 
                     DtList = BindGridViewBySearch(objML_CokeDynamicSearch);
                     ViewState["grdCokeDynamicEdit"] = DtList;
                }
                  else
                  {
                      DtList = (DataTable)ViewState["grdCokeDynamicEdit"];
                  }
                                  

                if (DtList != null)
                {
                    if (DtList.Rows.Count > 0)
                    {
                        grdCokeDynamicEdit.DataSource = DtList;
                        grdCokeDynamicEdit.DataBind();
                    }
                    else
                    {
                        DtList.Rows.Add(DtList.NewRow());
                        grdCokeDynamicEdit.DataSource = DtList;
                        grdCokeDynamicEdit.DataBind();

                        int TotalColumns = grdCokeDynamicEdit.Rows[0].Cells.Count;
                        grdCokeDynamicEdit.Rows[0].Cells.Clear();
                        grdCokeDynamicEdit.Rows[0].Cells.Add(new TableCell());
                        grdCokeDynamicEdit.Rows[0].Cells[0].ColumnSpan = TotalColumns;
                        grdCokeDynamicEdit.Rows[0].Cells[0].Text = "No Record Found";
                    }
                }
                UpdatePanelGrid.Update();
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
           
        }

        //private void FillGridEdit()
        //{
        //    try
        //    {
        //        DataTable DtList = null;  // BindGridView();
        //        ML_CokeDynamic objML_CokeDynamicSearch = new ML_CokeDynamic();
               

        //        if (ViewState["grdCokeDynamicEdit"] == null)
        //        {
        //            DtList = BindGridViewBySearch(objML_CokeDynamicSearch);
        //            ViewState["grdCokeDynamicEdit"] = DtList;
        //        }
        //        else
        //        {
        //            DtList = (DataTable)ViewState["grdCokeDynamicEdit"];
        //        }
        //        //}


        //        if (DtList != null)
        //        {
        //            if (DtList.Rows.Count > 0)
        //            {
        //                grdCokeDynamicEdit.DataSource = DtList;
        //                grdCokeDynamicEdit.DataBind();
        //            }
        //            else
        //            {
        //                DtList.Rows.Add(DtList.NewRow());
        //                grdCokeDynamicEdit.DataSource = DtList;
        //                grdCokeDynamicEdit.DataBind();

        //                int TotalColumns = grdCokeDynamicEdit.Rows[0].Cells.Count;
        //                grdCokeDynamicEdit.Rows[0].Cells.Clear();
        //                grdCokeDynamicEdit.Rows[0].Cells.Add(new TableCell());
        //                grdCokeDynamicEdit.Rows[0].Cells[0].ColumnSpan = TotalColumns;
        //                grdCokeDynamicEdit.Rows[0].Cells[0].Text = "No Record Found";
        //            }
        //        }
        //        UpdatePanelGrid.Update();
        //    }
        //    catch (Exception ex)
        //    {
        //        Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //    }

        //}

        private void FillObjectToForm(long lngId, bool IsEditFlag = true)
        {
            objBusinessClass = new BusinessLayer.BusinessClass();
            ML_CokeDynamic objML_CokeDynamic = objBusinessClass.GetCokeDynamicById(lngId);
            try
            {
                if (objML_CokeDynamic != null)
                {
                    if (IsEditFlag)
                    {
                        ML_Common.SetDropDownValue(ddlCokeTypeEdit, objML_CokeDynamic.CokeTypeId);

                        ML_Common.SetDropDownValue(ddlCokeSupplierEdit, objML_CokeDynamic.CokeSupplierId);
                        ML_Common.SetDropDownValue(ddlAnalysisTypeEdit, objML_CokeDynamic.AnalysisTypeId);
                        //ddlCokeTypeEdit.SelectedItem.Text = ML_Common.clean(objML_CokeDynamic.CokeType);
                        //ddlCokeSupplierEdit.SelectedItem.Text = ML_Common.clean(objML_CokeDynamic.CokeSupplier);
                        //ddlAnalysisTypeEdit.SelectedItem.Text = ML_Common.clean(objML_CokeDynamic.AnalysisType);
                        txtFieldSizeEdit.Text = ML_Common.clean(objML_CokeDynamic.FieldSize);
                        txtFieldUnitEdit.Text = ML_Common.clean(objML_CokeDynamic.FieldUnit);
                        txtFieldSpecEdit.Text = ML_Common.clean(objML_CokeDynamic.FieldSpec);
                        txtMaxValueEdit.Text = ML_Common.clean(objML_CokeDynamic.MaxValue);
                        txtMinValueEdit.Text = ML_Common.clean(objML_CokeDynamic.MinValue);

                    }
                    else
                    {
                        lblCokeType.Text = ML_Common.clean(objML_CokeDynamic.CokeType);
                        lblCokeSupplier.Text = ML_Common.clean(objML_CokeDynamic.CokeSupplier);
                        lblAnalysisType.Text = ML_Common.clean(objML_CokeDynamic.AnalysisType);
                        lblFieldSize.Text = ML_Common.clean(objML_CokeDynamic.FieldSize);
                        lblFieldUnit.Text = ML_Common.clean(objML_CokeDynamic.FieldUnit);
                        lblFieldSpec.Text = ML_Common.clean(objML_CokeDynamic.FieldSpec);
                        lblMaxValue.Text = ML_Common.clean(objML_CokeDynamic.MaxValue);
                        lblMinValue.Text = ML_Common.clean(objML_CokeDynamic.MinValue);

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
                ML_Common.SetDropDownValue(ddlCokeTypeEdit, -1);
                ML_Common.SetDropDownValue(ddlCokeSupplierEdit, -1);
                ML_Common.SetDropDownValue(ddlAnalysisTypeEdit, -1);
                //ddlCokeTypeEdit.SelectedIndex = 0;
                //ddlCokeSupplierEdit.SelectedIndex = 0;
                //ddlAnalysisTypeEdit.SelectedIndex = 0;
                txtFieldSizeEdit.Text = string.Empty;
                txtFieldUnitEdit.Text = string.Empty;
                txtFieldSpecEdit.Text = string.Empty;
                txtMinValueEdit.Text = string.Empty;
                txtMaxValueEdit.Text = string.Empty;

            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }


        public void PanelMainDisplay(bool hidePanel)
        {
            try
            {
               // PanelMain.Visible = hidePanel;
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }


     
        #endregion

        #region Event GridView
        protected void grdCokeDynamicEdit_RowDataBound(object sender, GridViewRowEventArgs e)
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
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblCokeDynamicId = (Label)e.Row.FindControl("lblCokeDynamicId");
                    if (lblCokeDynamicId != null)
                    {
                        try
                        {
                            lblCokeDynamicId.Text = ML_Common.string2Eclips(lblCokeDynamicId.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblCokeDynamicId.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblCokeDynamic = (Label)e.Row.FindControl("lblCokeDynamic");
                    if (lblCokeDynamic != null)
                    {
                        try
                        {
                            lblCokeDynamic.Text = ML_Common.string2Eclips(lblCokeDynamic.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblCokeDynamic.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblCokeTypeId = (Label)e.Row.FindControl("lblCokeTypeId");
                    if (lblCokeTypeId != null)
                    {
                        try
                        {
                            lblCokeTypeId.Text = ML_Common.string2Eclips(lblCokeTypeId.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblCokeTypeId.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblCokeType = (Label)e.Row.FindControl("lblCokeType");
                    if (lblCokeType != null)
                    {
                        try
                        {
                            lblCokeType.Text = ML_Common.string2Eclips(lblCokeType.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblCokeType.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblCokeSupplierId = (Label)e.Row.FindControl("lblCokeSupplierId");
                    if (lblCokeSupplierId != null)
                    {
                        try
                        {
                            lblCokeSupplierId.Text = ML_Common.string2Eclips(lblCokeSupplierId.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblCokeSupplierId.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


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


                    Label lblAnalysisTypeId = (Label)e.Row.FindControl("lblAnalysisTypeId");
                    if (lblAnalysisTypeId != null)
                    {
                        try
                        {
                            lblAnalysisTypeId.Text = ML_Common.string2Eclips(lblAnalysisTypeId.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblAnalysisTypeId.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblAnalysisType = (Label)e.Row.FindControl("lblAnalysisType");
                    if (lblAnalysisType != null)
                    {
                        try
                        {
                            lblAnalysisType.Text = ML_Common.string2Eclips(lblAnalysisType.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblAnalysisType.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblFieldSize = (Label)e.Row.FindControl("lblFieldSize");
                    if (lblFieldSize != null)
                    {
                        try
                        {
                            lblFieldSize.Text = ML_Common.string2Eclips(lblFieldSize.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblFieldSize.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblFieldUnit = (Label)e.Row.FindControl("lblFieldUnit");
                    if (lblFieldUnit != null)
                    {
                        try
                        {
                            lblFieldUnit.Text = ML_Common.string2Eclips(lblFieldUnit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblFieldUnit.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblFieldSpec = (Label)e.Row.FindControl("lblFieldSpec");
                    if (lblFieldSpec != null)
                    {
                        try
                        {
                            lblFieldSpec.Text = ML_Common.string2Eclips(lblFieldSpec.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblFieldSpec.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblFieldResult = (Label)e.Row.FindControl("lblFieldResult");
                    if (lblFieldResult != null)
                    {
                        try
                        {
                            lblFieldResult.Text = ML_Common.string2Eclips(lblFieldResult.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblFieldResult.Text = string.Empty;
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
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblCokeDynamicIdEdit = (Label)e.Row.FindControl("lblCokeDynamicIdEdit");
                    if (lblCokeDynamicIdEdit != null)
                    {
                        try
                        {
                            lblCokeDynamicIdEdit.Text = ML_Common.string2Eclips(lblCokeDynamicIdEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblCokeDynamicIdEdit.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblCokeDynamicEdit = (Label)e.Row.FindControl("lblCokeDynamicEdit");
                    if (lblCokeDynamicEdit != null)
                    {
                        try
                        {
                            lblCokeDynamicEdit.Text = ML_Common.string2Eclips(lblCokeDynamicEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblCokeDynamicEdit.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblCokeTypeIdEdit = (Label)e.Row.FindControl("lblCokeTypeIdEdit");
                    if (lblCokeTypeIdEdit != null)
                    {
                        try
                        {
                            lblCokeTypeIdEdit.Text = ML_Common.string2Eclips(lblCokeTypeIdEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblCokeTypeIdEdit.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblCokeTypeEdit = (Label)e.Row.FindControl("lblCokeTypeEdit");
                    if (lblCokeTypeEdit != null)
                    {
                        try
                        {
                            lblCokeTypeEdit.Text = ML_Common.string2Eclips(lblCokeTypeEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblCokeTypeEdit.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblCokeSupplierIdEdit = (Label)e.Row.FindControl("lblCokeSupplierIdEdit");
                    if (lblCokeSupplierIdEdit != null)
                    {
                        try
                        {
                            lblCokeSupplierIdEdit.Text = ML_Common.string2Eclips(lblCokeSupplierIdEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblCokeSupplierIdEdit.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblCokeSupplierEdit = (Label)e.Row.FindControl("lblCokeSupplierEdit");
                    if (lblCokeSupplierEdit != null)
                    {
                        try
                        {
                            lblCokeSupplierEdit.Text = ML_Common.string2Eclips(lblCokeSupplierEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblCokeSupplierEdit.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblAnalysisTypeIdEdit = (Label)e.Row.FindControl("lblAnalysisTypeIdEdit");
                    if (lblAnalysisTypeIdEdit != null)
                    {
                        try
                        {
                            lblAnalysisTypeIdEdit.Text = ML_Common.string2Eclips(lblAnalysisTypeIdEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblAnalysisTypeIdEdit.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblAnalysisTypeEdit = (Label)e.Row.FindControl("lblAnalysisTypeEdit");
                    if (lblAnalysisTypeEdit != null)
                    {
                        try
                        {
                            lblAnalysisTypeEdit.Text = ML_Common.string2Eclips(lblAnalysisTypeEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblAnalysisTypeEdit.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblFieldSizeEdit = (Label)e.Row.FindControl("lblFieldSizeEdit");
                    if (lblFieldSizeEdit != null)
                    {
                        try
                        {
                            lblFieldSizeEdit.Text = ML_Common.string2Eclips(lblFieldSizeEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblFieldSizeEdit.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblFieldUnitEdit = (Label)e.Row.FindControl("lblFieldUnitEdit");
                    if (lblFieldUnitEdit != null)
                    {
                        try
                        {
                            lblFieldUnitEdit.Text = ML_Common.string2Eclips(lblFieldUnitEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblFieldUnitEdit.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblFieldSpecEdit = (Label)e.Row.FindControl("lblFieldSpecEdit");
                    if (lblFieldSpecEdit != null)
                    {
                        try
                        {
                            lblFieldSpecEdit.Text = ML_Common.string2Eclips(lblFieldSpecEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblFieldSpecEdit.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                        }
                    }


                    Label lblFieldResultEdit = (Label)e.Row.FindControl("lblFieldResultEdit");
                    if (lblFieldResultEdit != null)
                    {
                        try
                        {
                            lblFieldResultEdit.Text = ML_Common.string2Eclips(lblFieldResultEdit.Text, 30);
                        }
                        catch (Exception ex)
                        {
                            lblFieldResultEdit.Text = string.Empty;
                            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
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

        protected void grdCokeDynamicEdit_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                // Guid  guid = ML_Common.String2Guid(grdCokeDynamicEdit.DataKeys[e.RowIndex].Values[0].ToString()); 
                long lngId = ML_Common.string2Long(grdCokeDynamicEdit.DataKeys[e.RowIndex].Values[0].ToString());
                DeleteGridRowItem(lngId);
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

        protected void grdCokeDynamicEdit_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                lblMsg.Visible = false;
                //grdCokeDynamicEdit.EditIndex = -1; 
                //grdCokeDynamicEdit.EditIndex = e.NewEditIndex; 
                // Guid  guid = ML_Common.String2Guid(grdCokeDynamicEdit.DataKeys[e.NewEditIndex].Values[0].ToString()); 
                //long lngId = ML_Common.string2Long(grdCokeDynamicEdit.DataKeys[e.NewEditIndex].Values[0].ToString()); 
                int lngId = ML_Common.string2int32(grdCokeDynamicEdit.DataKeys[e.NewEditIndex].Values[0].ToString());
                if (lngId > 0)
                {
                    ViewState["grdCokeDynamicId"] = lngId;
                    grdCokeDynamicEdit.EditIndex = -1;
                    e.Cancel = true;
                    // PanelMainDisplay(false); 
                    FormFieldsClear();
                    //PanelEditFormDisplay(true); 
                    FillObjectToForm(lngId, true);
                    UpdatePanelEdit.Update();
                    ModalPopupExtenderEdit.Show();
                   // FormFieldsClear();
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

        protected void grdCokeDynamicEdit_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                if (grdCokeDynamicEdit.EditIndex != -1)
                {
                    e.Cancel = true;
                }
                else
                {
                    FillGrid();
                    grdCokeDynamicEdit.PageIndex = e.NewPageIndex;
                    grdCokeDynamicEdit.DataBind();
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }

        protected void grdCokeDynamicEdit_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;
                lblMsg.Visible = false;
                // Guid  guid = ML_Common.String2Guid(grdCokeDynamicEdit.DataKeys[e.NewSelectedIndex].Values[0].ToString()); 
                //long lngId = ML_Common.string2Long(grdCokeDynamicEdit.DataKeys[e.NewSelectedIndex].Values[0].ToString()); 
                int lngId = ML_Common.string2int32(grdCokeDynamicEdit.DataKeys[e.NewSelectedIndex].Values[0].ToString());
                ViewState["grdCokeDynamicId"] = lngId;
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
            try
            {
                
                ViewState["grdCokeDynamicEdit"] = null;
                PanelMainDisplay(true);
                objML_CokeDynamic = new ML_CokeDynamic();
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
                int lngId = Convert.ToInt32(ViewState["grdCokeDynamicId"]);
                ML_CokeDynamic objML_CokeDynamic = objBusinessClass.GetCokeDynamicById(lngId);
                try
                {
                    if (objML_CokeDynamic != null)
                    {
                        

                        //objML_CokeDynamic.CokeTypeId = ML_Common.string2int32(ML_Common.clean(ddlCokeTypeEdit.SelectedIndex));
                        //objML_CokeDynamic.CokeType = ML_Common.clean(ddlCokeTypeEdit.SelectedItem.Text);
                        //objML_CokeDynamic.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(ddlCokeSupplierEdit.SelectedIndex));
                        //objML_CokeDynamic.CokeSupplier = ML_Common.clean(ddlCokeSupplierEdit.SelectedItem.Text);
                        //objML_CokeDynamic.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(ddlAnalysisTypeEdit.SelectedIndex));
                        //objML_CokeDynamic.AnalysisType = ML_Common.clean(ddlAnalysisTypeEdit.SelectedItem.Text);

                        objML_CokeDynamic.CokeTypeId = ML_Common.string2int32(ML_Common.GetDropDownValue(ddlCokeTypeEdit, true));
                        objML_CokeDynamic.CokeType = ML_Common.string2string(ML_Common.GetDropDownValue(ddlCokeTypeEdit, false));

                        objML_CokeDynamic.CokeSupplierId = ML_Common.string2int32(ML_Common.GetDropDownValue(ddlCokeSupplierEdit, true));
                        objML_CokeDynamic.CokeSupplier = ML_Common.string2string(ML_Common.GetDropDownValue(ddlCokeSupplierEdit, false));

                        objML_CokeDynamic.AnalysisTypeId = ML_Common.string2int32(ML_Common.GetDropDownValue(ddlAnalysisTypeEdit, true));
                        objML_CokeDynamic.AnalysisType = ML_Common.string2string(ML_Common.GetDropDownValue(ddlAnalysisTypeEdit, false));

                        objML_CokeDynamic.FieldSize = ML_Common.clean(txtFieldSizeEdit.Text);
                        objML_CokeDynamic.FieldUnit = ML_Common.clean(txtFieldUnitEdit.Text);
                        objML_CokeDynamic.FieldSpec = ML_Common.clean(txtFieldSpecEdit.Text);
                        objML_CokeDynamic.MinValue = ML_Common.clean(txtMinValueEdit.Text);
                        objML_CokeDynamic.MaxValue = ML_Common.clean(txtMaxValueEdit.Text);


                        int obhReturn = objBusinessClass.UpdateCokeDynamic(objML_CokeDynamic);
                        if (obhReturn == 1)
                        {
                            lblMsg.Visible = true;
                            lblMsg.Text = "Record Update Successfully";
                            lblMsgEdit.Text = "Record Update Successfully";
                            //FormFieldsClear();
                            ModalPopupExtenderEdit.Hide();
                            //lblMsg.Text = string.Empty;
                            lblMsgEdit.Text = string.Empty;
                        }   
                        else if (obhReturn == 2)
                        {
                            lblMsg.Text = "Ooops!OtherIssue...";
                            lblMsgEdit.Text = "Ooops!OtherIssue...";
                            lblMsg.Visible = true;
                            ModalPopupExtenderEdit.Hide();
                            lblMsgEdit.Text = string.Empty;
                        }
                        else
                        {
                            lblMsg.Text = "Ooops!OtherIssue...";
                            lblMsgEdit.Text = "Ooops!OtherIssue...";
                            lblMsg.Visible = true;
                            lblMsgEdit.Text = string.Empty;
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
                // grdCokeDynamicEdit.EditIndex = -1; 
              
                FormFieldsClear();
                FillGrid();
               // PanelEditFormDisplay(false);
                PanelMainDisplay(true);
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }
        #endregion
        //#region populate
        //private void populateCokeTypeList()
        //{
        //    objBusinessClass = new BusinessLayer.BusinessClass();
        //    DataTable ds = null;// objBusinessClass.GetCokeTypeDetail();
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
        //            if (ddlCokeTypeSearch.Items.Count > 0)
        //            {
        //                ddlCokeTypeSearch.Items.Clear();
        //            }

        //            ddlCokeTypeSearch.DataTextField = "CokeType";
        //            ddlCokeTypeSearch.DataValueField = "CokeTypeId";
        //            ddlCokeTypeSearch.DataSource = ds.DefaultView;
        //            ddlCokeTypeSearch.DataBind();
        //        }
        //        ddlCokeTypeSearch.Items.Insert(0, new ListItem("---- Select ----", "-1"));
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
        //        if (ddlCokeSupplierSearch.Items.Count > 0)
        //        {
        //            ddlCokeSupplierSearch.Items.Clear();
        //        }

        //        if (ds.Rows.Count > 0)
        //        {
        //            ddlCokeSupplierSearch.DataTextField = "CokeSupplier";
        //            ddlCokeSupplierSearch.DataValueField = "CokeSupplierId";
        //            ddlCokeSupplierSearch.DataSource = ds.DefaultView;
        //            ddlCokeSupplierSearch.DataBind();
        //        }
        //        ddlCokeSupplierSearch.Items.Insert(0, new ListItem("---- Select ----", "-1"));
        //    }
        //    catch (Exception ex)
        //    {
        //        Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        //    }
        //}

        ////private void populateAnalysisTypeList()
        ////{
        ////    objBusinessClass = new BusinessLayer.BusinessClass();
        ////    DataTable ds = null;// objBusinessClass.GetCokeSupplierDetail();
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
        ////        if (ddlAnalysisTypeSearch.Items.Count > 0)
        ////        {
        ////            ddlAnalysisTypeSearch.Items.Clear();
        ////        }

        ////        if (ds.Rows.Count > 0)
        ////        {
        ////            ddlAnalysisTypeSearch.DataTextField = "AnalysisType";
        ////            ddlAnalysisTypeSearch.DataValueField = "AnalysisTypeId";
        ////            ddlAnalysisTypeSearch.DataSource = ds.DefaultView;
        ////            ddlAnalysisTypeSearch.DataBind();
        ////        }
        ////        ddlAnalysisTypeSearch.Items.Insert(0, new ListItem("---- Select ----", "-1"));
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        ////    }
        ////}

        ////private void populateCokeTypeListEdit()
        ////{
        ////    objBusinessClass = new BusinessLayer.BusinessClass();
        ////    DataTable   ds = null;// objBusinessClass.GetCokeTypeDetail();
        ////    try
        ////    {

        ////        if (ViewState["CokeType"] == null)
        ////        {
        ////            ds = objBusinessClass.GetCokeTypeDetail();
        ////            ViewState["CokeType"] = ds;
        ////        }
        ////        else
        ////        {
        ////            ds = (DataTable)ViewState["CokeType"];
        ////        }


        ////        if (ds.Rows.Count > 0)
        ////        {
        ////            if (ddlCokeTypeEdit.Items.Count > 0)
        ////            {
        ////                ddlCokeTypeEdit.Items.Clear();
        ////            }

        ////            ddlCokeTypeEdit.DataTextField = "CokeType";
        ////            ddlCokeTypeEdit.DataValueField = "CokeTypeId";
        ////            ddlCokeTypeEdit.DataSource = ds.DefaultView;
        ////            ddlCokeTypeEdit.DataBind();
        ////        }
        ////        ddlCokeTypeEdit.Items.Insert(0, new ListItem("---- Select ----", "-1"));
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        ////    }
        ////}

        ////private void populateCokeSupplierListEdit()
        ////{
        ////    objBusinessClass = new BusinessLayer.BusinessClass();
        ////    DataTable  ds = null;// objBusinessClass.GetCokeSupplierDetail();
        ////    try
        ////    {
        ////        if (ViewState["CokeSupplier"] == null)
        ////        {
        ////            ds = objBusinessClass.GetCokeSupplierDetail();
        ////            ViewState["CokeSupplier"] = ds;
        ////        }
        ////        else
        ////        {
        ////            ds = (DataTable)ViewState["CokeSupplier"];
        ////        }
        ////        if (ddlCokeSupplierEdit.Items.Count > 0)
        ////        {
        ////            ddlCokeSupplierEdit.Items.Clear();
        ////        }

        ////        if (ds.Rows.Count > 0)
        ////        {
        ////            ddlCokeSupplierEdit.DataTextField = "CokeSupplier";
        ////            ddlCokeSupplierEdit.DataValueField = "CokeSupplierId";
        ////            ddlCokeSupplierEdit.DataSource = ds.DefaultView;
        ////            ddlCokeSupplierEdit.DataBind();
        ////        }
        ////        ddlCokeSupplierEdit.Items.Insert(0, new ListItem("---- Select ----", "-1"));
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        ////    }
        ////}

        ////private void populateAnalysisTypeListEdit()
        ////{
        ////    objBusinessClass = new BusinessLayer.BusinessClass();
        ////    DataTable ds = null;// objBusinessClass.GetCokeSupplierDetail();
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
        ////        if (ddlAnalysisTypeEdit.Items.Count > 0)
        ////        {
        ////            ddlAnalysisTypeEdit.Items.Clear();
        ////        }

        ////        if (ds.Rows.Count > 0)
        ////        {
        ////            ddlAnalysisTypeEdit.DataTextField = "AnalysisType";
        ////            ddlAnalysisTypeEdit.DataValueField = "AnalysisTypeId";
        ////            ddlAnalysisTypeEdit.DataSource = ds.DefaultView;
        ////            ddlAnalysisTypeEdit.DataBind();
        ////        }
        ////        ddlAnalysisTypeEdit.Items.Insert(0, new ListItem("---- Select ----", "-1"));
        ////    }
        ////    catch (Exception ex)
        ////    {
        ////        Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
        ////    }
        ////}
        //#endregion
        
        #region  BindDataTable
        private DataTable BindCokeDynamicDataTable()
        {
            DataTable myDataTable = new DataTable("myDataTable");
            try
            {


                DataColumn ColumnId;
                ColumnId = new DataColumn();
                ColumnId.DataType = System.Type.GetType("System.String");
                ColumnId.ColumnName = "Id";
                myDataTable.Columns.Add(ColumnId);


                DataColumn ColumnCokeDynamicId;
                ColumnCokeDynamicId = new DataColumn();
                ColumnCokeDynamicId.DataType = System.Type.GetType("System.String");
                ColumnCokeDynamicId.ColumnName = "CokeDynamicId";
                myDataTable.Columns.Add(ColumnCokeDynamicId);


                DataColumn ColumnCokeDynamic;
                ColumnCokeDynamic = new DataColumn();
                ColumnCokeDynamic.DataType = System.Type.GetType("System.String");
                ColumnCokeDynamic.ColumnName = "CokeDynamic";
                myDataTable.Columns.Add(ColumnCokeDynamic);


                DataColumn ColumnCokeTypeId;
                ColumnCokeTypeId = new DataColumn();
                ColumnCokeTypeId.DataType = System.Type.GetType("System.String");
                ColumnCokeTypeId.ColumnName = "CokeTypeId";
                myDataTable.Columns.Add(ColumnCokeTypeId);


                DataColumn ColumnCokeType;
                ColumnCokeType = new DataColumn();
                ColumnCokeType.DataType = System.Type.GetType("System.String");
                ColumnCokeType.ColumnName = "CokeType";
                myDataTable.Columns.Add(ColumnCokeType);


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


                DataColumn ColumnAnalysisTypeId;
                ColumnAnalysisTypeId = new DataColumn();
                ColumnAnalysisTypeId.DataType = System.Type.GetType("System.String");
                ColumnAnalysisTypeId.ColumnName = "AnalysisTypeId";
                myDataTable.Columns.Add(ColumnAnalysisTypeId);


                DataColumn ColumnAnalysisType;
                ColumnAnalysisType = new DataColumn();
                ColumnAnalysisType.DataType = System.Type.GetType("System.String");
                ColumnAnalysisType.ColumnName = "AnalysisType";
                myDataTable.Columns.Add(ColumnAnalysisType);


                DataColumn ColumnFieldSize;
                ColumnFieldSize = new DataColumn();
                ColumnFieldSize.DataType = System.Type.GetType("System.String");
                ColumnFieldSize.ColumnName = "FieldSize";
                myDataTable.Columns.Add(ColumnFieldSize);


                DataColumn ColumnFieldUnit;
                ColumnFieldUnit = new DataColumn();
                ColumnFieldUnit.DataType = System.Type.GetType("System.String");
                ColumnFieldUnit.ColumnName = "FieldUnit";
                myDataTable.Columns.Add(ColumnFieldUnit);


                DataColumn ColumnFieldSpec;
                ColumnFieldSpec = new DataColumn();
                ColumnFieldSpec.DataType = System.Type.GetType("System.String");
                ColumnFieldSpec.ColumnName = "FieldSpec";
                myDataTable.Columns.Add(ColumnFieldSpec);


                DataColumn ColumnFieldResult;
                ColumnFieldResult = new DataColumn();
                ColumnFieldResult.DataType = System.Type.GetType("System.String");
                ColumnFieldResult.ColumnName = "FieldResult";
                myDataTable.Columns.Add(ColumnFieldResult);


                DataColumn ColumnRemarks;
                ColumnRemarks = new DataColumn();
                ColumnRemarks.DataType = System.Type.GetType("System.String");
                ColumnRemarks.ColumnName = "Remarks";
                myDataTable.Columns.Add(ColumnRemarks);


            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
            return myDataTable;
        }
        #endregion 

        protected void btnCancelPopup_Click(object sender, EventArgs e)
        {
            ModalPopupExtenderView.Hide();
        }
        protected void btnCokeDynamicEditCancelPopup_Click(object sender, EventArgs e)
        {
            ModalPopupExtenderEdit.Hide();
        }

        protected void btnCokeDynamicViewCancelPopup_Click(object sender, EventArgs e)
        {
            ModalPopupExtenderView.Hide();
        }
    }
}