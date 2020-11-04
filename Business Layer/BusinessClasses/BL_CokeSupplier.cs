#region BUSINESSCLASSES For tblCokeSupplier
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
    public class BL_CokeSupplier
    {
        #region All Variable
       
        ML_CokeSupplier objML_CokeSupplier = null;

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
        public int Add(ML_CokeSupplier objML_CokeSupplier)
        {
            int results = 0;
            try
            {
                



                




                
                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	          { 
	             #region Add Properties 
	             //new SqlParameter("@Id", objML_CokeSupplier.Id), 
 //new SqlParameter("@CokeSupplierId", objML_CokeSupplier.CokeSupplierId), 
 new SqlParameter("@CokeSupplier", objML_CokeSupplier.CokeSupplier), 
 new SqlParameter("@Address1", objML_CokeSupplier.Address1), 
 new SqlParameter("@Address2", objML_CokeSupplier.Address2), 
 new SqlParameter("@Address3", objML_CokeSupplier.Address3), 
 new SqlParameter("@CityName", objML_CokeSupplier.CityName), 
 new SqlParameter("@StateName", objML_CokeSupplier.StateName), 
 new SqlParameter("@PinCode", objML_CokeSupplier.PinCode), 
 new SqlParameter("@Title", objML_CokeSupplier.Title), 
 new SqlParameter("@CountryName", objML_CokeSupplier.CountryName), 
 new SqlParameter("@ContactPerson", objML_CokeSupplier.ContactPerson), 
 new SqlParameter("@MobNo", objML_CokeSupplier.MobNo), 
 new SqlParameter("@WebSite", objML_CokeSupplier.WebSite), 
 new SqlParameter("@Email", objML_CokeSupplier.Email), 
 new SqlParameter("@Remarks", objML_CokeSupplier.Remarks), 
 new SqlParameter("@IsActive", objML_CokeSupplier.IsActive), 
 new SqlParameter("@IsArchive", objML_CokeSupplier.IsArchive), 
 //new SqlParameter("@CreatedDate", objML_CokeSupplier.CreatedDate), 
 new SqlParameter("@CreatedBy", objML_CokeSupplier.CreatedBy), 
 //new SqlParameter("@ModifiedDate", objML_CokeSupplier.ModifiedDate), 
 //new SqlParameter("@ModifiedBy", objML_CokeSupplier.ModifiedBy), 
 new SqlParameter("@CreatedByUserNameId", objML_CokeSupplier.CreatedByUserNameId), 
	             ReturnObj 
	             #endregion  
	          };
                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_SaveCokeSupplier.ToString(), this.Parameters);
                




                

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

        public int Update(ML_CokeSupplier objML_CokeSupplier)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	           { 
	               #region Update Properties 
	               new SqlParameter("@Id", objML_CokeSupplier.Id), 
 new SqlParameter("@CokeSupplierId", objML_CokeSupplier.CokeSupplierId), 
 new SqlParameter("@CokeSupplier", objML_CokeSupplier.CokeSupplier), 
 new SqlParameter("@Address1", objML_CokeSupplier.Address1), 
 new SqlParameter("@Address2", objML_CokeSupplier.Address2), 
 new SqlParameter("@Address3", objML_CokeSupplier.Address3), 
 new SqlParameter("@CityName", objML_CokeSupplier.CityName), 
 new SqlParameter("@StateName", objML_CokeSupplier.StateName), 
 new SqlParameter("@PinCode", objML_CokeSupplier.PinCode), 
 new SqlParameter("@Title", objML_CokeSupplier.Title), 
 new SqlParameter("@CountryName", objML_CokeSupplier.CountryName), 
 new SqlParameter("@ContactPerson", objML_CokeSupplier.ContactPerson), 
 new SqlParameter("@MobNo", objML_CokeSupplier.MobNo), 
 new SqlParameter("@WebSite", objML_CokeSupplier.WebSite), 
 new SqlParameter("@Email", objML_CokeSupplier.Email), 
 new SqlParameter("@Remarks", objML_CokeSupplier.Remarks), 
 new SqlParameter("@IsActive", objML_CokeSupplier.IsActive), 
 new SqlParameter("@IsArchive", objML_CokeSupplier.IsArchive), 
 //new SqlParameter("@CreatedDate", objML_CokeSupplier.CreatedDate), 
 //new SqlParameter("@CreatedBy", objML_CokeSupplier.CreatedBy), 
 //new SqlParameter("@ModifiedDate", objML_CokeSupplier.ModifiedDate), 
 new SqlParameter("@ModifiedBy", objML_CokeSupplier.ModifiedBy), 
 new SqlParameter("@CreatedByUserNameId", objML_CokeSupplier.CreatedByUserNameId), 
	               ReturnObj 
	               #endregion  
	           };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateCokeSupplier.ToString(), this.Parameters);

                




                

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

        public int UpdateUnique(ML_CokeSupplier objML_CokeSupplier)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	           { 
	               #region Update Unique Properties 
	               new SqlParameter("@Id", objML_CokeSupplier.Id), 
 new SqlParameter("@CokeSupplierId", objML_CokeSupplier.CokeSupplierId), 
 new SqlParameter("@CokeSupplier", objML_CokeSupplier.CokeSupplier), 
 new SqlParameter("@Address1", objML_CokeSupplier.Address1), 
 new SqlParameter("@Address2", objML_CokeSupplier.Address2), 
 new SqlParameter("@Address3", objML_CokeSupplier.Address3), 
 new SqlParameter("@CityName", objML_CokeSupplier.CityName), 
 new SqlParameter("@StateName", objML_CokeSupplier.StateName), 
 new SqlParameter("@PinCode", objML_CokeSupplier.PinCode), 
 new SqlParameter("@Title", objML_CokeSupplier.Title), 
 new SqlParameter("@CountryName", objML_CokeSupplier.CountryName), 
 new SqlParameter("@ContactPerson", objML_CokeSupplier.ContactPerson), 
 new SqlParameter("@MobNo", objML_CokeSupplier.MobNo), 
 new SqlParameter("@WebSite", objML_CokeSupplier.WebSite), 
 new SqlParameter("@Email", objML_CokeSupplier.Email), 
 new SqlParameter("@Remarks", objML_CokeSupplier.Remarks), 
 new SqlParameter("@IsActive", objML_CokeSupplier.IsActive), 
 new SqlParameter("@IsArchive", objML_CokeSupplier.IsArchive), 
 //new SqlParameter("@CreatedDate", objML_CokeSupplier.CreatedDate), 
 //new SqlParameter("@CreatedBy", objML_CokeSupplier.CreatedBy), 
 //new SqlParameter("@ModifiedDate", objML_CokeSupplier.ModifiedDate), 
 new SqlParameter("@ModifiedBy", objML_CokeSupplier.ModifiedBy), 
 new SqlParameter("@CreatedByUserNameId", objML_CokeSupplier.CreatedByUserNameId), 
	               ReturnObj 
	               #endregion  
	           };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateUniqueCokeSupplier.ToString(), this.Parameters);

                




                

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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeSupplierById.ToString(), this.Parameters);

                




                

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
        public int DeleteCokeSupplierById(int Id)
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeSupplierById.ToString(), this.Parameters);

                




                

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

        public int DeleteCokeSupplierByCokeSupplierId(int CokeSupplierId)
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteCokeSupplierByCokeSupplierId.ToString(), this.Parameters);

                




                

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

        public DataTable GetCokeSupplierBySeacrh(ML_CokeSupplier objML_CokeSupplier)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                DateTime? dtFromdate = null;
                DateTime objFromdate;
                if (DateTime.TryParse(objML_CokeSupplier.FromDate.ToString(), out objFromdate))
                {
                    if (objFromdate.ToString() != "1/1/1900 12:00:00 AM")
                    {
                        dtFromdate = objFromdate;
                    }
                }
                DateTime? dtTodate = null;
                DateTime objdtTodate;
                if (DateTime.TryParse(objML_CokeSupplier.ToDate.ToString(), out objdtTodate))
                {
                    if (objdtTodate.ToString() != "1/1/1900 12:00:00 AM")
                    {
                        dtTodate = objdtTodate;
                    }
                }

                SqlParameter[] parameters = 
	  { 
	   #region Search Properties 
	  //new SqlParameter("@Id", objML_CokeSupplier.Id), 
// new SqlParameter("@CokeSupplierId", objML_CokeSupplier.CokeSupplierId), 
 new SqlParameter("@CokeSupplier", objML_CokeSupplier.CokeSupplier), 
 //new SqlParameter("@Address1", objML_CokeSupplier.Address1), 
 //new SqlParameter("@Address2", objML_CokeSupplier.Address2), 
 //new SqlParameter("@Address3", objML_CokeSupplier.Address3), 
 //new SqlParameter("@CityName", objML_CokeSupplier.CityName), 
 //new SqlParameter("@StateName", objML_CokeSupplier.StateName), 
 //new SqlParameter("@PinCode", objML_CokeSupplier.PinCode), 
 //new SqlParameter("@Title", objML_CokeSupplier.Title), 
 //new SqlParameter("@CountryName", objML_CokeSupplier.CountryName), 
 //new SqlParameter("@ContactPerson", objML_CokeSupplier.ContactPerson), 
 //new SqlParameter("@MobNo", objML_CokeSupplier.MobNo), 
 //new SqlParameter("@WebSite", objML_CokeSupplier.WebSite), 
 //new SqlParameter("@Email", objML_CokeSupplier.Email), 
 //new SqlParameter("@Remarks", objML_CokeSupplier.Remarks), 
 //new SqlParameter("@IsActive", objML_CokeSupplier.IsActive), 
 //new SqlParameter("@IsArchive", objML_CokeSupplier.IsArchive), 
 //new SqlParameter("@CreatedDate", objML_CokeSupplier.CreatedDate), 
 //new SqlParameter("@CreatedBy", objML_CokeSupplier.CreatedBy), 
 //new SqlParameter("@ModifiedDate", objML_CokeSupplier.ModifiedDate), 
 //new SqlParameter("@ModifiedBy", objML_CokeSupplier.ModifiedBy), 
 //new SqlParameter("@CreatedByUserNameId", objML_CokeSupplier.CreatedByUserNameId), 
 new SqlParameter("@FromDate", dtFromdate), 
 new SqlParameter("@ToDate",dtTodate)
	   #endregion 
	  };
                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeSupplierBySearch.ToString(), this.Parameters);


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

        public DataTable GetCokeSupplier()
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeSupplier.ToString());


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


        public ML_CokeSupplier GetCokeSupplierById(int Id)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeSupplier = new ML_CokeSupplier();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@Id", Id) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeSupplierById.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeSupplier.Id = ML_Common.string2int32(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeSupplier.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeSupplier.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeSupplier.Address1 = ML_Common.clean(dr["Address1"].ToString());
                        objML_CokeSupplier.Address2 = ML_Common.clean(dr["Address2"].ToString());
                        objML_CokeSupplier.Address3 = ML_Common.clean(dr["Address3"].ToString());
                        objML_CokeSupplier.CityName = ML_Common.clean(dr["CityName"].ToString());
                        objML_CokeSupplier.StateName = ML_Common.clean(dr["StateName"].ToString());
                        objML_CokeSupplier.PinCode = ML_Common.clean(dr["PinCode"].ToString());
                        objML_CokeSupplier.Title = ML_Common.clean(dr["Title"].ToString());
                        objML_CokeSupplier.CountryName = ML_Common.clean(dr["CountryName"].ToString());
                        objML_CokeSupplier.ContactPerson = ML_Common.clean(dr["ContactPerson"].ToString());
                        objML_CokeSupplier.MobNo = ML_Common.clean(dr["MobNo"].ToString());
                        objML_CokeSupplier.WebSite = ML_Common.clean(dr["WebSite"].ToString());
                        objML_CokeSupplier.Email = ML_Common.clean(dr["Email"].ToString());
                        objML_CokeSupplier.Remarks = ML_Common.clean(dr["Remarks"].ToString());
                        objML_CokeSupplier.IsActive = ML_Common.clean(dr["IsActive"].ToString());
                        objML_CokeSupplier.IsArchive = ML_Common.clean(dr["IsArchive"].ToString());
                        objML_CokeSupplier.CreatedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["CreatedDate"].ToString()));
                        objML_CokeSupplier.CreatedBy = ML_Common.clean(dr["CreatedBy"].ToString());
                        objML_CokeSupplier.ModifiedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["ModifiedDate"].ToString()));
                        objML_CokeSupplier.ModifiedBy = ML_Common.clean(dr["ModifiedBy"].ToString());
                        objML_CokeSupplier.CreatedByUserNameId = ML_Common.string2int(ML_Common.clean(dr["CreatedByUserNameId"].ToString()));
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
            return objML_CokeSupplier;
        }


        public ML_CokeSupplier GetCokeSupplierByCokeSupplierId(int CokeSupplierId)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeSupplier = new ML_CokeSupplier();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeSupplierByCokeSupplierId.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_CokeSupplier.Id = ML_Common.string2int32(ML_Common.clean(dr["Id"].ToString()));
                        objML_CokeSupplier.CokeSupplierId = ML_Common.string2int32(ML_Common.clean(dr["CokeSupplierId"].ToString()));
                        objML_CokeSupplier.CokeSupplier = ML_Common.clean(dr["CokeSupplier"].ToString());
                        objML_CokeSupplier.Address1 = ML_Common.clean(dr["Address1"].ToString());
                        objML_CokeSupplier.Address2 = ML_Common.clean(dr["Address2"].ToString());
                        objML_CokeSupplier.Address3 = ML_Common.clean(dr["Address3"].ToString());
                        objML_CokeSupplier.CityName = ML_Common.clean(dr["CityName"].ToString());
                        objML_CokeSupplier.StateName = ML_Common.clean(dr["StateName"].ToString());
                        objML_CokeSupplier.PinCode = ML_Common.clean(dr["PinCode"].ToString());
                        objML_CokeSupplier.Title = ML_Common.clean(dr["Title"].ToString());
                        objML_CokeSupplier.CountryName = ML_Common.clean(dr["CountryName"].ToString());
                        objML_CokeSupplier.ContactPerson = ML_Common.clean(dr["ContactPerson"].ToString());
                        objML_CokeSupplier.MobNo = ML_Common.clean(dr["MobNo"].ToString());
                        objML_CokeSupplier.WebSite = ML_Common.clean(dr["WebSite"].ToString());
                        objML_CokeSupplier.Email = ML_Common.clean(dr["Email"].ToString());
                        objML_CokeSupplier.Remarks = ML_Common.clean(dr["Remarks"].ToString());
                        objML_CokeSupplier.IsActive = ML_Common.clean(dr["IsActive"].ToString());
                        objML_CokeSupplier.IsArchive = ML_Common.clean(dr["IsArchive"].ToString());
                        objML_CokeSupplier.CreatedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["CreatedDate"].ToString()));
                        objML_CokeSupplier.CreatedBy = ML_Common.clean(dr["CreatedBy"].ToString());
                        objML_CokeSupplier.ModifiedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["ModifiedDate"].ToString()));
                        objML_CokeSupplier.ModifiedBy = ML_Common.clean(dr["ModifiedBy"].ToString());
                        objML_CokeSupplier.CreatedByUserNameId = ML_Common.string2int(ML_Common.clean(dr["CreatedByUserNameId"].ToString()));
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
            return objML_CokeSupplier;
        }


        public DataTable GetCokeSupplierByIdDs(int Id)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeSupplier = new ML_CokeSupplier();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@Id", Id) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeSupplierById.ToString(), this.Parameters);


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


        public DataTable GetCokeSupplierByCokeSupplierIdDs(int CokeSupplierId)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeSupplier = new ML_CokeSupplier();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@CokeSupplierId", CokeSupplierId) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeSupplierByCokeSupplierId.ToString(), this.Parameters);


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




        public DataTable GetCokeSupplierByLoginName(string loginName)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_CokeSupplier = new ML_CokeSupplier();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@loginName", loginName) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetCokeSupplierByLoginName.ToString(), this.Parameters);


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





#region SP name for  tblCokeSupplier
// usp_SaveCokeSupplier, 
// usp_UpdateCokeSupplier, 
// usp_UpdateUniqueCokeSupplier, 
// usp_DeleteCokeSupplierById, 
// usp_DeleteCokeSupplierByCokeSupplierId, 
// usp_GetCokeSupplierBySearch, 
// usp_GetCokeSupplier, 
// usp_GetCokeSupplierById, 
// usp_GetCokeSupplierByCokeSupplierId, 
// usp_GetCokeSupplierByLoginName, 
#endregion
#endregion