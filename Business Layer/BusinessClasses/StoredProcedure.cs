using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.BusinessClasses
{
   public partial class StoredProcedure
    {
       public enum Name
        {
          
          
           /// <summary>
           /// ////////Startup
           /// </summary>

            #region SP name for  tblCanteenMaster
            usp_SaveCanteenMaster,
            usp_UpdateCanteenMaster,
            usp_UpdateUniqueCanteenMaster,
            usp_DeleteCanteenMasterByCanteenCode,
            usp_DeleteCanteenMasterByCanteenName,
            usp_DeleteCanteenMasterByCanteenAddress,
            usp_DeleteCanteenMasterByCanteenActive,
            usp_GetCanteenMasterBySearch,
            usp_GetCanteenMaster,
            usp_GetCanteenMasterByCanteenCode,
            usp_GetCanteenMasterByCanteenName,
            usp_GetCanteenMasterByCanteenAddress,
            usp_GetCanteenMasterByCanteenActive,
            usp_GetCanteenMasterByLoginName, 
            #endregion		         
          
            #region SP name for  tblCategoryGroupMaster
            usp_SaveCategoryGroupMaster,
            usp_UpdateCategoryGroupMaster,
            usp_UpdateUniqueCategoryGroupMaster,
            usp_DeleteCategoryGroupMasterByCategoryGroupCode,
            usp_DeleteCategoryGroupMasterByCanteenCode,
            usp_DeleteCategoryGroupMasterByCategoryGroupName,
            usp_DeleteCategoryGroupMasterByCategoryGroupActive,
            usp_GetCategoryGroupMasterBySearch,
            usp_GetCategoryGroupMaster,
            usp_GetCategoryGroupMasterByCategoryGroupCode,
            usp_GetCategoryGroupMasterByCanteenCode,
            usp_GetCategoryGroupMasterByCategoryGroupName,
            usp_GetCategoryGroupMasterByCategoryGroupActive,
            usp_GetCategoryGroupMasterByLoginName, 
            #endregion		
          

               
            #region SP name for  tblUserType
            usp_SaveUserType,
            usp_UpdateUserType,
            usp_UpdateUniqueUserType,
            usp_DeleteUserTypeById,
            usp_DeleteUserTypeByUserTypeId,
            usp_DeleteUserTypeByUserType,
            usp_GetUserTypeBySearch,
            usp_GetUserType,
            usp_GetUserTypeById,
            usp_GetUserTypeByUserTypeId,
            usp_GetUserTypeByUserType,
            usp_GetUserTypeByLoginName,
            #endregion

            #region SP name for  tblUserName
            usp_SaveUserName,
            usp_UpdateUserName,
            usp_UpdateUniqueUserName,
            usp_DeleteUserNameById,
            usp_DeleteUserNameByUserNameId,
            usp_DeleteUserNameByUserName,
            usp_DeleteUserNameByEmail,
            usp_DeleteUserNameByUserTypeId,
            usp_DeleteUserNameByUserType,
            usp_DeleteUserNameByReTryAttempt,
            usp_DeleteUserNameByIsLocked,
            usp_DeleteUserNameByLockedDateTime,
            usp_DeleteUserNameByUserNamenEmailnPassword,
            usp_DeleteUserNameByUserNamenEmail,
            usp_DeleteUserNameByEmailnPassword,
            usp_GetUserNameBySearch,
            usp_GetUserName,
            usp_GetUserNameById,
            usp_GetUserNameByUserNameId,
            usp_GetUserNameByUserName,
            usp_GetUserNameByEmail,
            usp_GetUserNameByUserTypeId,
            usp_GetUserNameByUserType,
            usp_GetUserNameByReTryAttempt,
            usp_GetUserNameByIsLocked,
            usp_GetUserNameByLockedDateTime,
            usp_GetUserNameByUserNamenEmailnPassword,
            usp_GetUserNameByUserNamenEmail,
            usp_GetUserNameByEmailnPassword,
            usp_GetUserNameByLoginName,
            usp_UpdateUserPassword,
            usp_GetAuthenticateUser,
            usp_GetUserNameByUserNamenPassword,
            usp_GetUserNameList,         
            #endregion

            #region SP name for  tblItemMaster
            usp_SaveItemMaster,
            usp_UpdateItemMaster,
            usp_UpdateUniqueItemMaster,
            usp_DeleteItemMasterByItemCode,
            usp_DeleteItemMasterByCanteenCode,
            usp_DeleteItemMasterByCategoryGroupCode,
            usp_DeleteItemMasterByItemCategoryCode,
            usp_DeleteItemMasterByItemName,
            usp_DeleteItemMasterByItemEmployeeRate,
            usp_DeleteItemMasterByItemActive,
            usp_DeleteItemMasterByItemImage,
            usp_GetItemMasterBySearch,
            usp_GetItemMaster,
            usp_GetItemMasterByItemCode,
            usp_GetItemMasterByCanteenCode,
            usp_GetItemMasterByCategoryGroupCode,
            usp_GetItemMasterByItemCategoryCode,
            usp_GetItemMasterByItemName,
            usp_GetItemMasterByItemEmployeeRate,
            usp_GetItemMasterByItemActive,
            usp_GetItemMasterByItemImage,
            usp_GetItemMasterByLoginName,
            usp_DeleteItemMasterById,
            #endregion

            #region SP name for  tblItemCategoryMaster
            usp_SaveItemCategoryMaster,
            usp_UpdateItemCategoryMaster,
            usp_UpdateUniqueItemCategoryMaster,
            usp_DeleteItemCategoryMasterByItemCategoryCode,
            usp_GetItemCategoryMasterBySearch,
            usp_GetItemCategoryMaster,
            usp_GetItemCategoryMasterByItemCategoryCode,
            usp_GetItemCategoryMasterByCanteenCode,
            usp_GetItemCategoryMasterByCategoryGroupCode,
            usp_GetItemCategoryMasterByItemCategoryName,
            usp_GetItemCategoryMasterByItemCategoryActive,
            usp_GetItemCategoryMasterByStartTime,
            usp_GetItemCategoryMasterByEndTime,
            usp_GetItemCategoryMasterByLoginName,
            #endregion

           #region SP name for  tblAnalysisType
           usp_SaveAnalysisType,
           usp_UpdateAnalysisType,
           usp_UpdateUniqueAnalysisType,
           usp_DeleteAnalysisTypeById,
           usp_DeleteAnalysisTypeByAnalysisTypeId,
           usp_DeleteAnalysisTypeByAnalysisType,
           usp_GetAnalysisTypeBySearch,
           usp_GetAnalysisType,
           usp_GetAnalysisTypeById,
           usp_GetAnalysisTypeByAnalysisTypeId,
           usp_GetAnalysisTypeByAnalysisType,
           usp_GetAnalysisTypeByLoginName, 
           #endregion		

           #region SP name for  tblCokeDynamic
           usp_SaveCokeDynamic,
           usp_UpdateCokeDynamic,
           usp_UpdateUniqueCokeDynamic,
           usp_DeleteCokeDynamicById,
           usp_DeleteCokeDynamicByCokeDynamicId,
           usp_DeleteCokeDynamicByCokeDynamic,
           usp_DeleteCokeDynamicByCokeTypeId,
           usp_DeleteCokeDynamicByCokeType,
           usp_DeleteCokeDynamicByCokeSupplierId,
           usp_DeleteCokeDynamicByCokeSupplier,
           usp_DeleteCokeDynamicByAnalysisTypeId,
           usp_DeleteCokeDynamicByAnalysisType,
           usp_DeleteCokeDynamicByIdnCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType,
           usp_DeleteCokeDynamicByCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType,
           usp_DeleteCokeDynamicByCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType,
           usp_DeleteCokeDynamicByCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType,
           usp_DeleteCokeDynamicByCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType,
           usp_DeleteCokeDynamicByCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType,
           usp_DeleteCokeDynamicByCokeSuppliernAnalysisTypeIdnAnalysisType,
           usp_DeleteCokeDynamicByAnalysisTypeIdnAnalysisType,
           usp_GetCokeDynamicBySearch,
           usp_GetCokeDynamic,
           usp_GetCokeDynamicById,
           usp_GetCokeDynamicByCokeDynamicId,
           usp_GetCokeDynamicByCokeDynamic,
           usp_GetCokeDynamicByCokeTypeId,
           usp_GetCokeDynamicByCokeType,
           usp_GetCokeDynamicByCokeSupplierId,
           usp_GetCokeDynamicByCokeSupplier,
           usp_GetCokeDynamicByAnalysisTypeId,
           usp_GetCokeDynamicByAnalysisType,
           usp_GetCokeDynamicByIdnCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType,
           usp_GetCokeDynamicByCokeDynamicIdnCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType,
           usp_GetCokeDynamicByCokeDynamicnCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType,
           usp_GetCokeDynamicByCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType,
           usp_GetCokeDynamicByCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType,
           usp_GetCokeDynamicByCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType,
           usp_GetCokeDynamicByCokeSuppliernAnalysisTypeIdnAnalysisType,
           usp_GetCokeDynamicByAnalysisTypeIdnAnalysisType,
           usp_GetCokeDynamicByLoginName, 


           usp_GetCokeDynamicByCokeTypeIdnCokeSupplierId,
         
           #endregion		

           #region SP name for  tblCokeDynamicResult
           usp_SaveCokeDynamicResult,
           usp_UpdateCokeDynamicResult,
           usp_UpdateUniqueCokeDynamicResult,
           usp_DeleteCokeDynamicResultById,
           usp_DeleteCokeDynamicResultByCokeDynamicResultId,
           usp_DeleteCokeDynamicResultByCokeDynamicResult,
           usp_DeleteCokeDynamicResultByCokeDynamicId,
           usp_DeleteCokeDynamicResultByCokeDynamic,
           usp_DeleteCokeDynamicResultByCokeCompositeMasterId,
           usp_DeleteCokeDynamicResultByCokeCompositeMaster,
           usp_DeleteCokeDynamicResultByCokeTypeId,
           usp_DeleteCokeDynamicResultByCokeType,
           usp_DeleteCokeDynamicResultByCokeSupplierId,
           usp_DeleteCokeDynamicResultByCokeSupplier,
           usp_DeleteCokeDynamicResultByAnalysisTypeId,
           usp_DeleteCokeDynamicResultByAnalysisType,
           usp_DeleteCokeDynamicResultByIdnCokeDynamicResultIdnCokeDynamicResultnCokeDynamicIdnCokeDynamicnCokeCompositeMasterIdnCokeCompositeMasternCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType,
           usp_GetCokeDynamicResultBySearch,
           usp_GetCokeDynamicResult,
           usp_GetCokeDynamicResultById,
           usp_GetCokeDynamicResultByCokeDynamicResultId,
           usp_GetCokeDynamicResultByCokeDynamicResult,
           usp_GetCokeDynamicResultByCokeDynamicId,
           usp_GetCokeDynamicResultByCokeDynamic,
           usp_GetCokeDynamicResultByCokeCompositeMasterId,
           usp_GetCokeDynamicResultByCokeCompositeMaster,
           usp_GetCokeDynamicResultByCokeTypeId,
           usp_GetCokeDynamicResultByCokeType,
           usp_GetCokeDynamicResultByCokeSupplierId,
           usp_GetCokeDynamicResultByCokeSupplier,
           usp_GetCokeDynamicResultByAnalysisTypeId,
           usp_GetCokeDynamicResultByAnalysisType,
           usp_GetCokeDynamicResultByIdnCokeDynamicResultIdnCokeDynamicResultnCokeDynamicIdnCokeDynamicnCokeCompositeMasterIdnCokeCompositeMasternCokeTypeIdnCokeTypenCokeSupplierIdnCokeSuppliernAnalysisTypeIdnAnalysisType,
           usp_GetCokeDynamicResultByLoginName,
           usp_GetCokeDynamicResultByCompositeMasterID,
           #endregion		


            #region SP name for  tblCokeType
           usp_SaveCokeType,
           usp_UpdateCokeType,
           usp_UpdateUniqueCokeType,
           usp_DeleteCokeTypeById,
           usp_DeleteCokeTypeByCokeTypeId,
           usp_GetCokeTypeBySearch,
           usp_GetCokeType,
           usp_GetCokeTypeById,
           usp_GetCokeTypeByCokeTypeId,
           usp_GetCokeTypeByLoginName, 
            #endregion

          
            #region SP name for  tblCokeSupplier
           usp_SaveCokeSupplier,
           usp_UpdateCokeSupplier,
           usp_UpdateUniqueCokeSupplier,
           usp_DeleteCokeSupplierById,
           usp_DeleteCokeSupplierByCokeSupplierId,
           usp_GetCokeSupplierBySearch,
           usp_GetCokeSupplier,
           usp_GetCokeSupplierById,
           usp_GetCokeSupplierByCokeSupplierId,
           usp_GetCokeSupplierByLoginName,
           usp_GetCokeSupplierbyDate,
            #endregion


        }
    
   
   
   
   
   }
}
