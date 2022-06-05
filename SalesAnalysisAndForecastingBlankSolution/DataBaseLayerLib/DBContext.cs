using LinqToDB.Data;
using LinqToDB.Configuration;
using LinqToDB;
using DataBaseLayerLib.Entities.AAFS_Entities;
using System;
using System.Collections.Generic;

namespace DataBaseLayerLib
{
	/// <summary>
	/// Connections layer.
	/// </summary>
	public class DBContext : DataConnection, IDBFactory
	{
		#region Tables
		public ITable<Product> Products => this.GetTable<Product>();
		#endregion

		#region Querries
		public IEnumerable<Product> GetProductList()
		{
			return Products;
		}
		#endregion

		#region Properties
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

		#region Methods

		#endregion
	}
}
