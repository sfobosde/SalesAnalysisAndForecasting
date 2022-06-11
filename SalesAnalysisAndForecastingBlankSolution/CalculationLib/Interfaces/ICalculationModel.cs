using DataBaseLayerLib.Entities.AAFS_Entities;
using System.Collections.Generic;

namespace CalculationLib.Interfaces
{
	public interface ICalculationModel
	{
		/// <summary>
		/// Calculate weekly dynamics.
		/// </summary>
		/// <param name="productSales"></param>
		void CalculateWeeklyDependecys(List<ProductSales> productSales);
	}
}
