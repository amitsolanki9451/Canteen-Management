using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
  public  class ML_CategoryGroupMaster
    {
        #region Properties
        /// <summary>
        /// Gets or sets the CategoryGroupCode value.
        /// </summary>
        public Int32 CategoryGroupCode { get; set; }
        /// <summary>
        /// Gets or sets the CanteenCode value.
        /// </summary>
        public Int32 CanteenCode { get; set; }
        /// <summary>
        /// Gets or sets the CategoryGroupName value.
        /// </summary>
        public String CategoryGroupName { get; set; }
        /// <summary>
        /// Gets or sets the CategoryGroupActive value.
        /// </summary>
        public Int32 CategoryGroupActive { get; set; }
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
