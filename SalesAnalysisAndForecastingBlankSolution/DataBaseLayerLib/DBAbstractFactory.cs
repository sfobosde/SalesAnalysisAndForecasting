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
		/// <summary>
		/// Get DataBase connection string from app.config.
		/// </summary>
		private void GetConnectionString()
		{
			connectionString = ConfigurationManager
				.AppSettings["connectionString"];
		}
		#endregion
	}
}
