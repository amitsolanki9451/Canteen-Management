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
   public class BL_CanteenMaster
    {
        #region All Variable
        StringBuilder sbTraceInformation = new StringBuilder();
        ML_CanteenMaster objML_CanteenMaster = null;

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
        public int Add(ML_CanteenMaster objML_CanteenMaster)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CanteenMaster:Add(ML_CanteenMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);
                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	          { 
	             #region Add Properties 
	             new SqlParameter("@CanteenCode", objML_CanteenMaster.CanteenCode), 
 new SqlParameter("@CanteenName", objML_CanteenMaster.CanteenName), 
 new SqlParameter("@CanteenAddress", objML_CanteenMaster.CanteenAddress), 
 new SqlParameter("@CanteenActive", objML_CanteenMaster.CanteenActive), 
	             ReturnObj 
	             #endregion  
	          };
                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_SaveCanteenMaster.ToString(), this.Parameters);
                sbTraceInformation.Append("Exit:-From BusinessClasses-CanteenMaster:Add(ML_CanteenMaster");
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

        public int Update(ML_CanteenMaster objML_CanteenMaster)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CanteenMaster:Update(ML_CanteenMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	           { 
	               #region Update Properties 
	               new SqlParameter("@CanteenCode", objML_CanteenMaster.CanteenCode), 
 new SqlParameter("@CanteenName", objML_CanteenMaster.CanteenName), 
 new SqlParameter("@CanteenAddress", objML_CanteenMaster.CanteenAddress), 
 new SqlParameter("@CanteenActive", objML_CanteenMaster.CanteenActive), 
	               ReturnObj 
	               #endregion  
	           };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateCanteenMaster.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CanteenMaster:Update(ML_CanteenMaster");
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

        public int UpdateUnique(ML_CanteenMaster objML_CanteenMaster)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CanteenMaster:UpdateUnique(ML_CanteenMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	           { 
	               #region Update Unique Properties 
	               new SqlParameter("@CanteenCode", objML_CanteenMaster.CanteenCode), 
 new SqlParameter("@CanteenName", objML_CanteenMaster.CanteenName), 
 new SqlParameter("@CanteenAddress", objML_CanteenMaster.CanteenAddress), 
 new SqlParameter("@CanteenActive", objML_CanteenMaster.CanteenActive), 
	               ReturnObj 
	               #endregion  
	           };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateUniqueCanteenMaster.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CanteenMaster:UpdateUnique(ML_CanteenMaster");
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
      //          sbTraceInformation.Append("Entered:-Inside BusinessClasses-CanteenMaster:Delete(long delId)");
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
      //          SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCanteenMasterById.ToString(), this.Parameters);

      //          sbTraceInformation.Append("Exit:-From BusinessClasses-CanteenMaster:Delete(long AdminId)");
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
        public int DeleteCanteenMasterByCanteenCode(long CanteenCode)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CanteenMaster:Delete(long delId)");
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCanteenMasterByCanteenCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CanteenMaster:Delete(long AdminId)");
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

        public int DeleteCanteenMasterByCanteenName(long CanteenName)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CanteenMaster:Delete(long delId)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@CanteenName", CanteenName), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCanteenMasterByCanteenName.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CanteenMaster:Delete(long AdminId)");
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

        public int DeleteCanteenMasterByCanteenAddress(long CanteenAddress)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CanteenMaster:Delete(long delId)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@CanteenAddress", CanteenAddress), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCanteenMasterByCanteenAddress.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CanteenMaster:Delete(long AdminId)");
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

        public int DeleteCanteenMasterByCanteenActive(long CanteenActive)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CanteenMaster:Delete(long delId)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@CanteenActive", CanteenActive), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCanteenMasterByCanteenActive.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CanteenMaster:Delete(long AdminId)");
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

        public DataSet GetCanteenMasterBySeacrh(ML_CanteenMaster objML_CanteenMaster)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CanteenMaster:GetCanteenMasterBySeacrh(ML_CanteenMaster objML_CanteenMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                DateTime? dtFromdate = null;
                DateTime objFromdate;
                if (DateTime.TryParse(objML_CanteenMaster.FromDate.ToString(), out objFromdate))
                {
                    if (objFromdate.ToString() != "1/1/1900 12:00:00 AM")
                    {
                        dtFromdate = objFromdate;
                    }
                }
                DateTime? dtTodate = null;
                DateTime objdtTodate;
                if (DateTime.TryParse(objML_CanteenMaster.ToDate.ToString(), out objdtTodate))
                {
                    if (objdtTodate.ToString() != "1/1/1900 12:00:00 AM")
                    {
                        dtTodate = objdtTodate;
                    }
                }

                SqlParameter[] parameters = 
	  { 
	   #region Search Properties 
	  new SqlParameter("@CanteenCode", objML_CanteenMaster.CanteenCode), 
 new SqlParameter("@CanteenName", objML_CanteenMaster.CanteenName), 
 new SqlParameter("@CanteenAddress", objML_CanteenMaster.CanteenAddress), 
 new SqlParameter("@CanteenActive", objML_CanteenMaster.CanteenActive), 
 new SqlParameter("@FromDate", dtFromdate), 
 new SqlParameter("@ToDate",dtTodate)
	   #endregion 
	  };
                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCanteenMasterBySearch.ToString(), this.Parameters);
                sbTraceInformation.Append("Exit:-From BusinessClasses-CanteenMaster:GetCanteenMasterBySeacrh(ML_CanteenMaster objML_CanteenMaster");
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

        public DataSet GetCanteenMaster()
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CanteenMaster:GetCanteenMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCanteenMaster.ToString());

                sbTraceInformation.Append("Exit:-From BusinessClasses-CanteenMaster:GetCanteenMaster");
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


        public ML_CanteenMaster GetCanteenMasterByCanteenCode(long CanteenCode)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CanteenMaster:GetCanteenMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_CanteenMaster = new ML_CanteenMaster();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CanteenCode", CanteenCode) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCanteenMasterByCanteenCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CanteenMaster:GetCanteenMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CanteenMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_CanteenMaster.CanteenName = ML_Common.clean(dr["CanteenName"].ToString());
                        objML_CanteenMaster.CanteenAddress = ML_Common.clean(dr["CanteenAddress"].ToString());
                        objML_CanteenMaster.CanteenActive = ML_Common.string2int32(ML_Common.clean(dr["CanteenActive"].ToString()));
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
            return objML_CanteenMaster;
        }


        public ML_CanteenMaster GetCanteenMasterByCanteenName(long CanteenName)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CanteenMaster:GetCanteenMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_CanteenMaster = new ML_CanteenMaster();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CanteenName", CanteenName) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCanteenMasterByCanteenName.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CanteenMaster:GetCanteenMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CanteenMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_CanteenMaster.CanteenName = ML_Common.clean(dr["CanteenName"].ToString());
                        objML_CanteenMaster.CanteenAddress = ML_Common.clean(dr["CanteenAddress"].ToString());
                        objML_CanteenMaster.CanteenActive = ML_Common.string2int32(ML_Common.clean(dr["CanteenActive"].ToString()));
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
            return objML_CanteenMaster;
        }


        public ML_CanteenMaster GetCanteenMasterByCanteenAddress(long CanteenAddress)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CanteenMaster:GetCanteenMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_CanteenMaster = new ML_CanteenMaster();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CanteenAddress", CanteenAddress) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCanteenMasterByCanteenAddress.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CanteenMaster:GetCanteenMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CanteenMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_CanteenMaster.CanteenName = ML_Common.clean(dr["CanteenName"].ToString());
                        objML_CanteenMaster.CanteenAddress = ML_Common.clean(dr["CanteenAddress"].ToString());
                        objML_CanteenMaster.CanteenActive = ML_Common.string2int32(ML_Common.clean(dr["CanteenActive"].ToString()));
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
            return objML_CanteenMaster;
        }


        public ML_CanteenMaster GetCanteenMasterByCanteenActive(long CanteenActive)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CanteenMaster:GetCanteenMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_CanteenMaster = new ML_CanteenMaster();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CanteenActive", CanteenActive) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCanteenMasterByCanteenActive.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CanteenMaster:GetCanteenMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CanteenMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_CanteenMaster.CanteenName = ML_Common.clean(dr["CanteenName"].ToString());
                        objML_CanteenMaster.CanteenAddress = ML_Common.clean(dr["CanteenAddress"].ToString());
                        objML_CanteenMaster.CanteenActive = ML_Common.string2int32(ML_Common.clean(dr["CanteenActive"].ToString()));
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
            return objML_CanteenMaster;
        }


        public DataSet GetCanteenMasterByCanteenCodeDs(long CanteenCode)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CanteenMaster: GetCanteenMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_CanteenMaster = new ML_CanteenMaster();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CanteenCode", CanteenCode) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCanteenMasterByCanteenCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CanteenMaster: GetCanteenMasterById(long Id)");
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


        public DataSet GetCanteenMasterByCanteenNameDs(long CanteenName)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CanteenMaster: GetCanteenMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_CanteenMaster = new ML_CanteenMaster();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CanteenName", CanteenName) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCanteenMasterByCanteenName.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CanteenMaster: GetCanteenMasterById(long Id)");
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


        public DataSet GetCanteenMasterByCanteenAddressDs(long CanteenAddress)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CanteenMaster: GetCanteenMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_CanteenMaster = new ML_CanteenMaster();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CanteenAddress", CanteenAddress) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCanteenMasterByCanteenAddress.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CanteenMaster: GetCanteenMasterById(long Id)");
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


        public DataSet GetCanteenMasterByCanteenActiveDs(long CanteenActive)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CanteenMaster: GetCanteenMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_CanteenMaster = new ML_CanteenMaster();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CanteenActive", CanteenActive) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCanteenMasterByCanteenActive.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CanteenMaster: GetCanteenMasterById(long Id)");
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




        public DataSet GetCanteenMasterByLoginName(string loginName)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-CanteenMaster:GetCanteenMasterByLoginName(string loginName)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_CanteenMaster = new ML_CanteenMaster();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@loginName", loginName) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCanteenMasterByLoginName.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-CanteenMaster:GetCanteenMasterByLoginName(string loginName)");
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
