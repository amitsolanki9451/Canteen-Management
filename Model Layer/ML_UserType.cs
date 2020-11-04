using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
   public class ML_UserType
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        public Int32 Id { get; set; }
        /// <summary>
        /// Gets or sets the UserTypeId value.
        /// </summary>
        public Int32 UserTypeId { get; set; }
        /// <summary>
        /// Gets or sets the UserType value.
        /// </summary>
        public String UserType { get; set; }
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
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Gets or sets the CreatedBy value.
        /// </summary>
        public String CreatedBy { get; set; }
        /// <summary>
        /// Gets or sets the ModifiedDate value.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
        /// <summary>
        /// Gets or sets the ModifiedBy value.
        /// </summary>
        public String ModifiedBy { get; set; }
        /// <summary>
        /// Gets or sets the FromDate value.
        /// </summary>
        public DateTime? FromDate { get; set; }
        /// <summary>
        /// Gets or sets the ToDate value.
        /// </summary>
        public DateTime? ToDate { get; set; }

        /// <summary>
        /// Gets or sets the CreatedByUserNameId value.
        /// </summary>
        public Int32 CreatedByUserNameId { get; set; }
        #endregion
    }
}
