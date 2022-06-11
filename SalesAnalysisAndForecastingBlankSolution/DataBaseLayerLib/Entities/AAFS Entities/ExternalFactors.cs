using LinqToDB.Mapping;
using System;

namespace DataBaseLayerLib.Entities.AAFS_Entities
{
	[Table(Name = "ExternalFactors")]
	public class ExternalFactors
	{
		/// <summary>
		/// Uniqueidentifier of factor.
		/// </summary>
		[Column]
		public string factorId;

		/// <summary>
		/// Uniqueidentifier of factor type (classify).
		/// </summary>
		[Column]
		public string factorTypeId;

		/// <summary>
		/// Factor description.
		/// </summary>
		[Column]
		public string factorDescription;

		/// <summary>
		/// Factor occurence date (start date).
		/// </summary>
		[Column]
		public DateTime factorOccurenceDate;

		/// <summary>
		/// Factor termitation date (end date).
		/// </summary>
		[Column]
		public DateTime factorTermitationDate;
	}
}
