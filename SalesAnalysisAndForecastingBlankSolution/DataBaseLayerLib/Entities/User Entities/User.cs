using System;
using System.Text.Json.Serialization;

namespace DataBaseLayerLib.Entities.User_Entities
{
	/// <summary>
	/// User Entity properties.
	/// </summary>
	class User
	{
		/// <summary>
		/// User Id.
		/// </summary>
		public Guid UserId { get; set; }

		/// <summary>
		/// User login (domain).
		/// </summary>
		public string UserLogin { get; set; }

		/// <summary>
		/// User system name.
		/// </summary>
		public string UserName { get; set; }


		/// <summary>
		/// User password.
		/// Change type.
		/// </summary>
		[JsonIgnore]
		public string UserPassword { get; set; }
	}
}
