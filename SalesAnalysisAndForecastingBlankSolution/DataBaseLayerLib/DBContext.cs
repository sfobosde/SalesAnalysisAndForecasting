using LinqToDB.Configuration;
using DataBaseLayerLib.Entities.AAFS_Entities;
using System.Collections.Generic;
using System.Linq;
using System;

namespace DataBaseLayerLib
{
	/// <summary>
	/// Connections layer.
	/// </summary>
	public class DBContext : DBFactory
	{
		#region Querries
		/// <summary>
		/// Get products List querry.
		/// </summary>
		/// <returns></returns>
		public override List<Product> GetProductList()
		{
			var querry = from product in Products
						 select product;

			return querry.ToList();
		}

		/// <summary>
		/// Get product sales.
		/// </summary>
		/// <returns></returns>
		public override List<ProductSales> GetProductSales(string productId)
		{
			var productSalesTable = GetProductSalesTable(productId);

			var productSales = from productSale in productSalesTable
							   select productSale;

			return productSales.ToList();
		}
		#endregion

		#region Fields
		#endregion

		#region Constructions
		/// <summary>
		/// Delegate options to DataConnection.
		/// </summary>
		/// <param name="options"></param>
		public DBContext(LinqToDBConnectionOptions<DBContext> options)
			: base(options)
		{
			
		}
		#endregion
	}
}
