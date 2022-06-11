using DataBaseLayerLib.Entities.AAFS_Entities;
using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;
using System.Collections.Generic;
using System.Linq;

namespace DataBaseLayerLib
{
	public abstract class DBFactory : DataConnection, IDBContext
	{
		#region Interface Querries
		/// <summary>
		/// Get Proguct list.
		/// </summary>
		/// <returns></returns>
		public abstract List<Product> GetProductList();

		/// <summary>
		/// Get product sales by product id.
		/// </summary>
		/// <returns></returns>
		public abstract List<ProductSales> GetProductSales(string productId);
		#endregion

		#region Tables
		/// <summary>
		/// Product catalog table.
		/// </summary>
		public ITable<Product> Products => this.GetTable<Product>();
		#endregion

		#region Methods
		/// <summary>
		/// Get product sales history
		/// </summary>
		protected ITable<ProductSales> GetProductSalesTable(string productId)
		{
			var productSalesTableName = from product in Products
										where product.productId.Equals(productId)
										select product.salesDataTableName;

			return this
				.GetTable<ProductSales>()
				.TableName(
				productSalesTableName
				.FirstOrDefault());
		}
		#endregion
		/// <summary>
		/// Delegate connection properties to base (linq2db) object.
		/// Creating tables.
		/// </summary>
		/// <param name="options"></param>
		public DBFactory(LinqToDBConnectionOptions<DBContext> options)
			: base(options)
		{
			
		}
	}
}
