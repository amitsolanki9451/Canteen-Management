#region BUSINESSCLASSES For tblCokeType
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
    public class BL_CokeType
    {
        #region All Variable
       
        ML_CokeType objML_CokeType = null;

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
        public int Add(ML_CokeType objML_CokeType)
        {
            int results = 0;
            try
            {
                



                




                
                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	          { 
	             #region Add Properties 
	             //new SqlParameter("@Id", objML_CokeType.Id), 
 //new SqlParameter("@CokeTypeId", objML_CokeType.CokeTypeId), 
 new SqlParameter("@CokeType", objML_CokeType.CokeType), 
 new SqlParameter("@Remarks", objML_CokeType.Remarks), 
 new SqlParameter("@IsActive", objML_CokeType.IsActive), 
 new SqlParameter("@IsArchive", objML_CokeType.IsArchive), 
 //new SqlParameter("@CreatedDate", objML_CokeType.CreatedDate), 
 new SqlParameter("@CreatedBy", objML_CokeType.CreatedBy), 
 //new SqlParameter("@ModifiedDate", objML_CokeType.ModifiedDate), 
 //new SqlParameter("@ModifiedBy", objML_CokeType.ModifiedBy), 
 new SqlParameter("@CreatedByUserNameId", objML_CokeType.CreatedByUserNameId), 
	             ReturnObj 
	             #endregion  
	          };
                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_SaveCokeType.ToString(), this.Parameters);
                




                

                if (ReturnObj.Value != null)
                {
                    results = ML_Common.string2int32(ReturnObj.Value.ToString());
                }
            }
           catch (SqlException sqlExc)
            {
                SqlException sqlExt = sqlExc; 
                throw;
            }
            catch (Exception ex)
            {
                results = 0;
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(



            }
            return results;
        }

        public int Update(ML_CokeType objML_CokeType)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	           { 
	               #region Update Properties 
	               new SqlParameter("@Id", objML_CokeType.Id), 
 new SqlParameter("@CokeTypeId", objML_CokeType.CokeTypeId), 
 new SqlParameter("@CokeType", objML_CokeType.CokeType), 
 new SqlParameter("@Remarks", objML_CokeType.Remarks), 
 new SqlParameter("@IsActive", objML_CokeType.IsActive), 
 new SqlParameter("@IsArchive", objML_CokeType.IsArchive), 
 //new SqlParameter("@CreatedDate", objML_CokeType.CreatedDate), 
 //new SqlParameter("@CreatedBy", objML_CokeType.CreatedBy), 
 //new SqlParameter("@ModifiedDate", objML_CokeType.ModifiedDate), 
 new SqlParameter("@ModifiedBy", objML_CokeType.ModifiedBy), 
 new SqlParameter("@CreatedByUserNameId", objML_CokeType.CreatedByUserNameId), 
	               ReturnObj 
	               #endregion  
	           };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateCokeType.ToString(), this.Parameters);

                




                

                if (ReturnObj.Value != null)
                {
                    results = ML_Common.string2int32(ReturnObj.Value.ToString());
                }
            }
           catch (SqlException sqlExc)
            {
                SqlException sqlExt = sqlExc; 
                throw;
            }
            catch (Exception ex)
            {
                results = 0;
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(



            }
            return results;
        }

        public int UpdateUnique(ML_CokeType objML_CokeType)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	           { 
	               #region Update Unique Properties 
	               new SqlParameter("@Id", objML_CokeType.Id), 
 new SqlParameter("@CokeTypeId", objML_CokeType.CokeTypeId), 
 new SqlParameter("@CokeType", objML_CokeType.CokeType), 
 new SqlParameter("@Remarks", objML_CokeType.Remarks), 
 new SqlParameter("@IsActive", objML_CokeType.IsActive), 
 new SqlParameter("@IsArchive", objML_CokeType.IsArchive), 
 //new SqlParameter("@CreatedDate", objML_CokeType.CreatedDate), 
 //new SqlParameter("@CreatedBy", objML_CokeType.CreatedBy), 
 //new SqlParameter("@ModifiedDate", objML_CokeType.ModifiedDate), 
 new SqlParameter("@ModifiedBy", objML_CokeType.ModifiedBy), 
 new SqlParameter("@CreatedByUserNameId", objML_CokeType.CreatedByUserNameId), 
	               ReturnObj 
	               #endregion  
	           };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateUniqueCokeType.ToString(), this.Parameters);

                




                

                if (ReturnObj.Value != null)
                {
                    results = ML_Common.string2int32(ReturnObj.Value.ToString());
                }
            }
           catch (SqlException sqlExc)
            {
                SqlException sqlExt = sqlExc; 
                throw;
            }
            catch (Exception ex)
            {
                results = 0;
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(



            }
            return results;
        }

        public int Delete(int delId)
        {
            int results = 0;
            try
            {
                



                




                

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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeTypeById.ToString(), this.Parameters);

                




                

                if (ReturnObj.Value != null)
                {
                    results = ML_Common.string2int32(ReturnObj.Value.ToString());
                }
            }
           catch (SqlException sqlExc)
            {
                SqlException sqlExt = sqlExc; 
                throw;
            }
            catch (Exception ex)
            {
                results = 0;
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(



            }
            return results;
        }

        #endregion
        #region Delete
        public int DeleteCokeTypeById(int Id)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@Id", Id), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeTypeById.ToString(), this.Parameters);

                




                

                if (ReturnObj.Value != null)
                {
                    results = ML_Common.string2int32(ReturnObj.Value.ToString());
                }
            }
           catch (SqlException sqlExc)
            {
                SqlException sqlExt = sqlExc; 
                throw;
            }
            catch (Exception ex)
            {
                results = 0;
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(



            }
            return results;
        }

        public int DeleteCokeTypeByCokeTypeId(int CokeTypeId)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@CokeTypeId", CokeTypeId), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeTypeByCokeTypeId.ToString(), this.Parameters);


                if (ReturnObj.Value != null)
                {
                    results = ML_Common.string2int32(ReturnObj.Value.ToString());
                }
            }
           catch (SqlException sqlExc)
            {
                SqlException sqlExt = sqlExc; 
                throw;
            }
            catch (Exception ex)
            {
                results = 0;
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(



            }
            return results;
        }

        #endregion
        #region Delete Relationship
        #endregion


        #region Get Method

        public DataTable GetCokeTypeBySeacrh(ML_CokeType objML_CokeType)
        {
            DataTable dt = new DataTable();
            try
            {
                
                DateTime? dtFromdate = null;
                DateTime objFromdate;
                if (DateTime.TryParse(objML_CokeType.FromDate.ToString(), out objFromdate))
                {
                    if (objFromdate.ToString() != "1/1/1900 12:00:00 AM")
                    {
                        dtFromdate = objFromdate;
                    }
                }
                DateTime? dtTodate = null;
                DateTime objdtTodate;
                if (DateTime.TryParse(objML_CokeType.ToDate.ToString(), out objdtTodate))
                {
                    if (objdtTodate.ToString() != "1/1/1900 12:00:00 AM")
                    {
                        dtTodate = objdtTodate;
                    }
                }

                SqlParameter[] parameters = 
	  { 
	   #region Search Properties 
	  //new SqlParameter("@Id", objML_CokeType.Id), 
 //new SqlParameter("@CokeTypeId", objML_CokeType.CokeTypeId), 
 new SqlParameter("@CokeType", objML_CokeType.CokeType), 
 //new SqlParameter("@Remarks", objML_CokeType.Remarks), 
 //new SqlParameter("@IsActive", objML_CokeType.IsActive), 
 //new SqlParameter("@IsArchive", objML_CokeType.IsArchive), 
 //new SqlParameter("@CreatedDate", objML_CokeType.CreatedDate), 
 //new SqlParameter("@CreatedBy", objML_CokeType.CreatedBy), 
 //new SqlParameter("@ModifiedDate", objML_CokeType.ModifiedDate), 
 //new SqlParameter("@ModifiedBy", objML_CokeType.ModifiedBy), 
 //new SqlParameter("@CreatedByUserNameId", objML_CokeType.CreatedByUserNameId), 
 new SqlParameter("@FromDate", dtFromdate), 
 new SqlParameter("@ToDate",dtTodate)
	   #endregion 
	  };
                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeTypeBySearch.ToString(), this.Parameters);

                if (sdr.HasRows)
                {
                    dt.Load(sdr);
                }  



                
            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(



            }
            return dt;
        }

        public DataSet GetCokeType()
        {
            DataSet ds = null;
            try
            {
                //sbTraceInformation = new StringBuilder();
                //sbTraceInformation.Append("Entered:-Inside BusinessClasses-DailyLogs:GetDailyLogs");
                //sbTraceInformation.Remove(0, sbTraceInformation.Length);
                ds = SqlHelper.ExecuteDataset(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeType.ToString());

                //sbTraceInformation.Append("Exit:-From BusinessClasses-DailyLogs:GetDailyLogs");
                //sbTraceInformation.Remove(0, sbTraceInformation.Length);
                  

            }
            catch (Exception ex)
            {
                ds = new DataSet();
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(



            }
            return ds;
        }


        public ML_CokeType GetCokeTypeById(int Id)
        {
             DataTable dt = new DataTable();
            try
            {
                

                objML_CokeType = new ML_CokeType();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@Id", Id) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeTypeById.ToString(), this.Parameters);
                               

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeType.Id = ML_Common.string2int32(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeType.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeType.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeType.Remarks = ML_Common.clean(dr["Remarks"].ToString());
                        objML_CokeType.IsActive = ML_Common.clean(dr["IsActive"].ToString());
                        objML_CokeType.IsArchive = ML_Common.clean(dr["IsArchive"].ToString());
                        objML_CokeType.CreatedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["CreatedDate"].ToString()));
                        objML_CokeType.CreatedBy = ML_Common.clean(dr["CreatedBy"].ToString());
                        objML_CokeType.ModifiedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["ModifiedDate"].ToString()));
                        objML_CokeType.ModifiedBy = ML_Common.clean(dr["ModifiedBy"].ToString());
                        objML_CokeType.CreatedByUserNameId = ML_Common.string2int(ML_Common.clean(dr["CreatedByUserNameId"].ToString()));
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
                //LogManager.LogManager.WriteTraceLog(



            }
            return objML_CokeType;
        }


        public ML_CokeType GetCokeTypeByCokeTypeId(int CokeTypeId)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeType = new ML_CokeType();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeTypeId", CokeTypeId) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeTypeByCokeTypeId.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeType.Id = ML_Common.string2int32(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeType.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeType.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeType.Remarks = ML_Common.clean(dr["Remarks"].ToString());
                        objML_CokeType.IsActive = ML_Common.clean(dr["IsActive"].ToString());
                        objML_CokeType.IsArchive = ML_Common.clean(dr["IsArchive"].ToString());
                        objML_CokeType.CreatedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["CreatedDate"].ToString()));
                        objML_CokeType.CreatedBy = ML_Common.clean(dr["CreatedBy"].ToString());
                        objML_CokeType.ModifiedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["ModifiedDate"].ToString()));
                        objML_CokeType.ModifiedBy = ML_Common.clean(dr["ModifiedBy"].ToString());
                        objML_CokeType.CreatedByUserNameId = ML_Common.string2int(ML_Common.clean(dr["CreatedByUserNameId"].ToString()));
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
                //LogManager.LogManager.WriteTraceLog(



            }
            return objML_CokeType;
        }


        public DataTable GetCokeTypeByIdDs(int Id)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeType = new ML_CokeType();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@Id", Id) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeTypeById.ToString(), this.Parameters);


                if (sdr.HasRows)
                {
                    dt.Load(sdr);
                }  



                

            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(



            }
            return dt;
        }


        public DataTable GetCokeTypeByCokeTypeIdDs(int CokeTypeId)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeType = new ML_CokeType();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeTypeId", CokeTypeId) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeTypeByCokeTypeId.ToString(), this.Parameters);


                if (sdr.HasRows)
                {
                    dt.Load(sdr);
                }  



                

            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(



            }
            return dt;
        }




        public DataTable GetCokeTypeByLoginName(string loginName)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeType = new ML_CokeType();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@loginName", loginName) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeTypeByLoginName.ToString(), this.Parameters);


                if (sdr.HasRows)
                {
                    dt.Load(sdr);
                }  



                

            }
            catch (Exception ex)
            {
                Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
                throw;
            }
            finally
            {
                //LogManager.LogManager.WriteTraceLog(



            }
            return dt;
        }


        #endregion
    }
}





#region SP name for  tblCokeType
// usp_SaveCokeType, 
// usp_UpdateCokeType, 
// usp_UpdateUniqueCokeType, 
// usp_DeleteCokeTypeById, 
// usp_DeleteCokeTypeByCokeTypeId, 
// usp_GetCokeTypeBySearch, 
// usp_GetCokeType, 
// usp_GetCokeTypeById, 
// usp_GetCokeTypeByCokeTypeId, 
// usp_GetCokeTypeByLoginName, 
#endregion
#endregion