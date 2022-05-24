using System;

namespace DataBaseLayerLib
{
	/// <summary>
	/// Connections layer.
	/// </summary>
	abstract class DBAbstractFactory : IDBFactory
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

		public void GetConnectionString()
		{
			
		}
		#endregion
	}
}
