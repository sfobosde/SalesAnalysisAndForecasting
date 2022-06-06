﻿using DataBaseLayerLib.Entities.AAFS_Entities;
using System.Collections.Generic;

namespace DataBaseLayerLib
{
	/// <summary>
	/// Mask layer to db.
	/// </summary>
	public interface IDBContext
	{
		/// <summary>
		/// Get Products List.
		/// </summary>
		/// <returns></returns>
		List<Product> GetProductList();
	}
}