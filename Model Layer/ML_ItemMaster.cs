using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class ML_ItemMaster
	{
		#region Properties
		/// <summary>
		/// Gets or sets the ItemCode value.
		/// </summary>
		public Int32 ItemCode { get; set; }
		/// <summary>
		/// Gets or sets the CanteenCode value.
		/// </summary>
		public Int32 CanteenCode { get; set; }
		/// <summary>
		/// Gets or sets the CategoryGroupCode value.
		/// </summary>
		public Int32 CategoryGroupCode { get; set; }
		/// <summary>
		/// Gets or sets the ItemCategoryCode value.
		/// </summary>
		public Int32 ItemCategoryCode { get; set; }
		/// <summary>
		/// Gets or sets the ItemName value.
		/// </summary>
		public String ItemName { get; set; }
		/// <summary>
		/// Gets or sets the ItemEmployeeRate value.
		/// </summary>
		public Decimal ItemEmployeeRate { get; set; }
		/// <summary>
		/// Gets or sets the ItemActive value.
		/// </summary>
		public Int32 ItemActive { get; set; }
		/// <summary>
		/// Gets or sets the ItemImage value.
		/// </summary>
		public Byte[] ItemImage { get; set; }
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
