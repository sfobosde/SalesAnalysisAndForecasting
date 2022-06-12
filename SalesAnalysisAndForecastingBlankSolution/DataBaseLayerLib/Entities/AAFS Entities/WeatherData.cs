using LinqToDB.Mapping;
using System;

namespace DataBaseLayerLib.Entities.AAFS_Entities
{
	[Table(Name = "WeatherData")]
	public class WeatherData
	{
		/// <summary>
		/// Uniqueidentifier of weather date.
		/// </summary>
		[Column]
		public string weatherDataId;

		/// <summary>
		/// Weather date.
		/// </summary>
		[Column]
		public DateTime weatherDate;

		/// <summary>
		/// Uniqueidentifier of weather cluster.
		/// </summary>
		[Column]
		public string weatherClusterId;
	}
}
