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
using System.Drawing;

namespace CMS.TechTeam
{
    public partial class frmCokeDynamic : System.Web.UI.Page
    {
        #region Initialize the Object of the Class
        static string strId = string.Empty;
        public static string setStringFile = string.Empty;
        public static string strImgPath = string.Empty;
       // int errNumber = int.MinValue;
        BusinessClass objBusinessClass = null;
        ML_CokeDynamic objML_CokeDynamic = null;
        #endregion
        public DataTable dtCokeDynamic = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                // Page.Form.Attributes.Add("enctype", "multipart//form-data");
                if (!IsPostBack)
                {
                    ViewState["dtCokeDynamic"] = null;
                    FormFieldsClear();
                    //populateCokeTypeList();
                    //populateCokeSupplierList();
                    //populateAnalysisTypeList();
                    
                    btnSubmit.Visible = false;
                    btnNewAdd.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }

        #region DML Method

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAdd.Enabled)
                {
                    DataRow dr;

                    if (ViewState["dtCokeDynamic"] == null)
                    {
                        dtCokeDynamic = new DataTable();
                        dtCokeDynamic = BindCokeDynamicDataTable();

                    }
                    else
                    {
                        dtCokeDynamic = (DataTable)ViewState["dtCokeDynamic"];
                    }



                    dr = dtCokeDynamic.NewRow();
                    dr["CokeTypeId"] = ML_Common.string2int32(ML_Common.GetDropDownValue(ddlCokeType, true));
                    dr["CokeType"] = ML_Common.string2string(ML_Common.GetDropDownValue(ddlCokeType, false));


                    dr["CokeSupplierId"] = ML_Common.string2int32(ML_Common.GetDropDownValue(ddlCokeSupplier, true));
                    dr["CokeSupplier"] = ML_Common.string2string(ML_Common.GetDropDownValue(ddlCokeSupplier, false));
                    //dr["NameofParty"] = dr["CokeSupplier"];

                    dr["AnalysisTypeId"] = ML_Common.string2int32(ML_Common.GetDropDownValue(ddlAnalysisType, true));
                    dr["AnalysisType"] = ML_Common.string2string(ML_Common.GetDropDownValue(ddlAnalysisType, false));
                    //dr["NameofAnalysis"] = dr["AnalysisType"];

                    //dr["SampleNo"] = dtFlowMetrDataTable.Rows.Count + 1;// ML_Common.string2int32(ML_Common.clean(txtSampleNo.Text));
                    //dr["SamplingDate"] = ML_Common.ToDateTimeSafeNull(txtSamplingDate.Text);
                    //dr["StoreSINo"] = ML_Common.string2int32(ML_Common.clean(txtStoreSINo.Text));
                    //dr["SampleDetail"] = ML_Common.clean(txtSampleDetail.Text);

                    dr["FieldSize"] = ML_Common.clean(txtFieldSize.Text);
                    dr["FieldUnit"] = ML_Common.clean(txtFieldUnit.Text);
                    dr["FieldSpec"] = ML_Common.clean(txtFieldSpec.Text);
                    dr["MinValue"] = ML_Common.clean(txtMinValue.Text);
                    dr["MaxValue"] = ML_Common.clean(txtMaxValue.Text);







                    dtCokeDynamic.Rows.Add(dr);

                    //DtList = (DataTable)ViewState["grdStartupBathTapping"];
                    if (dtCokeDynamic.Rows.Count > 0)
                    {
                        ViewState["dtCokeDynamic"] = dtCokeDynamic;
                        grdCokeDynamic.DataSource = dtCokeDynamic;
                        grdCokeDynamic.DataBind();
                    }
                    else
                    {
                        dtCokeDynamic.Rows.Add(dtCokeDynamic.NewRow());
                        grdCokeDynamic.DataSource = dtCokeDynamic;
                        grdCokeDynamic.DataBind();

                        int TotalColumns = grdCokeDynamic.Rows[0].Cells.Count;
                        grdCokeDynamic.Rows[0].Cells.Clear();
                        grdCokeDynamic.Rows[0].Cells.Add(new TableCell());
                        grdCokeDynamic.Rows[0].Cells[0].ColumnSpan = TotalColumns;
                        grdCokeDynamic.Rows[0].Cells[0].Text = "No Record Found";
                    }


                    txtFieldSize.Text = string.Empty;
                    txtFieldUnit.Text = string.Empty;
                    txtFieldSpec.Text = string.Empty;
                    txtMinValue.Text = string.Empty;
                    txtMaxValue.Text = string.Empty;



                    UpdatePanelGrid.Update();
                    btnSubmit.Visible = true;

                    btnSubmit.BackColor = System.Drawing.ColorTranslator.FromHtml("#5bc0de");
                    btnSubmit.ForeColor = System.Drawing.Color.White;



                    btnNewAdd.Visible = true;
                   // btnNewAdd.BackColor = System.Drawing.Color.Green;
                    btnNewAdd.BackColor = System.Drawing.ColorTranslator.FromHtml("#5bc0de");
                    btnSubmit.ForeColor = System.Drawing.Color.White;
                    UpdatePanelSave.Update();
                }

            }
            catch (Exception ex)
            {
                string str = ex.Message.ToString();

            }
        }

        protected void btnNewAdd_Click(object sender, EventArgs e)
        {
            try
            {

                ML_Common.SetDropDownValue(ddlCokeType, -1);
                ML_Common.SetDropDownValue(ddlCokeSupplier, -1);
                ML_Common.SetDropDownValue(ddlAnalysisType, -1);
                txtFieldSize.Text = string.Empty;
                txtFieldUnit.Text = string.Empty;
                txtFieldSpec.Text = string.Empty;
                txtMinValue.Text = string.Empty;
                txtMaxValue.Text = string.Empty;



                ViewState["dtCokeDynamic"] = null;
                dtCokeDynamic = new DataTable();
                dtCokeDynamic = BindCokeDynamicDataTable();

                dtCokeDynamic.Rows.Add(dtCokeDynamic.NewRow());
                grdCokeDynamic.DataSource = dtCokeDynamic;
                grdCokeDynamic.DataBind();

                //int TotalColumns = grdCokeComposite.Rows[0].Cells.Count;
                //grdCokeComposite.Rows[0].Cells.Clear();
                //grdCokeComposite.Rows[0].Cells.Add(new TableCell());
                //grdCokeComposite.Rows[0].Cells[0].ColumnSpan = TotalColumns;
                //grdCokeComposite.Rows[0].Cells[0].Text = "No Record Found";

                btnSubmit.Visible = false;
                btnNewAdd.Visible = false;



                UpdatePanelSave.Update();
                UpdatePanelGrid.Update();


            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }

        #endregion

        #region Event GridView
        protected void grdCokeDynamic_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if ((e.Row.RowType == DataControlRowType.DataRow) && (e.Row.RowState == DataControlRowState.Normal || e.Row.RowState == DataControlRowState.Alternate))
            {
                //try
                //{
                //    Label lblId = (Label)e.Row.FindControl("lblId");
                //    if (lblId != null)
                //    {
                //        try
                //        {
                //            lblId.Text = ML_Common.string2Eclips(lblId.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblId.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblCokeDynamicId = (Label)e.Row.FindControl("lblCokeDynamicId");
                //    if (lblCokeDynamicId != null)
                //    {
                //        try
                //        {
                //            lblCokeDynamicId.Text = ML_Common.string2Eclips(lblCokeDynamicId.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblCokeDynamicId.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblCokeDynamic = (Label)e.Row.FindControl("lblCokeDynamic");
                //    if (lblCokeDynamic != null)
                //    {
                //        try
                //        {
                //            lblCokeDynamic.Text = ML_Common.string2Eclips(lblCokeDynamic.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblCokeDynamic.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblCokeTypeId = (Label)e.Row.FindControl("lblCokeTypeId");
                //    if (lblCokeTypeId != null)
                //    {
                //        try
                //        {
                //            lblCokeTypeId.Text = ML_Common.string2Eclips(lblCokeTypeId.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblCokeTypeId.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblCokeType = (Label)e.Row.FindControl("lblCokeType");
                //    if (lblCokeType != null)
                //    {
                //        try
                //        {
                //            lblCokeType.Text = ML_Common.string2Eclips(lblCokeType.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblCokeType.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblCokeSupplierId = (Label)e.Row.FindControl("lblCokeSupplierId");
                //    if (lblCokeSupplierId != null)
                //    {
                //        try
                //        {
                //            lblCokeSupplierId.Text = ML_Common.string2Eclips(lblCokeSupplierId.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblCokeSupplierId.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblCokeSupplier = (Label)e.Row.FindControl("lblCokeSupplier");
                //    if (lblCokeSupplier != null)
                //    {
                //        try
                //        {
                //            lblCokeSupplier.Text = ML_Common.string2Eclips(lblCokeSupplier.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblCokeSupplier.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblAnalysisTypeId = (Label)e.Row.FindControl("lblAnalysisTypeId");
                //    if (lblAnalysisTypeId != null)
                //    {
                //        try
                //        {
                //            lblAnalysisTypeId.Text = ML_Common.string2Eclips(lblAnalysisTypeId.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblAnalysisTypeId.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblAnalysisType = (Label)e.Row.FindControl("lblAnalysisType");
                //    if (lblAnalysisType != null)
                //    {
                //        try
                //        {
                //            lblAnalysisType.Text = ML_Common.string2Eclips(lblAnalysisType.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblAnalysisType.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblFieldSize = (Label)e.Row.FindControl("lblFieldSize");
                //    if (lblFieldSize != null)
                //    {
                //        try
                //        {
                //            lblFieldSize.Text = ML_Common.string2Eclips(lblFieldSize.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblFieldSize.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblFieldUnit = (Label)e.Row.FindControl("lblFieldUnit");
                //    if (lblFieldUnit != null)
                //    {
                //        try
                //        {
                //            lblFieldUnit.Text = ML_Common.string2Eclips(lblFieldUnit.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblFieldUnit.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblFieldSpec = (Label)e.Row.FindControl("lblFieldSpec");
                //    if (lblFieldSpec != null)
                //    {
                //        try
                //        {
                //            lblFieldSpec.Text = ML_Common.string2Eclips(lblFieldSpec.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblFieldSpec.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblMinValue = (Label)e.Row.FindControl("lblMinValue");
                //    if (lblMinValue != null)
                //    {
                //        try
                //        {
                //            lblMinValue.Text = ML_Common.string2Eclips(lblMinValue.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblMinValue.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblMaxValue = (Label)e.Row.FindControl("lblMaxValue");
                //    if (lblMaxValue != null)
                //    {
                //        try
                //        {
                //            lblMaxValue.Text = ML_Common.string2Eclips(lblMaxValue.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblMaxValue.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }
                //  }
                //catch (Exception ex)
                //{
                //    Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //}
            }


            if ((e.Row.RowType == DataControlRowType.DataRow) && (e.Row.RowState == DataControlRowState.Edit || (e.Row.RowState == (DataControlRowState.Edit | DataControlRowState.Alternate))))
            {
                //try
                //{
                //    Label lblIdEdit = (Label)e.Row.FindControl("lblIdEdit");
                //    if (lblIdEdit != null)
                //    {
                //        try
                //        {
                //            lblIdEdit.Text = ML_Common.string2Eclips(lblIdEdit.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblIdEdit.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblCokeDynamicIdEdit = (Label)e.Row.FindControl("lblCokeDynamicIdEdit");
                //    if (lblCokeDynamicIdEdit != null)
                //    {
                //        try
                //        {
                //            lblCokeDynamicIdEdit.Text = ML_Common.string2Eclips(lblCokeDynamicIdEdit.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblCokeDynamicIdEdit.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblCokeDynamicEdit = (Label)e.Row.FindControl("lblCokeDynamicEdit");
                //    if (lblCokeDynamicEdit != null)
                //    {
                //        try
                //        {
                //            lblCokeDynamicEdit.Text = ML_Common.string2Eclips(lblCokeDynamicEdit.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblCokeDynamicEdit.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblCokeTypeIdEdit = (Label)e.Row.FindControl("lblCokeTypeIdEdit");
                //    if (lblCokeTypeIdEdit != null)
                //    {
                //        try
                //        {
                //            lblCokeTypeIdEdit.Text = ML_Common.string2Eclips(lblCokeTypeIdEdit.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblCokeTypeIdEdit.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblCokeTypeEdit = (Label)e.Row.FindControl("lblCokeTypeEdit");
                //    if (lblCokeTypeEdit != null)
                //    {
                //        try
                //        {
                //            lblCokeTypeEdit.Text = ML_Common.string2Eclips(lblCokeTypeEdit.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblCokeTypeEdit.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblCokeSupplierIdEdit = (Label)e.Row.FindControl("lblCokeSupplierIdEdit");
                //    if (lblCokeSupplierIdEdit != null)
                //    {
                //        try
                //        {
                //            lblCokeSupplierIdEdit.Text = ML_Common.string2Eclips(lblCokeSupplierIdEdit.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblCokeSupplierIdEdit.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblCokeSupplierEdit = (Label)e.Row.FindControl("lblCokeSupplierEdit");
                //    if (lblCokeSupplierEdit != null)
                //    {
                //        try
                //        {
                //            lblCokeSupplierEdit.Text = ML_Common.string2Eclips(lblCokeSupplierEdit.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblCokeSupplierEdit.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblAnalysisTypeIdEdit = (Label)e.Row.FindControl("lblAnalysisTypeIdEdit");
                //    if (lblAnalysisTypeIdEdit != null)
                //    {
                //        try
                //        {
                //            lblAnalysisTypeIdEdit.Text = ML_Common.string2Eclips(lblAnalysisTypeIdEdit.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblAnalysisTypeIdEdit.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblAnalysisTypeEdit = (Label)e.Row.FindControl("lblAnalysisTypeEdit");
                //    if (lblAnalysisTypeEdit != null)
                //    {
                //        try
                //        {
                //            lblAnalysisTypeEdit.Text = ML_Common.string2Eclips(lblAnalysisTypeEdit.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblAnalysisTypeEdit.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblFieldSizeEdit = (Label)e.Row.FindControl("lblFieldSizeEdit");
                //    if (lblFieldSizeEdit != null)
                //    {
                //        try
                //        {
                //            lblFieldSizeEdit.Text = ML_Common.string2Eclips(lblFieldSizeEdit.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblFieldSizeEdit.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblFieldUnitEdit = (Label)e.Row.FindControl("lblFieldUnitEdit");
                //    if (lblFieldUnitEdit != null)
                //    {
                //        try
                //        {
                //            lblFieldUnitEdit.Text = ML_Common.string2Eclips(lblFieldUnitEdit.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblFieldUnitEdit.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblFieldSpecEdit = (Label)e.Row.FindControl("lblFieldSpecEdit");
                //    if (lblFieldSpecEdit != null)
                //    {
                //        try
                //        {
                //            lblFieldSpecEdit.Text = ML_Common.string2Eclips(lblFieldSpecEdit.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblFieldSpecEdit.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblMinValueEdit = (Label)e.Row.FindControl("lblMinValueEdit");
                //    if (lblMinValueEdit != null)
                //    {
                //        try
                //        {
                //            lblMinValueEdit.Text = ML_Common.string2Eclips(lblMinValueEdit.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblMinValueEdit.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }


                //    Label lblMaxValueEdit = (Label)e.Row.FindControl("lblMaxValueEdit");
                //    if (lblMaxValueEdit != null)
                //    {
                //        try
                //        {
                //            lblMaxValueEdit.Text = ML_Common.string2Eclips(lblMaxValueEdit.Text, 30);
                //        }
                //        catch (Exception ex)
                //        {
                //            lblMaxValueEdit.Text = string.Empty;
                //            Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //        }
                //    }
                //}
                //catch (Exception ex)
                //{
                //    Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
                //}
            }
        }

        protected void grdCokeDynamic_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                // Guid  guid = ML_Common.String2Guid(grdCokeComposite.DataKeys[e.RowIndex].Values[0].ToString()); 
                int lngId = ML_Common.string2int(grdCokeDynamic.DataKeys[e.RowIndex].Values[0].ToString());
                DeleteGridRowItem(lngId);
                ViewState["grdCokeDynamic"] = null;
                //FillGrid();
                //  FormFieldsClear();
                //PanelEditFormDisplay(false); 

                lblMsg.Text = string.Empty;
                UpdatePanelCokeDynamicDisplay.Update();
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }

        protected void grdCokeDynamic_RowEditing(object sender, GridViewEditEventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;

                //grdCokeComposite.EditIndex = -1; 
                //grdCokeComposite.EditIndex = e.NewEditIndex; 
                // Guid  guid = ML_Common.String2Guid(grdCokeComposite.DataKeys[e.NewEditIndex].Values[0].ToString()); 
                //int lngId = ML_Common.string2int(grdCokeComposite.DataKeys[e.NewEditIndex].Values[0].ToString()); 
                int lngId = ML_Common.string2int32(grdCokeDynamic.DataKeys[e.NewEditIndex].Values[0].ToString());
                if (lngId > 0)
                {
                    ViewState["grdCokeDynamicId"] = lngId;
                    grdCokeDynamic.EditIndex = -1;
                    e.Cancel = true;
                    FormFieldsClear();
                    //FillObjectToForm(lngId, true);
                    // UpdatePanelEdit.Update(); 
                    //ModalPopupExtenderEdit.Show(); 
                }
                else
                {
                    lblMsg.Text = "Record is not exists?";

                }
                UpdatePanelCokeDynamicDisplay.Update();
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }

        protected void grdCokeDynamic_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                if (grdCokeDynamic.EditIndex != -1)
                {
                    e.Cancel = true;
                }
                else
                {
                    //FillGrid();
                    grdCokeDynamic.PageIndex = e.NewPageIndex;
                    grdCokeDynamic.DataBind();
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }

        protected void grdCokeDynamic_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            try
            {
                lblMsg.Text = string.Empty;

                // Guid  guid = ML_Common.String2Guid(grdCokeComposite.DataKeys[e.NewSelectedIndex].Values[0].ToString()); 
                //int lngId = ML_Common.string2int(grdCokeComposite.DataKeys[e.NewSelectedIndex].Values[0].ToString()); 
                int lngId = ML_Common.string2int32(grdCokeDynamic.DataKeys[e.NewSelectedIndex].Values[0].ToString());
                ViewState["grdCokeDynamicId"] = lngId;
                if (lngId > 0)
                {
                    FormFieldsClear();
                    //FillObjectToForm(lngId, false);
                    // UpdatePanelView.Update(); 
                    //ModalPopupExtenderView.Show(); 
                }
                else
                {
                    lblMsg.Text = "Record is not exists?";

                }
                UpdatePanelCokeDynamicDisplay.Update();
            }
            catch (Exception ex)
            {
                Exception exc = ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
        }


        private int DeleteGridRowItem(int lngId)
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


        #endregion

        #region Other Method
        public void FormFieldsClear()
        {
            try
            {

                //ddlCokeType.SelectedIndex = 0;

                //ddlCokeSupplier.SelectedIndex = 0;

                //ddlAnalysisType.SelectedIndex = 0;
                
                txtFieldSize.Text = string.Empty;
                txtFieldUnit.Text = string.Empty;
                txtFieldSpec.Text = string.Empty;
                txtMinValue.Text = string.Empty;
                txtMaxValue.Text = string.Empty;
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
        //            if (ddlCokeType.Items.Count > 0)
        //            {
        //                ddlCokeType.Items.Clear();
        //            }

        //            ddlCokeType.DataTextField = "CokeType";
        //            ddlCokeType.DataValueField = "CokeTypeId";
        //            ddlCokeType.DataSource = ds.DefaultView;
        //            ddlCokeType.DataBind();
        //        }
        //        ddlCokeType.Items.Insert(0, new ListItem("---- Select ----", "-1"));
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
        //        if (ddlCokeSupplier.Items.Count > 0)
        //        {
        //            ddlCokeSupplier.Items.Clear();
        //        }

        //        if (ds.Rows.Count > 0)
        //        {
        //            ddlCokeSupplier.DataTextField = "CokeSupplier";
        //            ddlCokeSupplier.DataValueField = "CokeSupplierId";
        //            ddlCokeSupplier.DataSource = ds.DefaultView;
        //            ddlCokeSupplier.DataBind();
        //        }
        //        ddlCokeSupplier.Items.Insert(0, new ListItem("---- Select ----", "-1"));
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
        ////        ddlAnalysisType.Items.Insert(0, new ListItem("---- Select ----", "-1"));
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


                DataColumn ColumnMinValue;
                ColumnMinValue = new DataColumn();
                ColumnMinValue.DataType = System.Type.GetType("System.String");
                ColumnMinValue.ColumnName = "MinValue";
                myDataTable.Columns.Add(ColumnMinValue);


                DataColumn ColumnMaxValue;
                ColumnMaxValue = new DataColumn();
                ColumnMaxValue.DataType = System.Type.GetType("System.String");
                ColumnMaxValue.ColumnName = "MaxValue";
                myDataTable.Columns.Add(ColumnMaxValue);


            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
            }
            return myDataTable;
        }
        #endregion

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
           
            if (IsValid)
            {
                //errNumber = -1;
                try
                {
                    if (btnSubmit.Enabled)
                    {
                        int obhReturn = -1;
                        objBusinessClass = new BusinessLayer.BusinessClass();
                        objML_CokeDynamic = new ML_CokeDynamic();
                        
                        //objML_CokeDynamic.Id = ML_Common.string2Long(ML_Common.clean(txtId.Text));
                        //objML_CokeDynamic.CokeDynamicId = ML_Common.string2Long(ML_Common.clean(txtCokeDynamicId.Text));
                        //objML_CokeDynamic.CokeDynamic = ML_Common.clean(txtCokeDynamic.Text);

                        objML_CokeDynamic.CokeTypeId = ML_Common.string2int32(ML_Common.GetDropDownValue(ddlCokeType, true));
                        objML_CokeDynamic.CokeType = ML_Common.string2string(ML_Common.GetDropDownValue(ddlCokeType, false));

                        objML_CokeDynamic.CokeSupplierId = ML_Common.string2int32(ML_Common.GetDropDownValue(ddlCokeSupplier, true));
                        objML_CokeDynamic.CokeSupplier = ML_Common.string2string(ML_Common.GetDropDownValue(ddlCokeSupplier, false));

                        objML_CokeDynamic.AnalysisTypeId = ML_Common.string2int32(ML_Common.GetDropDownValue(ddlAnalysisType, true));
                        objML_CokeDynamic.AnalysisType = ML_Common.string2string(ML_Common.GetDropDownValue(ddlAnalysisType, false));


                        objML_CokeDynamic.FieldSize = ML_Common.clean(txtFieldSize.Text);
                        objML_CokeDynamic.FieldUnit = ML_Common.clean(txtFieldUnit.Text);
                        objML_CokeDynamic.FieldSpec = ML_Common.clean(txtFieldSpec.Text);
                        objML_CokeDynamic.MinValue = ML_Common.clean(txtMinValue.Text);
                        objML_CokeDynamic.MaxValue = ML_Common.clean(txtMaxValue.Text);




                        for (int i = 0; i <= grdCokeDynamic.Rows.Count - 1; i++)
                        {

                            objML_CokeDynamic.FieldSize = string.Empty;
                            objML_CokeDynamic.FieldUnit = string.Empty;
                            objML_CokeDynamic.FieldSpec = string.Empty;
                            objML_CokeDynamic.MinValue = string.Empty;
                            objML_CokeDynamic.MaxValue = string.Empty;


                            GridViewRow gRow = grdCokeDynamic.Rows[i];
                            Label lblCokeTypeID = (Label)gRow.FindControl("lblCokeTypeID");
                            if (lblCokeTypeID != null)
                            {
                                objML_CokeDynamic.CokeTypeId = ML_Common.string2int32(lblCokeTypeID.Text);
                            }
                            Label lblCokeType = (Label)gRow.FindControl("lblCokeType");
                            if (lblCokeType != null)
                            {
                                objML_CokeDynamic.CokeType = ML_Common.clean(lblCokeType.Text);
                            }



                            Label lblCokeSupplierID = (Label)gRow.FindControl("lblCokeSupplierID");
                            if (lblCokeSupplierID != null)
                            {
                                objML_CokeDynamic.CokeSupplierId = ML_Common.string2int32(lblCokeSupplierID.Text);
                            }
                            Label lblCokeSupplier = (Label)gRow.FindControl("lblCokeSupplier");
                            if (lblCokeSupplier != null)
                            {
                                objML_CokeDynamic.CokeSupplier = ML_Common.clean(lblCokeSupplier.Text);
                            }



                            Label lblAnalysisTypeID = (Label)gRow.FindControl("lblAnalysisTypeID");
                            if (lblAnalysisTypeID != null)
                            {
                                objML_CokeDynamic.AnalysisTypeId = ML_Common.string2int32(lblAnalysisTypeID.Text);
                            }
                            Label lblAnalysisType = (Label)gRow.FindControl("lblAnalysisType");
                            if (lblAnalysisTypeID != null)
                            {
                                objML_CokeDynamic.AnalysisType = ML_Common.clean(lblAnalysisType.Text);
                            }




                            Label lblFieldSize = (Label)gRow.FindControl("lblFieldSize");
                            if (lblFieldSize != null)
                            {
                                objML_CokeDynamic.FieldSize = lblFieldSize.Text;
                            }
                            Label lblFieldUnit = (Label)gRow.FindControl("lblFieldUnit");
                            if (lblFieldUnit != null)
                            {
                                objML_CokeDynamic.FieldUnit = lblFieldUnit.Text;
                            }
                            Label lblFieldSpec = (Label)gRow.FindControl("lblFieldSpec");
                            if (lblFieldSpec != null)
                            {
                                objML_CokeDynamic.FieldSpec = lblFieldSpec.Text;
                            }
                            Label lblMinValue = (Label)gRow.FindControl("lblMinValue");
                            if (lblMinValue != null)
                            {
                                objML_CokeDynamic.MinValue = lblMinValue.Text;
                            }
                            Label lblMaxValue = (Label)gRow.FindControl("lblMaxValue");
                            if (lblMaxValue != null)
                            {
                                objML_CokeDynamic.MaxValue = lblMaxValue.Text;
                            }
                            obhReturn = objBusinessClass.AddCokeDynamic(objML_CokeDynamic);
                        }

                        if (obhReturn == 1)
                        {
                            lblMsg.Text = "Record Update Successfully";
                            lblMsgEdit.Text = "Record Update Successfully";
                            btnSubmit.Visible = false;
                            UpdatePanelSave.Update();

                        }
                        else
                        {
                            lblMsg.Text = "Ooops!OtherIssue...";
                            lblMsgEdit.Text = "Ooops!OtherIssue...";
                        }
                        txtFieldSize.Text = string.Empty;
                        txtFieldUnit.Text = string.Empty;
                        txtFieldSpec.Text = string.Empty;
                        txtMinValue.Text = string.Empty;
                        txtMaxValue.Text = string.Empty;

                        lblMsg.Text = string.Empty;
                        lblMsgEdit.Text = string.Empty;
                        UpdatePanelSave.Update();
                        btnSubmit.Enabled = true;

                        ViewState["dtCokeDynamic"] = null;

                        dtCokeDynamic = new DataTable();
                        dtCokeDynamic = BindCokeDynamicDataTable();
                        grdCokeDynamic.DataSource = dtCokeDynamic;
                        grdCokeDynamic.DataBind();
                        UpdatePanelGrid.Update();

                        btnAdd.Enabled = true;
                        //btnSubmit.Visible = false;
                    }
                  
                }

                catch (Exception ex)
                {
                    Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                }
            }


        }



    }
}