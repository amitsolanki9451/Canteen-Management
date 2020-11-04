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
  public  class BL_UserType
    {
        #region All Variable
       
        ML_UserType objML_UserType = null;

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
        public int Add(ML_UserType objML_UserType)
        {
            int results = 0;
            try
            {
                
                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	          { 
	             #region Add Properties 
	             //new SqlParameter("@Id", objML_UserType.Id), 
 //new SqlParameter("@UserTypeId", objML_UserType.UserTypeId), 
 new SqlParameter("@UserType", objML_UserType.UserType), 
 new SqlParameter("@IsActive", objML_UserType.IsActive), 
 new SqlParameter("@IsArchive", objML_UserType.IsArchive), 
 //new SqlParameter("@CreatedDate", objML_UserType.CreatedDate), 
 new SqlParameter("@CreatedBy", objML_UserType.CreatedBy), 
  new SqlParameter("@CreatedByUserNameId", objML_UserType.CreatedByUserNameId),
 //new SqlParameter("@ModifiedDate", objML_UserType.ModifiedDate), 
 //new SqlParameter("@ModifiedBy", objML_UserType.ModifiedBy), 
	             ReturnObj 
	             #endregion  
	          };
                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_SaveUserType.ToString(), this.Parameters);
                




                

                if (ReturnObj.Value != null)
                {
                    results = ML_Common.string2int32(ReturnObj.Value.ToString());
                }
            }
            catch (SqlException sqlExc)
            {
                SqlException sqlExt = sqlExc; throw;
            }
            catch (Exception ex)
            {
                results = 0;
                Exception exx = ex;
                throw;
            }
            finally
            {
                //
            }
            return results;
        }

        public int Update(ML_UserType objML_UserType)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	           { 
	               #region Update Properties 
	               //new SqlParameter("@Id", objML_UserType.Id), 
 new SqlParameter("@UserTypeId", objML_UserType.UserTypeId), 
 new SqlParameter("@UserType", objML_UserType.UserType), 
 new SqlParameter("@IsActive", objML_UserType.IsActive), 
 new SqlParameter("@IsArchive", objML_UserType.IsArchive), 
 //new SqlParameter("@CreatedDate", objML_UserType.CreatedDate), 
 //new SqlParameter("@CreatedBy", objML_UserType.CreatedBy), 
 //new SqlParameter("@ModifiedDate", objML_UserType.ModifiedDate), 
 new SqlParameter("@ModifiedBy", objML_UserType.ModifiedBy), 
	               ReturnObj 
	               #endregion  
	           };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateUserType.ToString(), this.Parameters);

                




                

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
                Exception exx = ex;
                throw;
            }
            finally
            {
                //
            }
            return results;
        }

        public int UpdateUnique(ML_UserType objML_UserType)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	           { 
	               #region Update Unique Properties 
	               //new SqlParameter("@Id", objML_UserType.Id), 
 new SqlParameter("@UserTypeId", objML_UserType.UserTypeId), 
 new SqlParameter("@UserType", objML_UserType.UserType), 
 new SqlParameter("@IsActive", objML_UserType.IsActive), 
 new SqlParameter("@IsArchive", objML_UserType.IsArchive), 
 //new SqlParameter("@CreatedDate", objML_UserType.CreatedDate), 
 //new SqlParameter("@CreatedBy", objML_UserType.CreatedBy), 
 //new SqlParameter("@ModifiedDate", objML_UserType.ModifiedDate), 
 new SqlParameter("@ModifiedBy", objML_UserType.ModifiedBy), 
	               ReturnObj 
	               #endregion  
	           };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateUniqueUserType.ToString(), this.Parameters);

                




                

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
                Exception exx = ex;
                throw;
            }
            finally
            {
                //
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteUserTypeById.ToString(), this.Parameters);

                




                

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
                Exception exx = ex;
                throw;
            }
            finally
            {
                //
            }
            return results;
        }

        #endregion
        #region Delete
        public int DeleteUserTypeById(int Id)
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteUserTypeById.ToString(), this.Parameters);

                




                

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
                Exception exx = ex;
                throw;
            }
            finally
            {
                //
            }
            return results;
        }

        public int DeleteUserTypeByUserTypeId(int UserTypeId)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@UserTypeId", UserTypeId), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteUserTypeByUserTypeId.ToString(), this.Parameters);

                




                

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
                Exception exx = ex;
                throw;
            }
            finally
            {
                //
            }
            return results;
        }

        public int DeleteUserTypeByUserType(string UserType)
        {
            int results = 0;
            try
            {
                



                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@UserType", UserType), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteUserTypeByUserType.ToString(), this.Parameters);

                




                

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
                Exception exx = ex;
                throw;
            }
            finally
            {
                //
            }
            return results;
        }

        #endregion
        #region Delete Relationship
        #endregion


        #region Get Method

        public DataTable GetUserTypeBySeacrh(ML_UserType objML_UserType)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                DateTime? dtFromdate = null;
                DateTime objFromdate;
                if (DateTime.TryParse(objML_UserType.FromDate.ToString(), out objFromdate))
                {
                    if (objFromdate.ToString() != "1/1/1900 12:00:00 AM")
                    {
                        dtFromdate = objFromdate;
                    }
                }
                DateTime? dtTodate = null;
                DateTime objdtTodate;
                if (DateTime.TryParse(objML_UserType.ToDate.ToString(), out objdtTodate))
                {
                    if (objdtTodate.ToString() != "1/1/1900 12:00:00 AM")
                    {
                        dtTodate = objdtTodate;
                    }
                }

                SqlParameter[] parameters = 
	  { 
	   #region Search Properties 
	  //new SqlParameter("@Id", objML_UserType.Id), 
 new SqlParameter("@UserTypeId", objML_UserType.UserTypeId), 
 new SqlParameter("@UserType", objML_UserType.UserType), 
 //new SqlParameter("@IsActive", objML_UserType.IsActive), 
 //new SqlParameter("@IsArchive", objML_UserType.IsArchive), 
 //new SqlParameter("@CreatedDate", objML_UserType.CreatedDate), 
 //new SqlParameter("@CreatedBy", objML_UserType.CreatedBy), 
 //new SqlParameter("@ModifiedDate", objML_UserType.ModifiedDate), 
 //new SqlParameter("@ModifiedBy", objML_UserType.ModifiedBy), 
 new SqlParameter("@FromDate", dtFromdate), 
 new SqlParameter("@ToDate",dtTodate)
	   #endregion 
	  };
                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserTypeBySearch.ToString(), this.Parameters);

                if (sdr.HasRows)
                {
                    dt.Load(sdr);
                }  



                
            }
            catch (Exception ex)
            {
                Exception exx = ex;
                throw;
            }
            finally
            {
                //
            }
            return dt;
        }

        public DataTable GetUserType()
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserType.ToString());

                if (sdr.HasRows)
                {
                    dt.Load(sdr);
                }  




                
            }
            catch (Exception ex)
            {
                
                Exception exx = ex;
                throw;
            }
            finally
            {
                //
            }
            return dt;
        }


        public ML_UserType GetUserTypeById(int Id)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_UserType = new ML_UserType();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@Id", Id) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserTypeById.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_UserType.Id = ML_Common.string2Int32(ML_Common.clean(dr["Id"].ToString()));
                        objML_UserType.UserTypeId = ML_Common.string2Int32(ML_Common.clean(dr["UserTypeId"].ToString()));
                        objML_UserType.UserType = ML_Common.clean(dr["UserType"].ToString());
                        objML_UserType.IsActive = ML_Common.clean(dr["IsActive"].ToString());
                        objML_UserType.IsArchive = ML_Common.clean(dr["IsArchive"].ToString());
                        objML_UserType.CreatedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["CreatedDate"].ToString()));
                        objML_UserType.CreatedBy = ML_Common.clean(dr["CreatedBy"].ToString());
                        objML_UserType.ModifiedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["ModifiedDate"].ToString()));
                        objML_UserType.ModifiedBy = ML_Common.clean(dr["ModifiedBy"].ToString());
                        objML_UserType.CreatedByUserNameId = ML_Common.string2Int32(dr["CreatedByUserNameId"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Exception exx = ex;
                throw;
            }
            finally
            {
                //
            }
            return objML_UserType;
        }


        public ML_UserType GetUserTypeByUserTypeId(int UserTypeId)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_UserType = new ML_UserType();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@UserTypeId", UserTypeId) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserTypeByUserTypeId.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_UserType.Id = ML_Common.string2Int32(ML_Common.clean(dr["Id"].ToString()));
                        objML_UserType.UserTypeId = ML_Common.string2Int32(ML_Common.clean(dr["UserTypeId"].ToString()));
                        objML_UserType.UserType = ML_Common.clean(dr["UserType"].ToString());
                        objML_UserType.IsActive = ML_Common.clean(dr["IsActive"].ToString());
                        objML_UserType.IsArchive = ML_Common.clean(dr["IsArchive"].ToString());
                        objML_UserType.CreatedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["CreatedDate"].ToString()));
                        objML_UserType.CreatedBy = ML_Common.clean(dr["CreatedBy"].ToString());
                        objML_UserType.ModifiedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["ModifiedDate"].ToString()));
                        objML_UserType.ModifiedBy = ML_Common.clean(dr["ModifiedBy"].ToString());
                        objML_UserType.CreatedByUserNameId = ML_Common.string2Int32(dr["CreatedByUserNameId"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Exception exx = ex;
                throw;
            }
            finally
            {
                //
            }
            return objML_UserType;
        }


        public ML_UserType GetUserTypeByUserType(string UserType)
        {
             DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_UserType = new ML_UserType();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@UserType", UserType) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserTypeByUserType.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_UserType.Id = ML_Common.string2Int32(ML_Common.clean(dr["Id"].ToString()));
                        objML_UserType.UserTypeId = ML_Common.string2Int32(ML_Common.clean(dr["UserTypeId"].ToString()));
                        objML_UserType.UserType = ML_Common.clean(dr["UserType"].ToString());
                        objML_UserType.IsActive = ML_Common.clean(dr["IsActive"].ToString());
                        objML_UserType.IsArchive = ML_Common.clean(dr["IsArchive"].ToString());
                        objML_UserType.CreatedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["CreatedDate"].ToString()));
                        objML_UserType.CreatedBy = ML_Common.clean(dr["CreatedBy"].ToString());
                        objML_UserType.ModifiedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["ModifiedDate"].ToString()));
                        objML_UserType.ModifiedBy = ML_Common.clean(dr["ModifiedBy"].ToString());
                        objML_UserType.CreatedByUserNameId = ML_Common.string2Int32(dr["CreatedByUserNameId"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Exception exx = ex;
                throw;
            }
            finally
            {
                //
            }
            return objML_UserType;
        }


        public DataTable GetUserTypeByIdDs(int Id)
        {
            DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserType = new ML_UserType();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@Id", Id) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserTypeById.ToString(), this.Parameters);


                if (sdr.HasRows)
                {
                    dt.Load(sdr);
                }  



                

            }
            catch (Exception ex)
            {
                Exception exx = ex;
                throw;
            }
            finally
            {
                //
            }
            return dt;
        }


        public DataTable GetUserTypeByUserTypeIdDs(int UserTypeId)
        {
            DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserType = new ML_UserType();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@UserTypeId", UserTypeId) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserTypeByUserTypeId.ToString(), this.Parameters);


                if (sdr.HasRows)
                {
                    dt.Load(sdr);
                }  



                

            }
            catch (Exception ex)
            {
                Exception exx = ex;
                throw;
            }
            finally
            {
                //
            }
            return dt;
        }


        public DataTable GetUserTypeByUserTypeDs(string UserType)
        {
            DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserType = new ML_UserType();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@UserType", UserType) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserTypeByUserType.ToString(), this.Parameters);


                if (sdr.HasRows)
                {
                    dt.Load(sdr);
                }  



                

            }
            catch (Exception ex)
            {
                Exception exx = ex;
                throw;
            }
            finally
            {
                //
            }
            return dt;
        }




        public DataTable GetUserTypeByLoginName(string loginName)
        {
            DataTable dt = new DataTable();
            try
            {
                



                




                

                objML_UserType = new ML_UserType();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@loginName", loginName) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserTypeByLoginName.ToString(), this.Parameters);

                if (sdr.HasRows)
                {
                    dt.Load(sdr);
                }  




                

            }
            catch (Exception ex)
            {
                Exception exx = ex;
                throw;
            }
            finally
            {
                //
            }
            return dt;
        }


        #endregion
    }
}
