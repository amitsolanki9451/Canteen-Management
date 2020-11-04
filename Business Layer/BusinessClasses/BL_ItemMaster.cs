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
    public class BL_ItemMaster
    {
        #region All Variable 
        StringBuilder sbTraceInformation = new StringBuilder();
        ML_ItemMaster objML_ItemMaster = null;

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
        public int Add(ML_ItemMaster objML_ItemMaster)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:Add(ML_ItemMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);
                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters =
                { 
	             #region Add Properties 
	             new SqlParameter("@ItemCode", objML_ItemMaster.ItemCode),
 new SqlParameter("@CanteenCode", objML_ItemMaster.CanteenCode),
 new SqlParameter("@CategoryGroupCode", objML_ItemMaster.CategoryGroupCode),
 new SqlParameter("@ItemCategoryCode", objML_ItemMaster.ItemCategoryCode),
 new SqlParameter("@ItemName", objML_ItemMaster.ItemName),
 new SqlParameter("@ItemEmployeeRate", objML_ItemMaster.ItemEmployeeRate),
 new SqlParameter("@ItemActive", objML_ItemMaster.ItemActive),
 new SqlParameter("@ItemImage", objML_ItemMaster.ItemImage),
                 ReturnObj 
	             #endregion  
	          };
                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_SaveItemMaster.ToString(), this.Parameters);
                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:Add(ML_ItemMaster");
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

        public int Update(ML_ItemMaster objML_ItemMaster)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:Update(ML_ItemMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters =
                { 
	               #region Update Properties 
	               new SqlParameter("@ItemCode", objML_ItemMaster.ItemCode),
 new SqlParameter("@CanteenCode", objML_ItemMaster.CanteenCode),
 new SqlParameter("@CategoryGroupCode", objML_ItemMaster.CategoryGroupCode),
 new SqlParameter("@ItemCategoryCode", objML_ItemMaster.ItemCategoryCode),
 new SqlParameter("@ItemName", objML_ItemMaster.ItemName),
 new SqlParameter("@ItemEmployeeRate", objML_ItemMaster.ItemEmployeeRate),
 new SqlParameter("@ItemActive", objML_ItemMaster.ItemActive),
 new SqlParameter("@ItemImage", objML_ItemMaster.ItemImage),
                   ReturnObj 
	               #endregion  
	           };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateItemMaster.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:Update(ML_ItemMaster");
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

        public int UpdateUnique(ML_ItemMaster objML_ItemMaster)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:UpdateUnique(ML_ItemMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters =
                { 
	               #region Update Unique Properties 
	               new SqlParameter("@ItemCode", objML_ItemMaster.ItemCode),
 new SqlParameter("@CanteenCode", objML_ItemMaster.CanteenCode),
 new SqlParameter("@CategoryGroupCode", objML_ItemMaster.CategoryGroupCode),
 new SqlParameter("@ItemCategoryCode", objML_ItemMaster.ItemCategoryCode),
 new SqlParameter("@ItemName", objML_ItemMaster.ItemName),
 new SqlParameter("@ItemEmployeeRate", objML_ItemMaster.ItemEmployeeRate),
 new SqlParameter("@ItemActive", objML_ItemMaster.ItemActive),
 new SqlParameter("@ItemImage", objML_ItemMaster.ItemImage),
                   ReturnObj 
	               #endregion  
	           };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateUniqueItemMaster.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:UpdateUnique(ML_ItemMaster");
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
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:Delete(long delId)");
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteItemMasterById.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:Delete(long AdminId)");
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
        public int DeleteItemMasterByItemCode(long ItemCode)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:Delete(long delId)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters =
                { 
	   #region Delete Properties 
	    new SqlParameter("@ItemCode", ItemCode),
      ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteItemMasterByItemCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:Delete(long AdminId)");
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

        public int DeleteItemMasterByCanteenCode(long CanteenCode)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:Delete(long delId)");
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteItemMasterByCanteenCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:Delete(long AdminId)");
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

        public int DeleteItemMasterByCategoryGroupCode(long CategoryGroupCode)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:Delete(long delId)");
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteItemMasterByCategoryGroupCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:Delete(long AdminId)");
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

        public int DeleteItemMasterByItemCategoryCode(long ItemCategoryCode)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:Delete(long delId)");
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteItemMasterByItemCategoryCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:Delete(long AdminId)");
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

        public int DeleteItemMasterByItemName(long ItemName)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:Delete(long delId)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters =
                { 
	   #region Delete Properties 
	    new SqlParameter("@ItemName", ItemName),
      ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteItemMasterByItemName.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:Delete(long AdminId)");
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

        public int DeleteItemMasterByItemEmployeeRate(long ItemEmployeeRate)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:Delete(long delId)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters =
                { 
	   #region Delete Properties 
	    new SqlParameter("@ItemEmployeeRate", ItemEmployeeRate),
      ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteItemMasterByItemEmployeeRate.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:Delete(long AdminId)");
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

        public int DeleteItemMasterByItemActive(long ItemActive)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:Delete(long delId)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters =
                { 
	   #region Delete Properties 
	    new SqlParameter("@ItemActive", ItemActive),
      ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteItemMasterByItemActive.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:Delete(long AdminId)");
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

        public int DeleteItemMasterByItemImage(long ItemImage)
        {
            int results = 0;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:Delete(long delId)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters =
                { 
	   #region Delete Properties 
	    new SqlParameter("@ItemImage", ItemImage),
      ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteItemMasterByItemImage.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:Delete(long AdminId)");
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

        public DataSet GetItemMasterBySeacrh(ML_ItemMaster objML_ItemMaster)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:GetItemMasterBySeacrh(ML_ItemMaster objML_ItemMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                DateTime? dtFromdate = null;
                DateTime objFromdate;
                if (DateTime.TryParse(objML_ItemMaster.FromDate.ToString(), out objFromdate))
                {
                    if (objFromdate.ToString() != "1/1/1900 12:00:00 AM")
                    {
                        dtFromdate = objFromdate;
                    }
                }
                DateTime? dtTodate = null;
                DateTime objdtTodate;
                if (DateTime.TryParse(objML_ItemMaster.ToDate.ToString(), out objdtTodate))
                {
                    if (objdtTodate.ToString() != "1/1/1900 12:00:00 AM")
                    {
                        dtTodate = objdtTodate;
                    }
                }

                SqlParameter[] parameters =
                { 
	   #region Search Properties 
	  new SqlParameter("@ItemCode", objML_ItemMaster.ItemCode),
 new SqlParameter("@CanteenCode", objML_ItemMaster.CanteenCode),
 new SqlParameter("@CategoryGroupCode", objML_ItemMaster.CategoryGroupCode),
 new SqlParameter("@ItemCategoryCode", objML_ItemMaster.ItemCategoryCode),
 new SqlParameter("@ItemName", objML_ItemMaster.ItemName),
 new SqlParameter("@ItemEmployeeRate", objML_ItemMaster.ItemEmployeeRate),
 new SqlParameter("@ItemActive", objML_ItemMaster.ItemActive),
 new SqlParameter("@ItemImage", objML_ItemMaster.ItemImage),
 new SqlParameter("@FromDate", dtFromdate),
 new SqlParameter("@ToDate",dtTodate)
	   #endregion 
	  };
                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemMasterBySearch.ToString(), this.Parameters);
                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:GetItemMasterBySeacrh(ML_ItemMaster objML_ItemMaster");
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

        public DataSet GetItemMaster()
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:GetItemMaster");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemMaster.ToString());

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:GetItemMaster");
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


        public ML_ItemMaster GetItemMasterByItemCode(long ItemCode)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemMaster = new ML_ItemMaster();
                SqlParameter[] parameters =
                { 
	   #region Get Properties 
	    new SqlParameter("@ItemCode", ItemCode) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemMasterByItemCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_ItemMaster.ItemCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCode"].ToString()));
                        objML_ItemMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_ItemMaster.CategoryGroupCode = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupCode"].ToString()));
                        objML_ItemMaster.ItemCategoryCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryCode"].ToString()));
                        objML_ItemMaster.ItemName = ML_Common.clean(dr["ItemName"].ToString());
                        objML_ItemMaster.ItemEmployeeRate = Convert.ToDecimal(ML_Common.clean(dr["ItemEmployeeRate"].ToString()));
                        objML_ItemMaster.ItemActive = ML_Common.string2int32(ML_Common.clean(dr["ItemActive"].ToString()));
                        //objML_ItemMaster.ItemImage = ML_Common.clean(dr["ItemImage"].ToString());
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
            return objML_ItemMaster;
        }


        public ML_ItemMaster GetItemMasterByCanteenCode(long CanteenCode)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemMaster = new ML_ItemMaster();
                SqlParameter[] parameters =
                { 
	   #region Get Properties 
	    new SqlParameter("@CanteenCode", CanteenCode) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemMasterByCanteenCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_ItemMaster.ItemCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCode"].ToString()));
                        objML_ItemMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_ItemMaster.CategoryGroupCode = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupCode"].ToString()));
                        objML_ItemMaster.ItemCategoryCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryCode"].ToString()));
                        objML_ItemMaster.ItemName = ML_Common.clean(dr["ItemName"].ToString());
                        objML_ItemMaster.ItemEmployeeRate = Convert.ToDecimal(ML_Common.clean(dr["ItemEmployeeRate"].ToString()));
                        objML_ItemMaster.ItemActive = ML_Common.string2int32(ML_Common.clean(dr["ItemActive"].ToString()));
                        //objML_ItemMaster.ItemImage = ML_Common.clean(dr["ItemImage"].ToString());
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
            return objML_ItemMaster;
        }


        public ML_ItemMaster GetItemMasterByCategoryGroupCode(long CategoryGroupCode)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemMaster = new ML_ItemMaster();
                SqlParameter[] parameters =
                { 
	   #region Get Properties 
	    new SqlParameter("@CategoryGroupCode", CategoryGroupCode) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemMasterByCategoryGroupCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_ItemMaster.ItemCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCode"].ToString()));
                        objML_ItemMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_ItemMaster.CategoryGroupCode = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupCode"].ToString()));
                        objML_ItemMaster.ItemCategoryCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryCode"].ToString()));
                        objML_ItemMaster.ItemName = ML_Common.clean(dr["ItemName"].ToString());
                        objML_ItemMaster.ItemEmployeeRate = Convert.ToDecimal(ML_Common.clean(dr["ItemEmployeeRate"].ToString()));
                        objML_ItemMaster.ItemActive = ML_Common.string2int32(ML_Common.clean(dr["ItemActive"].ToString()));
                        //objML_ItemMaster.ItemImage = ML_Common.clean(dr["ItemImage"].ToString());
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
            return objML_ItemMaster;
        }


        public ML_ItemMaster GetItemMasterByItemCategoryCode(long ItemCategoryCode)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemMaster = new ML_ItemMaster();
                SqlParameter[] parameters =
                { 
	   #region Get Properties 
	    new SqlParameter("@ItemCategoryCode", ItemCategoryCode) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemMasterByItemCategoryCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_ItemMaster.ItemCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCode"].ToString()));
                        objML_ItemMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_ItemMaster.CategoryGroupCode = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupCode"].ToString()));
                        objML_ItemMaster.ItemCategoryCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryCode"].ToString()));
                        objML_ItemMaster.ItemName = ML_Common.clean(dr["ItemName"].ToString());
                        objML_ItemMaster.ItemEmployeeRate = Convert.ToDecimal(ML_Common.clean(dr["ItemEmployeeRate"].ToString()));
                        objML_ItemMaster.ItemActive = ML_Common.string2int32(ML_Common.clean(dr["ItemActive"].ToString()));
                        //objML_ItemMaster.ItemImage = ML_Common.clean(dr["ItemImage"].ToString());
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
            return objML_ItemMaster;
        }


        public ML_ItemMaster GetItemMasterByItemName(long ItemName)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemMaster = new ML_ItemMaster();
                SqlParameter[] parameters =
                { 
	   #region Get Properties 
	    new SqlParameter("@ItemName", ItemName) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemMasterByItemName.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_ItemMaster.ItemCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCode"].ToString()));
                        objML_ItemMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_ItemMaster.CategoryGroupCode = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupCode"].ToString()));
                        objML_ItemMaster.ItemCategoryCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryCode"].ToString()));
                        objML_ItemMaster.ItemName = ML_Common.clean(dr["ItemName"].ToString());
                        objML_ItemMaster.ItemEmployeeRate = Convert.ToDecimal(ML_Common.clean(dr["ItemEmployeeRate"].ToString()));
                        objML_ItemMaster.ItemActive = ML_Common.string2int32(ML_Common.clean(dr["ItemActive"].ToString()));
                        //objML_ItemMaster.ItemImage = ML_Common.clean(dr["ItemImage"].ToString());
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
            return objML_ItemMaster;
        }


        public ML_ItemMaster GetItemMasterByItemEmployeeRate(long ItemEmployeeRate)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemMaster = new ML_ItemMaster();
                SqlParameter[] parameters =
                { 
	   #region Get Properties 
	    new SqlParameter("@ItemEmployeeRate", ItemEmployeeRate) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemMasterByItemEmployeeRate.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_ItemMaster.ItemCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCode"].ToString()));
                        objML_ItemMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_ItemMaster.CategoryGroupCode = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupCode"].ToString()));
                        objML_ItemMaster.ItemCategoryCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryCode"].ToString()));
                        objML_ItemMaster.ItemName = ML_Common.clean(dr["ItemName"].ToString());
                        objML_ItemMaster.ItemEmployeeRate = Convert.ToDecimal(ML_Common.clean(dr["ItemEmployeeRate"].ToString()));
                        objML_ItemMaster.ItemActive = ML_Common.string2int32(ML_Common.clean(dr["ItemActive"].ToString()));
                        //objML_ItemMaster.ItemImage = ML_Common.clean(dr["ItemImage"].ToString());
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
            return objML_ItemMaster;
        }


        public ML_ItemMaster GetItemMasterByItemActive(long ItemActive)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemMaster = new ML_ItemMaster();
                SqlParameter[] parameters =
                { 
	   #region Get Properties 
	    new SqlParameter("@ItemActive", ItemActive) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemMasterByItemActive.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_ItemMaster.ItemCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCode"].ToString()));
                        objML_ItemMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_ItemMaster.CategoryGroupCode = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupCode"].ToString()));
                        objML_ItemMaster.ItemCategoryCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryCode"].ToString()));
                        objML_ItemMaster.ItemName = ML_Common.clean(dr["ItemName"].ToString());
                        objML_ItemMaster.ItemEmployeeRate = Convert.ToDecimal(ML_Common.clean(dr["ItemEmployeeRate"].ToString()));
                        objML_ItemMaster.ItemActive = ML_Common.string2int32(ML_Common.clean(dr["ItemActive"].ToString()));
                        //objML_ItemMaster.ItemImage = ML_Common.clean(dr["ItemImage"].ToString());
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
            return objML_ItemMaster;
        }


        public ML_ItemMaster GetItemMasterByItemImage(long ItemImage)
        {
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemMaster = new ML_ItemMaster();
                SqlParameter[] parameters =
                { 
	   #region Get Properties 
	    new SqlParameter("@ItemImage", ItemImage) 
	   #endregion 
	  };

                this.Parameters = parameters;
                DataSet ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemMasterByItemImage.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                if (ds.Tables.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_ItemMaster.ItemCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCode"].ToString()));
                        objML_ItemMaster.CanteenCode = ML_Common.string2int32(ML_Common.clean(dr["CanteenCode"].ToString()));
                        objML_ItemMaster.CategoryGroupCode = ML_Common.string2int32(ML_Common.clean(dr["CategoryGroupCode"].ToString()));
                        objML_ItemMaster.ItemCategoryCode = ML_Common.string2int32(ML_Common.clean(dr["ItemCategoryCode"].ToString()));
                        objML_ItemMaster.ItemName = ML_Common.clean(dr["ItemName"].ToString());
                        objML_ItemMaster.ItemEmployeeRate = Convert.ToDecimal(ML_Common.clean(dr["ItemEmployeeRate"].ToString()));
                        objML_ItemMaster.ItemActive = ML_Common.string2int32(ML_Common.clean(dr["ItemActive"].ToString()));
                        //objML_ItemMaster.ItemImage = ML_Common.clean(dr["ItemImage"].ToString());
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
            return objML_ItemMaster;
        }


        public DataSet GetItemMasterByItemCodeDs(long ItemCode)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster: GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemMaster = new ML_ItemMaster();
                SqlParameter[] parameters =
                { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@ItemCode", ItemCode) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemMasterByItemCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster: GetItemMasterById(long Id)");
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


        public DataSet GetItemMasterByCanteenCodeDs(long CanteenCode)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster: GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemMaster = new ML_ItemMaster();
                SqlParameter[] parameters =
                { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CanteenCode", CanteenCode) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemMasterByCanteenCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster: GetItemMasterById(long Id)");
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


        public DataSet GetItemMasterByCategoryGroupCodeDs(long CategoryGroupCode)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster: GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemMaster = new ML_ItemMaster();
                SqlParameter[] parameters =
                { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CategoryGroupCode", CategoryGroupCode) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemMasterByCategoryGroupCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster: GetItemMasterById(long Id)");
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


        public DataSet GetItemMasterByItemCategoryCodeDs(long ItemCategoryCode)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster: GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemMaster = new ML_ItemMaster();
                SqlParameter[] parameters =
                { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@ItemCategoryCode", ItemCategoryCode) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemMasterByItemCategoryCode.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster: GetItemMasterById(long Id)");
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


        public DataSet GetItemMasterByItemNameDs(long ItemName)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster: GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemMaster = new ML_ItemMaster();
                SqlParameter[] parameters =
                { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@ItemName", ItemName) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemMasterByItemName.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster: GetItemMasterById(long Id)");
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


        public DataSet GetItemMasterByItemEmployeeRateDs(long ItemEmployeeRate)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster: GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemMaster = new ML_ItemMaster();
                SqlParameter[] parameters =
                { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@ItemEmployeeRate", ItemEmployeeRate) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemMasterByItemEmployeeRate.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster: GetItemMasterById(long Id)");
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


        public DataSet GetItemMasterByItemActiveDs(long ItemActive)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster: GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemMaster = new ML_ItemMaster();
                SqlParameter[] parameters =
                { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@ItemActive", ItemActive) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemMasterByItemActive.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster: GetItemMasterById(long Id)");
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


        public DataSet GetItemMasterByItemImageDs(long ItemImage)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster: GetItemMasterById(long Id)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemMaster = new ML_ItemMaster();
                SqlParameter[] parameters =
                { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@ItemImage", ItemImage) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemMasterByItemImage.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster: GetItemMasterById(long Id)");
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




        public DataSet GetItemMasterByLoginName(string loginName)
        {
            DataSet ds = null;
            try
            {
                sbTraceInformation = new StringBuilder();
                sbTraceInformation.Append("Entered:-Inside BusinessClasses-ItemMaster:GetItemMasterByLoginName(string loginName)");
                sbTraceInformation.Remove(0, sbTraceInformation.Length);

                objML_ItemMaster = new ML_ItemMaster();
                SqlParameter[] parameters =
                { 
	   #region Get Properties 
	    new SqlParameter("@loginName", loginName) 
	   #endregion  
	  };

                this.Parameters = parameters;
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetItemMasterByLoginName.ToString(), this.Parameters);

                sbTraceInformation.Append("Exit:-From BusinessClasses-ItemMaster:GetItemMasterByLoginName(string loginName)");
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
