using DataBaseLayerLib.Entities.AAFS_Entities;
using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;
using System;
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
		protected ITable<Product> Products => this.GetTable<Product>();

		/// <summary>
		/// Product sales tables dictionary with productId key.
		/// </summary>
		private Dictionary<string, ITable<ProductSales>> ProductSales;
		#endregion

		#region Methods
		/// <summary>
		/// Get product sales history
		/// </summary>
		protected ITable<ProductSales> GetProductSalesTable(string productId)
		{
			try
			{
				var productSales = ProductSales.FirstOrDefault(productSales =>
				productSales.Key.Equals(productId)).Value;

				if (productSales == null)
				{
					var productSalesTableName = from product in Products
												where product.productId.Equals(productId)
												select product.salesDataTableName;

					var sales = this.GetTable<ProductSales>()
							.TableName(productSalesTableName
							.FirstOrDefault());

					ProductSales.Add(productId, sales);

					return sales;
				}
				return productSales;
			}
			/// If guid was not in table.
			catch (ArgumentNullException e)
			{
				throw new ArgumentNullException("Cannot load data.", e);
			}
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
			ProductSales = new Dictionary<string, ITable<ProductSales>>();
		}
	}
}
