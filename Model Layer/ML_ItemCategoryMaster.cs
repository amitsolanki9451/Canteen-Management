using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
   public class ML_ItemCategoryMaster
    {
		#region Properties
		/// <summary>
		/// Gets or sets the ItemCategoryCode value.
		/// </summary>
		public Int32 ItemCategoryCode { get; set; }
		/// <summary>
		/// Gets or sets the CanteenCode value.
		/// </summary>
		public Int32 CanteenCode { get; set; }
		/// <summary>
		/// Gets or sets the CategoryGroupCode value.
		/// </summary>
		public Int32 CategoryGroupCode { get; set; }
		/// <summary>
		/// Gets or sets the ItemCategoryName value.
		/// </summary>
		public String ItemCategoryName { get; set; }
		/// <summary>
		/// Gets or sets the ItemCategoryActive value.
		/// </summary>
		public Int32 ItemCategoryActive { get; set; }
		/// <summary>
		/// Gets or sets the StartTime value.
		/// </summary>
		public DateTime StartTime { get; set; }
		/// <summary>
		/// Gets or sets the EndTime value.
		/// </summary>
		public DateTime EndTime { get; set; }
		/// <summary>
		/// Gets or sets the ItemCategoryOrder value.
		/// </summary>
		public Int32 ItemCategoryOrder { get; set; }
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
