using DataBaseLayerLib.Entities.AAFS_Entities;
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

		/// <summary>
		/// Get product sales.
		/// </summary>
		/// <returns></returns>
		List<ProductSales> GetProductSales(string productId);

		/// <summary>
		/// Get weather data.
		/// </summary>
		/// <param name="productId"></param>
		/// <returns></returns>
		List<WeatherData> GetWeatherData();

		/// <summary>
		/// Get Policy changes.
		/// </summary>
		/// <returns></returns>
		List<PolicyChanges> GetPolicyChanges();

		/// <summary>
		/// Get external factors.
		/// </summary>
		/// <returns></returns>
		List<ExternalFactors> GetExternalFactors();
	}
}
