﻿using System;
using System.Configuration;

namespace DataBaseLayerLib
{
	/// <summary>
	/// Connections layer.
	/// </summary>
	public class DBAbstractFactory : IDBFactory
	{
		#region Fields

		/// <summary>
		/// Connection data string from configuration.
		/// </summary>
		private string connectionString;
		#endregion

		#region
		#endregion

		#region
		#endregion

		#region Methods

		public string GetConnectionString()
		{
			return "G";
				//ConfigurationManager.ConnectionStrings["SalesAndForecasting"].ConnectionString;
		}
		#endregion
	}
}