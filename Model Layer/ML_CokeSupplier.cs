using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
   public class ML_CokeSupplier
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        public Int32 Id { get; set; }
        /// <summary>
        /// Gets or sets the CokeSupplierId value.
        /// </summary>
        public Int32 CokeSupplierId { get; set; }
        /// <summary>
        /// Gets or sets the CokeSupplier value.
        /// </summary>
        public String CokeSupplier { get; set; }
        /// <summary>
        /// Gets or sets the Address1 value.
        /// </summary>
        public String Address1 { get; set; }
        /// <summary>
        /// Gets or sets the Address2 value.
        /// </summary>
        public String Address2 { get; set; }
        /// <summary>
        /// Gets or sets the Address3 value.
        /// </summary>
        public String Address3 { get; set; }
        /// <summary>
        /// Gets or sets the CityName value.
        /// </summary>
        public String CityName { get; set; }
        /// <summary>
        /// Gets or sets the StateName value.
        /// </summary>
        public String StateName { get; set; }
        /// <summary>
        /// Gets or sets the PinCode value.
        /// </summary>
        public String PinCode { get; set; }
        /// <summary>
        /// Gets or sets the Title value.
        /// </summary>
        public String Title { get; set; }
        /// <summary>
        /// Gets or sets the CountryName value.
        /// </summary>
        public String CountryName { get; set; }
        /// <summary>
        /// Gets or sets the ContactPerson value.
        /// </summary>
        public String ContactPerson { get; set; }
        /// <summary>
        /// Gets or sets the MobNo value.
        /// </summary>
        public String MobNo { get; set; }
        /// <summary>
        /// Gets or sets the WebSite value.
        /// </summary>
        public String WebSite { get; set; }
        /// <summary>
        /// Gets or sets the Email value.
        /// </summary>
        public String Email { get; set; }
        /// <summary>
        /// Gets or sets the Remarks value.
        /// </summary>
        public String Remarks { get; set; }
        /// <summary>
        /// Gets or sets the IsActive value.
        /// </summary>
        public String IsActive { get; set; }
        /// <summary>
        /// Gets or sets the IsArchive value.
        /// </summary>
        public String IsArchive { get; set; }
        /// <summary>
        /// Gets or sets the CreatedDate value.
        /// </summary>
        public DateTime CreatedDate { get; set; }
        /// <summary>
        /// Gets or sets the CreatedBy value.
        /// </summary>
        public String CreatedBy { get; set; }
        /// <summary>
        /// Gets or sets the ModifiedDate value.
        /// </summary>
        public DateTime ModifiedDate { get; set; }
        /// <summary>
        /// Gets or sets the ModifiedBy value.
        /// </summary>
        public String ModifiedBy { get; set; }
        /// <summary>
        /// Gets or sets the CreatedByUserNameId value.
        /// </summary>
        public Int32 CreatedByUserNameId { get; set; }
        /// <summary>
        /// Gets or sets the FromDate value.
        /// </summary>
        public DateTime? FromDate { get; set; }
        /// <summary>
        /// Gets or sets the ToDate value.
        /// </summary>
        public DateTime? ToDate { get; set; }
        #endregion
    }
}
