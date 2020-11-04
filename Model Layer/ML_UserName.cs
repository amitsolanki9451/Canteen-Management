using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
   public class ML_UserName
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        public Int32 Id { get; set; }
        /// <summary>
        /// Gets or sets the UserNameId value.
        /// </summary>
        public Int32 UserNameId { get; set; }
        /// <summary>
        /// Gets or sets the UserName value.
        /// </summary>
        public String UserName { get; set; }
        /// <summary>
        /// Gets or sets the FirstName value.
        /// </summary>
        public String FirstName { get; set; }
        /// <summary>
        /// Gets or sets the LastName value.
        /// </summary>
        public String LastName { get; set; }
        /// <summary>
        /// Gets or sets the Email value.
        /// </summary>
        public String Email { get; set; }
        /// <summary>
        /// Gets or sets the Telephone value.
        /// </summary>
        public String Telephone { get; set; }
        /// <summary>
        /// Gets or sets the Mobile value.
        /// </summary>
        public String Mobile { get; set; }
        /// <summary>
        /// Gets or sets the Remarks value.
        /// </summary>
        public String Remarks { get; set; }
        /// <summary>
        /// Gets or sets the Password value.
        /// </summary>
        public String Password { get; set; }
        /// <summary>
        /// Gets or sets the UserTypeId value.
        /// </summary>
        public Int32 UserTypeId { get; set; }
        /// <summary>
        /// Gets or sets the UserType value.
        /// </summary>
        public String UserType { get; set; }
        /// <summary>
        /// Gets or sets the ReTryAttempt value.
        /// </summary>
        public Int32 ReTryAttempt { get; set; }
        /// <summary>
        /// Gets or sets the IsLocked value.
        /// </summary>
        public Boolean IsLocked { get; set; }
        /// <summary>
        /// Gets or sets the LockedDateTime value.
        /// </summary>
        public DateTime? LockedDateTime { get; set; }
        /// <summary>
        /// Gets or sets the ImagePath value.
        /// </summary>
        public String ImagePath { get; set; }
        /// <summary>
        /// Gets or sets the ImageName value.
        /// </summary>
        public String ImageName { get; set; }
        /// <summary>
        /// Gets or sets the DefaultImageName value.
        /// </summary>
        public String DefaultImageName { get; set; }
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
