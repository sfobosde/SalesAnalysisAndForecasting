using DataBaseLayerLib.Entities.AAFS_Entities;
using System;
using System.Collections.Generic;

namespace CalculationLib
{
	public class WeeklyDynamicCalcEventArgs : EventArgs
	{
		/// <summary>
		/// Product id.
		/// </summary>
		public string ProductId;

		/// <summary>
		/// Sales history.
		/// </summary>
		public List<ProductSales> ProductSales;

		/// <summary>
		/// Weather data.
		/// </summary>
		public List<WeatherData> WeatherData;

		/// <summary>
		/// Policy chages data.
		/// </summary>
		public List<PolicyChanges> PolicyChanges;

		/// <summary>
		/// External factors.
		/// </summary>
		public List<ExternalFactors> ExternalFactors;
	}
}
