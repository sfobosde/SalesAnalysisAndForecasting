using LinqToDB.Configuration;
using DataBaseLayerLib.Entities.AAFS_Entities;
using System.Collections.Generic;

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
		public override IEnumerable<Product> GetProductList()
		{
			return Products;
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
