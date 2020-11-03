using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using ModelLayer;
using DataAccessLayer;
using System.Globalization;
using BusinessLayer.BusinessClasses;
using System.Text.RegularExpressions;
using System.IO;

using System.IO;
namespace BusinessLayer.BusinessClasses
{
    public class BL_ItemCategoryMaster
    {
        #region All Variable 
        StringBuilder sbTraceInformation = new StringBuilder();
        ML_ItemCategoryMaster objML_ItemCategoryMaster = null;

        #endregion

        #region Prperties 

        public string SearchCriteria
        {
            get;
            set;
        }
        public SqlParameter[] Parameters
        {
            get;
            set;
        }
        #endregion


        #region DML Method 
        public int Add(ML_ItemCategoryMaster objML_ItemCategoryMaster)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster:Add(ML_ItemCategoryMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);
                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters =
                { 
	             #region Add Properties 
	             new SqlParameter("@ItemCategoryCode", objML_ItemCategoryMaster.ItemCategoryCode),
 new SqlParameter("@CanteenCode", objML_ItemCategoryMaster.CanteenCode),
 new SqlParameter("@CategoryGroupCode", objML_ItemCategoryMaster.CategoryGroupCode),
 new SqlParameter("@ItemCategoryName", objML_ItemCategoryMaster.ItemCategoryName),
 new SqlParameter("@ItemCategoryActive", objML_ItemCategoryMaster.ItemCategoryActive),
 new SqlParameter("@StartTime", objML_ItemCategoryMaster.StartTime),
 new SqlParameter("@EndTime", objML_ItemCategoryMaster.EndTime),
 new SqlParameter("@ItemCategoryOrder", objML_ItemCategoryMaster.ItemCategoryOrder),
                 ReturnObj 
	             #endregion  
	          };
                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_SaveItemCategoryMaster.ToString(), this.Parameters);
                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster:Add(ML_ItemCategoryMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ReturnObj.Value != null)
                {
                    results = ML_Common.string2int32(ReturnObj.Value.ToString());
                }
            }
            catch (SqlException sqlExc)
            {
                int errNumber = int.MinValue;
                //LogManager.LogManager.WriteErrorLog(sqlExc); 
                foreach (SqlError error in sqlExc.Errors)
                {
                    errNumber = error.Number;
                }
                if (errNumber == 50000)
                {
                    results = 999;
                    throw;
                }
            }
            catch (Exception ex)
            {
                results = 0;
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return results;
        }

        public int Update(ML_ItemCategoryMaster objML_ItemCategoryMaster)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster:Update(ML_ItemCategoryMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters =
                { 
	               #region Update Properties 
	               new SqlParameter("@ItemCategoryCode", objML_ItemCategoryMaster.ItemCategoryCode),
 new SqlParameter("@CanteenCode", objML_ItemCategoryMaster.CanteenCode),
 new SqlParameter("@CategoryGroupCode", objML_ItemCategoryMaster.CategoryGroupCode),
 new SqlParameter("@ItemCategoryName", objML_ItemCategoryMaster.ItemCategoryName),
 new SqlParameter("@ItemCategoryActive", objML_ItemCategoryMaster.ItemCategoryActive),
 new SqlParameter("@StartTime", objML_ItemCategoryMaster.StartTime),
 new SqlParameter("@EndTime", objML_ItemCategoryMaster.EndTime),
 new SqlParameter("@ItemCategoryOrder", objML_ItemCategoryMaster.ItemCategoryOrder),
                   ReturnObj 
	               #endregion  
	           };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateItemCategoryMaster.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster:Update(ML_ItemCategoryMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ReturnObj.Value != null)
                {
                    results = ML_Common.string2int32(ReturnObj.Value.ToString());
                }
            }
            catch (SqlException sqlExc)
            {
                int errNumber = int.MinValue;
                //LogManager.LogManager.WriteErrorLog(sqlExc); 
                foreach (SqlError error in sqlExc.Errors)
                {
                    errNumber = error.Number;
                }
                if (errNumber == 50000)
                {
                    results = 999;
                    throw;
                }
            }
            catch (Exception ex)
            {
                results = 0;
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return results;
        }

        public int UpdateUnique(ML_ItemCategoryMaster objML_ItemCategoryMaster)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster:UpdateUnique(ML_ItemCategoryMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters =
                { 
	               #region Update Unique Properties 
	               new SqlParameter("@ItemCategoryCode", objML_ItemCategoryMaster.ItemCategoryCode),
 new SqlParameter("@CanteenCode", objML_ItemCategoryMaster.CanteenCode),
 new SqlParameter("@CategoryGroupCode", objML_ItemCategoryMaster.CategoryGroupCode),
 new SqlParameter("@ItemCategoryName", objML_ItemCategoryMaster.ItemCategoryName),
 new SqlParameter("@ItemCategoryActive", objML_ItemCategoryMaster.ItemCategoryActive),
 new SqlParameter("@StartTime", objML_ItemCategoryMaster.StartTime),
 new SqlParameter("@EndTime", objML_ItemCategoryMaster.EndTime),
 new SqlParameter("@ItemCategoryOrder", objML_ItemCategoryMaster.ItemCategoryOrder),
                   ReturnObj 
	               #endregion  
	           };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateUniqueItemCategoryMaster.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster:UpdateUnique(ML_ItemCategoryMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ReturnObj.Value != null)
                {
                    results = ML_Common.string2int32(ReturnObj.Value.ToString());
                }
            }
            catch (SqlException sqlExc)
            {
                int errNumber = int.MinValue;
                //LogManager.LogManager.WriteErrorLog(sqlExc); 
                foreach (SqlError error in sqlExc.Errors)
                {
                    errNumber = error.Number;
                }
                if (errNumber == 50000)
                {
                    results = 999;
                    throw;
                }
            }
            catch (Exception ex)
            {
                results = 0;
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return results;
        }

        public int Delete(long delId)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster:Delete(long delId)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters =
                { 
	   #region Delete Properties 
	    new SqlParameter("@Id", delId),
      ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteItemMasterByItemCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster:Delete(long AdminId)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ReturnObj.Value != null)
                {
                    results = ML_Common.string2int32(ReturnObj.Value.ToString());
                }
            }
            catch (SqlException sqlExc)
            {
                int errNumber = int.MinValue;
                //LogManager.LogManager.WriteErrorLog(sqlExc); 
                foreach (SqlError error in sqlExc.Errors)
                {
                    errNumber = error.Number;
                }
                if (errNumber == 50000)
                {
                    results = 999;
                    throw;
                }
            }
            catch (Exception ex)
            {
                results = 0;
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return results;
        }

        #endregion
        #region Delete  
        public int DeleteItemCategoryMasterByItemCategoryCode(long ItemCategoryCode)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster:Delete(long delId)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters =
                { 
	   #region Delete Properties 
	    new SqlParameter("@ItemCategoryCode", ItemCategoryCode),
      ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteItemCategoryMasterByItemCategoryCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster:Delete(long AdminId)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ReturnObj.Value != null)
                {
                    results = ML_Common.string2int32(ReturnObj.Value.ToString());
                }
            }
            catch (SqlException sqlExc)
            {
                int errNumber = int.MinValue;
                //LogManager.LogManager.WriteErrorLog(sqlExc); 
                foreach (SqlError error in sqlExc.Errors)
                {
                    errNumber = error.Number;
                }
                if (errNumber == 50000)
                {
                    results = 999;
                    throw;
                }
            }
            catch (Exception ex)
            {
                results = 0;
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return results;
        }

        #endregion
        #region Delete Relationship  
        #endregion


        #region Get Method 

        public DataSet GetItemCategoryMasterBySeacrh(ML_ItemCategoryMaster objML_ItemCategoryMaster)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster:GetItemCategoryMasterBySeacrh(ML_ItemCategoryMaster objML_ItemCategoryMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                DateTime? dtFromdate = null;
                DateTime objFromdate;
                if (DateTime.TryParse(objML_ItemCategoryMaster.FromDate.ToString(), out objFromdate))
                {
                    if (objFromdate.ToString() != "1/1/1900 12:00:00 AM")
                    {
                        dtFromdate = objFromdate;
                    }
                }
                DateTime? dtTodate = null;
                DateTime objdtTodate;
                if (DateTime.TryParse(objML_ItemCategoryMaster.ToDate.ToString(), out objdtTodate))
                {
                    if (objdtTodate.ToString() != "1/1/1900 12:00:00 AM")
                    {
                        dtTodate = objdtTodate;
                    }
                }

                SqlParameter[] parameters =
                { 
	   #region Search Properties 
	  new SqlParameter("@ItemCategoryCode", objML_ItemCategoryMaster.ItemCategoryCode),
 new SqlParameter("@CanteenCode", objML_ItemCategoryMaster.CanteenCode),
 new SqlParameter("@CategoryGroupCode", objML_ItemCategoryMaster.CategoryGroupCode),
 new SqlParameter("@ItemCategoryName", objML_ItemCategoryMaster.ItemCategoryName),
 new SqlParameter("@ItemCategoryActive", objML_ItemCategoryMaster.ItemCategoryActive),
 new SqlParameter("@StartTime", objML_ItemCategoryMaster.StartTime),
 new SqlParameter("@EndTime", objML_ItemCategoryMaster.EndTime),
 new SqlParameter("@ItemCategoryOrder", objML_ItemCategoryMaster.ItemCategoryOrder),
 new SqlParameter("@FromDate", dtFromdate),
 new SqlParameter("@ToDate",dtTodate)
	   #endregion 
	  };
                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemCategoryMasterBySearch.ToString(), this.Parameters);
                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster:GetItemCategoryMasterBySeacrh(ML_ItemCategoryMaster objML_ItemCategoryMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);
            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return ds;
        }

        public DataSet GetItemCategoryMaster()
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster:GetItemCategoryMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemCategoryMaster.ToString());

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster:GetItemCategoryMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);
            }
            catch (Exception ex)
            {
                ds = new DataSet();
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return ds;
        }


        public ML_ItemCategoryMaster GetItemCategoryMasterByItemCategoryCode(long ItemCategoryCode)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster:GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
                SqlParameter[] parameters =
                { 
	   #region Get Properties 
	    new SqlParameter("@ItemCategoryCode", ItemCategoryCode) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemCategoryMasterByItemCategoryCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster:GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_ItemCategoryMaster.ItemCategoryCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryCode"].ToString()));
                        objML_ItemCategoryMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_ItemCategoryMaster.CategoryGroupCode = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupCode"].ToString()));
                        objML_ItemCategoryMaster.ItemCategoryName = ML_Common.clean(dr["ItemCategoryName"].ToString());
                        objML_ItemCategoryMaster.ItemCategoryActive = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryActive"].ToString()));
                        objML_ItemCategoryMaster.StartTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["StartTime"].ToString()));
                        objML_ItemCategoryMaster.EndTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["EndTime"].ToString()));
                        objML_ItemCategoryMaster.ItemCategoryOrder = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryOrder"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return objML_ItemCategoryMaster;
        }


        public ML_ItemCategoryMaster GetItemCategoryMasterByCanteenCode(long CanteenCode)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster:GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
                SqlParameter[] parameters =
                { 
	   #region Get Properties 
	    new SqlParameter("@CanteenCode", CanteenCode) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemCategoryMasterByCanteenCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster:GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_ItemCategoryMaster.ItemCategoryCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryCode"].ToString()));
                        objML_ItemCategoryMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_ItemCategoryMaster.CategoryGroupCode = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupCode"].ToString()));
                        objML_ItemCategoryMaster.ItemCategoryName = ML_Common.clean(dr["ItemCategoryName"].ToString());
                        objML_ItemCategoryMaster.ItemCategoryActive = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryActive"].ToString()));
                        objML_ItemCategoryMaster.StartTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["StartTime"].ToString()));
                        objML_ItemCategoryMaster.EndTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["EndTime"].ToString()));
                        objML_ItemCategoryMaster.ItemCategoryOrder = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryOrder"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return objML_ItemCategoryMaster;
        }


        public ML_ItemCategoryMaster GetItemCategoryMasterByCategoryGroupCode(long CategoryGroupCode)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster:GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
                SqlParameter[] parameters =
                { 
	   #region Get Properties 
	    new SqlParameter("@CategoryGroupCode", CategoryGroupCode) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemCategoryMasterByCategoryGroupCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster:GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_ItemCategoryMaster.ItemCategoryCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryCode"].ToString()));
                        objML_ItemCategoryMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_ItemCategoryMaster.CategoryGroupCode = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupCode"].ToString()));
                        objML_ItemCategoryMaster.ItemCategoryName = ML_Common.clean(dr["ItemCategoryName"].ToString());
                        objML_ItemCategoryMaster.ItemCategoryActive = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryActive"].ToString()));
                        objML_ItemCategoryMaster.StartTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["StartTime"].ToString()));
                        objML_ItemCategoryMaster.EndTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["EndTime"].ToString()));
                        objML_ItemCategoryMaster.ItemCategoryOrder = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryOrder"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return objML_ItemCategoryMaster;
        }


        public ML_ItemCategoryMaster GetItemCategoryMasterByItemCategoryName(long ItemCategoryName)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster:GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
                SqlParameter[] parameters =
                { 
	   #region Get Properties 
	    new SqlParameter("@ItemCategoryName", ItemCategoryName) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemCategoryMasterByItemCategoryName.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster:GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_ItemCategoryMaster.ItemCategoryCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryCode"].ToString()));
                        objML_ItemCategoryMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_ItemCategoryMaster.CategoryGroupCode = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupCode"].ToString()));
                        objML_ItemCategoryMaster.ItemCategoryName = ML_Common.clean(dr["ItemCategoryName"].ToString());
                        objML_ItemCategoryMaster.ItemCategoryActive = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryActive"].ToString()));
                        objML_ItemCategoryMaster.StartTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["StartTime"].ToString()));
                        objML_ItemCategoryMaster.EndTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["EndTime"].ToString()));
                        objML_ItemCategoryMaster.ItemCategoryOrder = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryOrder"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return objML_ItemCategoryMaster;
        }


        public ML_ItemCategoryMaster GetItemCategoryMasterByItemCategoryActive(long ItemCategoryActive)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster:GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
                SqlParameter[] parameters =
                { 
	   #region Get Properties 
	    new SqlParameter("@ItemCategoryActive", ItemCategoryActive) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemCategoryMasterByItemCategoryActive.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster:GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_ItemCategoryMaster.ItemCategoryCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryCode"].ToString()));
                        objML_ItemCategoryMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_ItemCategoryMaster.CategoryGroupCode = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupCode"].ToString()));
                        objML_ItemCategoryMaster.ItemCategoryName = ML_Common.clean(dr["ItemCategoryName"].ToString());
                        objML_ItemCategoryMaster.ItemCategoryActive = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryActive"].ToString()));
                        objML_ItemCategoryMaster.StartTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["StartTime"].ToString()));
                        objML_ItemCategoryMaster.EndTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["EndTime"].ToString()));
                        objML_ItemCategoryMaster.ItemCategoryOrder = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryOrder"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return objML_ItemCategoryMaster;
        }


        public ML_ItemCategoryMaster GetItemCategoryMasterByStartTime(long StartTime)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster:GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
                SqlParameter[] parameters =
                { 
	   #region Get Properties 
	    new SqlParameter("@StartTime", StartTime) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemCategoryMasterByStartTime.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster:GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_ItemCategoryMaster.ItemCategoryCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryCode"].ToString()));
                        objML_ItemCategoryMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_ItemCategoryMaster.CategoryGroupCode = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupCode"].ToString()));
                        objML_ItemCategoryMaster.ItemCategoryName = ML_Common.clean(dr["ItemCategoryName"].ToString());
                        objML_ItemCategoryMaster.ItemCategoryActive = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryActive"].ToString()));
                        objML_ItemCategoryMaster.StartTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["StartTime"].ToString()));
                        objML_ItemCategoryMaster.EndTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["EndTime"].ToString()));
                        objML_ItemCategoryMaster.ItemCategoryOrder = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryOrder"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return objML_ItemCategoryMaster;
        }


        public ML_ItemCategoryMaster GetItemCategoryMasterByEndTime(long EndTime)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster:GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
                SqlParameter[] parameters =
                { 
	   #region Get Properties 
	    new SqlParameter("@EndTime", EndTime) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemCategoryMasterByEndTime.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster:GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_ItemCategoryMaster.ItemCategoryCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryCode"].ToString()));
                        objML_ItemCategoryMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_ItemCategoryMaster.CategoryGroupCode = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupCode"].ToString()));
                        objML_ItemCategoryMaster.ItemCategoryName = ML_Common.clean(dr["ItemCategoryName"].ToString());
                        objML_ItemCategoryMaster.ItemCategoryActive = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryActive"].ToString()));
                        objML_ItemCategoryMaster.StartTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["StartTime"].ToString()));
                        objML_ItemCategoryMaster.EndTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["EndTime"].ToString()));
                        objML_ItemCategoryMaster.ItemCategoryOrder = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryOrder"].ToString()));
                    }
                }
            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return objML_ItemCategoryMaster;
        }


        public DataSet GetItemCategoryMasterByItemCategoryCodeDs(long ItemCategoryCode)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster: GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
                SqlParameter[] parameters =
                { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@ItemCategoryCode", ItemCategoryCode) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemCategoryMasterByItemCategoryCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster: GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return ds;
        }


        public DataSet GetItemCategoryMasterByCanteenCodeDs(long CanteenCode)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster: GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
                SqlParameter[] parameters =
                { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CanteenCode", CanteenCode) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemCategoryMasterByCanteenCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster: GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return ds;
        }


        public DataSet GetItemCategoryMasterByCategoryGroupCodeDs(long CategoryGroupCode)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster: GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
                SqlParameter[] parameters =
                { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CategoryGroupCode", CategoryGroupCode) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemCategoryMasterByCategoryGroupCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster: GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return ds;
        }


        public DataSet GetItemCategoryMasterByItemCategoryNameDs(long ItemCategoryName)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster: GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
                SqlParameter[] parameters =
                { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@ItemCategoryName", ItemCategoryName) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemCategoryMasterByItemCategoryName.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster: GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return ds;
        }


        public DataSet GetItemCategoryMasterByItemCategoryActiveDs(long ItemCategoryActive)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster: GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
                SqlParameter[] parameters =
                { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@ItemCategoryActive", ItemCategoryActive) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemCategoryMasterByItemCategoryActive.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster: GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return ds;
        }


        public DataSet GetItemCategoryMasterByStartTimeDs(long StartTime)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster: GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
                SqlParameter[] parameters =
                { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@StartTime", StartTime) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemCategoryMasterByStartTime.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster: GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return ds;
        }


        public DataSet GetItemCategoryMasterByEndTimeDs(long EndTime)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster: GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
                SqlParameter[] parameters =
                { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@EndTime", EndTime) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemCategoryMasterByEndTime.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster: GetItemCategoryMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return ds;
        }




        public DataSet GetItemCategoryMasterByLoginName(string loginName)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemCategoryMaster:GetItemCategoryMasterByLoginName(string loginName)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
                SqlParameter[] parameters =
                { 
	   #region Get Properties 
	    new SqlParameter("@loginName", loginName) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemCategoryMasterByLoginName.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemCategoryMaster:GetItemCategoryMasterByLoginName(string loginName)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
            }
            return ds;
        }


        #endregion
    }
}
