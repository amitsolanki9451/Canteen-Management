using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BusinessLayer.BusinessClasses;
using ModelLayer;
namespace BusinessLayer
{
    
    public partial class BusinessClass : IBusinessClass
    {
        #region Initialize the Object of the Class
        #endregion

        #region Manged By Amit Singh Solanki



        #region  IClass Business For tblUserName
        public int AddUserName(ML_UserName objML_UserName)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                intReturn = objBL_UserName.Add(objML_UserName);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int UpdateUserName(ML_UserName objML_UserName)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                intReturn = objBL_UserName.Update(objML_UserName);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int UpdateUniqueUserName(ML_UserName objML_UserName)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                intReturn = objBL_UserName.UpdateUnique(objML_UserName);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteUserName(int UserNameId)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                intReturn = objBL_UserName.Delete(UserNameId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteUserNameById(int Id)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                intReturn = objBL_UserName.DeleteUserNameById(Id);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteUserNameByUserNameId(int UserNameId)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                intReturn = objBL_UserName.DeleteUserNameByUserNameId(UserNameId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteUserNameByUserName(string UserName)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                intReturn = objBL_UserName.DeleteUserNameByUserName(UserName);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteUserNameByEmail(string Email)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                intReturn = objBL_UserName.DeleteUserNameByEmail(Email);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteUserNameByUserTypeId(int UserTypeId)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                intReturn = objBL_UserName.DeleteUserNameByUserTypeId(UserTypeId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteUserNameByUserType(string UserType)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                intReturn = objBL_UserName.DeleteUserNameByUserType(UserType);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteUserNameByReTryAttempt(int ReTryAttempt)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                intReturn = objBL_UserName.DeleteUserNameByReTryAttempt(ReTryAttempt);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteUserNameByIsLocked(int IsLocked)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                intReturn = objBL_UserName.DeleteUserNameByIsLocked(IsLocked);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteUserNameByLockedDateTime(DateTime LockedDateTime)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                intReturn = objBL_UserName.DeleteUserNameByLockedDateTime(LockedDateTime);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteUserNameByUserNamenEmailnPassword(string UserName, string Email, string Password)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                intReturn = objBL_UserName.DeleteUserNameByUserNamenEmailnPassword(UserName, Email, Password);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteUserNameByUserNamenEmail(string UserName, string Email)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                intReturn = objBL_UserName.DeleteUserNameByUserNamenEmail(UserName, Email);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteUserNameByEmailnPassword(string Email, string Password)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                intReturn = objBL_UserName.DeleteUserNameByEmailnPassword(Email, Password);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public DataTable GetUserNameDetail()
        {
            DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                dt = objBL_UserName.GetUserName();
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public ML_UserName GetUserNameById(int Id)
        {
            ML_UserName objML_UserName = new ML_UserName();
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                objML_UserName = objBL_UserName.GetUserNameById(Id);
            }
            catch
            {
                throw;
            }
            return objML_UserName;
        }


        public ML_UserName GetUserNameByUserNameId(int UserNameId)
        {
            ML_UserName objML_UserName = new ML_UserName();
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                objML_UserName = objBL_UserName.GetUserNameByUserNameId(UserNameId);
            }
            catch
            {
                throw;
            }
            return objML_UserName;
        }


        public ML_UserName GetUserNameByUserName(string UserName)
        {
            ML_UserName objML_UserName = new ML_UserName();
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                objML_UserName = objBL_UserName.GetUserNameByUserName(UserName);
            }
            catch
            {
                throw;
            }
            return objML_UserName;
        }


        public ML_UserName GetUserNameByEmail(string Email)
        {
            ML_UserName objML_UserName = new ML_UserName();
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                objML_UserName = objBL_UserName.GetUserNameByEmail(Email);
            }
            catch
            {
                throw;
            }
            return objML_UserName;
        }


        public ML_UserName GetUserNameByUserTypeId(int UserTypeId)
        {
            ML_UserName objML_UserName = new ML_UserName();
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                objML_UserName = objBL_UserName.GetUserNameByUserTypeId(UserTypeId);
            }
            catch
            {
                throw;
            }
            return objML_UserName;
        }


        public ML_UserName GetUserNameByUserType(string UserType)
        {
            ML_UserName objML_UserName = new ML_UserName();
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                objML_UserName = objBL_UserName.GetUserNameByUserType(UserType);
            }
            catch
            {
                throw;
            }
            return objML_UserName;
        }


        public ML_UserName GetUserNameByReTryAttempt(int ReTryAttempt)
        {
            ML_UserName objML_UserName = new ML_UserName();
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                objML_UserName = objBL_UserName.GetUserNameByReTryAttempt(ReTryAttempt);
            }
            catch
            {
                throw;
            }
            return objML_UserName;
        }


        public ML_UserName GetUserNameByIsLocked(int IsLocked)
        {
            ML_UserName objML_UserName = new ML_UserName();
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                objML_UserName = objBL_UserName.GetUserNameByIsLocked(IsLocked);
            }
            catch
            {
                throw;
            }
            return objML_UserName;
        }


        public ML_UserName GetUserNameByLockedDateTime(DateTime LockedDateTime)
        {
            ML_UserName objML_UserName = new ML_UserName();
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                objML_UserName = objBL_UserName.GetUserNameByLockedDateTime(LockedDateTime);
            }
            catch
            {
                throw;
            }
            return objML_UserName;
        }


        public ML_UserName GetUserNameByUserNamenEmailnPassword(string UserName, string Email, string Password)
        {
            ML_UserName objML_UserName = new ML_UserName();
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                objML_UserName = objBL_UserName.GetUserNameByUserNamenEmailnPassword(UserName, Email, Password);
            }
            catch
            {
                throw;
            }
            return objML_UserName;
        }


        public ML_UserName GetUserNameByUserNamenEmail(string UserName, string Email)
        {
            ML_UserName objML_UserName = new ML_UserName();
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                objML_UserName = objBL_UserName.GetUserNameByUserNamenEmail(UserName, Email);
            }
            catch
            {
                throw;
            }
            return objML_UserName;
        }


        public ML_UserName GetUserNameByEmailnPassword(string Email, string Password)
        {
            ML_UserName objML_UserName = new ML_UserName();
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                objML_UserName = objBL_UserName.GetUserNameByEmailnPassword(Email, Password);
            }
            catch
            {
                throw;
            }
            return objML_UserName;
        }


        public DataTable GetUserNameByIdDs(int Id)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                dt = objBL_UserName.GetUserNameByIdDs(Id);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetUserNameByUserNameIdDs(int UserNameId)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                dt = objBL_UserName.GetUserNameByUserNameIdDs(UserNameId);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetUserNameByUserNameDs(string UserName)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                dt = objBL_UserName.GetUserNameByUserNameDs(UserName);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetUserNameByEmailDs(string Email)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                dt = objBL_UserName.GetUserNameByEmailDs(Email);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetUserNameByUserTypeIdDs(int UserTypeId)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                dt = objBL_UserName.GetUserNameByUserTypeIdDs(UserTypeId);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetUserNameByUserTypeDs(string UserType)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                dt = objBL_UserName.GetUserNameByUserTypeDs(UserType);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetUserNameByReTryAttemptDs(int ReTryAttempt)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                dt = objBL_UserName.GetUserNameByReTryAttemptDs(ReTryAttempt);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetUserNameByIsLockedDs(int IsLocked)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                dt = objBL_UserName.GetUserNameByIsLockedDs(IsLocked);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetUserNameByLockedDateTimeDs(DateTime LockedDateTime)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                dt = objBL_UserName.GetUserNameByLockedDateTimeDs(LockedDateTime);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetUserNameByUserNamenEmailnPasswordDs(string UserName, string Email, string Password)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                dt = objBL_UserName.GetUserNameByUserNamenEmailnPasswordDs(UserName, Email, Password);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetUserNameByUserNamenEmailDs(string UserName, string Email)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                dt = objBL_UserName.GetUserNameByUserNamenEmailDs(UserName, Email);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetUserNameByEmailnPasswordDs(string Email, string Password)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                dt = objBL_UserName.GetUserNameByEmailnPasswordDs(Email, Password);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetUserNameByLoginName(string loginName)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                dt = objBL_UserName.GetUserNameByLoginName(loginName);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetUserNameBySeacrh(ML_UserName objML_UserName)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                dt = objBL_UserName.GetUserNameBySeacrh(objML_UserName);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public int GetAuthenticateUser(string UserName, string Password)
        {
            int returnCode = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                returnCode = objBL_UserName.GetAuthenticateUser(UserName, Password);
            }
            catch
            {
                throw;
            }
            return returnCode;
        }

        public int UpdatePassword(string UserName, string OldPassword, string NewPassword)
        {
            int returnCode = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                returnCode = objBL_UserName.UpdatePassword(UserName, OldPassword, NewPassword);
            }
            catch
            {
                throw;
            }
            return returnCode;
        }


      

        public ML_UserName GetUserNameByUserNamenPassword(string UserName, string Password)
        {
            ML_UserName objML_UserName = new ML_UserName();
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                objML_UserName = objBL_UserName.GetUserNameByUserNamenPassword(UserName, Password);
            }
            catch
            {
                throw;
            }
            return objML_UserName;
        }

        public ML_UserName GetUserDetailsByLoginId(string UserName, string Password)
        {
            ML_UserName objML_UserName = new ML_UserName();
             DataTable dt = new DataTable();
            try
            {
                BL_UserName objBL_UserName = new BL_UserName();
                objML_UserName = objBL_UserName.GetUserNameByUserNamenPassword(UserName, Password);
            }
            catch
            {
                throw;
            }
            return objML_UserName;
        }

        #endregion

        #region  IClass Business For tblUserType
        public int AddUserType(ML_UserType objML_UserType)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserType objBL_UserType = new BL_UserType();
                intReturn = objBL_UserType.Add(objML_UserType);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int UpdateUserType(ML_UserType objML_UserType)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserType objBL_UserType = new BL_UserType();
                intReturn = objBL_UserType.Update(objML_UserType);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int UpdateUniqueUserType(ML_UserType objML_UserType)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserType objBL_UserType = new BL_UserType();
                intReturn = objBL_UserType.UpdateUnique(objML_UserType);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteUserType(int UserTypeId)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserType objBL_UserType = new BL_UserType();
                intReturn = objBL_UserType.Delete(UserTypeId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteUserTypeById(int Id)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserType objBL_UserType = new BL_UserType();
                intReturn = objBL_UserType.DeleteUserTypeById(Id);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteUserTypeByUserTypeId(int UserTypeId)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserType objBL_UserType = new BL_UserType();
                intReturn = objBL_UserType.DeleteUserTypeByUserTypeId(UserTypeId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteUserTypeByUserType(string UserType)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_UserType objBL_UserType = new BL_UserType();
                intReturn = objBL_UserType.DeleteUserTypeByUserType(UserType);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public DataTable GetUserTypeDetail()
        {
            DataTable dt = new DataTable();
            try
            {
                BL_UserType objBL_UserType = new BL_UserType();
                dt = objBL_UserType.GetUserType();
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public ML_UserType GetUserTypeById(int Id)
        {
            ML_UserType objML_UserType = new ML_UserType();
             DataTable dt = new DataTable();
            try
            {
                BL_UserType objBL_UserType = new BL_UserType();
                objML_UserType = objBL_UserType.GetUserTypeById(Id);
            }
            catch
            {
                throw;
            }
            return objML_UserType;
        }


        public ML_UserType GetUserTypeByUserTypeId(int UserTypeId)
        {
            ML_UserType objML_UserType = new ML_UserType();
             DataTable dt = new DataTable();
            try
            {
                BL_UserType objBL_UserType = new BL_UserType();
                objML_UserType = objBL_UserType.GetUserTypeByUserTypeId(UserTypeId);
            }
            catch
            {
                throw;
            }
            return objML_UserType;
        }


        public ML_UserType GetUserTypeByUserType(string UserType)
        {
            ML_UserType objML_UserType = new ML_UserType();
             DataTable dt = new DataTable();
            try
            {
                BL_UserType objBL_UserType = new BL_UserType();
                objML_UserType = objBL_UserType.GetUserTypeByUserType(UserType);
            }
            catch
            {
                throw;
            }
            return objML_UserType;
        }


        public DataTable GetUserTypeByIdDs(int Id)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_UserType objBL_UserType = new BL_UserType();
                dt = objBL_UserType.GetUserTypeByIdDs(Id);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetUserTypeByUserTypeIdDs(int UserTypeId)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_UserType objBL_UserType = new BL_UserType();
                dt = objBL_UserType.GetUserTypeByUserTypeIdDs(UserTypeId);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetUserTypeByUserTypeDs(string UserType)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_UserType objBL_UserType = new BL_UserType();
                dt = objBL_UserType.GetUserTypeByUserTypeDs(UserType);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetUserTypeByLoginName(string loginName)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_UserType objBL_UserType = new BL_UserType();
                dt = objBL_UserType.GetUserTypeByLoginName(loginName);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetUserTypeBySeacrh(ML_UserType objML_UserType)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_UserType objBL_UserType = new BL_UserType();
                dt = objBL_UserType.GetUserTypeBySeacrh(objML_UserType);
            }
            catch
            {
                throw;
            }
            return dt;
        }
        #endregion

        #region  IClass Business For tblItemMaster
        public int AddItemMaster(ML_ItemMaster objML_ItemMaster)
        {
            int intReturn = 0;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                intReturn = objBL_ItemMaster.Add(objML_ItemMaster);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int UpdateItemMaster(ML_ItemMaster objML_ItemMaster)
        {
            int intReturn = 0;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                intReturn = objBL_ItemMaster.Update(objML_ItemMaster);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int UpdateUniqueItemMaster(ML_ItemMaster objML_ItemMaster)
        {
            int intReturn = 0;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                intReturn = objBL_ItemMaster.UpdateUnique(objML_ItemMaster);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteItemMaster(long ItemMasterId)
        {
            int intReturn = 0;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                intReturn = objBL_ItemMaster.Delete(ItemMasterId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteItemMasterByItemCode(long ItemCode)
        {
            int intReturn = 0;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                intReturn = objBL_ItemMaster.DeleteItemMasterByItemCode(ItemCode);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteItemMasterByCanteenCode(long CanteenCode)
        {
            int intReturn = 0;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                intReturn = objBL_ItemMaster.DeleteItemMasterByCanteenCode(CanteenCode);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteItemMasterByCategoryGroupCode(long CategoryGroupCode)
        {
            int intReturn = 0;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                intReturn = objBL_ItemMaster.DeleteItemMasterByCategoryGroupCode(CategoryGroupCode);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteItemMasterByItemCategoryCode(long ItemCategoryCode)
        {
            int intReturn = 0;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                intReturn = objBL_ItemMaster.DeleteItemMasterByItemCategoryCode(ItemCategoryCode);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteItemMasterByItemName(long ItemName)
        {
            int intReturn = 0;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                intReturn = objBL_ItemMaster.DeleteItemMasterByItemName(ItemName);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteItemMasterByItemEmployeeRate(long ItemEmployeeRate)
        {
            int intReturn = 0;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                intReturn = objBL_ItemMaster.DeleteItemMasterByItemEmployeeRate(ItemEmployeeRate);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteItemMasterByItemActive(long ItemActive)
        {
            int intReturn = 0;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                intReturn = objBL_ItemMaster.DeleteItemMasterByItemActive(ItemActive);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteItemMasterByItemImage(long ItemImage)
        {
            int intReturn = 0;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                intReturn = objBL_ItemMaster.DeleteItemMasterByItemImage(ItemImage);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public DataSet GetItemMasterDetail()
        {
            DataSet ds = null;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                ds = objBL_ItemMaster.GetItemMaster();
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public ML_ItemMaster GetItemMasterByItemCode(long ItemCode)
        {
            ML_ItemMaster objML_ItemMaster = new ML_ItemMaster();
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                objML_ItemMaster = objBL_ItemMaster.GetItemMasterByItemCode(ItemCode);
            }
            catch
            {
                throw;
            }
            return objML_ItemMaster;
        }


        public ML_ItemMaster GetItemMasterByCanteenCode(long CanteenCode)
        {
            ML_ItemMaster objML_ItemMaster = new ML_ItemMaster();
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                objML_ItemMaster = objBL_ItemMaster.GetItemMasterByCanteenCode(CanteenCode);
            }
            catch
            {
                throw;
            }
            return objML_ItemMaster;
        }


        public ML_ItemMaster GetItemMasterByCategoryGroupCode(long CategoryGroupCode)
        {
            ML_ItemMaster objML_ItemMaster = new ML_ItemMaster();
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                objML_ItemMaster = objBL_ItemMaster.GetItemMasterByCategoryGroupCode(CategoryGroupCode);
            }
            catch
            {
                throw;
            }
            return objML_ItemMaster;
        }


        public ML_ItemMaster GetItemMasterByItemCategoryCode(long ItemCategoryCode)
        {
            ML_ItemMaster objML_ItemMaster = new ML_ItemMaster();
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                objML_ItemMaster = objBL_ItemMaster.GetItemMasterByItemCategoryCode(ItemCategoryCode);
            }
            catch
            {
                throw;
            }
            return objML_ItemMaster;
        }


        public ML_ItemMaster GetItemMasterByItemName(long ItemName)
        {
            ML_ItemMaster objML_ItemMaster = new ML_ItemMaster();
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                objML_ItemMaster = objBL_ItemMaster.GetItemMasterByItemName(ItemName);
            }
            catch
            {
                throw;
            }
            return objML_ItemMaster;
        }


        public ML_ItemMaster GetItemMasterByItemEmployeeRate(long ItemEmployeeRate)
        {
            ML_ItemMaster objML_ItemMaster = new ML_ItemMaster();
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                objML_ItemMaster = objBL_ItemMaster.GetItemMasterByItemEmployeeRate(ItemEmployeeRate);
            }
            catch
            {
                throw;
            }
            return objML_ItemMaster;
        }


        public ML_ItemMaster GetItemMasterByItemActive(long ItemActive)
        {
            ML_ItemMaster objML_ItemMaster = new ML_ItemMaster();
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                objML_ItemMaster = objBL_ItemMaster.GetItemMasterByItemActive(ItemActive);
            }
            catch
            {
                throw;
            }
            return objML_ItemMaster;
        }


        public ML_ItemMaster GetItemMasterByItemImage(long ItemImage)
        {
            ML_ItemMaster objML_ItemMaster = new ML_ItemMaster();
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                objML_ItemMaster = objBL_ItemMaster.GetItemMasterByItemImage(ItemImage);
            }
            catch
            {
                throw;
            }
            return objML_ItemMaster;
        }


        public DataSet GetItemMasterByItemCodeDs(long ItemCode)
        {
            DataSet ds = null;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                ds = objBL_ItemMaster.GetItemMasterByItemCodeDs(ItemCode);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetItemMasterByCanteenCodeDs(long CanteenCode)
        {
            DataSet ds = null;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                ds = objBL_ItemMaster.GetItemMasterByCanteenCodeDs(CanteenCode);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetItemMasterByCategoryGroupCodeDs(long CategoryGroupCode)
        {
            DataSet ds = null;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                ds = objBL_ItemMaster.GetItemMasterByCategoryGroupCodeDs(CategoryGroupCode);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetItemMasterByItemCategoryCodeDs(long ItemCategoryCode)
        {
            DataSet ds = null;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                ds = objBL_ItemMaster.GetItemMasterByItemCategoryCodeDs(ItemCategoryCode);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetItemMasterByItemNameDs(long ItemName)
        {
            DataSet ds = null;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                ds = objBL_ItemMaster.GetItemMasterByItemNameDs(ItemName);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetItemMasterByItemEmployeeRateDs(long ItemEmployeeRate)
        {
            DataSet ds = null;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                ds = objBL_ItemMaster.GetItemMasterByItemEmployeeRateDs(ItemEmployeeRate);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetItemMasterByItemActiveDs(long ItemActive)
        {
            DataSet ds = null;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                ds = objBL_ItemMaster.GetItemMasterByItemActiveDs(ItemActive);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetItemMasterByItemImageDs(long ItemImage)
        {
            DataSet ds = null;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                ds = objBL_ItemMaster.GetItemMasterByItemImageDs(ItemImage);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetItemMasterByLoginName(string loginName)
        {
            DataSet ds = null;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                ds = objBL_ItemMaster.GetItemMasterByLoginName(loginName);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetItemMasterBySeacrh(ML_ItemMaster objML_ItemMaster)
        {
            DataSet ds = null;
            try
            {
                BL_ItemMaster objBL_ItemMaster = new BL_ItemMaster();
                ds = objBL_ItemMaster.GetItemMasterBySeacrh(objML_ItemMaster);
            }
            catch
            {
                throw;
            }
            return ds;
        }
        #endregion

        #region  IClass Business For tblItemCategoryMaster
        public int AddItemCategoryMaster(ML_ItemCategoryMaster objML_ItemCategoryMaster)
        {
            int intReturn = 0;
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                intReturn = objBL_ItemCategoryMaster.Add(objML_ItemCategoryMaster);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int UpdateItemCategoryMaster(ML_ItemCategoryMaster objML_ItemCategoryMaster)
        {
            int intReturn = 0;
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                intReturn = objBL_ItemCategoryMaster.Update(objML_ItemCategoryMaster);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int UpdateUniqueItemCategoryMaster(ML_ItemCategoryMaster objML_ItemCategoryMaster)
        {
            int intReturn = 0;
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                intReturn = objBL_ItemCategoryMaster.UpdateUnique(objML_ItemCategoryMaster);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteItemCategoryMaster(long ItemCategoryMasterId)
        {
            int intReturn = 0;
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                intReturn = objBL_ItemCategoryMaster.Delete(ItemCategoryMasterId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteItemCategoryMasterByItemCategoryCode(long ItemCategoryCode)
        {
            int intReturn = 0;
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                intReturn = objBL_ItemCategoryMaster.DeleteItemCategoryMasterByItemCategoryCode(ItemCategoryCode);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public DataSet GetItemCategoryMasterDetail()
        {
            DataSet ds = null;
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                ds = objBL_ItemCategoryMaster.GetItemCategoryMaster();
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public ML_ItemCategoryMaster GetItemCategoryMasterByItemCategoryCode(long ItemCategoryCode)
        {
            ML_ItemCategoryMaster objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                objML_ItemCategoryMaster = objBL_ItemCategoryMaster.GetItemCategoryMasterByItemCategoryCode(ItemCategoryCode);
            }
            catch
            {
                throw;
            }
            return objML_ItemCategoryMaster;
        }


        public ML_ItemCategoryMaster GetItemCategoryMasterByCanteenCode(long CanteenCode)
        {
            ML_ItemCategoryMaster objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                objML_ItemCategoryMaster = objBL_ItemCategoryMaster.GetItemCategoryMasterByCanteenCode(CanteenCode);
            }
            catch
            {
                throw;
            }
            return objML_ItemCategoryMaster;
        }


        public ML_ItemCategoryMaster GetItemCategoryMasterByCategoryGroupCode(long CategoryGroupCode)
        {
            ML_ItemCategoryMaster objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                objML_ItemCategoryMaster = objBL_ItemCategoryMaster.GetItemCategoryMasterByCategoryGroupCode(CategoryGroupCode);
            }
            catch
            {
                throw;
            }
            return objML_ItemCategoryMaster;
        }


        public ML_ItemCategoryMaster GetItemCategoryMasterByItemCategoryName(long ItemCategoryName)
        {
            ML_ItemCategoryMaster objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                objML_ItemCategoryMaster = objBL_ItemCategoryMaster.GetItemCategoryMasterByItemCategoryName(ItemCategoryName);
            }
            catch
            {
                throw;
            }
            return objML_ItemCategoryMaster;
        }


        public ML_ItemCategoryMaster GetItemCategoryMasterByItemCategoryActive(long ItemCategoryActive)
        {
            ML_ItemCategoryMaster objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                objML_ItemCategoryMaster = objBL_ItemCategoryMaster.GetItemCategoryMasterByItemCategoryActive(ItemCategoryActive);
            }
            catch
            {
                throw;
            }
            return objML_ItemCategoryMaster;
        }


        public ML_ItemCategoryMaster GetItemCategoryMasterByStartTime(long StartTime)
        {
            ML_ItemCategoryMaster objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                objML_ItemCategoryMaster = objBL_ItemCategoryMaster.GetItemCategoryMasterByStartTime(StartTime);
            }
            catch
            {
                throw;
            }
            return objML_ItemCategoryMaster;
        }


        public ML_ItemCategoryMaster GetItemCategoryMasterByEndTime(long EndTime)
        {
            ML_ItemCategoryMaster objML_ItemCategoryMaster = new ML_ItemCategoryMaster();
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                objML_ItemCategoryMaster = objBL_ItemCategoryMaster.GetItemCategoryMasterByEndTime(EndTime);
            }
            catch
            {
                throw;
            }
            return objML_ItemCategoryMaster;
        }


        public DataSet GetItemCategoryMasterByItemCategoryCodeDs(long ItemCategoryCode)
        {
            DataSet ds = null;
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                ds = objBL_ItemCategoryMaster.GetItemCategoryMasterByItemCategoryCodeDs(ItemCategoryCode);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetItemCategoryMasterByCanteenCodeDs(long CanteenCode)
        {
            DataSet ds = null;
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                ds = objBL_ItemCategoryMaster.GetItemCategoryMasterByCanteenCodeDs(CanteenCode);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetItemCategoryMasterByCategoryGroupCodeDs(long CategoryGroupCode)
        {
            DataSet ds = null;
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                ds = objBL_ItemCategoryMaster.GetItemCategoryMasterByCategoryGroupCodeDs(CategoryGroupCode);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetItemCategoryMasterByItemCategoryNameDs(long ItemCategoryName)
        {
            DataSet ds = null;
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                ds = objBL_ItemCategoryMaster.GetItemCategoryMasterByItemCategoryNameDs(ItemCategoryName);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetItemCategoryMasterByItemCategoryActiveDs(long ItemCategoryActive)
        {
            DataSet ds = null;
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                ds = objBL_ItemCategoryMaster.GetItemCategoryMasterByItemCategoryActiveDs(ItemCategoryActive);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetItemCategoryMasterByStartTimeDs(long StartTime)
        {
            DataSet ds = null;
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                ds = objBL_ItemCategoryMaster.GetItemCategoryMasterByStartTimeDs(StartTime);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetItemCategoryMasterByEndTimeDs(long EndTime)
        {
            DataSet ds = null;
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                ds = objBL_ItemCategoryMaster.GetItemCategoryMasterByEndTimeDs(EndTime);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetItemCategoryMasterByLoginName(string loginName)
        {
            DataSet ds = null;
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                ds = objBL_ItemCategoryMaster.GetItemCategoryMasterByLoginName(loginName);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetItemCategoryMasterBySeacrh(ML_ItemCategoryMaster objML_ItemCategoryMaster)
        {
            DataSet ds = null;
            try
            {
                BL_ItemCategoryMaster objBL_ItemCategoryMaster = new BL_ItemCategoryMaster();
                ds = objBL_ItemCategoryMaster.GetItemCategoryMasterBySeacrh(objML_ItemCategoryMaster);
            }
            catch
            {
                throw;
            }
            return ds;
        }
        #endregion

       

        #region  IClass Business For tblCokeDynamic
        public int AddCokeDynamic(ML_CokeDynamic objML_CokeDynamic)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                intReturn = objBL_CokeDynamic.Add(objML_CokeDynamic);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int UpdateCokeDynamic(ML_CokeDynamic objML_CokeDynamic)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                intReturn = objBL_CokeDynamic.Update(objML_CokeDynamic);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int UpdateUniqueCokeDynamic(ML_CokeDynamic objML_CokeDynamic)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                intReturn = objBL_CokeDynamic.UpdateUnique(objML_CokeDynamic);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamic(long CokeDynamicId)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                intReturn = objBL_CokeDynamic.Delete(CokeDynamicId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicById(long Id)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                intReturn = objBL_CokeDynamic.DeleteCokeDynamicById(Id);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicByCokeDynamicId(long CokeDynamicId)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                intReturn = objBL_CokeDynamic.DeleteCokeDynamicByCokeDynamicId(CokeDynamicId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicByCokeDynamic(long CokeDynamic)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                intReturn = objBL_CokeDynamic.DeleteCokeDynamicByCokeDynamic(CokeDynamic);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicByCokeTypeId(long CokeTypeId)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                intReturn = objBL_CokeDynamic.DeleteCokeDynamicByCokeTypeId(CokeTypeId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicByCokeType(long CokeType)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                intReturn = objBL_CokeDynamic.DeleteCokeDynamicByCokeType(CokeType);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicByCokeSupplierId(long CokeSupplierId)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                intReturn = objBL_CokeDynamic.DeleteCokeDynamicByCokeSupplierId(CokeSupplierId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicByCokeSupplier(long CokeSupplier)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                intReturn = objBL_CokeDynamic.DeleteCokeDynamicByCokeSupplier(CokeSupplier);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicByAnalysisTypeId(long AnalysisTypeId)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                intReturn = objBL_CokeDynamic.DeleteCokeDynamicByAnalysisTypeId(AnalysisTypeId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicByAnalysisType(long AnalysisType)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                intReturn = objBL_CokeDynamic.DeleteCokeDynamicByAnalysisType(AnalysisType);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicByIdnCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long Id, int CokeDynamicId, int CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                intReturn = objBL_CokeDynamic.DeleteCokeDynamicByIdnCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(Id, CokeDynamicId, CokeDynamic, CokeTypeId, CokeType, CokeSupplierId, CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicByCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeDynamicId, int CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                intReturn = objBL_CokeDynamic.DeleteCokeDynamicByCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(CokeDynamicId, CokeDynamic, CokeTypeId, CokeType, CokeSupplierId, CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicByCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                intReturn = objBL_CokeDynamic.DeleteCokeDynamicByCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(CokeDynamic, CokeTypeId, CokeType, CokeSupplierId, CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicByCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                intReturn = objBL_CokeDynamic.DeleteCokeDynamicByCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(CokeTypeId, CokeType, CokeSupplierId, CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicByCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                intReturn = objBL_CokeDynamic.DeleteCokeDynamicByCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(CokeType, CokeSupplierId, CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicByCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                intReturn = objBL_CokeDynamic.DeleteCokeDynamicByCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(CokeSupplierId, CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicByCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                intReturn = objBL_CokeDynamic.DeleteCokeDynamicByCokeSuppliernAnalysisTypeIdnAnalysisType(CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicByAnalysisTypeIdnAnalysisType(long AnalysisTypeId, int AnalysisType)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                intReturn = objBL_CokeDynamic.DeleteCokeDynamicByAnalysisTypeIdnAnalysisType(AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public DataTable GetCokeDynamicDetail()
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                dt = objBL_CokeDynamic.GetCokeDynamic();
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public ML_CokeDynamic GetCokeDynamicById(long Id)
        {
            ML_CokeDynamic objML_CokeDynamic = new ML_CokeDynamic();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                objML_CokeDynamic = objBL_CokeDynamic.GetCokeDynamicById(Id);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeDynamicId(long CokeDynamicId)
        {
            ML_CokeDynamic objML_CokeDynamic = new ML_CokeDynamic();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                objML_CokeDynamic = objBL_CokeDynamic.GetCokeDynamicByCokeDynamicId(CokeDynamicId);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeDynamic(long CokeDynamic)
        {
            ML_CokeDynamic objML_CokeDynamic = new ML_CokeDynamic();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                objML_CokeDynamic = objBL_CokeDynamic.GetCokeDynamicByCokeDynamic(CokeDynamic);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeTypeId(long CokeTypeId)
        {
            ML_CokeDynamic objML_CokeDynamic = new ML_CokeDynamic();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                objML_CokeDynamic = objBL_CokeDynamic.GetCokeDynamicByCokeTypeId(CokeTypeId);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeType(long CokeType)
        {
            ML_CokeDynamic objML_CokeDynamic = new ML_CokeDynamic();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                objML_CokeDynamic = objBL_CokeDynamic.GetCokeDynamicByCokeType(CokeType);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeSupplierId(long CokeSupplierId)
        {
            ML_CokeDynamic objML_CokeDynamic = new ML_CokeDynamic();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                objML_CokeDynamic = objBL_CokeDynamic.GetCokeDynamicByCokeSupplierId(CokeSupplierId);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeSupplier(long CokeSupplier)
        {
            ML_CokeDynamic objML_CokeDynamic = new ML_CokeDynamic();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                objML_CokeDynamic = objBL_CokeDynamic.GetCokeDynamicByCokeSupplier(CokeSupplier);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByAnalysisTypeId(long AnalysisTypeId)
        {
            ML_CokeDynamic objML_CokeDynamic = new ML_CokeDynamic();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                objML_CokeDynamic = objBL_CokeDynamic.GetCokeDynamicByAnalysisTypeId(AnalysisTypeId);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByAnalysisType(long AnalysisType)
        {
            ML_CokeDynamic objML_CokeDynamic = new ML_CokeDynamic();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                objML_CokeDynamic = objBL_CokeDynamic.GetCokeDynamicByAnalysisType(AnalysisType);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByIdnCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long Id, int CokeDynamicId, int CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            ML_CokeDynamic objML_CokeDynamic = new ML_CokeDynamic();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                objML_CokeDynamic = objBL_CokeDynamic.GetCokeDynamicByIdnCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(Id, CokeDynamicId, CokeDynamic, CokeTypeId, CokeType, CokeSupplierId, CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeDynamicId, int CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            ML_CokeDynamic objML_CokeDynamic = new ML_CokeDynamic();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                objML_CokeDynamic = objBL_CokeDynamic.GetCokeDynamicByCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(CokeDynamicId, CokeDynamic, CokeTypeId, CokeType, CokeSupplierId, CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            ML_CokeDynamic objML_CokeDynamic = new ML_CokeDynamic();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                objML_CokeDynamic = objBL_CokeDynamic.GetCokeDynamicByCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(CokeDynamic, CokeTypeId, CokeType, CokeSupplierId, CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            ML_CokeDynamic objML_CokeDynamic = new ML_CokeDynamic();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                objML_CokeDynamic = objBL_CokeDynamic.GetCokeDynamicByCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(CokeTypeId, CokeType, CokeSupplierId, CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            ML_CokeDynamic objML_CokeDynamic = new ML_CokeDynamic();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                objML_CokeDynamic = objBL_CokeDynamic.GetCokeDynamicByCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(CokeType, CokeSupplierId, CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            ML_CokeDynamic objML_CokeDynamic = new ML_CokeDynamic();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                objML_CokeDynamic = objBL_CokeDynamic.GetCokeDynamicByCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(CokeSupplierId, CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            ML_CokeDynamic objML_CokeDynamic = new ML_CokeDynamic();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                objML_CokeDynamic = objBL_CokeDynamic.GetCokeDynamicByCokeSuppliernAnalysisTypeIdnAnalysisType(CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamic;
        }


        public ML_CokeDynamic GetCokeDynamicByAnalysisTypeIdnAnalysisType(long AnalysisTypeId, int AnalysisType)
        {
            ML_CokeDynamic objML_CokeDynamic = new ML_CokeDynamic();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                objML_CokeDynamic = objBL_CokeDynamic.GetCokeDynamicByAnalysisTypeIdnAnalysisType(AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamic;
        }


        public DataTable GetCokeDynamicByIdDs(long Id)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                dt = objBL_CokeDynamic.GetCokeDynamicByIdDs(Id);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicByCokeDynamicIdDs(long CokeDynamicId)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                dt = objBL_CokeDynamic.GetCokeDynamicByCokeDynamicIdDs(CokeDynamicId);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicByCokeDynamicDs(long CokeDynamic)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                dt = objBL_CokeDynamic.GetCokeDynamicByCokeDynamicDs(CokeDynamic);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicByCokeTypeIdDs(long CokeTypeId)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                dt = objBL_CokeDynamic.GetCokeDynamicByCokeTypeIdDs(CokeTypeId);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicByCokeTypeDs(long CokeType)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                dt = objBL_CokeDynamic.GetCokeDynamicByCokeTypeDs(CokeType);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicByCokeSupplierIdDs(long CokeSupplierId)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                dt = objBL_CokeDynamic.GetCokeDynamicByCokeSupplierIdDs(CokeSupplierId);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicByCokeSupplierDs(long CokeSupplier)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                dt = objBL_CokeDynamic.GetCokeDynamicByCokeSupplierDs(CokeSupplier);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicByAnalysisTypeIdDs(long AnalysisTypeId)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                dt = objBL_CokeDynamic.GetCokeDynamicByAnalysisTypeIdDs(AnalysisTypeId);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicByAnalysisTypeDs(long AnalysisType)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                dt = objBL_CokeDynamic.GetCokeDynamicByAnalysisTypeDs(AnalysisType);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicByIdnCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long Id, int CokeDynamicId, int CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                dt = objBL_CokeDynamic.GetCokeDynamicByIdnCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(Id, CokeDynamicId, CokeDynamic, CokeTypeId, CokeType, CokeSupplierId, CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicByCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long CokeDynamicId, int CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                dt = objBL_CokeDynamic.GetCokeDynamicByCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(CokeDynamicId, CokeDynamic, CokeTypeId, CokeType, CokeSupplierId, CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicByCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                dt = objBL_CokeDynamic.GetCokeDynamicByCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(CokeDynamic, CokeTypeId, CokeType, CokeSupplierId, CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicByCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                dt = objBL_CokeDynamic.GetCokeDynamicByCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(CokeTypeId, CokeType, CokeSupplierId, CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicByCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                dt = objBL_CokeDynamic.GetCokeDynamicByCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(CokeType, CokeSupplierId, CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicByCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                dt = objBL_CokeDynamic.GetCokeDynamicByCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(CokeSupplierId, CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicByCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                dt = objBL_CokeDynamic.GetCokeDynamicByCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicByAnalysisTypeIdnAnalysisTypeDs(long AnalysisTypeId, int AnalysisType)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                dt = objBL_CokeDynamic.GetCokeDynamicByAnalysisTypeIdnAnalysisTypeDs(AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicByLoginName(string loginName)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                dt = objBL_CokeDynamic.GetCokeDynamicByLoginName(loginName);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicBySeacrh(ML_CokeDynamic objML_CokeDynamic)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamic objBL_CokeDynamic = new BL_CokeDynamic();
                dt = objBL_CokeDynamic.GetCokeDynamicBySeacrh(objML_CokeDynamic);
            }
            catch
            {
                throw;
            }
            return dt;
        }
        #endregion


        #region  IClass Business For tblCokeDynamicResult
        public int AddCokeDynamicResult(ML_CokeDynamicResult objML_CokeDynamicResult)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                intReturn = objBL_CokeDynamicResult.Add(objML_CokeDynamicResult);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int UpdateCokeDynamicResult(ML_CokeDynamicResult objML_CokeDynamicResult)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                intReturn = objBL_CokeDynamicResult.Update(objML_CokeDynamicResult);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int UpdateUniqueCokeDynamicResult(ML_CokeDynamicResult objML_CokeDynamicResult)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                intReturn = objBL_CokeDynamicResult.UpdateUnique(objML_CokeDynamicResult);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicResult(long CokeDynamicResultId)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                intReturn = objBL_CokeDynamicResult.Delete(CokeDynamicResultId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicResultById(long Id)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                intReturn = objBL_CokeDynamicResult.DeleteCokeDynamicResultById(Id);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicResultByCokeDynamicResultId(long CokeDynamicResultId)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                intReturn = objBL_CokeDynamicResult.DeleteCokeDynamicResultByCokeDynamicResultId(CokeDynamicResultId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicResultByCokeDynamicResult(long CokeDynamicResult)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                intReturn = objBL_CokeDynamicResult.DeleteCokeDynamicResultByCokeDynamicResult(CokeDynamicResult);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicResultByCokeDynamicId(long CokeDynamicId)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                intReturn = objBL_CokeDynamicResult.DeleteCokeDynamicResultByCokeDynamicId(CokeDynamicId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicResultByCokeDynamic(long CokeDynamic)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                intReturn = objBL_CokeDynamicResult.DeleteCokeDynamicResultByCokeDynamic(CokeDynamic);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicResultByCokeCompositeMasterId(long CokeCompositeMasterId)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                intReturn = objBL_CokeDynamicResult.DeleteCokeDynamicResultByCokeCompositeMasterId(CokeCompositeMasterId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicResultByCokeCompositeMaster(long CokeCompositeMaster)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                intReturn = objBL_CokeDynamicResult.DeleteCokeDynamicResultByCokeCompositeMaster(CokeCompositeMaster);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicResultByCokeTypeId(long CokeTypeId)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                intReturn = objBL_CokeDynamicResult.DeleteCokeDynamicResultByCokeTypeId(CokeTypeId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicResultByCokeType(long CokeType)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                intReturn = objBL_CokeDynamicResult.DeleteCokeDynamicResultByCokeType(CokeType);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicResultByCokeSupplierId(long CokeSupplierId)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                intReturn = objBL_CokeDynamicResult.DeleteCokeDynamicResultByCokeSupplierId(CokeSupplierId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicResultByCokeSupplier(long CokeSupplier)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                intReturn = objBL_CokeDynamicResult.DeleteCokeDynamicResultByCokeSupplier(CokeSupplier);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicResultByAnalysisTypeId(long AnalysisTypeId)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                intReturn = objBL_CokeDynamicResult.DeleteCokeDynamicResultByAnalysisTypeId(AnalysisTypeId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicResultByAnalysisType(long AnalysisType)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                intReturn = objBL_CokeDynamicResult.DeleteCokeDynamicResultByAnalysisType(AnalysisType);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeDynamicResultByIdnCokeDynamicResultIdnCokeDynamicResultnCokeDynamicIdnCokeDynamicnCokeCompositeMasterIdnCokeCompositeMasternCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long Id, int CokeDynamicResultId, int CokeDynamicResult, int CokeDynamicId, int CokeDynamic, int CokeCompositeMasterId, int CokeCompositeMaster, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            int intReturn = 0;
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                intReturn = objBL_CokeDynamicResult.DeleteCokeDynamicResultByIdnCokeDynamicResultIdnCokeDynamicResultnCokeDynamicIdnCokeDynamicnCokeCompositeMasterIdnCokeCompositeMasternCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(Id, CokeDynamicResultId, CokeDynamicResult, CokeDynamicId, CokeDynamic, CokeCompositeMasterId, CokeCompositeMaster, CokeTypeId, CokeType, CokeSupplierId, CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public DataTable GetCokeDynamicResultDetail()
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                dt = objBL_CokeDynamicResult.GetCokeDynamicResult();
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultById(long Id)
        {
            ML_CokeDynamicResult objML_CokeDynamicResult = new ML_CokeDynamicResult();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                objML_CokeDynamicResult = objBL_CokeDynamicResult.GetCokeDynamicResultById(Id);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByCokeDynamicResultId(long CokeDynamicResultId)
        {
            ML_CokeDynamicResult objML_CokeDynamicResult = new ML_CokeDynamicResult();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                objML_CokeDynamicResult = objBL_CokeDynamicResult.GetCokeDynamicResultByCokeDynamicResultId(CokeDynamicResultId);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByCokeDynamicResult(long CokeDynamicResult)
        {
            ML_CokeDynamicResult objML_CokeDynamicResult = new ML_CokeDynamicResult();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                objML_CokeDynamicResult = objBL_CokeDynamicResult.GetCokeDynamicResultByCokeDynamicResult(CokeDynamicResult);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByCokeDynamicId(long CokeDynamicId)
        {
            ML_CokeDynamicResult objML_CokeDynamicResult = new ML_CokeDynamicResult();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                objML_CokeDynamicResult = objBL_CokeDynamicResult.GetCokeDynamicResultByCokeDynamicId(CokeDynamicId);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByCokeDynamic(long CokeDynamic)
        {
            ML_CokeDynamicResult objML_CokeDynamicResult = new ML_CokeDynamicResult();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                objML_CokeDynamicResult = objBL_CokeDynamicResult.GetCokeDynamicResultByCokeDynamic(CokeDynamic);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByCokeCompositeMasterId(long CokeCompositeMasterId)
        {
            ML_CokeDynamicResult objML_CokeDynamicResult = new ML_CokeDynamicResult();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                objML_CokeDynamicResult = objBL_CokeDynamicResult.GetCokeDynamicResultByCokeCompositeMasterId(CokeCompositeMasterId);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByCokeCompositeMaster(long CokeCompositeMaster)
        {
            ML_CokeDynamicResult objML_CokeDynamicResult = new ML_CokeDynamicResult();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                objML_CokeDynamicResult = objBL_CokeDynamicResult.GetCokeDynamicResultByCokeCompositeMaster(CokeCompositeMaster);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByCokeTypeId(long CokeTypeId)
        {
            ML_CokeDynamicResult objML_CokeDynamicResult = new ML_CokeDynamicResult();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                objML_CokeDynamicResult = objBL_CokeDynamicResult.GetCokeDynamicResultByCokeTypeId(CokeTypeId);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByCokeType(long CokeType)
        {
            ML_CokeDynamicResult objML_CokeDynamicResult = new ML_CokeDynamicResult();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                objML_CokeDynamicResult = objBL_CokeDynamicResult.GetCokeDynamicResultByCokeType(CokeType);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByCokeSupplierId(long CokeSupplierId)
        {
            ML_CokeDynamicResult objML_CokeDynamicResult = new ML_CokeDynamicResult();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                objML_CokeDynamicResult = objBL_CokeDynamicResult.GetCokeDynamicResultByCokeSupplierId(CokeSupplierId);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByCokeSupplier(long CokeSupplier)
        {
            ML_CokeDynamicResult objML_CokeDynamicResult = new ML_CokeDynamicResult();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                objML_CokeDynamicResult = objBL_CokeDynamicResult.GetCokeDynamicResultByCokeSupplier(CokeSupplier);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByAnalysisTypeId(long AnalysisTypeId)
        {
            ML_CokeDynamicResult objML_CokeDynamicResult = new ML_CokeDynamicResult();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                objML_CokeDynamicResult = objBL_CokeDynamicResult.GetCokeDynamicResultByAnalysisTypeId(AnalysisTypeId);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByAnalysisType(long AnalysisType)
        {
            ML_CokeDynamicResult objML_CokeDynamicResult = new ML_CokeDynamicResult();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                objML_CokeDynamicResult = objBL_CokeDynamicResult.GetCokeDynamicResultByAnalysisType(AnalysisType);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamicResult;
        }


        public ML_CokeDynamicResult GetCokeDynamicResultByIdnCokeDynamicResultIdnCokeDynamicResultnCokeDynamicIdnCokeDynamicnCokeCompositeMasterIdnCokeCompositeMasternCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long Id, int CokeDynamicResultId, int CokeDynamicResult, int CokeDynamicId, int CokeDynamic, int CokeCompositeMasterId, int CokeCompositeMaster, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        {
            ML_CokeDynamicResult objML_CokeDynamicResult = new ML_CokeDynamicResult();
             DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                objML_CokeDynamicResult = objBL_CokeDynamicResult.GetCokeDynamicResultByIdnCokeDynamicResultIdnCokeDynamicResultnCokeDynamicIdnCokeDynamicnCokeCompositeMasterIdnCokeCompositeMasternCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(Id, CokeDynamicResultId, CokeDynamicResult, CokeDynamicId, CokeDynamic, CokeCompositeMasterId, CokeCompositeMaster, CokeTypeId, CokeType, CokeSupplierId, CokeSupplier, AnalysisTypeId, AnalysisType);
            }
            catch
            {
                throw;
            }
            return objML_CokeDynamicResult;
        }


        public DataTable GetCokeDynamicResultByIdDs(long Id)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                dt = objBL_CokeDynamicResult.GetCokeDynamicResultByIdDs(Id);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicResultByCokeDynamicResultIdDs(long CokeDynamicResultId)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                dt = objBL_CokeDynamicResult.GetCokeDynamicResultByCokeDynamicResultIdDs(CokeDynamicResultId);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicResultByCokeDynamicResultDs(long CokeDynamicResult)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                dt = objBL_CokeDynamicResult.GetCokeDynamicResultByCokeDynamicResultDs(CokeDynamicResult);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicResultByCokeDynamicIdDs(long CokeDynamicId)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                dt = objBL_CokeDynamicResult.GetCokeDynamicResultByCokeDynamicIdDs(CokeDynamicId);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicResultByCokeDynamicDs(long CokeDynamic)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                dt = objBL_CokeDynamicResult.GetCokeDynamicResultByCokeDynamicDs(CokeDynamic);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicResultByCokeCompositeMasterIdDs(long CokeCompositeMasterId)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                dt = objBL_CokeDynamicResult.GetCokeDynamicResultByCokeCompositeMasterIdDs(CokeCompositeMasterId);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicResultByCokeCompositeMasterDs(long CokeCompositeMaster)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                dt = objBL_CokeDynamicResult.GetCokeDynamicResultByCokeCompositeMasterDs(CokeCompositeMaster);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicResultByCokeTypeIdDs(long CokeTypeId)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                dt = objBL_CokeDynamicResult.GetCokeDynamicResultByCokeTypeIdDs(CokeTypeId);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicResultByCokeTypeDs(long CokeType)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                dt = objBL_CokeDynamicResult.GetCokeDynamicResultByCokeTypeDs(CokeType);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicResultByCokeSupplierIdDs(long CokeSupplierId)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                dt = objBL_CokeDynamicResult.GetCokeDynamicResultByCokeSupplierIdDs(CokeSupplierId);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicResultByCokeSupplierDs(long CokeSupplier)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                dt = objBL_CokeDynamicResult.GetCokeDynamicResultByCokeSupplierDs(CokeSupplier);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicResultByAnalysisTypeIdDs(long AnalysisTypeId)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                dt = objBL_CokeDynamicResult.GetCokeDynamicResultByAnalysisTypeIdDs(AnalysisTypeId);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicResultByAnalysisTypeDs(long AnalysisType)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                dt = objBL_CokeDynamicResult.GetCokeDynamicResultByAnalysisTypeDs(AnalysisType);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        //public DataTable GetCokeDynamicResultByIdnCokeDynamicResultIdnCokeDynamicResultnCokeDynamicIdnCokeDynamicnCPCokeIdnCPCokeNamenCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long Id, int CokeDynamicResultId, int CokeDynamicResult, int CokeDynamicId, int CokeDynamic, int CokeCompositeMasterId, int CokeCompositeMaster, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType)
        //{
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
        //        dt = objBL_CokeDynamicResult.GetCokeDynamicResultByIdnCokeDynamicResultIdnCokeDynamicResultnCokeDynamicIdnCokeDynamicnCokeCompositeMasterIdnCokeCompositeMasternCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(Id, CokeDynamicResultId, CokeDynamicResult, CokeDynamicId, CokeDynamic, CokeCompositeMasterId, CokeCompositeMaster, CokeTypeId, CokeType, CokeSupplierId, CokeSupplier, AnalysisTypeId, AnalysisType);
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    return dt;
        //}


        public DataTable GetCokeDynamicResultByLoginName(string loginName)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                dt = objBL_CokeDynamicResult.GetCokeDynamicResultByLoginName(loginName);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeDynamicResultBySeacrh(ML_CokeDynamicResult objML_CokeDynamicResult)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeDynamicResult objBL_CokeDynamicResult = new BL_CokeDynamicResult();
                dt = objBL_CokeDynamicResult.GetCokeDynamicResultBySeacrh(objML_CokeDynamicResult);
            }
            catch
            {
                throw;
            }
            return dt;
        }
        #endregion

        #region  IClass Business For tblCokeType
        public int AddCokeType(ML_CokeType objML_CokeType)
        {
            int intReturn = 0;
            DataTable dt = new DataTable();
            try
            {
                BL_CokeType objBL_CokeType = new BL_CokeType();
                intReturn = objBL_CokeType.Add(objML_CokeType);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int UpdateCokeType(ML_CokeType objML_CokeType)
        {
            int intReturn = 0;
            DataTable dt = new DataTable();
            try
            {
                BL_CokeType objBL_CokeType = new BL_CokeType();
                intReturn = objBL_CokeType.Update(objML_CokeType);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int UpdateUniqueCokeType(ML_CokeType objML_CokeType)
        {
            int intReturn = 0;
            DataTable dt = new DataTable();
            try
            {
                BL_CokeType objBL_CokeType = new BL_CokeType();
                intReturn = objBL_CokeType.UpdateUnique(objML_CokeType);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeType(int CokeTypeId)
        {
            int intReturn = 0;
            DataTable dt = new DataTable();
            try
            {
                BL_CokeType objBL_CokeType = new BL_CokeType();
                intReturn = objBL_CokeType.Delete(CokeTypeId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeTypeById(int Id)
        {
            int intReturn = 0;
            DataTable dt = new DataTable();
            try
            {
                BL_CokeType objBL_CokeType = new BL_CokeType();
                intReturn = objBL_CokeType.DeleteCokeTypeById(Id);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeTypeByCokeTypeId(int CokeTypeId)
        {
            int intReturn = 0;
            DataTable dt = new DataTable();
            try
            {
                BL_CokeType objBL_CokeType = new BL_CokeType();
                intReturn = objBL_CokeType.DeleteCokeTypeByCokeTypeId(CokeTypeId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public DataSet GetCokeTypeDetail()
        {
            DataSet ds = null;
            try
            {
                BL_CokeType objBL_CokeType = new BL_CokeType();
                ds = objBL_CokeType.GetCokeType();
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public ML_CokeType GetCokeTypeById(int Id)
        {
            ML_CokeType objML_CokeType = new ML_CokeType();
            DataTable dt = new DataTable();
            try
            {
                BL_CokeType objBL_CokeType = new BL_CokeType();
                objML_CokeType = objBL_CokeType.GetCokeTypeById(Id);
            }
            catch
            {
                throw;
            }
            return objML_CokeType;
        }


        public ML_CokeType GetCokeTypeByCokeTypeId(int CokeTypeId)
        {
            ML_CokeType objML_CokeType = new ML_CokeType();
            DataTable dt = new DataTable();
            try
            {
                BL_CokeType objBL_CokeType = new BL_CokeType();
                objML_CokeType = objBL_CokeType.GetCokeTypeByCokeTypeId(CokeTypeId);
            }
            catch
            {
                throw;
            }
            return objML_CokeType;
        }


        public DataTable GetCokeTypeByIdDs(int Id)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeType objBL_CokeType = new BL_CokeType();
                dt = objBL_CokeType.GetCokeTypeByIdDs(Id);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeTypeByCokeTypeIdDs(int CokeTypeId)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeType objBL_CokeType = new BL_CokeType();
                dt = objBL_CokeType.GetCokeTypeByCokeTypeIdDs(CokeTypeId);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeTypeByLoginName(string loginName)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeType objBL_CokeType = new BL_CokeType();
                dt = objBL_CokeType.GetCokeTypeByLoginName(loginName);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeTypeBySeacrh(ML_CokeType objML_CokeType)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeType objBL_CokeType = new BL_CokeType();
                dt = objBL_CokeType.GetCokeTypeBySeacrh(objML_CokeType);
            }
            catch
            {
                throw;
            }
            return dt;
        }
        #endregion

        #region  IClass Business For tblCokeSupplier
        public int AddCokeSupplier(ML_CokeSupplier objML_CokeSupplier)
        {
            int intReturn = 0;
            DataTable dt = new DataTable();
            try
            {
                BL_CokeSupplier objBL_CokeSupplier = new BL_CokeSupplier();
                intReturn = objBL_CokeSupplier.Add(objML_CokeSupplier);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int UpdateCokeSupplier(ML_CokeSupplier objML_CokeSupplier)
        {
            int intReturn = 0;
            DataTable dt = new DataTable();
            try
            {
                BL_CokeSupplier objBL_CokeSupplier = new BL_CokeSupplier();
                intReturn = objBL_CokeSupplier.Update(objML_CokeSupplier);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int UpdateUniqueCokeSupplier(ML_CokeSupplier objML_CokeSupplier)
        {
            int intReturn = 0;
            DataTable dt = new DataTable();
            try
            {
                BL_CokeSupplier objBL_CokeSupplier = new BL_CokeSupplier();
                intReturn = objBL_CokeSupplier.UpdateUnique(objML_CokeSupplier);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeSupplier(int CokeSupplierId)
        {
            int intReturn = 0;
            DataTable dt = new DataTable();
            try
            {
                BL_CokeSupplier objBL_CokeSupplier = new BL_CokeSupplier();
                intReturn = objBL_CokeSupplier.Delete(CokeSupplierId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeSupplierById(int Id)
        {
            int intReturn = 0;
            DataTable dt = new DataTable();
            try
            {
                BL_CokeSupplier objBL_CokeSupplier = new BL_CokeSupplier();
                intReturn = objBL_CokeSupplier.DeleteCokeSupplierById(Id);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCokeSupplierByCokeSupplierId(int CokeSupplierId)
        {
            int intReturn = 0;
            DataTable dt = new DataTable();
            try
            {
                BL_CokeSupplier objBL_CokeSupplier = new BL_CokeSupplier();
                intReturn = objBL_CokeSupplier.DeleteCokeSupplierByCokeSupplierId(CokeSupplierId);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public DataTable GetCokeSupplierDetail()
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeSupplier objBL_CokeSupplier = new BL_CokeSupplier();
                dt = objBL_CokeSupplier.GetCokeSupplier();
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public ML_CokeSupplier GetCokeSupplierById(int Id)
        {
            ML_CokeSupplier objML_CokeSupplier = new ML_CokeSupplier();
            DataTable dt = new DataTable();
            try
            {
                BL_CokeSupplier objBL_CokeSupplier = new BL_CokeSupplier();
                objML_CokeSupplier = objBL_CokeSupplier.GetCokeSupplierById(Id);
            }
            catch
            {
                throw;
            }
            return objML_CokeSupplier;
        }


        public ML_CokeSupplier GetCokeSupplierByCokeSupplierId(int CokeSupplierId)
        {
            ML_CokeSupplier objML_CokeSupplier = new ML_CokeSupplier();
            DataTable dt = new DataTable();
            try
            {
                BL_CokeSupplier objBL_CokeSupplier = new BL_CokeSupplier();
                objML_CokeSupplier = objBL_CokeSupplier.GetCokeSupplierByCokeSupplierId(CokeSupplierId);
            }
            catch
            {
                throw;
            }
            return objML_CokeSupplier;
        }


        public DataTable GetCokeSupplierByIdDs(int Id)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeSupplier objBL_CokeSupplier = new BL_CokeSupplier();
                dt = objBL_CokeSupplier.GetCokeSupplierByIdDs(Id);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeSupplierByCokeSupplierIdDs(int CokeSupplierId)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeSupplier objBL_CokeSupplier = new BL_CokeSupplier();
                dt = objBL_CokeSupplier.GetCokeSupplierByCokeSupplierIdDs(CokeSupplierId);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeSupplierByLoginName(string loginName)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeSupplier objBL_CokeSupplier = new BL_CokeSupplier();
                dt = objBL_CokeSupplier.GetCokeSupplierByLoginName(loginName);
            }
            catch
            {
                throw;
            }
            return dt;
        }


        public DataTable GetCokeSupplierBySeacrh(ML_CokeSupplier objML_CokeSupplier)
        {
            DataTable dt = new DataTable();
            try
            {
                BL_CokeSupplier objBL_CokeSupplier = new BL_CokeSupplier();
                dt = objBL_CokeSupplier.GetCokeSupplierBySeacrh(objML_CokeSupplier);
            }
            catch
            {
                throw;
            }
            return dt;
        }
        #endregion

        #region  IClass Business For tblCategoryGroupMaster
        public int AddCategoryGroupMaster(ML_CategoryGroupMaster objML_CategoryGroupMaster)
        {
            int intReturn = 0;
            try
            {
                BL_CategoryGroupMaster objBL_CategoryGroupMaster = new BL_CategoryGroupMaster();
                intReturn = objBL_CategoryGroupMaster.Add(objML_CategoryGroupMaster);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int UpdateCategoryGroupMaster(ML_CategoryGroupMaster objML_CategoryGroupMaster)
        {
            int intReturn = 0;
            try
            {
                BL_CategoryGroupMaster objBL_CategoryGroupMaster = new BL_CategoryGroupMaster();
                intReturn = objBL_CategoryGroupMaster.Update(objML_CategoryGroupMaster);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int UpdateUniqueCategoryGroupMaster(ML_CategoryGroupMaster objML_CategoryGroupMaster)
        {
            int intReturn = 0;
            try
            {
                BL_CategoryGroupMaster objBL_CategoryGroupMaster = new BL_CategoryGroupMaster();
                intReturn = objBL_CategoryGroupMaster.UpdateUnique(objML_CategoryGroupMaster);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        //public int DeleteCategoryGroupMaster(long CategoryGroupMasterId)
        //{
        //    int intReturn = 0;
        //    try
        //    {
        //        BL_CategoryGroupMaster objBL_CategoryGroupMaster = new BL_CategoryGroupMaster();
        //        intReturn = objBL_CategoryGroupMaster.Delete(CategoryGroupMasterId);
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    return intReturn;
        //}


        public int DeleteCategoryGroupMasterByCategoryGroupCode(long CategoryGroupCode)
        {
            int intReturn = 0;
            try
            {
                BL_CategoryGroupMaster objBL_CategoryGroupMaster = new BL_CategoryGroupMaster();
                intReturn = objBL_CategoryGroupMaster.DeleteCategoryGroupMasterByCategoryGroupCode(CategoryGroupCode);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCategoryGroupMasterByCanteenCode(long CanteenCode)
        {
            int intReturn = 0;
            try
            {
                BL_CategoryGroupMaster objBL_CategoryGroupMaster = new BL_CategoryGroupMaster();
                intReturn = objBL_CategoryGroupMaster.DeleteCategoryGroupMasterByCanteenCode(CanteenCode);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCategoryGroupMasterByCategoryGroupName(long CategoryGroupName)
        {
            int intReturn = 0;
            try
            {
                BL_CategoryGroupMaster objBL_CategoryGroupMaster = new BL_CategoryGroupMaster();
                intReturn = objBL_CategoryGroupMaster.DeleteCategoryGroupMasterByCategoryGroupName(CategoryGroupName);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public int DeleteCategoryGroupMasterByCategoryGroupActive(long CategoryGroupActive)
        {
            int intReturn = 0;
            try
            {
                BL_CategoryGroupMaster objBL_CategoryGroupMaster = new BL_CategoryGroupMaster();
                intReturn = objBL_CategoryGroupMaster.DeleteCategoryGroupMasterByCategoryGroupActive(CategoryGroupActive);
            }
            catch
            {
                throw;
            }
            return intReturn;
        }


        public DataSet GetCategoryGroupMasterDetail()
        {
            DataSet ds = null;
            try
            {
                BL_CategoryGroupMaster objBL_CategoryGroupMaster = new BL_CategoryGroupMaster();
                ds = objBL_CategoryGroupMaster.GetCategoryGroupMaster();
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public ML_CategoryGroupMaster GetCategoryGroupMasterByCategoryGroupCode(long CategoryGroupCode)
        {
            ML_CategoryGroupMaster objML_CategoryGroupMaster = new ML_CategoryGroupMaster();
            try
            {
                BL_CategoryGroupMaster objBL_CategoryGroupMaster = new BL_CategoryGroupMaster();
                objML_CategoryGroupMaster = objBL_CategoryGroupMaster.GetCategoryGroupMasterByCategoryGroupCode(CategoryGroupCode);
            }
            catch
            {
                throw;
            }
            return objML_CategoryGroupMaster;
        }


        public ML_CategoryGroupMaster GetCategoryGroupMasterByCanteenCode(long CanteenCode)
        {
            ML_CategoryGroupMaster objML_CategoryGroupMaster = new ML_CategoryGroupMaster();
            try
            {
                BL_CategoryGroupMaster objBL_CategoryGroupMaster = new BL_CategoryGroupMaster();
                objML_CategoryGroupMaster = objBL_CategoryGroupMaster.GetCategoryGroupMasterByCanteenCode(CanteenCode);
            }
            catch
            {
                throw;
            }
            return objML_CategoryGroupMaster;
        }


        public ML_CategoryGroupMaster GetCategoryGroupMasterByCategoryGroupName(long CategoryGroupName)
        {
            ML_CategoryGroupMaster objML_CategoryGroupMaster = new ML_CategoryGroupMaster();
            try
            {
                BL_CategoryGroupMaster objBL_CategoryGroupMaster = new BL_CategoryGroupMaster();
                objML_CategoryGroupMaster = objBL_CategoryGroupMaster.GetCategoryGroupMasterByCategoryGroupName(CategoryGroupName);
            }
            catch
            {
                throw;
            }
            return objML_CategoryGroupMaster;
        }


        public ML_CategoryGroupMaster GetCategoryGroupMasterByCategoryGroupActive(long CategoryGroupActive)
        {
            ML_CategoryGroupMaster objML_CategoryGroupMaster = new ML_CategoryGroupMaster();
            try
            {
                BL_CategoryGroupMaster objBL_CategoryGroupMaster = new BL_CategoryGroupMaster();
                objML_CategoryGroupMaster = objBL_CategoryGroupMaster.GetCategoryGroupMasterByCategoryGroupActive(CategoryGroupActive);
            }
            catch
            {
                throw;
            }
            return objML_CategoryGroupMaster;
        }


        public DataSet GetCategoryGroupMasterByCategoryGroupCodeDs(long CategoryGroupCode)
        {
            DataSet ds = null;
            try
            {
                BL_CategoryGroupMaster objBL_CategoryGroupMaster = new BL_CategoryGroupMaster();
                ds = objBL_CategoryGroupMaster.GetCategoryGroupMasterByCategoryGroupCodeDs(CategoryGroupCode);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetCategoryGroupMasterByCanteenCodeDs(long CanteenCode)
        {
            DataSet ds = null;
            try
            {
                BL_CategoryGroupMaster objBL_CategoryGroupMaster = new BL_CategoryGroupMaster();
                ds = objBL_CategoryGroupMaster.GetCategoryGroupMasterByCanteenCodeDs(CanteenCode);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetCategoryGroupMasterByCategoryGroupNameDs(long CategoryGroupName)
        {
            DataSet ds = null;
            try
            {
                BL_CategoryGroupMaster objBL_CategoryGroupMaster = new BL_CategoryGroupMaster();
                ds = objBL_CategoryGroupMaster.GetCategoryGroupMasterByCategoryGroupNameDs(CategoryGroupName);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetCategoryGroupMasterByCategoryGroupActiveDs(long CategoryGroupActive)
        {
            DataSet ds = null;
            try
            {
                BL_CategoryGroupMaster objBL_CategoryGroupMaster = new BL_CategoryGroupMaster();
                ds = objBL_CategoryGroupMaster.GetCategoryGroupMasterByCategoryGroupActiveDs(CategoryGroupActive);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetCategoryGroupMasterByLoginName(string loginName)
        {
            DataSet ds = null;
            try
            {
                BL_CategoryGroupMaster objBL_CategoryGroupMaster = new BL_CategoryGroupMaster();
                ds = objBL_CategoryGroupMaster.GetCategoryGroupMasterByLoginName(loginName);
            }
            catch
            {
                throw;
            }
            return ds;
        }


        public DataSet GetCategoryGroupMasterBySeacrh(ML_CategoryGroupMaster objML_CategoryGroupMaster)
        {
            DataSet ds = null;
            try
            {
                BL_CategoryGroupMaster objBL_CategoryGroupMaster = new BL_CategoryGroupMaster();
                ds = objBL_CategoryGroupMaster.GetCategoryGroupMasterBySeacrh(objML_CategoryGroupMaster);
            }
            catch
            {
                throw;
            }
            return ds;
        }
        #endregion


        
        
        #endregion
        

        #region TM
       



       




        #endregion
    }
}
