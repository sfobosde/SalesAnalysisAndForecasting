using System;
using LinqToDB.Mapping;

namespace DataBaseLayerLib.Entities.AAFS_Entities
{
	/// <summary>
	/// Company policy changes.
	/// </summary>
	[Table(Name = "PolicyChanges")]
	public class PolicyChanges
	{
		/// <summary>
		/// Uniqueidentifier of changes.
		/// </summary>
		[Column]
		public string policyChangeId;

		/// <summary>
		/// Uniqueidentifier of classify.
		/// </summary>
		[Column]
		public string classifyId;

		/// <summary>
		/// Policy changes description.
		/// </summary>
		[Column]
		public string changesDecription;

		/// <summary>
		/// Uniqueidentifier of oriented product.
		/// </summary>
		[Column]
		public string orientedProductId;

		/// <summary>
		/// Policy change enter(start) date.
		/// </summary>
		[Column]
		public DateTime enteringDate;

		/// <summary>
		/// Policy change out (stop) date.
		/// </summary>
		[Column]
		public DateTime rolbackDate;
	}
}
