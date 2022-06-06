using DataBaseLayerLib.Entities.AAFS_Entities;
using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;
using System.Collections.Generic;

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
		#endregion

		#region Tables
		/// <summary>
		/// Product catalog table.
		/// </summary>
		public ITable<Product> Products => this.GetTable<Product>();

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
