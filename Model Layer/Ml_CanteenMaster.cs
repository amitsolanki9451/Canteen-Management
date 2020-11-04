using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class ML_CanteenMaster
    {
        #region Properties
        /// <summary>
        /// Gets or sets the CanteenCode value.
        /// </summary>
        public Int32 CanteenCode { get; set; }
        /// <summary>
        /// Gets or sets the CanteenName value.
        /// </summary>
        public String CanteenName { get; set; }
        /// <summary>
        /// Gets or sets the CanteenAddress value.
        /// </summary>
        public String CanteenAddress { get; set; }
        /// <summary>
        /// Gets or sets the CanteenActive value.
        /// </summary>
        public Int32 CanteenActive { get; set; }
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
