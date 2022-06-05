using System;
using LinqToDB.Mapping;

namespace DataBaseLayerLib.Entities.AAFS_Entities
{
	/// <summary>
	/// ProductCatalog Table.
	/// </summary>
	[Table(Name = "ProductCatalog")]
	public class Product
	{
		/// <summary>
		/// Uniqueidentifier key for table.
		/// </summary>
		[PrimaryKey, Identity]
		public Guid productId;

		/// <summary>
		/// Varchar() product name.
		/// </summary>
		[Column]
		public string productName;

		/// <summary>
		/// Name of table with sales history.
		/// </summary>
		[Column]
		public string salesDataTableName;
	}
}
