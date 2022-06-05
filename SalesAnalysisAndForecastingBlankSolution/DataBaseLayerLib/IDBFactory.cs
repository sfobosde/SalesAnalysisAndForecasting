using DataBaseLayerLib.Entities.AAFS_Entities;
using System;
using System.Collections.Generic;

namespace DataBaseLayerLib
{
	/// <summary>
	/// Mask layer to db.
	/// </summary>
	public interface IDBFactory
	{
		/// <summary>
		/// Get Products List.
		/// </summary>
		/// <returns></returns>
		IEnumerable<Product> GetProductList();
	}
}
