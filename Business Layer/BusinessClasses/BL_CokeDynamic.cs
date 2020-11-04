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
   public class BL_CokeDynamic
    {
        #region All Variable
       
        ML_CokeDynamic objML_CokeDynamic = null;

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
        public int Add(ML_CokeDynamic objML_CokeDynamic)
        {
            int results = 0;
            try
            {
                



                




                
                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	          { 
	             #region Add Properties 
	             //new SqlParameter("@Id", objML_CokeDynamic.Id), 
// new SqlParameter("@CokeDynamicId", objML_CokeDynamic.CokeDynamicId), 
 new SqlParameter("@CokeDynamic", objML_CokeDynamic.CokeDynamic), 
 new SqlParameter("@CokeTypeId", objML_CokeDynamic.CokeTypeId), 
 new SqlParameter("@CokeType", objML_CokeDynamic.CokeType), 
 new SqlParameter("@CokeSupplierId", objML_CokeDynamic.CokeSupplierId), 
 new SqlParameter("@CokeSupplier", objML_CokeDynamic.CokeSupplier), 
 new SqlParameter("@AnalysisTypeId", objML_CokeDynamic.AnalysisTypeId), 
 new SqlParameter("@AnalysisType", objML_CokeDynamic.AnalysisType), 
 new SqlParameter("@FieldSize", objML_CokeDynamic.FieldSize), 
 new SqlParameter("@FieldUnit", objML_CokeDynamic.FieldUnit), 
 new SqlParameter("@FieldSpec", objML_CokeDynamic.FieldSpec), 
 new SqlParameter("@MinValue", objML_CokeDynamic.MinValue), 
 new SqlParameter("@MaxValue", objML_CokeDynamic.MaxValue), 
	             ReturnObj 
	             #endregion  
	          };
                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_SaveCokeDynamic.ToString(), this.Parameters);
                




                

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

        public int Update(ML_CokeDynamic objML_CokeDynamic)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	           { 
	               #region Update Properties 
	     new SqlParameter("@Id", objML_CokeDynamic.Id), 
 new SqlParameter("@CokeDynamicId", objML_CokeDynamic.CokeDynamicId), 
 new SqlParameter("@CokeDynamic", objML_CokeDynamic.CokeDynamic), 
 new SqlParameter("@CokeTypeId", objML_CokeDynamic.CokeTypeId), 
 new SqlParameter("@CokeType", objML_CokeDynamic.CokeType), 
 new SqlParameter("@CokeSupplierId", objML_CokeDynamic.CokeSupplierId), 
 new SqlParameter("@CokeSupplier", objML_CokeDynamic.CokeSupplier), 
 new SqlParameter("@AnalysisTypeId", objML_CokeDynamic.AnalysisTypeId), 
 new SqlParameter("@AnalysisType", objML_CokeDynamic.AnalysisType), 
 new SqlParameter("@FieldSize", objML_CokeDynamic.FieldSize), 
 new SqlParameter("@FieldUnit", objML_CokeDynamic.FieldUnit), 
 new SqlParameter("@FieldSpec", objML_CokeDynamic.FieldSpec), 
  new SqlParameter("@MinValue", objML_CokeDynamic.MinValue), 
 new SqlParameter("@MaxValue", objML_CokeDynamic.MaxValue),
	               ReturnObj 
	               #endregion  
	           };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateCokeDynamic.ToString(), this.Parameters);

                




                

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

        public int UpdateUnique(ML_CokeDynamic objML_CokeDynamic)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	           { 
	               #region Update Unique Properties 
	               //new SqlParameter("@Id", objML_CokeDynamic.Id), 
 new SqlParameter("@CokeDynamicId", objML_CokeDynamic.CokeDynamicId), 
 new SqlParameter("@CokeDynamic", objML_CokeDynamic.CokeDynamic), 
 new SqlParameter("@CokeTypeId", objML_CokeDynamic.CokeTypeId), 
 new SqlParameter("@CokeType", objML_CokeDynamic.CokeType), 
 new SqlParameter("@CokeSupplierId", objML_CokeDynamic.CokeSupplierId), 
 new SqlParameter("@CokeSupplier", objML_CokeDynamic.CokeSupplier), 
 new SqlParameter("@AnalysisTypeId", objML_CokeDynamic.AnalysisTypeId), 
 new SqlParameter("@AnalysisType", objML_CokeDynamic.AnalysisType), 
 new SqlParameter("@FieldSize", objML_CokeDynamic.FieldSize), 
 new SqlParameter("@FieldUnit", objML_CokeDynamic.FieldUnit), 
 new SqlParameter("@FieldSpec", objML_CokeDynamic.FieldSpec), 
  new SqlParameter("@MinValue", objML_CokeDynamic.MinValue), 
 new SqlParameter("@MaxValue", objML_CokeDynamic.MaxValue),
	               ReturnObj 
	               #endregion  
	           };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateUniqueCokeDynamic.ToString(), this.Parameters);

                




                

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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicById.ToString(), this.Parameters);

                




                

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
        public int DeleteCokeDynamicById(long Id)
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicById.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicByCokeDynamicId(long CokeDynamicId)
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicByCokeDynamicId.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicByCokeDynamic(long CokeDynamic)
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicByCokeDynamic.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicByCokeTypeId(long CokeTypeId)
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicByCokeTypeId.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicByCokeType(long CokeType)
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicByCokeType.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicByCokeSupplierId(long CokeSupplierId)
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicByCokeSupplierId.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicByCokeSupplier(long CokeSupplier)
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicByCokeSupplier.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicByAnalysisTypeId(long AnalysisTypeId)
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicByAnalysisTypeId.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicByAnalysisType(long AnalysisType)
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicByAnalysisType.ToString(), this.Parameters);

                




                

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
        public int DeleteCokeDynamicByIdnCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long Id, int CokeDynamicId, int CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
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
	    new SqlParameter("@CokeDynamicId", CokeDynamicId), 
	    new SqlParameter("@CokeDynamic", CokeDynamic), 
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicByIdnCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicByCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeDynamicId, int CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
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
	    new SqlParameter("@CokeDynamic", CokeDynamic), 
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicByCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicByCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicByCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicByCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
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
	    new SqlParameter("@CokeType", CokeType), 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId), 
	    new SqlParameter("@CokeSupplier", CokeSupplier), 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicByCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicByCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
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
	    new SqlParameter("@CokeSupplierId", CokeSupplierId), 
	    new SqlParameter("@CokeSupplier", CokeSupplier), 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicByCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicByCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
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
	    new SqlParameter("@CokeSupplier", CokeSupplier), 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicByCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicByCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeSupplier, int AnalysisTypeId, int AnalysisType)
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
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicByCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeDynamicByAnalysisTypeIdnAnalysisType(long AnalysisTypeId, int AnalysisType)
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
	    new SqlParameter("@AnalysisType", AnalysisType), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeDynamicByAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);

                




                

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

        public DataTable GetCokeDynamicBySeacrh(ML_CokeDynamic objML_CokeDynamic)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                DateTime? dtFromdate = null;
                DateTime objFromdate;
                if (DateTime.TryParse(objML_CokeDynamic.FromDate.ToString(), out objFromdate))
                {
                    if (objFromdate.ToString() != "1/1/1900 12:00:00 AM")
                    {
                        dtFromdate = objFromdate;
                    }
                }
                DateTime? dtTodate = null;
                DateTime objdtTodate;
                if (DateTime.TryParse(objML_CokeDynamic.ToDate.ToString(), out objdtTodate))
                {
                    if (objdtTodate.ToString() != "1/1/1900 12:00:00 AM")
                    {
                        dtTodate = objdtTodate;
                    }
                }

                SqlParameter[] parameters = 
	  { 
	   #region Search Properties 
	  //new SqlParameter("@Id", objML_CokeDynamic.Id), 
 //new SqlParameter("@CokeDynamicId", objML_CokeDynamic.CokeDynamicId), 
 //new SqlParameter("@CokeDynamic", objML_CokeDynamic.CokeDynamic), 
 new SqlParameter("@CokeTypeId", objML_CokeDynamic.CokeTypeId), 
 //new SqlParameter("@CokeType", objML_CokeDynamic.CokeType), 
 new SqlParameter("@CokeSupplierId", objML_CokeDynamic.CokeSupplierId), 
 //new SqlParameter("@CokeSupplier", objML_CokeDynamic.CokeSupplier), 
 new SqlParameter("@AnalysisTypeId", objML_CokeDynamic.AnalysisTypeId), 
 //new SqlParameter("@AnalysisType", objML_CokeDynamic.AnalysisType), 
 //new SqlParameter("@FieldSize", objML_CokeDynamic.FieldSize), 
 //new SqlParameter("@FieldUnit", objML_CokeDynamic.FieldUnit), 
 //new SqlParameter("@FieldSpec", objML_CokeDynamic.FieldSpec), 
 //new SqlParameter("@MinValue", objML_CokeDynamic.MinValue), 
 //new SqlParameter("@MaxValue", objML_CokeDynamic.MaxValue), 
 //new SqlParameter("@FromDate", dtFromdate), 
 //new SqlParameter("@ToDate",dtTodate)
	   #endregion 
	  };
                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicBySearch.ToString(), this.Parameters);


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

        public DataTable GetCokeDynamic()
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                
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


        public ML_CokeDynamic GetCokeDynamicById(long Id)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@Id", Id) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicById.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamic.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamic.CokeDynamicId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamic.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamic.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamic.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamic.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamic.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamic.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamic.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamic.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamic.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamic.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamic.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamic.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeDynamicId(long CokeDynamicId)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeDynamicId", CokeDynamicId) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeDynamicId.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamic.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamic.CokeDynamicId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamic.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamic.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamic.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamic.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamic.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamic.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamic.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamic.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamic.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamic.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamic.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamic.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeDynamic(long CokeDynamic)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeDynamic", CokeDynamic) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeDynamic.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamic.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamic.CokeDynamicId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamic.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamic.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamic.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamic.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamic.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamic.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamic.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamic.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamic.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamic.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamic.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamic.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeTypeId(long CokeTypeId)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeTypeId", CokeTypeId) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeTypeId.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamic.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamic.CokeDynamicId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamic.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamic.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamic.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamic.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamic.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamic.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamic.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamic.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamic.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamic.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamic.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamic.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeType(long CokeType)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeType", CokeType) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeType.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamic.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamic.CokeDynamicId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamic.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamic.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamic.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamic.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamic.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamic.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamic.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamic.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamic.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamic.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamic.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamic.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeSupplierId(long CokeSupplierId)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeSupplierId.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamic.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamic.CokeDynamicId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamic.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamic.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamic.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamic.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamic.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamic.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamic.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamic.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamic.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamic.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamic.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamic.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeSupplier(long CokeSupplier)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeSupplier", CokeSupplier) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeSupplier.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamic.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamic.CokeDynamicId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamic.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamic.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamic.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamic.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamic.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamic.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamic.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamic.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamic.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamic.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamic.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamic.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByAnalysisTypeId(long AnalysisTypeId)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByAnalysisTypeId.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamic.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamic.CokeDynamicId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamic.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamic.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamic.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamic.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamic.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamic.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamic.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamic.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamic.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamic.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamic.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamic.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByAnalysisType(long AnalysisType)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@AnalysisType", AnalysisType) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByAnalysisType.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamic.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamic.CokeDynamicId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamic.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamic.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamic.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamic.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamic.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamic.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamic.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamic.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamic.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamic.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamic.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamic.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByIdnCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long Id, int CokeDynamicId, int CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@Id", Id), 
	    new SqlParameter("@CokeDynamicId", CokeDynamicId), 
	    new SqlParameter("@CokeDynamic", CokeDynamic), 
	    new SqlParameter("@CokeTypeId", CokeTypeId), 
	    new SqlParameter("@CokeType", CokeType), 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId), 
	    new SqlParameter("@CokeSupplier", CokeSupplier), 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByIdnCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamic.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamic.CokeDynamicId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamic.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamic.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamic.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamic.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamic.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamic.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamic.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamic.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamic.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamic.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamic.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamic.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeDynamicId, int CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeDynamicId", CokeDynamicId), 
	    new SqlParameter("@CokeDynamic", CokeDynamic), 
	    new SqlParameter("@CokeTypeId", CokeTypeId), 
	    new SqlParameter("@CokeType", CokeType), 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId), 
	    new SqlParameter("@CokeSupplier", CokeSupplier), 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamic.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamic.CokeDynamicId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamic.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamic.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamic.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamic.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamic.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamic.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamic.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamic.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamic.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamic.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamic.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamic.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeDynamic", CokeDynamic), 
	    new SqlParameter("@CokeTypeId", CokeTypeId), 
	    new SqlParameter("@CokeType", CokeType), 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId), 
	    new SqlParameter("@CokeSupplier", CokeSupplier), 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamic.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamic.CokeDynamicId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamic.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamic.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamic.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamic.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamic.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamic.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamic.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamic.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamic.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamic.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamic.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamic.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeTypeId", CokeTypeId), 
	    new SqlParameter("@CokeType", CokeType), 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId), 
	    new SqlParameter("@CokeSupplier", CokeSupplier), 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamic.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamic.CokeDynamicId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamic.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamic.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamic.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamic.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamic.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamic.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamic.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamic.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamic.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamic.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamic.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamic.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeType", CokeType), 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId), 
	    new SqlParameter("@CokeSupplier", CokeSupplier), 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamic.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamic.CokeDynamicId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamic.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamic.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamic.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamic.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamic.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamic.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamic.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamic.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamic.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamic.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamic.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamic.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId), 
	    new SqlParameter("@CokeSupplier", CokeSupplier), 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamic.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamic.CokeDynamicId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamic.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamic.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamic.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamic.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamic.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamic.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamic.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamic.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamic.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamic.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamic.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamic.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeSupplier", CokeSupplier), 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamic.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamic.CokeDynamicId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamic.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamic.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamic.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamic.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamic.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamic.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamic.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamic.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamic.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamic.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamic.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamic.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByAnalysisTypeIdnAnalysisType(long AnalysisTypeId, int AnalysisType)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeDynamic.Id = ML_Common.string2Long(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeDynamic.CokeDynamicId = ML_Common.string2Long(ML_Common.clean(dr["CokeDynamicId"].ToString()));
                        objML_CokeDynamic.CokeDynamic = ML_Common.clean(dr["CokeDynamic"].ToString());
                        objML_CokeDynamic.CokeTypeId = ML_Common.string2int32(ML_Common.clean(dr["CokeTypeId"].ToString()));
                        objML_CokeDynamic.CokeType = ML_Common.clean(dr["CokeType"].ToString());
                        objML_CokeDynamic.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeDynamic.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeDynamic.AnalysisTypeId = ML_Common.string2int32(ML_Common.clean(dr["AnalysisTypeId"].ToString()));
                        objML_CokeDynamic.AnalysisType = ML_Common.clean(dr["AnalysisType"].ToString());
                        objML_CokeDynamic.FieldSize = ML_Common.clean(dr["FieldSize"].ToString());
                        objML_CokeDynamic.FieldUnit = ML_Common.clean(dr["FieldUnit"].ToString());
                        objML_CokeDynamic.FieldSpec = ML_Common.clean(dr["FieldSpec"].ToString());
                        objML_CokeDynamic.MinValue = ML_Common.clean(dr["MinValue"].ToString());
                        objML_CokeDynamic.MaxValue = ML_Common.clean(dr["MaxValue"].ToString());
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
            return objML_CokeDynamic;
        }


        public DataTable GetCokeDynamicByIdDs(long Id)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@Id", Id) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicById.ToString(), this.Parameters);



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


        public DataTable GetCokeDynamicByCokeDynamicIdDs(long CokeDynamicId)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeDynamicId", CokeDynamicId) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeDynamicId.ToString(), this.Parameters);


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


        public DataTable GetCokeDynamicByCokeDynamicDs(long CokeDynamic)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeDynamic", CokeDynamic) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeDynamic.ToString(), this.Parameters);


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


        public DataTable GetCokeDynamicByCokeTypeIdDs(long CokeTypeId)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeTypeId", CokeTypeId) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeTypeId.ToString(), this.Parameters);


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


        public DataTable GetCokeDynamicByCokeTypeDs(long CokeType)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeType", CokeType) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeType.ToString(), this.Parameters);


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


        public DataTable GetCokeDynamicByCokeSupplierIdDs(long CokeSupplierId)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeSupplierId.ToString(), this.Parameters);

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


        public DataTable GetCokeDynamicByCokeSupplierDs(long CokeSupplier)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeSupplier", CokeSupplier) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeSupplier.ToString(), this.Parameters);

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


        public DataTable GetCokeDynamicByAnalysisTypeIdDs(long AnalysisTypeId)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByAnalysisTypeId.ToString(), this.Parameters);


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


        public DataTable GetCokeDynamicByAnalysisTypeDs(long AnalysisType)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@AnalysisType", AnalysisType) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByAnalysisType.ToString(), this.Parameters);


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


        public DataTable GetCokeDynamicByIdnCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long Id, int CokeDynamicId, int CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@Id", Id), 
	    new SqlParameter("@CokeDynamicId", CokeDynamicId), 
	    new SqlParameter("@CokeDynamic", CokeDynamic), 
	    new SqlParameter("@CokeTypeId", CokeTypeId), 
	    new SqlParameter("@CokeType", CokeType), 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId), 
	    new SqlParameter("@CokeSupplier", CokeSupplier), 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByIdnCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);


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


        public DataTable GetCokeDynamicByCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long CokeDynamicId, int CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeDynamicId", CokeDynamicId), 
	    new SqlParameter("@CokeDynamic", CokeDynamic), 
	    new SqlParameter("@CokeTypeId", CokeTypeId), 
	    new SqlParameter("@CokeType", CokeType), 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId), 
	    new SqlParameter("@CokeSupplier", CokeSupplier), 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);



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


        public DataTable GetCokeDynamicByCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeDynamic", CokeDynamic), 
	    new SqlParameter("@CokeTypeId", CokeTypeId), 
	    new SqlParameter("@CokeType", CokeType), 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId), 
	    new SqlParameter("@CokeSupplier", CokeSupplier), 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);

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


        public DataTable GetCokeDynamicByCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeTypeId", CokeTypeId), 
	    new SqlParameter("@CokeType", CokeType), 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId), 
	    new SqlParameter("@CokeSupplier", CokeSupplier), 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);


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


        public DataTable GetCokeDynamicByCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeType", CokeType), 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId), 
	    new SqlParameter("@CokeSupplier", CokeSupplier), 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);


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


        public DataTable GetCokeDynamicByCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId), 
	    new SqlParameter("@CokeSupplier", CokeSupplier), 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);


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


        public DataTable GetCokeDynamicByCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeSupplier", CokeSupplier), 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByCokeSuppliernAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);


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


        public DataTable GetCokeDynamicByAnalysisTypeIdnAnalysisTypeDs(long AnalysisTypeId, int AnalysisType)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@AnalysisTypeId", AnalysisTypeId), 
	    new SqlParameter("@AnalysisType", AnalysisType), 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByAnalysisTypeIdnAnalysisType.ToString(), this.Parameters);


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




        public DataTable GetCokeDynamicByLoginName(string loginName)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeDynamic = new ML_CokeDynamic();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@loginName", loginName) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeDynamicByLoginName.ToString(), this.Parameters);


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
