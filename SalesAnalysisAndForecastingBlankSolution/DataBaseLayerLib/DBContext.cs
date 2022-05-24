using LinqToDB.Data;
using LinqToDB.Configuration;

namespace DataBaseLayerLib
{
	/// <summary>
	/// Connections layer.
	/// </summary>
	public class DBContext : DataConnection, IDBFactory
	{
		#region Properties
		#endregion

		#region Fields
		#endregion

		#region Constructions
		/// <summary>
		/// Delegate options to DataConnection.
		/// </summary>
		/// <param name="options"></param>
		public DBContext(LinqToDBConnectionOptions<DBContext> options)
			: base(options)
		{

		}
		#endregion

		#region Methods

		#endregion
	}
}
