using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
  public  class BL_UserName
    {
        #region All Variable
       
        ML_UserName objML_UserName = null;

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
        public int Add(ML_UserName objML_UserName)
        {
            int results = 0;
            try
            {
                


                



                
                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	          { 
	             #region Add Properties 
	             //new SqlParameter("@Id", objML_UserName.Id), 
 //new SqlParameter("@UserNameId", objML_UserName.UserNameId), 
 new SqlParameter("@UserName", objML_UserName.UserName), 
 new SqlParameter("@FirstName", objML_UserName.FirstName), 
 new SqlParameter("@LastName", objML_UserName.LastName), 
 new SqlParameter("@Email", objML_UserName.Email), 
 new SqlParameter("@Telephone", objML_UserName.Telephone), 
 new SqlParameter("@Mobile", objML_UserName.Mobile), 
 new SqlParameter("@Remarks", objML_UserName.Remarks), 
 new SqlParameter("@Password", objML_UserName.Password), 
 new SqlParameter("@UserTypeId", objML_UserName.UserTypeId), 
 new SqlParameter("@UserType", objML_UserName.UserType), 
 new SqlParameter("@ReTryAttempt", objML_UserName.ReTryAttempt), 
 new SqlParameter("@IsLocked", objML_UserName.IsLocked), 
 new SqlParameter("@LockedDateTime", objML_UserName.LockedDateTime), 

 new SqlParameter("@ImagePath", objML_UserName.ImagePath), 
 new SqlParameter("@ImageName", objML_UserName.ImageName), 

 new SqlParameter("@IsActive", objML_UserName.IsActive), 
 new SqlParameter("@IsArchive", objML_UserName.IsArchive), 
 //new SqlParameter("@CreatedDate", objML_UserName.CreatedDate), 
 new SqlParameter("@CreatedBy", objML_UserName.CreatedBy), 
  new SqlParameter("@CreatedByUserNameId", objML_UserName.CreatedByUserNameId),
 //new SqlParameter("@ModifiedDate", objML_UserName.ModifiedDate), 
 //new SqlParameter("@ModifiedBy", objML_UserName.ModifiedBy), 
	             ReturnObj 
	             #endregion  
	          };
                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_SaveUserName.ToString(), this.Parameters);
                



                

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

        public int Update(ML_UserName objML_UserName)
        {
            int results = 0;
            try
            {
                


                



                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	           { 
	               #region Update Properties 
 new SqlParameter("@Id", objML_UserName.Id), 
 new SqlParameter("@UserNameId", objML_UserName.UserNameId), 
 new SqlParameter("@UserName", objML_UserName.UserName), 
 new SqlParameter("@FirstName", objML_UserName.FirstName), 
 new SqlParameter("@LastName", objML_UserName.LastName), 
 new SqlParameter("@Email", objML_UserName.Email), 
 new SqlParameter("@Telephone", objML_UserName.Telephone), 
 new SqlParameter("@Mobile", objML_UserName.Mobile), 
 new SqlParameter("@Remarks", objML_UserName.Remarks), 
 new SqlParameter("@Password", objML_UserName.Password), 
 new SqlParameter("@UserTypeId", objML_UserName.UserTypeId), 
 new SqlParameter("@UserType", objML_UserName.UserType), 
 new SqlParameter("@ReTryAttempt", objML_UserName.ReTryAttempt), 
 new SqlParameter("@IsLocked", objML_UserName.IsLocked), 
 new SqlParameter("@LockedDateTime", objML_UserName.LockedDateTime), 
  new SqlParameter("@ImagePath", objML_UserName.ImagePath), 
 new SqlParameter("@ImageName", objML_UserName.ImageName),
 new SqlParameter("@IsActive", objML_UserName.IsActive), 
 new SqlParameter("@IsArchive", objML_UserName.IsArchive), 
 //new SqlParameter("@CreatedDate", objML_UserName.CreatedDate), 
 //new SqlParameter("@CreatedBy", objML_UserName.CreatedBy), 
 //new SqlParameter("@ModifiedDate", objML_UserName.ModifiedDate), 
 new SqlParameter("@ModifiedBy", objML_UserName.ModifiedBy), 
	               ReturnObj 
	               #endregion  
	           };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateUserName.ToString(), this.Parameters);

                



                

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

        public int UpdateUnique(ML_UserName objML_UserName)
        {
            int results = 0;
            try
            {
                


                



                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	           { 
	               #region Update Unique Properties 
	               //new SqlParameter("@Id", objML_UserName.Id), 
 new SqlParameter("@UserNameId", objML_UserName.UserNameId), 
 new SqlParameter("@UserName", objML_UserName.UserName), 
 new SqlParameter("@FirstName", objML_UserName.FirstName), 
 new SqlParameter("@LastName", objML_UserName.LastName), 
 new SqlParameter("@Email", objML_UserName.Email), 
 new SqlParameter("@Telephone", objML_UserName.Telephone), 
 new SqlParameter("@Mobile", objML_UserName.Mobile), 
 new SqlParameter("@Remarks", objML_UserName.Remarks), 
 new SqlParameter("@Password", objML_UserName.Password), 
 new SqlParameter("@UserTypeId", objML_UserName.UserTypeId), 
 new SqlParameter("@UserType", objML_UserName.UserType), 
 new SqlParameter("@ReTryAttempt", objML_UserName.ReTryAttempt), 
 new SqlParameter("@IsLocked", objML_UserName.IsLocked), 
 new SqlParameter("@LockedDateTime", objML_UserName.LockedDateTime), 
  new SqlParameter("@ImagePath", objML_UserName.ImagePath), 
 new SqlParameter("@ImageName", objML_UserName.ImageName),
 new SqlParameter("@IsActive", objML_UserName.IsActive), 
 new SqlParameter("@IsArchive", objML_UserName.IsArchive), 
 //new SqlParameter("@CreatedDate", objML_UserName.CreatedDate), 
 //new SqlParameter("@CreatedBy", objML_UserName.CreatedBy), 
 //new SqlParameter("@ModifiedDate", objML_UserName.ModifiedDate), 
 new SqlParameter("@ModifiedBy", objML_UserName.ModifiedBy), 
	               ReturnObj 
	               #endregion  
	           };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateUniqueUserName.ToString(), this.Parameters);

                



                

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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteUserNameById.ToString(), this.Parameters);

                




                

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
        public int DeleteUserNameById(int Id)
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteUserNameById.ToString(), this.Parameters);

                




                

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

        public int DeleteUserNameByUserNameId(int UserNameId)
        {
            int results = 0;
            try
            {
                


                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@UserNameId", UserNameId), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteUserNameByUserNameId.ToString(), this.Parameters);

                




                

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

        public int DeleteUserNameByUserName(string UserName)
        {
            int results = 0;
            try
            {
                


                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@UserName", UserName), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteUserNameByUserName.ToString(), this.Parameters);

                




                

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

        public int DeleteUserNameByEmail(string Email)
        {
            int results = 0;
            try
            {
                


                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@Email", Email), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteUserNameByEmail.ToString(), this.Parameters);

                




                

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

        public int DeleteUserNameByUserTypeId(int UserTypeId)
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteUserNameByUserTypeId.ToString(), this.Parameters);

                




                

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

        public int DeleteUserNameByUserType(string UserType)
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
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteUserNameByUserType.ToString(), this.Parameters);

                




                

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

        public int DeleteUserNameByReTryAttempt(int ReTryAttempt)
        {
            int results = 0;
            try
            {
                


                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@ReTryAttempt", ReTryAttempt), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteUserNameByReTryAttempt.ToString(), this.Parameters);

                




                

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

        public int DeleteUserNameByIsLocked(int IsLocked)
        {
            int results = 0;
            try
            {
                


                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@IsLocked", IsLocked), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteUserNameByIsLocked.ToString(), this.Parameters);

                




                

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

        public int DeleteUserNameByLockedDateTime(DateTime LockedDateTime)
        {
            int results = 0;
            try
            {
                


                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@LockedDateTime", LockedDateTime), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteUserNameByLockedDateTime.ToString(), this.Parameters);

                




                

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
        public int DeleteUserNameByUserNamenEmailnPassword(string UserName, string Email, string Password)
        {
            int results = 0;
            try
            {
                


                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@UserName", UserName), 
	    new SqlParameter("@Email", Email), 
	    new SqlParameter("@Password", Password), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteUserNameByUserNamenEmailnPassword.ToString(), this.Parameters);

                




                

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

        public int DeleteUserNameByUserNamenEmail(string UserName, string Email)
        {
            int results = 0;
            try
            {
                


                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@UserName", UserName), 
	    new SqlParameter("@Email", Email), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteUserNameByUserNamenEmail.ToString(), this.Parameters);

                




                

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

        public int DeleteUserNameByEmailnPassword(string Email, string Password)
        {
            int results = 0;
            try
            {
                


                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
	  { 
	   #region Delete Properties 
	    new SqlParameter("@Email", Email), 
	    new SqlParameter("@Password", Password), 
	  ReturnObj 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_DeleteUserNameByEmailnPassword.ToString(), this.Parameters);

                




                

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


        #region Get Method

        public DataTable GetUserNameBySeacrh(ML_UserName objML_UserName)
        {
            DataTable dt = new DataTable();
            try
            {
                


                




                

                DateTime? dtFromdate = null;
                DateTime objFromdate;
                if (DateTime.TryParse(objML_UserName.FromDate.ToString(), out objFromdate))
                {
                    if (objFromdate.ToString() != "1/1/1900 12:00:00 AM")
                    {
                        dtFromdate = objFromdate;
                    }
                }
                DateTime? dtTodate = null;
                DateTime objdtTodate;
                if (DateTime.TryParse(objML_UserName.ToDate.ToString(), out objdtTodate))
                {
                    if (objdtTodate.ToString() != "1/1/1900 12:00:00 AM")
                    {
                        dtTodate = objdtTodate;
                    }
                }

                SqlParameter[] parameters = 
	  { 
	   #region Search Properties 
	  //new SqlParameter("@Id", objML_UserName.Id), 
 //new SqlParameter("@UserNameId", objML_UserName.UserNameId), 
 //new SqlParameter("@UserName", objML_UserName.UserName), 
 //new SqlParameter("@FirstName", objML_UserName.FirstName), 
 //new SqlParameter("@LastName", objML_UserName.LastName), 
 //new SqlParameter("@Email", objML_UserName.Email), 
 //new SqlParameter("@Telephone", objML_UserName.Telephone), 
 //new SqlParameter("@Mobile", objML_UserName.Mobile), 
 //new SqlParameter("@Remarks", objML_UserName.Remarks), 
 //new SqlParameter("@Password", objML_UserName.Password), 
 new SqlParameter("@UserTypeId", objML_UserName.UserTypeId)
 //new SqlParameter("@UserType", objML_UserName.UserType), 
 //new SqlParameter("@ReTryAttempt", objML_UserName.ReTryAttempt), 
 //new SqlParameter("@IsLocked", objML_UserName.IsLocked), 
 //new SqlParameter("@LockedDateTime", objML_UserName.LockedDateTime), 
 //new SqlParameter("@IsActive", objML_UserName.IsActive), 
 //new SqlParameter("@IsArchive", objML_UserName.IsArchive), 
 //new SqlParameter("@CreatedDate", objML_UserName.CreatedDate), 
 //new SqlParameter("@CreatedBy", objML_UserName.CreatedBy), 
 //new SqlParameter("@ModifiedDate", objML_UserName.ModifiedDate), 
 //new SqlParameter("@ModifiedBy", objML_UserName.ModifiedBy), 
 //new SqlParameter("@FromDate", dtFromdate), 
 //new SqlParameter("@ToDate",dtTodate)
	   #endregion 
	  };
                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameBySearch.ToString(), this.Parameters);

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

        public DataTable GetUserName()
        {
            DataTable dt = new DataTable();
            try
            {
                


                




                
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameList.ToString());

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


        public ML_UserName GetUserNameById(int Id)
        {
             DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@Id", Id) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameById.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_UserName.Id = ML_Common.string2Int32(ML_Common.clean(dr["Id"].ToString()));
                        objML_UserName.UserNameId = ML_Common.string2Int32(ML_Common.clean(dr["UserNameId"].ToString()));
                        objML_UserName.UserName = ML_Common.clean(dr["UserName"].ToString());
                        objML_UserName.FirstName = ML_Common.clean(dr["FirstName"].ToString());
                        objML_UserName.LastName = ML_Common.clean(dr["LastName"].ToString());
                        objML_UserName.Email = ML_Common.clean(dr["Email"].ToString());
                        objML_UserName.Telephone = ML_Common.clean(dr["Telephone"].ToString());
                        objML_UserName.Mobile = ML_Common.clean(dr["Mobile"].ToString());
                        objML_UserName.Remarks = ML_Common.clean(dr["Remarks"].ToString());
                        objML_UserName.Password = ML_Common.clean(dr["Password"].ToString());
                        objML_UserName.UserTypeId = ML_Common.string2Int32(ML_Common.clean(dr["UserTypeId"].ToString()));
                        objML_UserName.UserType = ML_Common.clean(dr["UserType"].ToString());
                        objML_UserName.ReTryAttempt = ML_Common.string2int32(ML_Common.clean(dr["ReTryAttempt"].ToString()));
                        objML_UserName.IsLocked = ML_Common.string2Boolean(ML_Common.clean(dr["IsLocked"].ToString()));
                        objML_UserName.LockedDateTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["LockedDateTime"].ToString()));
                        objML_UserName.IsActive = ML_Common.clean(dr["IsActive"].ToString());
                        objML_UserName.IsArchive = ML_Common.clean(dr["IsArchive"].ToString());
                        objML_UserName.CreatedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["CreatedDate"].ToString()));
                        objML_UserName.CreatedBy = ML_Common.clean(dr["CreatedBy"].ToString());
                        objML_UserName.ModifiedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["ModifiedDate"].ToString()));
                        objML_UserName.ModifiedBy = ML_Common.clean(dr["ModifiedBy"].ToString());
                        objML_UserName.ImageName = ML_Common.clean(dr["ImageName"].ToString());
                        objML_UserName.ImagePath = ML_Common.clean(dr["ImagePath"].ToString());
                        objML_UserName.CreatedByUserNameId = ML_Common.string2Int32(dr["CreatedByUserNameId"].ToString());
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
            return objML_UserName;
        }


        public ML_UserName GetUserNameByUserNameId(int UserNameId)
        {
             DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@UserNameId", UserNameId) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByUserNameId.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_UserName.Id = ML_Common.string2Int32(ML_Common.clean(dr["Id"].ToString()));
                        objML_UserName.UserNameId = ML_Common.string2Int32(ML_Common.clean(dr["UserNameId"].ToString()));
                        objML_UserName.UserName = ML_Common.clean(dr["UserName"].ToString());
                        objML_UserName.FirstName = ML_Common.clean(dr["FirstName"].ToString());
                        objML_UserName.LastName = ML_Common.clean(dr["LastName"].ToString());
                        objML_UserName.Email = ML_Common.clean(dr["Email"].ToString());
                        objML_UserName.Telephone = ML_Common.clean(dr["Telephone"].ToString());
                        objML_UserName.Mobile = ML_Common.clean(dr["Mobile"].ToString());
                        objML_UserName.Remarks = ML_Common.clean(dr["Remarks"].ToString());
                        objML_UserName.Password = ML_Common.clean(dr["Password"].ToString());
                        objML_UserName.UserTypeId = ML_Common.string2Int32(ML_Common.clean(dr["UserTypeId"].ToString()));
                        objML_UserName.UserType = ML_Common.clean(dr["UserType"].ToString());
                        objML_UserName.ReTryAttempt = ML_Common.string2int32(ML_Common.clean(dr["ReTryAttempt"].ToString()));
                        objML_UserName.IsLocked = ML_Common.string2Boolean(ML_Common.clean(dr["IsLocked"].ToString()));
                        objML_UserName.LockedDateTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["LockedDateTime"].ToString()));
                        objML_UserName.IsActive = ML_Common.clean(dr["IsActive"].ToString());
                        objML_UserName.IsArchive = ML_Common.clean(dr["IsArchive"].ToString());
                        objML_UserName.CreatedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["CreatedDate"].ToString()));
                        objML_UserName.CreatedBy = ML_Common.clean(dr["CreatedBy"].ToString());
                        objML_UserName.ModifiedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["ModifiedDate"].ToString()));
                        objML_UserName.ModifiedBy = ML_Common.clean(dr["ModifiedBy"].ToString());
                        objML_UserName.ImageName = ML_Common.clean(dr["ImageName"].ToString());
                        objML_UserName.ImagePath = ML_Common.clean(dr["ImagePath"].ToString());
                        objML_UserName.CreatedByUserNameId = ML_Common.string2Int32(dr["CreatedByUserNameId"].ToString());
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
            return objML_UserName;
        }


        public ML_UserName GetUserNameByUserName(string UserName)
        {
             DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@UserName", UserName) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByUserName.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_UserName.Id = ML_Common.string2Int32(ML_Common.clean(dr["Id"].ToString()));
                        objML_UserName.UserNameId = ML_Common.string2Int32(ML_Common.clean(dr["UserNameId"].ToString()));
                        objML_UserName.UserName = ML_Common.clean(dr["UserName"].ToString());
                        objML_UserName.FirstName = ML_Common.clean(dr["FirstName"].ToString());
                        objML_UserName.LastName = ML_Common.clean(dr["LastName"].ToString());
                        objML_UserName.Email = ML_Common.clean(dr["Email"].ToString());
                        objML_UserName.Telephone = ML_Common.clean(dr["Telephone"].ToString());
                        objML_UserName.Mobile = ML_Common.clean(dr["Mobile"].ToString());
                        objML_UserName.Remarks = ML_Common.clean(dr["Remarks"].ToString());
                        objML_UserName.Password = ML_Common.clean(dr["Password"].ToString());
                        objML_UserName.UserTypeId = ML_Common.string2Int32(ML_Common.clean(dr["UserTypeId"].ToString()));
                        objML_UserName.UserType = ML_Common.clean(dr["UserType"].ToString());
                        objML_UserName.ReTryAttempt = ML_Common.string2int32(ML_Common.clean(dr["ReTryAttempt"].ToString()));
                        objML_UserName.IsLocked = ML_Common.string2Boolean(ML_Common.clean(dr["IsLocked"].ToString()));
                        objML_UserName.LockedDateTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["LockedDateTime"].ToString()));
                        objML_UserName.IsActive = ML_Common.clean(dr["IsActive"].ToString());
                        objML_UserName.IsArchive = ML_Common.clean(dr["IsArchive"].ToString());
                        objML_UserName.CreatedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["CreatedDate"].ToString()));
                        objML_UserName.CreatedBy = ML_Common.clean(dr["CreatedBy"].ToString());
                        objML_UserName.ModifiedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["ModifiedDate"].ToString()));
                        objML_UserName.ModifiedBy = ML_Common.clean(dr["ModifiedBy"].ToString());
                        objML_UserName.ImageName = ML_Common.clean(dr["ImageName"].ToString());
                        objML_UserName.ImagePath = ML_Common.clean(dr["ImagePath"].ToString());
                        objML_UserName.CreatedByUserNameId = ML_Common.string2Int32(dr["CreatedByUserNameId"].ToString());
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
            return objML_UserName;
        }


        public ML_UserName GetUserNameByEmail(string Email)
        {
             DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@Email", Email) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByEmail.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_UserName.Id = ML_Common.string2Int32(ML_Common.clean(dr["Id"].ToString()));
                        objML_UserName.UserNameId = ML_Common.string2Int32(ML_Common.clean(dr["UserNameId"].ToString()));
                        objML_UserName.UserName = ML_Common.clean(dr["UserName"].ToString());
                        objML_UserName.FirstName = ML_Common.clean(dr["FirstName"].ToString());
                        objML_UserName.LastName = ML_Common.clean(dr["LastName"].ToString());
                        objML_UserName.Email = ML_Common.clean(dr["Email"].ToString());
                        objML_UserName.Telephone = ML_Common.clean(dr["Telephone"].ToString());
                        objML_UserName.Mobile = ML_Common.clean(dr["Mobile"].ToString());
                        objML_UserName.Remarks = ML_Common.clean(dr["Remarks"].ToString());
                        objML_UserName.Password = ML_Common.clean(dr["Password"].ToString());
                        objML_UserName.UserTypeId = ML_Common.string2Int32(ML_Common.clean(dr["UserTypeId"].ToString()));
                        objML_UserName.UserType = ML_Common.clean(dr["UserType"].ToString());
                        objML_UserName.ReTryAttempt = ML_Common.string2int32(ML_Common.clean(dr["ReTryAttempt"].ToString()));
                        objML_UserName.IsLocked = ML_Common.string2Boolean(ML_Common.clean(dr["IsLocked"].ToString()));
                        objML_UserName.LockedDateTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["LockedDateTime"].ToString()));
                        objML_UserName.IsActive = ML_Common.clean(dr["IsActive"].ToString());
                        objML_UserName.IsArchive = ML_Common.clean(dr["IsArchive"].ToString());
                        objML_UserName.CreatedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["CreatedDate"].ToString()));
                        objML_UserName.CreatedBy = ML_Common.clean(dr["CreatedBy"].ToString());
                        objML_UserName.ModifiedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["ModifiedDate"].ToString()));
                        objML_UserName.ModifiedBy = ML_Common.clean(dr["ModifiedBy"].ToString());
                        objML_UserName.ImageName = ML_Common.clean(dr["ImageName"].ToString());
                        objML_UserName.ImagePath = ML_Common.clean(dr["ImagePath"].ToString());
                        objML_UserName.CreatedByUserNameId = ML_Common.string2Int32(dr["CreatedByUserNameId"].ToString());
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
            return objML_UserName;
        }


        public ML_UserName GetUserNameByUserTypeId(int UserTypeId)
        {
             DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@UserTypeId", UserTypeId) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByUserTypeId.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_UserName.Id = ML_Common.string2Int32(ML_Common.clean(dr["Id"].ToString()));
                        objML_UserName.UserNameId = ML_Common.string2Int32(ML_Common.clean(dr["UserNameId"].ToString()));
                        objML_UserName.UserName = ML_Common.clean(dr["UserName"].ToString());
                        objML_UserName.FirstName = ML_Common.clean(dr["FirstName"].ToString());
                        objML_UserName.LastName = ML_Common.clean(dr["LastName"].ToString());
                        objML_UserName.Email = ML_Common.clean(dr["Email"].ToString());
                        objML_UserName.Telephone = ML_Common.clean(dr["Telephone"].ToString());
                        objML_UserName.Mobile = ML_Common.clean(dr["Mobile"].ToString());
                        objML_UserName.Remarks = ML_Common.clean(dr["Remarks"].ToString());
                        objML_UserName.Password = ML_Common.clean(dr["Password"].ToString());
                        objML_UserName.UserTypeId = ML_Common.string2Int32(ML_Common.clean(dr["UserTypeId"].ToString()));
                        objML_UserName.UserType = ML_Common.clean(dr["UserType"].ToString());
                        objML_UserName.ReTryAttempt = ML_Common.string2int32(ML_Common.clean(dr["ReTryAttempt"].ToString()));
                        objML_UserName.IsLocked = ML_Common.string2Boolean(ML_Common.clean(dr["IsLocked"].ToString()));
                        objML_UserName.LockedDateTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["LockedDateTime"].ToString()));
                        objML_UserName.IsActive = ML_Common.clean(dr["IsActive"].ToString());
                        objML_UserName.IsArchive = ML_Common.clean(dr["IsArchive"].ToString());
                        objML_UserName.CreatedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["CreatedDate"].ToString()));
                        objML_UserName.CreatedBy = ML_Common.clean(dr["CreatedBy"].ToString());
                        objML_UserName.ModifiedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["ModifiedDate"].ToString()));
                        objML_UserName.ModifiedBy = ML_Common.clean(dr["ModifiedBy"].ToString());
                        objML_UserName.ImageName = ML_Common.clean(dr["ImageName"].ToString());
                        objML_UserName.ImagePath = ML_Common.clean(dr["ImagePath"].ToString());
                        objML_UserName.CreatedByUserNameId = ML_Common.string2Int32(dr["CreatedByUserNameId"].ToString());
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
            return objML_UserName;
        }


        public ML_UserName GetUserNameByUserType(string UserType)
        {
             DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@UserType", UserType) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByUserType.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_UserName.Id = ML_Common.string2Int32(ML_Common.clean(dr["Id"].ToString()));
                        objML_UserName.UserNameId = ML_Common.string2Int32(ML_Common.clean(dr["UserNameId"].ToString()));
                        objML_UserName.UserName = ML_Common.clean(dr["UserName"].ToString());
                        objML_UserName.FirstName = ML_Common.clean(dr["FirstName"].ToString());
                        objML_UserName.LastName = ML_Common.clean(dr["LastName"].ToString());
                        objML_UserName.Email = ML_Common.clean(dr["Email"].ToString());
                        objML_UserName.Telephone = ML_Common.clean(dr["Telephone"].ToString());
                        objML_UserName.Mobile = ML_Common.clean(dr["Mobile"].ToString());
                        objML_UserName.Remarks = ML_Common.clean(dr["Remarks"].ToString());
                        objML_UserName.Password = ML_Common.clean(dr["Password"].ToString());
                        objML_UserName.UserTypeId = ML_Common.string2Int32(ML_Common.clean(dr["UserTypeId"].ToString()));
                        objML_UserName.UserType = ML_Common.clean(dr["UserType"].ToString());
                        objML_UserName.ReTryAttempt = ML_Common.string2int32(ML_Common.clean(dr["ReTryAttempt"].ToString()));
                        objML_UserName.IsLocked = ML_Common.string2Boolean(ML_Common.clean(dr["IsLocked"].ToString()));
                        objML_UserName.LockedDateTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["LockedDateTime"].ToString()));
                        objML_UserName.IsActive = ML_Common.clean(dr["IsActive"].ToString());
                        objML_UserName.IsArchive = ML_Common.clean(dr["IsArchive"].ToString());
                        objML_UserName.CreatedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["CreatedDate"].ToString()));
                        objML_UserName.CreatedBy = ML_Common.clean(dr["CreatedBy"].ToString());
                        objML_UserName.ModifiedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["ModifiedDate"].ToString()));
                        objML_UserName.ModifiedBy = ML_Common.clean(dr["ModifiedBy"].ToString());
                        objML_UserName.ImageName = ML_Common.clean(dr["ImageName"].ToString());
                        objML_UserName.ImagePath = ML_Common.clean(dr["ImagePath"].ToString());
                        objML_UserName.CreatedByUserNameId = ML_Common.string2Int32(dr["CreatedByUserNameId"].ToString());
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
            return objML_UserName;
        }


        public ML_UserName GetUserNameByReTryAttempt(int ReTryAttempt)
        {
             DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@ReTryAttempt", ReTryAttempt) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByReTryAttempt.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_UserName.Id = ML_Common.string2Int32(ML_Common.clean(dr["Id"].ToString()));
                        objML_UserName.UserNameId = ML_Common.string2Int32(ML_Common.clean(dr["UserNameId"].ToString()));
                        objML_UserName.UserName = ML_Common.clean(dr["UserName"].ToString());
                        objML_UserName.FirstName = ML_Common.clean(dr["FirstName"].ToString());
                        objML_UserName.LastName = ML_Common.clean(dr["LastName"].ToString());
                        objML_UserName.Email = ML_Common.clean(dr["Email"].ToString());
                        objML_UserName.Telephone = ML_Common.clean(dr["Telephone"].ToString());
                        objML_UserName.Mobile = ML_Common.clean(dr["Mobile"].ToString());
                        objML_UserName.Remarks = ML_Common.clean(dr["Remarks"].ToString());
                        objML_UserName.Password = ML_Common.clean(dr["Password"].ToString());
                        objML_UserName.UserTypeId = ML_Common.string2Int32(ML_Common.clean(dr["UserTypeId"].ToString()));
                        objML_UserName.UserType = ML_Common.clean(dr["UserType"].ToString());
                        objML_UserName.ReTryAttempt = ML_Common.string2int32(ML_Common.clean(dr["ReTryAttempt"].ToString()));
                        objML_UserName.IsLocked = ML_Common.string2Boolean(ML_Common.clean(dr["IsLocked"].ToString()));
                        objML_UserName.LockedDateTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["LockedDateTime"].ToString()));
                        objML_UserName.IsActive = ML_Common.clean(dr["IsActive"].ToString());
                        objML_UserName.IsArchive = ML_Common.clean(dr["IsArchive"].ToString());
                        objML_UserName.CreatedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["CreatedDate"].ToString()));
                        objML_UserName.CreatedBy = ML_Common.clean(dr["CreatedBy"].ToString());
                        objML_UserName.ModifiedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["ModifiedDate"].ToString()));
                        objML_UserName.ModifiedBy = ML_Common.clean(dr["ModifiedBy"].ToString());
                        objML_UserName.ImageName = ML_Common.clean(dr["ImageName"].ToString());
                        objML_UserName.ImagePath = ML_Common.clean(dr["ImagePath"].ToString());
                        objML_UserName.CreatedByUserNameId = ML_Common.string2Int32(dr["CreatedByUserNameId"].ToString());
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
            return objML_UserName;
        }


        public ML_UserName GetUserNameByIsLocked(int IsLocked)
        {
             DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@IsLocked", IsLocked) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByIsLocked.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_UserName.Id = ML_Common.string2Int32(ML_Common.clean(dr["Id"].ToString()));
                        objML_UserName.UserNameId = ML_Common.string2Int32(ML_Common.clean(dr["UserNameId"].ToString()));
                        objML_UserName.UserName = ML_Common.clean(dr["UserName"].ToString());
                        objML_UserName.FirstName = ML_Common.clean(dr["FirstName"].ToString());
                        objML_UserName.LastName = ML_Common.clean(dr["LastName"].ToString());
                        objML_UserName.Email = ML_Common.clean(dr["Email"].ToString());
                        objML_UserName.Telephone = ML_Common.clean(dr["Telephone"].ToString());
                        objML_UserName.Mobile = ML_Common.clean(dr["Mobile"].ToString());
                        objML_UserName.Remarks = ML_Common.clean(dr["Remarks"].ToString());
                        objML_UserName.Password = ML_Common.clean(dr["Password"].ToString());
                        objML_UserName.UserTypeId = ML_Common.string2Int32(ML_Common.clean(dr["UserTypeId"].ToString()));
                        objML_UserName.UserType = ML_Common.clean(dr["UserType"].ToString());
                        objML_UserName.ReTryAttempt = ML_Common.string2int32(ML_Common.clean(dr["ReTryAttempt"].ToString()));
                        objML_UserName.IsLocked = ML_Common.string2Boolean(ML_Common.clean(dr["IsLocked"].ToString()));
                        objML_UserName.LockedDateTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["LockedDateTime"].ToString()));
                        objML_UserName.IsActive = ML_Common.clean(dr["IsActive"].ToString());
                        objML_UserName.IsArchive = ML_Common.clean(dr["IsArchive"].ToString());
                        objML_UserName.CreatedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["CreatedDate"].ToString()));
                        objML_UserName.CreatedBy = ML_Common.clean(dr["CreatedBy"].ToString());
                        objML_UserName.ModifiedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["ModifiedDate"].ToString()));
                        objML_UserName.ModifiedBy = ML_Common.clean(dr["ModifiedBy"].ToString());
                        objML_UserName.ImageName = ML_Common.clean(dr["ImageName"].ToString());
                        objML_UserName.ImagePath = ML_Common.clean(dr["ImagePath"].ToString());
                        objML_UserName.CreatedByUserNameId = ML_Common.string2Int32(dr["CreatedByUserNameId"].ToString());
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
            return objML_UserName;
        }


        public ML_UserName GetUserNameByLockedDateTime(DateTime LockedDateTime)
        {
             DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@LockedDateTime", LockedDateTime) 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByLockedDateTime.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_UserName.Id = ML_Common.string2Int32(ML_Common.clean(dr["Id"].ToString()));
                        objML_UserName.UserNameId = ML_Common.string2Int32(ML_Common.clean(dr["UserNameId"].ToString()));
                        objML_UserName.UserName = ML_Common.clean(dr["UserName"].ToString());
                        objML_UserName.FirstName = ML_Common.clean(dr["FirstName"].ToString());
                        objML_UserName.LastName = ML_Common.clean(dr["LastName"].ToString());
                        objML_UserName.Email = ML_Common.clean(dr["Email"].ToString());
                        objML_UserName.Telephone = ML_Common.clean(dr["Telephone"].ToString());
                        objML_UserName.Mobile = ML_Common.clean(dr["Mobile"].ToString());
                        objML_UserName.Remarks = ML_Common.clean(dr["Remarks"].ToString());
                        objML_UserName.Password = ML_Common.clean(dr["Password"].ToString());
                        objML_UserName.UserTypeId = ML_Common.string2Int32(ML_Common.clean(dr["UserTypeId"].ToString()));
                        objML_UserName.UserType = ML_Common.clean(dr["UserType"].ToString());
                        objML_UserName.ReTryAttempt = ML_Common.string2int32(ML_Common.clean(dr["ReTryAttempt"].ToString()));
                        objML_UserName.IsLocked = ML_Common.string2Boolean(ML_Common.clean(dr["IsLocked"].ToString()));
                        objML_UserName.LockedDateTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["LockedDateTime"].ToString()));
                        objML_UserName.IsActive = ML_Common.clean(dr["IsActive"].ToString());
                        objML_UserName.IsArchive = ML_Common.clean(dr["IsArchive"].ToString());
                        objML_UserName.CreatedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["CreatedDate"].ToString()));
                        objML_UserName.CreatedBy = ML_Common.clean(dr["CreatedBy"].ToString());
                        objML_UserName.ModifiedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["ModifiedDate"].ToString()));
                        objML_UserName.ModifiedBy = ML_Common.clean(dr["ModifiedBy"].ToString());
                        objML_UserName.ImageName = ML_Common.clean(dr["ImageName"].ToString());
                        objML_UserName.ImagePath = ML_Common.clean(dr["ImagePath"].ToString());
                        objML_UserName.CreatedByUserNameId = ML_Common.string2Int32(dr["CreatedByUserNameId"].ToString());
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
            return objML_UserName;
        }


        public ML_UserName GetUserNameByUserNamenEmailnPassword(string UserName, string Email, string Password)
        {
             DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@UserName", UserName), 
	    new SqlParameter("@Email", Email), 
	    new SqlParameter("@Password", Password), 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByUserNamenEmailnPassword.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_UserName.Id = ML_Common.string2Int32(ML_Common.clean(dr["Id"].ToString()));
                        objML_UserName.UserNameId = ML_Common.string2Int32(ML_Common.clean(dr["UserNameId"].ToString()));
                        objML_UserName.UserName = ML_Common.clean(dr["UserName"].ToString());
                        objML_UserName.FirstName = ML_Common.clean(dr["FirstName"].ToString());
                        objML_UserName.LastName = ML_Common.clean(dr["LastName"].ToString());
                        objML_UserName.Email = ML_Common.clean(dr["Email"].ToString());
                        objML_UserName.Telephone = ML_Common.clean(dr["Telephone"].ToString());
                        objML_UserName.Mobile = ML_Common.clean(dr["Mobile"].ToString());
                        objML_UserName.Remarks = ML_Common.clean(dr["Remarks"].ToString());
                        objML_UserName.Password = ML_Common.clean(dr["Password"].ToString());
                        objML_UserName.UserTypeId = ML_Common.string2Int32(ML_Common.clean(dr["UserTypeId"].ToString()));
                        objML_UserName.UserType = ML_Common.clean(dr["UserType"].ToString());
                        objML_UserName.ReTryAttempt = ML_Common.string2int32(ML_Common.clean(dr["ReTryAttempt"].ToString()));
                        objML_UserName.IsLocked = ML_Common.string2Boolean(ML_Common.clean(dr["IsLocked"].ToString()));
                        objML_UserName.LockedDateTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["LockedDateTime"].ToString()));
                        objML_UserName.IsActive = ML_Common.clean(dr["IsActive"].ToString());
                        objML_UserName.IsArchive = ML_Common.clean(dr["IsArchive"].ToString());
                        objML_UserName.CreatedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["CreatedDate"].ToString()));
                        objML_UserName.CreatedBy = ML_Common.clean(dr["CreatedBy"].ToString());
                        objML_UserName.ModifiedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["ModifiedDate"].ToString()));
                        objML_UserName.ModifiedBy = ML_Common.clean(dr["ModifiedBy"].ToString());
                        objML_UserName.ImageName = ML_Common.clean(dr["ImageName"].ToString());
                        objML_UserName.ImagePath = ML_Common.clean(dr["ImagePath"].ToString());
                        objML_UserName.CreatedByUserNameId = ML_Common.string2Int32(dr["CreatedByUserNameId"].ToString());
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
            return objML_UserName;
        }


        public ML_UserName GetUserNameByUserNamenEmail(string UserName, string Email)
        {
             DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@UserName", UserName), 
	    new SqlParameter("@Email", Email), 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByUserNamenEmail.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_UserName.Id = ML_Common.string2Int32(ML_Common.clean(dr["Id"].ToString()));
                        objML_UserName.UserNameId = ML_Common.string2Int32(ML_Common.clean(dr["UserNameId"].ToString()));
                        objML_UserName.UserName = ML_Common.clean(dr["UserName"].ToString());
                        objML_UserName.FirstName = ML_Common.clean(dr["FirstName"].ToString());
                        objML_UserName.LastName = ML_Common.clean(dr["LastName"].ToString());
                        objML_UserName.Email = ML_Common.clean(dr["Email"].ToString());
                        objML_UserName.Telephone = ML_Common.clean(dr["Telephone"].ToString());
                        objML_UserName.Mobile = ML_Common.clean(dr["Mobile"].ToString());
                        objML_UserName.Remarks = ML_Common.clean(dr["Remarks"].ToString());
                        objML_UserName.Password = ML_Common.clean(dr["Password"].ToString());
                        objML_UserName.UserTypeId = ML_Common.string2Int32(ML_Common.clean(dr["UserTypeId"].ToString()));
                        objML_UserName.UserType = ML_Common.clean(dr["UserType"].ToString());
                        objML_UserName.ReTryAttempt = ML_Common.string2int32(ML_Common.clean(dr["ReTryAttempt"].ToString()));
                        objML_UserName.IsLocked = ML_Common.string2Boolean(ML_Common.clean(dr["IsLocked"].ToString()));
                        objML_UserName.LockedDateTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["LockedDateTime"].ToString()));
                        objML_UserName.IsActive = ML_Common.clean(dr["IsActive"].ToString());
                        objML_UserName.IsArchive = ML_Common.clean(dr["IsArchive"].ToString());
                        objML_UserName.CreatedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["CreatedDate"].ToString()));
                        objML_UserName.CreatedBy = ML_Common.clean(dr["CreatedBy"].ToString());
                        objML_UserName.ModifiedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["ModifiedDate"].ToString()));
                        objML_UserName.ModifiedBy = ML_Common.clean(dr["ModifiedBy"].ToString());
                        objML_UserName.ImageName = ML_Common.clean(dr["ImageName"].ToString());
                        objML_UserName.ImagePath = ML_Common.clean(dr["ImagePath"].ToString());
                        objML_UserName.CreatedByUserNameId = ML_Common.string2Int32(dr["CreatedByUserNameId"].ToString());
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
            return objML_UserName;
        }


        public ML_UserName GetUserNameByEmailnPassword(string Email, string Password)
        {
             DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@Email", Email), 
	    new SqlParameter("@Password", Password), 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByEmailnPassword.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_UserName.Id = ML_Common.string2Int32(ML_Common.clean(dr["Id"].ToString()));
                        objML_UserName.UserNameId = ML_Common.string2Int32(ML_Common.clean(dr["UserNameId"].ToString()));
                        objML_UserName.UserName = ML_Common.clean(dr["UserName"].ToString());
                        objML_UserName.FirstName = ML_Common.clean(dr["FirstName"].ToString());
                        objML_UserName.LastName = ML_Common.clean(dr["LastName"].ToString());
                        objML_UserName.Email = ML_Common.clean(dr["Email"].ToString());
                        objML_UserName.Telephone = ML_Common.clean(dr["Telephone"].ToString());
                        objML_UserName.Mobile = ML_Common.clean(dr["Mobile"].ToString());
                        objML_UserName.Remarks = ML_Common.clean(dr["Remarks"].ToString());
                        objML_UserName.Password = ML_Common.clean(dr["Password"].ToString());
                        objML_UserName.UserTypeId = ML_Common.string2Int32(ML_Common.clean(dr["UserTypeId"].ToString()));
                        objML_UserName.UserType = ML_Common.clean(dr["UserType"].ToString());
                        objML_UserName.ReTryAttempt = ML_Common.string2int32(ML_Common.clean(dr["ReTryAttempt"].ToString()));
                        objML_UserName.IsLocked = ML_Common.string2Boolean(ML_Common.clean(dr["IsLocked"].ToString()));
                        objML_UserName.LockedDateTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["LockedDateTime"].ToString()));
                        objML_UserName.IsActive = ML_Common.clean(dr["IsActive"].ToString());
                        objML_UserName.IsArchive = ML_Common.clean(dr["IsArchive"].ToString());
                        objML_UserName.CreatedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["CreatedDate"].ToString()));
                        objML_UserName.CreatedBy = ML_Common.clean(dr["CreatedBy"].ToString());
                        objML_UserName.ModifiedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["ModifiedDate"].ToString()));
                        objML_UserName.ModifiedBy = ML_Common.clean(dr["ModifiedBy"].ToString());
                        objML_UserName.ImageName = ML_Common.clean(dr["ImageName"].ToString());
                        objML_UserName.ImagePath = ML_Common.clean(dr["ImagePath"].ToString());
                        objML_UserName.CreatedByUserNameId = ML_Common.string2Int32(dr["CreatedByUserNameId"].ToString());
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
            return objML_UserName;
        }


        public DataTable GetUserNameByIdDs(int Id)
        {
            DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@Id", Id) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameById.ToString(), this.Parameters);

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


        public DataTable GetUserNameByUserNameIdDs(int UserNameId)
        {
            DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@UserNameId", UserNameId) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByUserNameId.ToString(), this.Parameters);


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


        public DataTable GetUserNameByUserNameDs(string UserName)
        {
            DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@UserName", UserName) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByUserName.ToString(), this.Parameters);


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


        public DataTable GetUserNameByEmailDs(string Email)
        {
            DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@Email", Email) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByEmail.ToString(), this.Parameters);

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


        public DataTable GetUserNameByUserTypeIdDs(int UserTypeId)
        {
            DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@UserTypeId", UserTypeId) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByUserTypeId.ToString(), this.Parameters);

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


        public DataTable GetUserNameByUserTypeDs(string UserType)
        {
            DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@UserType", UserType) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByUserType.ToString(), this.Parameters);


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


        public DataTable GetUserNameByReTryAttemptDs(int ReTryAttempt)
        {
            DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@ReTryAttempt", ReTryAttempt) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByReTryAttempt.ToString(), this.Parameters);



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


        public DataTable GetUserNameByIsLockedDs(int IsLocked)
        {
            DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@IsLocked", IsLocked) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByIsLocked.ToString(), this.Parameters);

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


        public DataTable GetUserNameByLockedDateTimeDs(DateTime LockedDateTime)
        {
            DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@LockedDateTime", LockedDateTime) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByLockedDateTime.ToString(), this.Parameters);

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


        public DataTable GetUserNameByUserNamenEmailnPasswordDs(string UserName, string Email, string Password)
        {
            DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@UserName", UserName), 
	    new SqlParameter("@Email", Email), 
	    new SqlParameter("@Password", Password), 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByUserNamenEmailnPassword.ToString(), this.Parameters);
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


        public DataTable GetUserNameByUserNamenEmailDs(string UserName, string Email)
        {
            DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@UserName", UserName), 
	    new SqlParameter("@Email", Email), 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByUserNamenEmail.ToString(), this.Parameters);


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


        public DataTable GetUserNameByEmailnPasswordDs(string Email, string Password)
        {
            DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get ByIdDs Properties 
	    new SqlParameter("@Email", Email), 
	    new SqlParameter("@Password", Password), 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByEmailnPassword.ToString(), this.Parameters);

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




        public DataTable GetUserNameByLoginName(string loginName)
        {
            DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@loginName", loginName) 
	   #endregion  
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByLoginName.ToString(), this.Parameters);

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

        public ML_UserName GetUserNameByUserNamenPassword(string UserName, string Password)
        {
             DataTable dt = new DataTable();
            try
            {
                
                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@UserName", UserName), 
	    new SqlParameter("@Password", Password), 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByUserNamenPassword.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_UserName.Id = ML_Common.string2Int32(ML_Common.clean(dr["Id"].ToString()));
                        objML_UserName.UserNameId = ML_Common.string2Int32(ML_Common.clean(dr["UserNameId"].ToString()));
                        objML_UserName.UserName = ML_Common.clean(dr["UserName"].ToString());
                        objML_UserName.FirstName = ML_Common.clean(dr["FirstName"].ToString());
                        objML_UserName.LastName = ML_Common.clean(dr["LastName"].ToString());
                        objML_UserName.Email = ML_Common.clean(dr["Email"].ToString());
                        objML_UserName.Telephone = ML_Common.clean(dr["Telephone"].ToString());
                        objML_UserName.Mobile = ML_Common.clean(dr["Mobile"].ToString());
                        objML_UserName.Remarks = ML_Common.clean(dr["Remarks"].ToString());
                        objML_UserName.Password = ML_Common.clean(dr["Password"].ToString());
                        objML_UserName.UserTypeId = ML_Common.string2Int32(ML_Common.clean(dr["UserTypeId"].ToString()));
                        objML_UserName.UserType = ML_Common.clean(dr["UserType"].ToString());
                        objML_UserName.ReTryAttempt = ML_Common.string2int32(ML_Common.clean(dr["ReTryAttempt"].ToString()));
                        objML_UserName.IsLocked = ML_Common.string2Boolean(ML_Common.clean(dr["IsLocked"].ToString()));
                        objML_UserName.LockedDateTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["LockedDateTime"].ToString()));
                        objML_UserName.IsActive = ML_Common.clean(dr["IsActive"].ToString());
                        objML_UserName.IsArchive = ML_Common.clean(dr["IsArchive"].ToString());
                        objML_UserName.CreatedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["CreatedDate"].ToString()));
                        objML_UserName.CreatedBy = ML_Common.clean(dr["CreatedBy"].ToString());
                        objML_UserName.ModifiedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["ModifiedDate"].ToString()));
                        objML_UserName.ModifiedBy = ML_Common.clean(dr["ModifiedBy"].ToString());
                        objML_UserName.ImageName = ML_Common.clean(dr["ImageName"].ToString());
                        objML_UserName.ImagePath = ML_Common.clean(dr["ImagePath"].ToString());
                        objML_UserName.CreatedByUserNameId = ML_Common.string2Int32(dr["CreatedByUserNameId"].ToString());
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
            return objML_UserName;
        }

 //       public int UpdatePassword(int UserNameId, string OldPassword, string NewPassword)
 //       {
 //           int results = 0;
 //           try
 //           {
 //               


 //               




 //               

 //               SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
 //               ReturnObj.Direction = ParameterDirection.Output;
 //               SqlParameter[] parameters = 
 //              { 
 //                  #region Update Properties 
 //                  //new SqlParameter("@Id", objML_UserName.Id), 
 //new SqlParameter("@UserNameId", UserNameId),  
 //new SqlParameter("@OldPassword", OldPassword),  
 // new SqlParameter("@NewPassword", NewPassword), 
 //                  ReturnObj 
 //                  #endregion  
 //              };

 //               this.Parameters = parameters;
 //               SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateUserPassword.ToString(), this.Parameters);

 //               




 //               

 //               if (ReturnObj.Value != null)
 //               {
 //                   results = ML_Common.string2int32(ReturnObj.Value.ToString());
 //               }
 //           }
 //           catch (SqlException sqlExc)
 //           {
 //               int errNumber = int.MinValue;
 //               //////////////
 //               foreach (SqlError error in sqlExc.Errors)
 //               {
 //                   errNumber = error.Number;
 //               }
 //               if (errNumber == 50000)
 //               {
 //                   results = 999;
 //                   throw;
 //               }
 //           }
 //           catch (Exception ex)
 //           {
 //               results = 0;
 //               Exception exx = ex;
 //               throw;
 //           }
 //           finally
 //           {
 //               //
 //           }
 //           return results;
 //       }

        public int UpdatePassword(string UserName, string OldPassword, string NewPassword)
        {
            int results = 0;
            try
            {
                


                




                

                SqlParameter ReturnObj = new SqlParameter("@ReturnObj", ParameterDirection.Output);
                ReturnObj.Direction = ParameterDirection.Output;
                SqlParameter[] parameters = 
               { 
                   #region Update Properties 
                   //new SqlParameter("@Id", objML_UserName.Id), 
 new SqlParameter("@UserName", UserName),  
 new SqlParameter("@OldPassword", OldPassword),  
  new SqlParameter("@NewPassword", NewPassword), 
                   ReturnObj 
                   #endregion  
               };

                this.Parameters = parameters;
                SqlHelper.ExecuteNonQuery(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_UpdateUserPassword.ToString(), this.Parameters);

                




                

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

        public int GetAuthenticateUser(string UserName, string Password)
        {
            int ReturnCode = 0;
             DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@UserName", UserName), 
	    new SqlParameter("@Password", Password), 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetAuthenticateUser.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        ReturnCode = ML_Common.string2int32(ML_Common.clean(dr["ReturnCode"].ToString()));

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
            return ReturnCode;
        }


        public ML_UserName GetUserDetailsByLoginId(string UserName, string Password)
        {
             DataTable dt = new DataTable();
            try
            {
                


                




                

                objML_UserName = new ML_UserName();
                SqlParameter[] parameters = 
	  { 
	   #region Get Properties 
	    new SqlParameter("@UserName", UserName), 
	    new SqlParameter("@Password", Password), 
	   #endregion 
	  };

                this.Parameters = parameters;
                SqlDataReader sdr = SqlHelper.ExecuteReader(ML_Connection.CreateConnection().ToString(), CommandType.StoredProcedure, StoredProcedure.Name.usp_GetUserNameByUserNamenPassword.ToString(), this.Parameters);

                




                

                if (sdr.HasRows)
                {
                     dt.Load(sdr);
                    if (dt.Rows.Count > 0)
                    {
                        DataRow dr = dt.Rows[0];
                        objML_UserName.Id = ML_Common.string2Int32(ML_Common.clean(dr["Id"].ToString()));
                        objML_UserName.UserNameId = ML_Common.string2Int32(ML_Common.clean(dr["UserNameId"].ToString()));
                        objML_UserName.UserName = ML_Common.clean(dr["UserName"].ToString());
                        objML_UserName.FirstName = ML_Common.clean(dr["FirstName"].ToString());
                        objML_UserName.LastName = ML_Common.clean(dr["LastName"].ToString());
                        objML_UserName.Email = ML_Common.clean(dr["Email"].ToString());
                        objML_UserName.Telephone = ML_Common.clean(dr["Telephone"].ToString());
                        objML_UserName.Mobile = ML_Common.clean(dr["Mobile"].ToString());
                        objML_UserName.Remarks = ML_Common.clean(dr["Remarks"].ToString());
                        objML_UserName.Password = ML_Common.clean(dr["Password"].ToString());
                        objML_UserName.UserTypeId = ML_Common.string2Int32(ML_Common.clean(dr["UserTypeId"].ToString()));
                        objML_UserName.UserType = ML_Common.clean(dr["UserType"].ToString());
                        objML_UserName.ReTryAttempt = ML_Common.string2int32(ML_Common.clean(dr["ReTryAttempt"].ToString()));
                        objML_UserName.IsLocked = ML_Common.string2Boolean(ML_Common.clean(dr["IsLocked"].ToString()));
                        objML_UserName.LockedDateTime = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["LockedDateTime"].ToString()));
                        objML_UserName.IsActive = ML_Common.clean(dr["IsActive"].ToString());
                        objML_UserName.IsArchive = ML_Common.clean(dr["IsArchive"].ToString());
                        objML_UserName.CreatedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["CreatedDate"].ToString()));
                        objML_UserName.CreatedBy = ML_Common.clean(dr["CreatedBy"].ToString());
                        objML_UserName.ModifiedDate = ML_Common.ToDateTimeSafe(ML_Common.clean(dr["ModifiedDate"].ToString()));
                        objML_UserName.ModifiedBy = ML_Common.clean(dr["ModifiedBy"].ToString());
                        objML_UserName.ImageName = ML_Common.clean(dr["ImageName"].ToString());
                        objML_UserName.ImagePath = ML_Common.clean(dr["ImagePath"].ToString());
                        objML_UserName.CreatedByUserNameId = ML_Common.string2Int32(dr["CreatedByUserNameId"].ToString());
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
            return objML_UserName;
        }


        #endregion
    }
}
