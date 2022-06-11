using DataBaseLayerLib.Entities.AAFS_Entities;
using System;
using System.Collections.Generic;

namespace CalculationLib
{
	class WeeklyDynamicCalcEventArgs : EventArgs
	{
		/// <summary>
		/// Product id.
		/// </summary>
		private string productId;

		/// <summary>
		/// Sales history.
		/// </summary>
		private	List<ProductSales> productSales;

		/// <summary>
		/// Weather data.
		/// </summary>
		private List<WeatherData> weatherData;

		/// <summary>
		/// Policy chages data.
		/// </summary>
		private List<PolicyChanges> PolicyChanges;

		/// <summary>
		/// External factors.
		/// </summary>
		private List<ExternalFactors> ExternalFactors;
	}
}
