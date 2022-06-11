using System;
using LinqToDB.Mapping;

namespace DataBaseLayerLib.Entities.AAFS_Entities
{
	/// <summary>
	/// Product sales history.
	/// </summary>
	public class ProductSales
	{
		/// <summary>
		/// Uniqueidentifier of sale.
		/// </summary>
		[Column]
		public string saleId;

		/// <summary>
		/// Sales Date.
		/// </summary>
		[Column]
		public DateTime saleDate;

		/// <summary>
		/// Saled product amount.
		/// </summary>
		[Column]
		public int saleAmount;
	}
}
