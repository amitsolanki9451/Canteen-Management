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
  public  class BL_CokeDynamicResult
    {
        #region All Variable
       
        ML_CokeDynamicResult objML_CokeDynamicResult = null;

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
        public int Add(ML_CokeDynamicResult objML_CokeDynamicResult)
        {
            int results = 0;
            try
            {
                



                




                
                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	          { 
	             #region Add Properties 
	             //new SqlParameter("@Id", objML_CokeDynamicResult.Id), 
 new SqlParameter("@CokeDynamicResultId", objML_CokeDynamicResult.CokeDynamicResultId), 
 new SqlParameter("@CokeDynamicResult", objML_CokeDynamicResult.CokeDynamicResult), 
 new SqlParameter("@CokeDynamicId", objML_CokeDynamicResult.CokeDynamicId), 
 new SqlParameter("@CokeDynamic", objML_CokeDynamicResult.CokeDynamic), 
 new SqlParameter("@CokeCompositeMasterId", objML_CokeDynamicResult.CokeCompositeMasterId), 
 new SqlParameter("@CokeCompositeMaster", objML_CokeDynamicResult.CokeCompositeMaster), 
 new SqlParameter("@CokeTypeId", objML_CokeDynamicResult.CokeTypeId), 
 new SqlParameter("@CokeType", objML_CokeDynamicResult.CokeType), 
 new SqlParameter("@CokeSupplierId", objML_CokeDynamicResult.CokeSupplierId), 
 new SqlParameter("@CokeSupplier", objML_CokeDynamicResult.CokeSupplier), 
 new SqlParameter("@AnalysisTypeId", objML_CokeDynamicResult.AnalysisTypeId), 
 new SqlParameter("@AnalysisType", objML_CokeDynamicResult.AnalysisType), 
 new SqlParameter("@FieldSize", objML_CokeDynamicResult.FieldSize), 
 new SqlParameter("@FieldUnit", objML_CokeDynamicResult.FieldUnit), 
 new SqlParameter("@FieldSpec", objML_CokeDynamicResult.FieldSpec), 
 new SqlParameter("@MinValue", objML_CokeDynamicResult.MinValue), 
 new SqlParameter("@MaxValue", objML_CokeDynamicResult.MaxValue), 
  new SqlParameter("@Result", objML_CokeDynamicResult.Result), 
	             ReturnObj 
	             #endregion  
	          };
                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_SaveCokeDynamicResult.ToString(), this.Parameters);
                




                

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

        public int Update(ML_CokeDynamicResult objML_CokeDynamicResult)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	           { 
	               #region Update Properties 
	               //new SqlParameter("@Id", objML_CokeDynamicResult.Id), 
 new SqlParameter("@CokeDynamicResultId", objML_CokeDynamicResult.CokeDynamicResultId), 
 new SqlParameter("@CokeDynamicResult", objML_CokeDynamicResult.CokeDynamicResult), 
 new SqlParameter("@CokeDynamicId", objML_CokeDynamicResult.CokeDynamicId), 
 new SqlParameter("@CokeDynamic", objML_CokeDynamicResult.CokeDynamic), 
 new SqlParameter("@CokeCompositeMasterId", objML_CokeDynamicResult.CokeCompositeMasterId), 
 new SqlParameter("@CokeCompositeMaster", objML_CokeDynamicResult.CokeCompositeMaster), 
 new SqlParameter("@CokeTypeId", objML_CokeDynamicResult.CokeTypeId), 
 new SqlParameter("@CokeType", objML_CokeDynamicResult.CokeType), 
 new SqlParameter("@CokeSupplierId", objML_CokeDynamicResult.CokeSupplierId), 
 new SqlParameter("@CokeSupplier", objML_CokeDynamicResult.CokeSupplier), 
 new SqlParameter("@AnalysisTypeId", objML_CokeDynamicResult.AnalysisTypeId), 
 new SqlParameter("@AnalysisType", objML_CokeDynamicResult.AnalysisType), 
 new SqlParameter("@FieldSize", objML_CokeDynamicResult.FieldSize), 
 new SqlParameter("@FieldUnit", objML_CokeDynamicResult.FieldUnit), 
 new SqlParameter("@FieldSpec", objML_CokeDynamicResult.FieldSpec), 
 new SqlParameter("@MinValue", objML_CokeDynamicResult.MinValue), 
 new SqlParameter("@MaxValue", objML_CokeDynamicResult.MaxValue), 
   new SqlParameter("@Result", objML_CokeDynamicResult.Result), 
	               ReturnObj 
	               #endregion  
	           };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateCokeDynamicResult.ToString(), this.Parameters);

                




                

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

        public int UpdateUnique(ML_CokeDynamicResult objML_CokeDynamicResult)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	           { 
	               #region Update Unique Properties 
	               //new SqlParameter("@Id", objML_CokeDynamicResult.Id), 
 new SqlParameter("@CokeDynamicResultId", objML_CokeDynamicResult.CokeDynamicResultId), 
 new SqlParameter("@CokeDynamicResult", objML_CokeDynamicResult.CokeDynamicResult), 
 new SqlParameter("@CokeDynamicId", objML_CokeDynamicResult.CokeDynamicId), 
 new SqlParameter("@CokeDynamic", objML_CokeDynamicResult.CokeDynamic), 
 new SqlParameter("@CokeCompositeMasterId", objML_CokeDynamicResult.CokeCompositeMasterId), 
 new SqlParameter("@CokeCompositeMaster", objML_CokeDynamicResult.CokeCompositeMaster), 
 new SqlParameter("@CokeTypeId", objML_CokeDynamicResult.CokeTypeId), 
 new SqlParameter("@CokeType", objML_CokeDynamicResult.CokeType), 
 new SqlParameter("@CokeSupplierId", objML_CokeDynamicResult.CokeSupplierId), 
 new SqlParameter("@CokeSupplier", objML_CokeDynamicResult.CokeSupplier), 
 new SqlParameter("@AnalysisTypeId", objML_CokeDynamicResult.AnalysisTypeId), 
 new SqlParameter("@AnalysisType", objML_CokeDynamicResult.AnalysisType), 
 new SqlParameter("@FieldSize", objML_CokeDynamicResult.FieldSize), 
 new SqlParameter("@FieldUnit", objML_CokeDynamicResult.FieldUnit), 
 new SqlParameter("@FieldSpec", objML_CokeDynamicResult.FieldSpec), 
 new SqlParameter("@MinValue", objML_CokeDynamicResult.MinValue), 
 new SqlParameter("@MaxValue", objML_CokeDynamicResult.MaxValue), 
   new SqlParameter("@Result", objML_CokeDynamicResult.Result), 
	               ReturnObj 
	               #endregion  
	           };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateUniqueCokeDynamicResult.ToString(), this.Parameters);

                




                

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

        public int Delete(long delId)
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicResultById.ToString(), this.Parameters);

                




                

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
        public int DeleteCokeDynamicResultById(long Id)
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicResultById.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicResultByCokeDynamicResultId(long CokeDynamicResultId)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@CokeDynamicResultId", CokeDynamicResultId), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicResultByCokeDynamicResultId.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicResultByCokeDynamicResult(long CokeDynamicResult)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@CokeDynamicResult", CokeDynamicResult), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicResultByCokeDynamicResult.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicResultByCokeDynamicId(long CokeDynamicId)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@CokeDynamicId", CokeDynamicId), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicResultByCokeDynamicId.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicResultByCokeDynamic(long CokeDynamic)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@CokeDynamic", CokeDynamic), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicResultByCokeDynamic.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicResultByCokeCompositeMasterId(long CokeCompositeMasterId)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@CokeCompositeMasterId", CokeCompositeMasterId), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicResultByCokeCompositeMasterId.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicResultByCokeCompositeMaster(long CokeCompositeMaster)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@CokeCompositeMaster", CokeCompositeMaster), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicResultByCokeCompositeMaster.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicResultByCokeTypeId(long CokeTypeId)
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicResultByCokeTypeId.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicResultByCokeType(long CokeType)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@CokeType", CokeType), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicResultByCokeType.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicResultByCokeSupplierId(long CokeSupplierId)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicResultByCokeSupplierId.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicResultByCokeSupplier(long CokeSupplier)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@CokeSupplier", CokeSupplier), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicResultByCokeSupplier.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicResultByAnalysisTypeId(long AnalysisTypeId)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicResultByAnalysisTypeId.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicResultByAnalysisType(long AnalysisType)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicResultByAnalysisType.ToString(), this.Parameters);

                




                

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
        public int DeleteCokeDynamicResultByIdnCokeDynamicResultIdnCokeDynamicResultnCokeDynamicIdnCokeDynamicnCokeCompositeMasterIdnCokeCompositeMasternCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long Id, int CokeDynamicResultId, int CokeDynamicResult, int CokeDynamicId, int CokeDynamic, int CokeCompositeMasterId, int CokeCompositeMaster, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
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
	    new SqlParameter("@CokeDynamicResultId", CokeDynamicResultId), 
	    new SqlParameter("@CokeDynamicResult", CokeDynamicResult), 
	    new SqlParameter("@CokeDynamicId", CokeDynamicId), 
	    new SqlParameter("@CokeDynamic", CokeDynamic), 
	    new SqlParameter("@CokeCompositeMasterId", CokeCompositeMasterId), 
	    new SqlParameter("@CokeCompositeMaster", CokeCompositeMaster), 
	    new SqlParameter("@CokeTypeId", CokeTypeId), 
	    new SqlParameter("@CokeType", CokeType), 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId), 
	    new SqlParameter("@CokeSupplier", CokeSupplier), 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicResultByIdnCokeDynamicResultIdnCokeDynamicResultnCokeDynamicIdnCokeDynamicnCokeCompositeMasterIdnCokeCompositeMasternCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);

                




                

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


        #region Get Method

        public DataTable GetCokeDynamicResultBySeacrh(ML_CokeDynamicResult objML_CokeDynamicResult)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                DateTime? dtFromdate = null;
                DateTime objFromdate;
                if (DateTime.TryParse(objML_CokeDynamicResult.FromDate.ToString(), out objFromdate))
                {
                    if (objFromdate.ToString() != "1/1/1900 12:00:00 AM")
                    {
                        dtFromdate = objFromdate;
                    }
                }
                DateTime? dtTodate = null;
                DateTime objdtTodate;
                if (DateTime.TryParse(objML_CokeDynamicResult.ToDate.ToString(), out objdtTodate))
                {
                    if (objdtTodate.ToString() != "1/1/1900 12:00:00 AM")
                    {
                        dtTodate = objdtTodate;
                    }
                }

                SqlParameter[] parameters = 
	  { 
	   #region Search Properties 
	  //new SqlParameter("@Id", objML_CokeDynamicResult.Id), 
 new SqlParameter("@CokeDynamicResultId", objML_CokeDynamicResult.CokeDynamicResultId), 
 new SqlParameter("@CokeDynamicResult", objML_CokeDynamicResult.CokeDynamicResult), 
 new SqlParameter("@CokeDynamicId", objML_CokeDynamicResult.CokeDynamicId), 
 new SqlParameter("@CokeDynamic", objML_CokeDynamicResult.CokeDynamic), 
 new SqlParameter("@CokeCompositeMasterId", objML_CokeDynamicResult.CokeCompositeMasterId), 
 new SqlParameter("@CokeCompositeMaster", objML_CokeDynamicResult.CokeCompositeMaster), 
 new SqlParameter("@CokeTypeId", objML_CokeDynamicResult.CokeTypeId), 
 new SqlParameter("@CokeType", objML_CokeDynamicResult.CokeType), 
 new SqlParameter("@CokeSupplierId", objML_CokeDynamicResult.CokeSupplierId), 
 new SqlParameter("@CokeSupplier", objML_CokeDynamicResult.CokeSupplier), 
 new SqlParameter("@AnalysisTypeId", objML_CokeDynamicResult.AnalysisTypeId), 
 new SqlParameter("@AnalysisType", objML_CokeDynamicResult.AnalysisType), 
 new SqlParameter("@FieldSize", objML_CokeDynamicResult.FieldSize), 
 new SqlParameter("@FieldUnit", objML_CokeDynamicResult.FieldUnit), 
 new SqlParameter("@FieldSpec", objML_CokeDynamicResult.FieldSpec), 
 new SqlParameter("@MinValue", objML_CokeDynamicResult.MinValue), 
 new SqlParameter("@MaxValue", objML_CokeDynamicResult.MaxValue), 
 new SqlParameter("@FromDate", dtFromdate), 
 new SqlParameter("@ToDate",dtTodate)
	   #endregion 
	  };
                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultBySearch.ToString(), this.Parameters);


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

        public DataTable GetCokeDynamicResult()
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                
               // SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResult.ToString());


                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamic.ToString());


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


        public ML_CokeDynamicResult GetCokeDynamicResultById(long Id)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@Id", Id) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultById.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamicResult.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResultId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicResultId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResult = ML_Common.clean(dr["CokeDynamicResult"].ToString());
                        objML_CokeDynamicResult.CokeDynamicId = ML_Common.string2int32(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamicResult.CokeCompositeMasterId = ML_Common.string2int32(ML_Common.clean(dr["CokeCompositeMasterId"].ToString()));
                        objML_CokeDynamicResult.CokeCompositeMaster = ML_Common.clean(dr["CokeCompositeMaster"].ToString());
                        objML_CokeDynamicResult.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamicResult.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamicResult.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamicResult.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamicResult.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamicResult.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamicResult.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamicResult.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamicResult.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamicResult.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamicResult.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByCokeDynamicResultId(long CokeDynamicResultId)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeDynamicResultId", CokeDynamicResultId) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByCokeDynamicResultId.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamicResult.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResultId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicResultId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResult = ML_Common.clean(dr["CokeDynamicResult"].ToString());
                        objML_CokeDynamicResult.CokeDynamicId = ML_Common.string2int32(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamicResult.CokeCompositeMasterId = ML_Common.string2int32(ML_Common.clean(dr["CokeCompositeMasterId"].ToString()));
                        objML_CokeDynamicResult.CokeCompositeMaster = ML_Common.clean(dr["CokeCompositeMaster"].ToString());
                        objML_CokeDynamicResult.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamicResult.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamicResult.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamicResult.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamicResult.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamicResult.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamicResult.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamicResult.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamicResult.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamicResult.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamicResult.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByCokeDynamicResult(long CokeDynamicResult)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeDynamicResult", CokeDynamicResult) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByCokeDynamicResult.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamicResult.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResultId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicResultId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResult = ML_Common.clean(dr["CokeDynamicResult"].ToString());
                        objML_CokeDynamicResult.CokeDynamicId = ML_Common.string2int32(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamicResult.CokeCompositeMasterId = ML_Common.string2int32(ML_Common.clean(dr["CokeCompositeMasterId"].ToString()));
                        objML_CokeDynamicResult.CokeCompositeMaster = ML_Common.clean(dr["CokeCompositeMaster"].ToString());
                        objML_CokeDynamicResult.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamicResult.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamicResult.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamicResult.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamicResult.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamicResult.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamicResult.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamicResult.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamicResult.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamicResult.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamicResult.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByCokeDynamicId(long CokeDynamicId)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeDynamicId", CokeDynamicId) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByCokeDynamicId.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamicResult.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResultId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicResultId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResult = ML_Common.clean(dr["CokeDynamicResult"].ToString());
                        objML_CokeDynamicResult.CokeDynamicId = ML_Common.string2int32(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamicResult.CokeCompositeMasterId = ML_Common.string2int32(ML_Common.clean(dr["CokeCompositeMasterId"].ToString()));
                        objML_CokeDynamicResult.CokeCompositeMaster = ML_Common.clean(dr["CokeCompositeMaster"].ToString());
                        objML_CokeDynamicResult.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamicResult.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamicResult.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamicResult.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamicResult.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamicResult.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamicResult.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamicResult.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamicResult.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamicResult.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamicResult.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByCokeDynamic(long CokeDynamic)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeDynamic", CokeDynamic) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByCokeDynamic.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamicResult.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResultId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicResultId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResult = ML_Common.clean(dr["CokeDynamicResult"].ToString());
                        objML_CokeDynamicResult.CokeDynamicId = ML_Common.string2int32(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamicResult.CokeCompositeMasterId = ML_Common.string2int32(ML_Common.clean(dr["CokeCompositeMasterId"].ToString()));
                        objML_CokeDynamicResult.CokeCompositeMaster = ML_Common.clean(dr["CokeCompositeMaster"].ToString());
                        objML_CokeDynamicResult.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamicResult.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamicResult.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamicResult.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamicResult.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamicResult.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamicResult.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamicResult.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamicResult.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamicResult.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamicResult.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByCokeCompositeMasterId(long CokeCompositeMasterId)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeCompositeMasterId", CokeCompositeMasterId) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByCokeCompositeMasterId.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamicResult.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResultId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicResultId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResult = ML_Common.clean(dr["CokeDynamicResult"].ToString());
                        objML_CokeDynamicResult.CokeDynamicId = ML_Common.string2int32(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamicResult.CokeCompositeMasterId = ML_Common.string2int32(ML_Common.clean(dr["CokeCompositeMasterId"].ToString()));
                        objML_CokeDynamicResult.CokeCompositeMaster = ML_Common.clean(dr["CokeCompositeMaster"].ToString());
                        objML_CokeDynamicResult.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamicResult.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamicResult.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamicResult.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamicResult.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamicResult.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamicResult.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamicResult.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamicResult.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamicResult.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamicResult.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
                        objML_CokeDynamicResult.Result = ML_Common.string2NullableDouble(dr["Result"].ToString());
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
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByCokeCompositeMaster(long CokeCompositeMaster)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeCompositeMaster", CokeCompositeMaster) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByCokeCompositeMaster.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamicResult.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResultId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicResultId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResult = ML_Common.clean(dr["CokeDynamicResult"].ToString());
                        objML_CokeDynamicResult.CokeDynamicId = ML_Common.string2int32(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamicResult.CokeCompositeMasterId = ML_Common.string2int32(ML_Common.clean(dr["CokeCompositeMasterId"].ToString()));
                        objML_CokeDynamicResult.CokeCompositeMaster = ML_Common.clean(dr["CokeCompositeMaster"].ToString());
                        objML_CokeDynamicResult.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamicResult.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamicResult.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamicResult.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamicResult.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamicResult.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamicResult.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamicResult.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamicResult.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamicResult.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamicResult.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
                        objML_CokeDynamicResult.Result = ML_Common.string2NullableDouble(dr["Result"].ToString());
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
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByCokeTypeId(long CokeTypeId)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeTypeId", CokeTypeId) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByCokeTypeId.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamicResult.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResultId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicResultId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResult = ML_Common.clean(dr["CokeDynamicResult"].ToString());
                        objML_CokeDynamicResult.CokeDynamicId = ML_Common.string2int32(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamicResult.CokeCompositeMasterId = ML_Common.string2int32(ML_Common.clean(dr["CokeCompositeMasterId"].ToString()));
                        objML_CokeDynamicResult.CokeCompositeMaster = ML_Common.clean(dr["CokeCompositeMaster"].ToString());
                        objML_CokeDynamicResult.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamicResult.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamicResult.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamicResult.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamicResult.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamicResult.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamicResult.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamicResult.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamicResult.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamicResult.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamicResult.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByCokeType(long CokeType)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeType", CokeType) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByCokeType.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamicResult.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResultId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicResultId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResult = ML_Common.clean(dr["CokeDynamicResult"].ToString());
                        objML_CokeDynamicResult.CokeDynamicId = ML_Common.string2int32(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamicResult.CokeCompositeMasterId = ML_Common.string2int32(ML_Common.clean(dr["CokeCompositeMasterId"].ToString()));
                        objML_CokeDynamicResult.CokeCompositeMaster = ML_Common.clean(dr["CokeCompositeMaster"].ToString());
                        objML_CokeDynamicResult.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamicResult.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamicResult.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamicResult.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamicResult.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamicResult.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamicResult.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamicResult.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamicResult.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamicResult.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamicResult.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByCokeSupplierId(long CokeSupplierId)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByCokeSupplierId.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamicResult.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResultId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicResultId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResult = ML_Common.clean(dr["CokeDynamicResult"].ToString());
                        objML_CokeDynamicResult.CokeDynamicId = ML_Common.string2int32(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamicResult.CokeCompositeMasterId = ML_Common.string2int32(ML_Common.clean(dr["CokeCompositeMasterId"].ToString()));
                        objML_CokeDynamicResult.CokeCompositeMaster = ML_Common.clean(dr["CokeCompositeMaster"].ToString());
                        objML_CokeDynamicResult.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamicResult.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamicResult.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamicResult.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamicResult.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamicResult.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamicResult.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamicResult.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamicResult.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamicResult.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamicResult.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByCokeSupplier(long CokeSupplier)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeSupplier", CokeSupplier) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByCokeSupplier.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamicResult.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResultId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicResultId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResult = ML_Common.clean(dr["CokeDynamicResult"].ToString());
                        objML_CokeDynamicResult.CokeDynamicId = ML_Common.string2int32(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamicResult.CokeCompositeMasterId = ML_Common.string2int32(ML_Common.clean(dr["CokeCompositeMasterId"].ToString()));
                        objML_CokeDynamicResult.CokeCompositeMaster = ML_Common.clean(dr["CokeCompositeMaster"].ToString());
                        objML_CokeDynamicResult.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamicResult.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamicResult.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamicResult.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamicResult.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamicResult.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamicResult.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamicResult.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamicResult.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamicResult.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamicResult.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByAnalysisTypeId(long AnalysisTypeId)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByAnalysisTypeId.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamicResult.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResultId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicResultId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResult = ML_Common.clean(dr["CokeDynamicResult"].ToString());
                        objML_CokeDynamicResult.CokeDynamicId = ML_Common.string2int32(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamicResult.CokeCompositeMasterId = ML_Common.string2int32(ML_Common.clean(dr["CokeCompositeMasterId"].ToString()));
                        objML_CokeDynamicResult.CokeCompositeMaster = ML_Common.clean(dr["CokeCompositeMaster"].ToString());
                        objML_CokeDynamicResult.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamicResult.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamicResult.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamicResult.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamicResult.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamicResult.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamicResult.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamicResult.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamicResult.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamicResult.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamicResult.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByAnalysisType(long AnalysisType)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@AnalysisType", AnalysisType) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByAnalysisType.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamicResult.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResultId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicResultId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResult = ML_Common.clean(dr["CokeDynamicResult"].ToString());
                        objML_CokeDynamicResult.CokeDynamicId = ML_Common.string2int32(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamicResult.CokeCompositeMasterId = ML_Common.string2int32(ML_Common.clean(dr["CokeCompositeMasterId"].ToString()));
                        objML_CokeDynamicResult.CokeCompositeMaster = ML_Common.clean(dr["CokeCompositeMaster"].ToString());
                        objML_CokeDynamicResult.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamicResult.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamicResult.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamicResult.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamicResult.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamicResult.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamicResult.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamicResult.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamicResult.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamicResult.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamicResult.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByIdnCokeDynamicResultIdnCokeDynamicResultnCokeDynamicIdnCokeDynamicnCokeCompositeMasterIdnCokeCompositeMasternCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long Id, int CokeDynamicResultId, int CokeDynamicResult, int CokeDynamicId, int CokeDynamic, int CokeCompositeMasterId, int CokeCompositeMaster, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@Id", Id), 
	    new SqlParameter("@CokeDynamicResultId", CokeDynamicResultId), 
	    new SqlParameter("@CokeDynamicResult", CokeDynamicResult), 
	    new SqlParameter("@CokeDynamicId", CokeDynamicId), 
	    new SqlParameter("@CokeDynamic", CokeDynamic), 
	    new SqlParameter("@CokeCompositeMasterId", CokeCompositeMasterId), 
	    new SqlParameter("@CokeCompositeMaster", CokeCompositeMaster), 
	    new SqlParameter("@CokeTypeId", CokeTypeId), 
	    new SqlParameter("@CokeType", CokeType), 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId), 
	    new SqlParameter("@CokeSupplier", CokeSupplier), 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByIdnCokeDynamicResultIdnCokeDynamicResultnCokeDynamicIdnCokeDynamicnCokeCompositeMasterIdnCokeCompositeMasternCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamicResult.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResultId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicResultId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamicResult = ML_Common.clean(dr["CokeDynamicResult"].ToString());
                        objML_CokeDynamicResult.CokeDynamicId = ML_Common.string2int32(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamicResult.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamicResult.CokeCompositeMasterId = ML_Common.string2int32(ML_Common.clean(dr["CokeCompositeMasterId"].ToString()));
                        objML_CokeDynamicResult.CokeCompositeMaster = ML_Common.clean(dr["CokeCompositeMaster"].ToString());
                        objML_CokeDynamicResult.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamicResult.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamicResult.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamicResult.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamicResult.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamicResult.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamicResult.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamicResult.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamicResult.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamicResult.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamicResult.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamicResult;
        }


        public DataTable GetCokeDynamicResultByIdDs(long Id)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@Id", Id) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultById.ToString(), this.Parameters);


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


        public DataTable GetCokeDynamicResultByCokeDynamicResultIdDs(long CokeDynamicResultId)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeDynamicResultId", CokeDynamicResultId) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByCokeDynamicResultId.ToString(), this.Parameters);


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


        public DataTable GetCokeDynamicResultByCokeDynamicResultDs(long CokeDynamicResult)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeDynamicResult", CokeDynamicResult) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByCokeDynamicResult.ToString(), this.Parameters);


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


        public DataTable GetCokeDynamicResultByCokeDynamicIdDs(long CokeDynamicId)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeDynamicId", CokeDynamicId) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByCokeDynamicId.ToString(), this.Parameters);

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


        public DataTable GetCokeDynamicResultByCokeDynamicDs(long CokeDynamic)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeDynamic", CokeDynamic) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByCokeDynamic.ToString(), this.Parameters);


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


        public DataTable GetCokeDynamicResultByCokeCompositeMasterIdDs(long CokeCompositeMasterId)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeCompositeMasterId", CokeCompositeMasterId) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByCokeCompositeMasterId.ToString(), this.Parameters);


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


        public DataTable GetCokeDynamicResultByCokeCompositeMasterDs(long CokeCompositeMaster)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeCompositeMaster", CokeCompositeMaster) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByCokeCompositeMaster.ToString(), this.Parameters);


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


        public DataTable GetCokeDynamicResultByCokeTypeIdDs(long CokeTypeId)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeTypeId", CokeTypeId) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByCokeTypeId.ToString(), this.Parameters);


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


        public DataTable GetCokeDynamicResultByCokeTypeDs(long CokeType)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeType", CokeType) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByCokeType.ToString(), this.Parameters);

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


        public DataTable GetCokeDynamicResultByCokeSupplierIdDs(long CokeSupplierId)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByCokeSupplierId.ToString(), this.Parameters);


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


        public DataTable GetCokeDynamicResultByCokeSupplierDs(long CokeSupplier)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeSupplier", CokeSupplier) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByCokeSupplier.ToString(), this.Parameters);

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


        public DataTable GetCokeDynamicResultByAnalysisTypeIdDs(long AnalysisTypeId)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByAnalysisTypeId.ToString(), this.Parameters);


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


        public DataTable GetCokeDynamicResultByAnalysisTypeDs(long AnalysisType)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@AnalysisType", AnalysisType) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByAnalysisType.ToString(), this.Parameters);

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


      //  public DataTable GetCokeDynamicResultByIdnCokeDynamicResultIdnCokeDynamicResultnCokeDynamicIdnCokeDynamicnCokeCompositeMasterIdnCokeCompositeMasternCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long Id, int CokeDynamicResultId, int CokeDynamicResult, int CokeDynamicId, int CokeDynamic, int CokeCompositeMasterId, int CokeCompositeMaster, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
      //  {
      //      DataTable dt = new DataTable();
      //      try
      //      {
      //          



      //          




      //          

      //          objML_CokeDynamicResult = new ML_CokeDynamicResult();
      //          SqlParameter[] parameters = 
      //{ 
      // #region Get ByIdDs Properties 
      //  new SqlParameter("@Id", Id), 
      //  new SqlParameter("@CokeDynamicResultId", CokeDynamicResultId), 
      //  new SqlParameter("@CokeDynamicResult", CokeDynamicResult), 
      //  new SqlParameter("@CokeDynamicId", CokeDynamicId), 
      //  new SqlParameter("@CokeDynamic", CokeDynamic), 
      //  new SqlParameter("@CokeCompositeMasterId", CokeCompositeMasterId), 
      //  new SqlParameter("@CokeCompositeMaster", CokeCompositeMaster), 
      //  new SqlParameter("@CokeTypeId", CokeTypeId), 
      //  new SqlParameter("@CokeType", CokeType), 
      //  new SqlParameter("@CokeSupplierId", CokeSupplierId), 
      //  new SqlParameter("@CokeSupplier", CokeSupplier), 
      //  new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
      //  new SqlParameter("@AnalysisType", AnalysisType), 
      // #endregion  
      //};

      //          this.Parameters = parameters;
      //          SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByIdnCokeDynamicResultIdnCokeDynamicResultnCokeDynamicIdnCokeDynamicnCokeCompositeMasterIdnCokeCompositeMasternCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);

      //          




      //          

      //      }
      //      catch (Exception ex)
      //      {
      //          Exception exc = ex;// Exception exc=ex;// LogManager.LogManager.WriteErrorLog(ex); 
      //          throw;
      //      }
      //      finally
      //      {
      //          //LogManager.LogManager.WriteTraceLog(



      //      }
      //      return dt;
      //  }




        public DataTable GetCokeDynamicResultByLoginName(string loginName)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamicResult = new ML_CokeDynamicResult();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@loginName", loginName) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicResultByLoginName.ToString(), this.Parameters);


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
