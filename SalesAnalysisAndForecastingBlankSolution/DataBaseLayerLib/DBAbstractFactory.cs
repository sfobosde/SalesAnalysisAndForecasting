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
			connectionString = ConfigurationManager
				.AppSettings
				.Get("connectionString");

			return connectionString;
		}
		#endregion
	}
}
