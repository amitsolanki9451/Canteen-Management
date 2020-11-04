
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ModelLayer;

namespace BusinessLayer
{
   
    partial interface IBusinessClass
    {
        #region Managed By Amit Singh Solanki

        #region IClass  For tblUserName
        int AddUserName(ML_UserName objML_UserName);
        int UpdateUserName(ML_UserName objML_UserName);
        int UpdateUniqueUserName(ML_UserName objML_UserName);
        int DeleteUserName(int Id);
        int DeleteUserNameById(int Id);
        int DeleteUserNameByUserNameId(int UserNameId);
        int DeleteUserNameByUserName(string UserName);
        int DeleteUserNameByEmail(string Email);
        int DeleteUserNameByUserTypeId(int UserTypeId);
        int DeleteUserNameByUserType(string UserType);
        int DeleteUserNameByReTryAttempt(int ReTryAttempt);
        int DeleteUserNameByIsLocked(int IsLocked);
        int DeleteUserNameByLockedDateTime(DateTime LockedDateTime);
        int DeleteUserNameByUserNamenEmailnPassword(string UserName, string Email, string Password);
        int DeleteUserNameByUserNamenEmail(string UserName, string Email);
        int DeleteUserNameByEmailnPassword(string Email, string Password);
        ML_UserName GetUserNameById(int Id);
        ML_UserName GetUserNameByUserNameId(int UserNameId);
        ML_UserName GetUserNameByUserName(string UserName);
        ML_UserName GetUserNameByEmail(string Email);
        ML_UserName GetUserNameByUserTypeId(int UserTypeId);
        ML_UserName GetUserNameByUserType(string UserType);
        ML_UserName GetUserNameByReTryAttempt(int ReTryAttempt);
        ML_UserName GetUserNameByIsLocked(int IsLocked);
        ML_UserName GetUserNameByLockedDateTime(DateTime LockedDateTime);
        ML_UserName GetUserNameByUserNamenEmailnPassword(string UserName, string Email, string Password);
        ML_UserName GetUserNameByUserNamenEmail(string UserName, string Email);
        ML_UserName GetUserNameByEmailnPassword(string Email, string Password);
        DataTable GetUserNameDetail();
        DataTable GetUserNameByIdDs(int Id);
        DataTable GetUserNameByUserNameIdDs(int UserNameId);
        DataTable GetUserNameByUserNameDs(string UserName);
        DataTable GetUserNameByEmailDs(string Email);
        DataTable GetUserNameByUserTypeIdDs(int UserTypeId);
        DataTable GetUserNameByUserTypeDs(string UserType);
        DataTable GetUserNameByReTryAttemptDs(int ReTryAttempt);
        DataTable GetUserNameByIsLockedDs(int IsLocked);
        DataTable GetUserNameByLockedDateTimeDs(DateTime LockedDateTime);
        DataTable GetUserNameByUserNamenEmailnPasswordDs(string UserName, string Email, string Password);
        DataTable GetUserNameByUserNamenEmailDs(string UserName, string Email);
        DataTable GetUserNameByEmailnPasswordDs(string Email, string Password);
        DataTable GetUserNameByLoginName(string loginName);
        DataTable GetUserNameBySeacrh(ML_UserName objML_UserName);

        int GetAuthenticateUser(string UserName, string Password);
        int UpdatePassword(string UserName, string OldPassword, string NewPassword);
        ML_UserName GetUserNameByUserNamenPassword(string UserName, string Password);

        ML_UserName GetUserDetailsByLoginId(string UserName, string Password);







        #endregion 

        #region IClass  For tblUserType
        int AddUserType(ML_UserType objML_UserType);
        int UpdateUserType(ML_UserType objML_UserType);
        int UpdateUniqueUserType(ML_UserType objML_UserType);
        int DeleteUserType(int Id);
        int DeleteUserTypeById(int Id);
        int DeleteUserTypeByUserTypeId(int UserTypeId);
        int DeleteUserTypeByUserType(string UserType);
        ML_UserType GetUserTypeById(int Id);
        ML_UserType GetUserTypeByUserTypeId(int UserTypeId);
        ML_UserType GetUserTypeByUserType(string UserType);
        DataTable GetUserTypeDetail();
        DataTable GetUserTypeByIdDs(int Id);
        DataTable GetUserTypeByUserTypeIdDs(int UserTypeId);
        DataTable GetUserTypeByUserTypeDs(string UserType);
        DataTable GetUserTypeByLoginName(string loginName);
        DataTable GetUserTypeBySeacrh(ML_UserType objML_UserType);
        #endregion


        #region IClass  For tblItemMaster
        int AddItemMaster(ML_ItemMaster objML_ItemMaster);
        int UpdateItemMaster(ML_ItemMaster objML_ItemMaster);
        int UpdateUniqueItemMaster(ML_ItemMaster objML_ItemMaster);
        int DeleteItemMaster(long Id);
        int DeleteItemMasterByItemCode(long ItemCode);
        int DeleteItemMasterByCanteenCode(long CanteenCode);
        int DeleteItemMasterByCategoryGroupCode(long CategoryGroupCode);
        int DeleteItemMasterByItemCategoryCode(long ItemCategoryCode);
        int DeleteItemMasterByItemName(long ItemName);
        int DeleteItemMasterByItemEmployeeRate(long ItemEmployeeRate);
        int DeleteItemMasterByItemActive(long ItemActive);
        int DeleteItemMasterByItemImage(long ItemImage);
        ML_ItemMaster GetItemMasterByItemCode(long ItemCode);
        ML_ItemMaster GetItemMasterByCanteenCode(long CanteenCode);
        ML_ItemMaster GetItemMasterByCategoryGroupCode(long CategoryGroupCode);
        ML_ItemMaster GetItemMasterByItemCategoryCode(long ItemCategoryCode);
        ML_ItemMaster GetItemMasterByItemName(long ItemName);
        ML_ItemMaster GetItemMasterByItemEmployeeRate(long ItemEmployeeRate);
        ML_ItemMaster GetItemMasterByItemActive(long ItemActive);
        ML_ItemMaster GetItemMasterByItemImage(long ItemImage);
        DataSet GetItemMasterDetail();
        DataSet GetItemMasterByItemCodeDs(long ItemCode);
        DataSet GetItemMasterByCanteenCodeDs(long CanteenCode);
        DataSet GetItemMasterByCategoryGroupCodeDs(long CategoryGroupCode);
        DataSet GetItemMasterByItemCategoryCodeDs(long ItemCategoryCode);
        DataSet GetItemMasterByItemNameDs(long ItemName);
        DataSet GetItemMasterByItemEmployeeRateDs(long ItemEmployeeRate);
        DataSet GetItemMasterByItemActiveDs(long ItemActive);
        DataSet GetItemMasterByItemImageDs(long ItemImage);
        DataSet GetItemMasterByLoginName(string loginName);
        DataSet GetItemMasterBySeacrh(ML_ItemMaster objML_ItemMaster);
        #endregion

        #region IClass  For tblItemCategoryMaster
        int AddItemCategoryMaster(ML_ItemCategoryMaster objML_ItemCategoryMaster);
        int UpdateItemCategoryMaster(ML_ItemCategoryMaster objML_ItemCategoryMaster);
        int UpdateUniqueItemCategoryMaster(ML_ItemCategoryMaster objML_ItemCategoryMaster);
        int DeleteItemCategoryMaster(long Id);
        int DeleteItemCategoryMasterByItemCategoryCode(long ItemCategoryCode);
        ML_ItemCategoryMaster GetItemCategoryMasterByItemCategoryCode(long ItemCategoryCode);
        ML_ItemCategoryMaster GetItemCategoryMasterByCanteenCode(long CanteenCode);
        ML_ItemCategoryMaster GetItemCategoryMasterByCategoryGroupCode(long CategoryGroupCode);
        ML_ItemCategoryMaster GetItemCategoryMasterByItemCategoryName(long ItemCategoryName);
        ML_ItemCategoryMaster GetItemCategoryMasterByItemCategoryActive(long ItemCategoryActive);
        ML_ItemCategoryMaster GetItemCategoryMasterByStartTime(long StartTime);
        ML_ItemCategoryMaster GetItemCategoryMasterByEndTime(long EndTime);
        DataSet GetItemCategoryMasterDetail();
        DataSet GetItemCategoryMasterByItemCategoryCodeDs(long ItemCategoryCode);
        DataSet GetItemCategoryMasterByCanteenCodeDs(long CanteenCode);
        DataSet GetItemCategoryMasterByCategoryGroupCodeDs(long CategoryGroupCode);
        DataSet GetItemCategoryMasterByItemCategoryNameDs(long ItemCategoryName);
        DataSet GetItemCategoryMasterByItemCategoryActiveDs(long ItemCategoryActive);
        DataSet GetItemCategoryMasterByStartTimeDs(long StartTime);
        DataSet GetItemCategoryMasterByEndTimeDs(long EndTime);
        DataSet GetItemCategoryMasterByLoginName(string loginName);
        DataSet GetItemCategoryMasterBySeacrh(ML_ItemCategoryMaster objML_ItemCategoryMaster);
        #endregion

        #region IClass  For tblCokeType
        int AddCokeType(ML_CokeType objML_CokeType);
        int UpdateCokeType(ML_CokeType objML_CokeType);
        int UpdateUniqueCokeType(ML_CokeType objML_CokeType);
        int DeleteCokeType(int Id);
        int DeleteCokeTypeById(int Id);
        int DeleteCokeTypeByCokeTypeId(int CokeTypeId);
        ML_CokeType GetCokeTypeById(int Id);
        ML_CokeType GetCokeTypeByCokeTypeId(int CokeTypeId);
        DataSet GetCokeTypeDetail();
        DataTable GetCokeTypeByIdDs(int Id);
        DataTable GetCokeTypeByCokeTypeIdDs(int CokeTypeId);
        DataTable GetCokeTypeByLoginName(string loginName);
        DataTable GetCokeTypeBySeacrh(ML_CokeType objML_CokeType);
        #endregion


        #region IClass  For tblCokeSupplier
        int AddCokeSupplier(ML_CokeSupplier objML_CokeSupplier);
        int UpdateCokeSupplier(ML_CokeSupplier objML_CokeSupplier);
        int UpdateUniqueCokeSupplier(ML_CokeSupplier objML_CokeSupplier);
        int DeleteCokeSupplier(int Id);
        int DeleteCokeSupplierById(int Id);
        int DeleteCokeSupplierByCokeSupplierId(int CokeSupplierId);
        ML_CokeSupplier GetCokeSupplierById(int Id);
        ML_CokeSupplier GetCokeSupplierByCokeSupplierId(int CokeSupplierId);
        DataTable GetCokeSupplierDetail();
        DataTable GetCokeSupplierByIdDs(int Id);
        DataTable GetCokeSupplierByCokeSupplierIdDs(int CokeSupplierId);
        DataTable GetCokeSupplierByLoginName(string loginName);
        DataTable GetCokeSupplierBySeacrh(ML_CokeSupplier objML_CokeSupplier);
        #endregion

        #region IClass  For tblCokeDynamic
        int AddCokeDynamic(ML_CokeDynamic objML_CokeDynamic);
        int UpdateCokeDynamic(ML_CokeDynamic objML_CokeDynamic);
        int UpdateUniqueCokeDynamic(ML_CokeDynamic objML_CokeDynamic);
        int DeleteCokeDynamic(long Id);
        int DeleteCokeDynamicById(long Id);
        int DeleteCokeDynamicByCokeDynamicId(long CokeDynamicId);
        int DeleteCokeDynamicByCokeDynamic(long CokeDynamic);
        int DeleteCokeDynamicByCokeTypeId(long CokeTypeId);
        int DeleteCokeDynamicByCokeType(long CokeType);
        int DeleteCokeDynamicByCokeSupplierId(long CokeSupplierId);
        int DeleteCokeDynamicByCokeSupplier(long CokeSupplier);
        int DeleteCokeDynamicByAnalysisTypeId(long AnalysisTypeId);
        int DeleteCokeDynamicByAnalysisType(long AnalysisType);
        int DeleteCokeDynamicByIdnCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long Id, int CokeDynamicId, int CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType);
        int DeleteCokeDynamicByCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeDynamicId, int CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType);
        int DeleteCokeDynamicByCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType);
        int DeleteCokeDynamicByCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType);
        int DeleteCokeDynamicByCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType);
        int DeleteCokeDynamicByCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType);
        int DeleteCokeDynamicByCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeSupplier, int AnalysisTypeId, int AnalysisType);
        int DeleteCokeDynamicByAnalysisTypeIdnAnalysisType(long AnalysisTypeId, int AnalysisType);
        ML_CokeDynamic GetCokeDynamicById(long Id);
        ML_CokeDynamic GetCokeDynamicByCokeDynamicId(long CokeDynamicId);
        ML_CokeDynamic GetCokeDynamicByCokeDynamic(long CokeDynamic);
        ML_CokeDynamic GetCokeDynamicByCokeTypeId(long CokeTypeId);
        ML_CokeDynamic GetCokeDynamicByCokeType(long CokeType);
        ML_CokeDynamic GetCokeDynamicByCokeSupplierId(long CokeSupplierId);
        ML_CokeDynamic GetCokeDynamicByCokeSupplier(long CokeSupplier);
        ML_CokeDynamic GetCokeDynamicByAnalysisTypeId(long AnalysisTypeId);
        ML_CokeDynamic GetCokeDynamicByAnalysisType(long AnalysisType);
        ML_CokeDynamic GetCokeDynamicByIdnCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long Id, int CokeDynamicId, int CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType);
        ML_CokeDynamic GetCokeDynamicByCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeDynamicId, int CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType);
        ML_CokeDynamic GetCokeDynamicByCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType);
        ML_CokeDynamic GetCokeDynamicByCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType);
        ML_CokeDynamic GetCokeDynamicByCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType);
        ML_CokeDynamic GetCokeDynamicByCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType);
        ML_CokeDynamic GetCokeDynamicByCokeSuppliernAnalysisTypeIdnAnalysisType(long CokeSupplier, int AnalysisTypeId, int AnalysisType);
        ML_CokeDynamic GetCokeDynamicByAnalysisTypeIdnAnalysisType(long AnalysisTypeId, int AnalysisType);
        DataTable GetCokeDynamicDetail();
        DataTable GetCokeDynamicByIdDs(long Id);
        DataTable GetCokeDynamicByCokeDynamicIdDs(long CokeDynamicId);
        DataTable GetCokeDynamicByCokeDynamicDs(long CokeDynamic);
        DataTable GetCokeDynamicByCokeTypeIdDs(long CokeTypeId);
        DataTable GetCokeDynamicByCokeTypeDs(long CokeType);
        DataTable GetCokeDynamicByCokeSupplierIdDs(long CokeSupplierId);
        DataTable GetCokeDynamicByCokeSupplierDs(long CokeSupplier);
        DataTable GetCokeDynamicByAnalysisTypeIdDs(long AnalysisTypeId);
        DataTable GetCokeDynamicByAnalysisTypeDs(long AnalysisType);
        DataTable GetCokeDynamicByIdnCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long Id, int CokeDynamicId, int CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType);
        DataTable GetCokeDynamicByCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long CokeDynamicId, int CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType);
        DataTable GetCokeDynamicByCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long CokeDynamic, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType);
        DataTable GetCokeDynamicByCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType);
        DataTable GetCokeDynamicByCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType);
        DataTable GetCokeDynamicByCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType);
        DataTable GetCokeDynamicByCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long CokeSupplier, int AnalysisTypeId, int AnalysisType);
        DataTable GetCokeDynamicByAnalysisTypeIdnAnalysisTypeDs(long AnalysisTypeId, int AnalysisType);
        DataTable GetCokeDynamicByLoginName(string loginName);
        DataTable GetCokeDynamicBySeacrh(ML_CokeDynamic objML_CokeDynamic);
        #endregion
       
        #region IClass  For tblCokeDynamicResult
        int AddCokeDynamicResult(ML_CokeDynamicResult objML_CokeDynamicResult);
        int UpdateCokeDynamicResult(ML_CokeDynamicResult objML_CokeDynamicResult);
        int UpdateUniqueCokeDynamicResult(ML_CokeDynamicResult objML_CokeDynamicResult);
        int DeleteCokeDynamicResult(long Id);
        int DeleteCokeDynamicResultById(long Id);
        int DeleteCokeDynamicResultByCokeDynamicResultId(long CokeDynamicResultId);
        int DeleteCokeDynamicResultByCokeDynamicResult(long CokeDynamicResult);
        int DeleteCokeDynamicResultByCokeDynamicId(long CokeDynamicId);
        int DeleteCokeDynamicResultByCokeDynamic(long CokeDynamic);
        int DeleteCokeDynamicResultByCokeCompositeMasterId(long CokeCompositeMasterId);
        int DeleteCokeDynamicResultByCokeCompositeMaster(long CokeCompositeMaster);
        int DeleteCokeDynamicResultByCokeTypeId(long CokeTypeId);
        int DeleteCokeDynamicResultByCokeType(long CokeType);
        int DeleteCokeDynamicResultByCokeSupplierId(long CokeSupplierId);
        int DeleteCokeDynamicResultByCokeSupplier(long CokeSupplier);
        int DeleteCokeDynamicResultByAnalysisTypeId(long AnalysisTypeId);
        int DeleteCokeDynamicResultByAnalysisType(long AnalysisType);
        int DeleteCokeDynamicResultByIdnCokeDynamicResultIdnCokeDynamicResultnCokeDynamicIdnCokeDynamicnCokeCompositeMasterIdnCokeCompositeMasternCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long Id, int CokeDynamicResultId, int CokeDynamicResult, int CokeDynamicId, int CokeDynamic, int CokeCompositeMasterId, int CokeCompositeMaster, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType);
        ML_CokeDynamicResult GetCokeDynamicResultById(long Id);
        ML_CokeDynamicResult GetCokeDynamicResultByCokeDynamicResultId(long CokeDynamicResultId);
        ML_CokeDynamicResult GetCokeDynamicResultByCokeDynamicResult(long CokeDynamicResult);
        ML_CokeDynamicResult GetCokeDynamicResultByCokeDynamicId(long CokeDynamicId);
        ML_CokeDynamicResult GetCokeDynamicResultByCokeDynamic(long CokeDynamic);
        ML_CokeDynamicResult GetCokeDynamicResultByCokeCompositeMasterId(long CokeCompositeMasterId);
        ML_CokeDynamicResult GetCokeDynamicResultByCokeCompositeMaster(long CokeCompositeMaster);
        ML_CokeDynamicResult GetCokeDynamicResultByCokeTypeId(long CokeTypeId);
        ML_CokeDynamicResult GetCokeDynamicResultByCokeType(long CokeType);
        ML_CokeDynamicResult GetCokeDynamicResultByCokeSupplierId(long CokeSupplierId);
        ML_CokeDynamicResult GetCokeDynamicResultByCokeSupplier(long CokeSupplier);
        ML_CokeDynamicResult GetCokeDynamicResultByAnalysisTypeId(long AnalysisTypeId);
        ML_CokeDynamicResult GetCokeDynamicResultByAnalysisType(long AnalysisType);
        ML_CokeDynamicResult GetCokeDynamicResultByIdnCokeDynamicResultIdnCokeDynamicResultnCokeDynamicIdnCokeDynamicnCokeCompositeMasterIdnCokeCompositeMasternCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType(long Id, int CokeDynamicResultId, int CokeDynamicResult, int CokeDynamicId, int CokeDynamic, int CokeCompositeMasterId, int CokeCompositeMaster, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType);
        DataTable GetCokeDynamicResultDetail();
        DataTable GetCokeDynamicResultByIdDs(long Id);
        DataTable GetCokeDynamicResultByCokeDynamicResultIdDs(long CokeDynamicResultId);
        DataTable GetCokeDynamicResultByCokeDynamicResultDs(long CokeDynamicResult);
        DataTable GetCokeDynamicResultByCokeDynamicIdDs(long CokeDynamicId);
        DataTable GetCokeDynamicResultByCokeDynamicDs(long CokeDynamic);
        DataTable GetCokeDynamicResultByCokeCompositeMasterIdDs(long CokeCompositeMasterId);
        DataTable GetCokeDynamicResultByCokeCompositeMasterDs(long CokeCompositeMaster);
        DataTable GetCokeDynamicResultByCokeTypeIdDs(long CokeTypeId);
        DataTable GetCokeDynamicResultByCokeTypeDs(long CokeType);
        DataTable GetCokeDynamicResultByCokeSupplierIdDs(long CokeSupplierId);
        DataTable GetCokeDynamicResultByCokeSupplierDs(long CokeSupplier);
        DataTable GetCokeDynamicResultByAnalysisTypeIdDs(long AnalysisTypeId);
        DataTable GetCokeDynamicResultByAnalysisTypeDs(long AnalysisType);
        // DataTable GetCokeDynamicResultByIdnCokeDynamicResultIdnCokeDynamicResultnCokeDynamicIdnCokeDynamicnCokeCompositeMasterIdnCokeCompositeMasternCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisTypeDs(long Id, int CokeDynamicResultId, int CokeDynamicResult, int CokeDynamicId, int CokeDynamic, int CokeCompositeMasterId, int CokeCompositeMaster, int CokeTypeId, int CokeType, int CokeSupplierId, int CokeSupplier, int AnalysisTypeId, int AnalysisType);
        DataTable GetCokeDynamicResultByLoginName(string loginName);
        DataTable GetCokeDynamicResultBySeacrh(ML_CokeDynamicResult objML_CokeDynamicResult);
        #endregion


        #region IClass  For tblCategoryGroupMaster
        int AddCategoryGroupMaster(ML_CategoryGroupMaster objML_CategoryGroupMaster);
        int UpdateCategoryGroupMaster(ML_CategoryGroupMaster objML_CategoryGroupMaster);
        int UpdateUniqueCategoryGroupMaster(ML_CategoryGroupMaster objML_CategoryGroupMaster);
        //int DeleteCategoryGroupMaster(long Id);
        int DeleteCategoryGroupMasterByCategoryGroupCode(long CategoryGroupCode);
        int DeleteCategoryGroupMasterByCanteenCode(long CanteenCode);
        int DeleteCategoryGroupMasterByCategoryGroupName(long CategoryGroupName);
        int DeleteCategoryGroupMasterByCategoryGroupActive(long CategoryGroupActive);
        ML_CategoryGroupMaster GetCategoryGroupMasterByCategoryGroupCode(long CategoryGroupCode);
        ML_CategoryGroupMaster GetCategoryGroupMasterByCanteenCode(long CanteenCode);
        ML_CategoryGroupMaster GetCategoryGroupMasterByCategoryGroupName(long CategoryGroupName);
        ML_CategoryGroupMaster GetCategoryGroupMasterByCategoryGroupActive(long CategoryGroupActive);
        DataSet GetCategoryGroupMasterDetail();
        DataSet GetCategoryGroupMasterByCategoryGroupCodeDs(long CategoryGroupCode);
        DataSet GetCategoryGroupMasterByCanteenCodeDs(long CanteenCode);
        DataSet GetCategoryGroupMasterByCategoryGroupNameDs(long CategoryGroupName);
        DataSet GetCategoryGroupMasterByCategoryGroupActiveDs(long CategoryGroupActive);
        DataSet GetCategoryGroupMasterByLoginName(string loginName);
        DataSet GetCategoryGroupMasterBySeacrh(ML_CategoryGroupMaster objML_CategoryGroupMaster);
        #endregion

        #endregion


  
       


      

















       


   

        


        
    }
}
