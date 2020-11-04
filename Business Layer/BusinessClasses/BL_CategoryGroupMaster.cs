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

namespace BusinessLayer.BusinessClasses
{
   public class BL_CategoryGroupMaster
    {
        #region All Variable
        StringBuilder sbTraceInformation = new StringBuilder();
        ML_CategoryGroupMaster objML_CategoryGroupMaster = null;

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
        public int Add(ML_CategoryGroupMaster objML_CategoryGroupMaster)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CategoryGroupMaster:Add(ML_CategoryGroupMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);
                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	          { 
	             #region Add Properties 
	             new SqlParameter("@CategoryGroupCode", objML_CategoryGroupMaster.CategoryGroupCode), 
 new SqlParameter("@CanteenCode", objML_CategoryGroupMaster.CanteenCode), 
 new SqlParameter("@CategoryGroupName", objML_CategoryGroupMaster.CategoryGroupName), 
 new SqlParameter("@CategoryGroupActive", objML_CategoryGroupMaster.CategoryGroupActive), 
	             ReturnObj 
	             #endregion  
	          };
                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_SaveCategoryGroupMaster.ToString(), this.Parameters);
                sbTraceInformation.Append("Exit:-From BusinessClasses-CategoryGroupMaster:Add(ML_CategoryGroupMaster");
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

        public int Update(ML_CategoryGroupMaster objML_CategoryGroupMaster)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CategoryGroupMaster:Update(ML_CategoryGroupMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	           { 
	               #region Update Properties 
	               new SqlParameter("@CategoryGroupCode", objML_CategoryGroupMaster.CategoryGroupCode), 
 new SqlParameter("@CanteenCode", objML_CategoryGroupMaster.CanteenCode), 
 new SqlParameter("@CategoryGroupName", objML_CategoryGroupMaster.CategoryGroupName), 
 new SqlParameter("@CategoryGroupActive", objML_CategoryGroupMaster.CategoryGroupActive), 
	               ReturnObj 
	               #endregion  
	           };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateCategoryGroupMaster.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CategoryGroupMaster:Update(ML_CategoryGroupMaster");
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

        public int UpdateUnique(ML_CategoryGroupMaster objML_CategoryGroupMaster)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CategoryGroupMaster:UpdateUnique(ML_CategoryGroupMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	           { 
	               #region Update Unique Properties 
	               new SqlParameter("@CategoryGroupCode", objML_CategoryGroupMaster.CategoryGroupCode), 
 new SqlParameter("@CanteenCode", objML_CategoryGroupMaster.CanteenCode), 
 new SqlParameter("@CategoryGroupName", objML_CategoryGroupMaster.CategoryGroupName), 
 new SqlParameter("@CategoryGroupActive", objML_CategoryGroupMaster.CategoryGroupActive), 
	               ReturnObj 
	               #endregion  
	           };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateUniqueCategoryGroupMaster.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CategoryGroupMaster:UpdateUnique(ML_CategoryGroupMaster");
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

      //  public int Delete(long delId)
      //  {
      //      int results = 0;
      //      try
      //      {
      //          sbTraceInformation = new StringBuilder();
      //          sbTraceInformation.Append("Entered:-Inside BusinessClasses-CategoryGroupMaster:Delete(long delId)");
      //          sbTraceInformation.Remove(0, sbTraceInformation.Length);

      //          SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
      //          ReturnObj.Direction = ParameterDirection.Output;
      //          SqlParameter[] parameters = 
      //{ 
      // #region Delete Properties 
      //  new SqlParameter("@Id", delId), 
      //ReturnObj 
      // #endregion  
      //};

      //          this.Parameters = parameters;
      //          SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCategoryGroupMasterById.ToString(), this.Parameters);

      //          sbTraceInformation.Append("Exit:-From BusinessClasses-CategoryGroupMaster:Delete(long AdminId)");
      //          sbTraceInformation.Remove(0, sbTraceInformation.Length);

      //          if (ReturnObj.Value != null)
      //          {
      //              results = ML_Common.string2int32(ReturnObj.Value.ToString());
      //          }
      //      }
      //      catch (SqlException sqlExc)
      //      {
      //          int errNumber = int.MinValue;
      //          //LogManager.LogManager.WriteErrorLog(sqlExc); 
      //          foreach (SqlError error in sqlExc.Errors)
      //          {
      //              errNumber = error.Number;
      //          }
      //          if (errNumber == 50000)
      //          {
      //              results = 999;
      //              throw;
      //          }
      //      }
      //      catch (Exception ex)
      //      {
      //          results = 0;
      //          Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
      //          throw;
      //      }
      //      finally
      //      {
      //          //LogManager.LogManager.WriteTraceLog(sbTraceInformation.ToString()); 
      //      }
      //      return results;
      //  }

        #endregion
        #region Delete
        public int DeleteCategoryGroupMasterByCategoryGroupCode(long CategoryGroupCode)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CategoryGroupMaster:Delete(long delId)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@CategoryGroupCode", CategoryGroupCode), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCategoryGroupMasterByCategoryGroupCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CategoryGroupMaster:Delete(long AdminId)");
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

        public int DeleteCategoryGroupMasterByCanteenCode(long CanteenCode)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CategoryGroupMaster:Delete(long delId)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@CanteenCode", CanteenCode), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCategoryGroupMasterByCanteenCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CategoryGroupMaster:Delete(long AdminId)");
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

        public int DeleteCategoryGroupMasterByCategoryGroupName(long CategoryGroupName)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CategoryGroupMaster:Delete(long delId)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@CategoryGroupName", CategoryGroupName), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCategoryGroupMasterByCategoryGroupName.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CategoryGroupMaster:Delete(long AdminId)");
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

        public int DeleteCategoryGroupMasterByCategoryGroupActive(long CategoryGroupActive)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CategoryGroupMaster:Delete(long delId)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@CategoryGroupActive", CategoryGroupActive), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCategoryGroupMasterByCategoryGroupActive.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CategoryGroupMaster:Delete(long AdminId)");
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
       


        #region Get Method

        public DataSet GetCategoryGroupMasterBySeacrh(ML_CategoryGroupMaster objML_CategoryGroupMaster)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CategoryGroupMaster:GetCategoryGroupMasterBySeacrh(ML_CategoryGroupMaster objML_CategoryGroupMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                DateTime? dtFromdate = null;
                DateTime objFromdate;
                if (DateTime.TryParse(objML_CategoryGroupMaster.FromDate.ToString(), out objFromdate))
                {
                    if (objFromdate.ToString() != "1/1/1900 12:00:00 AM")
                    {
                        dtFromdate = objFromdate;
                    }
                }
                DateTime? dtTodate = null;
                DateTime objdtTodate;
                if (DateTime.TryParse(objML_CategoryGroupMaster.ToDate.ToString(), out objdtTodate))
                {
                    if (objdtTodate.ToString() != "1/1/1900 12:00:00 AM")
                    {
                        dtTodate = objdtTodate;
                    }
                }

                SqlParameter[] parameters = 
	  { 
	   #region Search Properties 
	  new SqlParameter("@CategoryGroupCode", objML_CategoryGroupMaster.CategoryGroupCode), 
 new SqlParameter("@CanteenCode", objML_CategoryGroupMaster.CanteenCode), 
 new SqlParameter("@CategoryGroupName", objML_CategoryGroupMaster.CategoryGroupName), 
 new SqlParameter("@CategoryGroupActive", objML_CategoryGroupMaster.CategoryGroupActive), 
 new SqlParameter("@FromDate", dtFromdate), 
 new SqlParameter("@ToDate",dtTodate)
	   #endregion 
	  };
                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCategoryGroupMasterBySearch.ToString(), this.Parameters);
                sbTraceInformation.Append("Exit:-From BusinessClasses-CategoryGroupMaster:GetCategoryGroupMasterBySeacrh(ML_CategoryGroupMaster objML_CategoryGroupMaster");
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

        public DataSet GetCategoryGroupMaster()
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CategoryGroupMaster:GetCategoryGroupMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCategoryGroupMaster.ToString());

                sbTraceInformation.Append("Exit:-From BusinessClasses-CategoryGroupMaster:GetCategoryGroupMaster");
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


        public ML_CategoryGroupMaster GetCategoryGroupMasterByCategoryGroupCode(long CategoryGroupCode)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CategoryGroupMaster:GetCategoryGroupMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_CategoryGroupMaster = new ML_CategoryGroupMaster();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CategoryGroupCode", CategoryGroupCode) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCategoryGroupMasterByCategoryGroupCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CategoryGroupMaster:GetCategoryGroupMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CategoryGroupMaster.CategoryGroupCode = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupCode"].ToString()));
                        objML_CategoryGroupMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_CategoryGroupMaster.CategoryGroupName = ML_Common.clean(dr["CategoryGroupName"].ToString());
                        objML_CategoryGroupMaster.CategoryGroupActive = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupActive"].ToString()));
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
            return objML_CategoryGroupMaster;
        }


        public ML_CategoryGroupMaster GetCategoryGroupMasterByCanteenCode(long CanteenCode)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CategoryGroupMaster:GetCategoryGroupMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_CategoryGroupMaster = new ML_CategoryGroupMaster();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CanteenCode", CanteenCode) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCategoryGroupMasterByCanteenCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CategoryGroupMaster:GetCategoryGroupMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CategoryGroupMaster.CategoryGroupCode = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupCode"].ToString()));
                        objML_CategoryGroupMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_CategoryGroupMaster.CategoryGroupName = ML_Common.clean(dr["CategoryGroupName"].ToString());
                        objML_CategoryGroupMaster.CategoryGroupActive = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupActive"].ToString()));
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
            return objML_CategoryGroupMaster;
        }


        public ML_CategoryGroupMaster GetCategoryGroupMasterByCategoryGroupName(long CategoryGroupName)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CategoryGroupMaster:GetCategoryGroupMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_CategoryGroupMaster = new ML_CategoryGroupMaster();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CategoryGroupName", CategoryGroupName) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCategoryGroupMasterByCategoryGroupName.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CategoryGroupMaster:GetCategoryGroupMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CategoryGroupMaster.CategoryGroupCode = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupCode"].ToString()));
                        objML_CategoryGroupMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_CategoryGroupMaster.CategoryGroupName = ML_Common.clean(dr["CategoryGroupName"].ToString());
                        objML_CategoryGroupMaster.CategoryGroupActive = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupActive"].ToString()));
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
            return objML_CategoryGroupMaster;
        }


        public ML_CategoryGroupMaster GetCategoryGroupMasterByCategoryGroupActive(long CategoryGroupActive)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CategoryGroupMaster:GetCategoryGroupMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_CategoryGroupMaster = new ML_CategoryGroupMaster();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CategoryGroupActive", CategoryGroupActive) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCategoryGroupMasterByCategoryGroupActive.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CategoryGroupMaster:GetCategoryGroupMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CategoryGroupMaster.CategoryGroupCode = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupCode"].ToString()));
                        objML_CategoryGroupMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_CategoryGroupMaster.CategoryGroupName = ML_Common.clean(dr["CategoryGroupName"].ToString());
                        objML_CategoryGroupMaster.CategoryGroupActive = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupActive"].ToString()));
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
            return objML_CategoryGroupMaster;
        }


        public DataSet GetCategoryGroupMasterByCategoryGroupCodeDs(long CategoryGroupCode)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CategoryGroupMaster: GetCategoryGroupMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_CategoryGroupMaster = new ML_CategoryGroupMaster();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CategoryGroupCode", CategoryGroupCode) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCategoryGroupMasterByCategoryGroupCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CategoryGroupMaster: GetCategoryGroupMasterById(long Id)");
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


        public DataSet GetCategoryGroupMasterByCanteenCodeDs(long CanteenCode)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CategoryGroupMaster: GetCategoryGroupMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_CategoryGroupMaster = new ML_CategoryGroupMaster();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CanteenCode", CanteenCode) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCategoryGroupMasterByCanteenCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CategoryGroupMaster: GetCategoryGroupMasterById(long Id)");
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


        public DataSet GetCategoryGroupMasterByCategoryGroupNameDs(long CategoryGroupName)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CategoryGroupMaster: GetCategoryGroupMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_CategoryGroupMaster = new ML_CategoryGroupMaster();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CategoryGroupName", CategoryGroupName) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCategoryGroupMasterByCategoryGroupName.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CategoryGroupMaster: GetCategoryGroupMasterById(long Id)");
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


        public DataSet GetCategoryGroupMasterByCategoryGroupActiveDs(long CategoryGroupActive)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CategoryGroupMaster: GetCategoryGroupMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_CategoryGroupMaster = new ML_CategoryGroupMaster();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CategoryGroupActive", CategoryGroupActive) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCategoryGroupMasterByCategoryGroupActive.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CategoryGroupMaster: GetCategoryGroupMasterById(long Id)");
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




        public DataSet GetCategoryGroupMasterByLoginName(string loginName)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CategoryGroupMaster:GetCategoryGroupMasterByLoginName(string loginName)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_CategoryGroupMaster = new ML_CategoryGroupMaster();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@loginName", loginName) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCategoryGroupMasterByLoginName.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CategoryGroupMaster:GetCategoryGroupMasterByLoginName(string loginName)");
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
