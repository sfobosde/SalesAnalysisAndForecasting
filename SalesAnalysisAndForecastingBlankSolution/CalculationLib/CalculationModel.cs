using CalculationLib.Interfaces;
using DataBaseLayerLib.Entities.AAFS_Entities;
using System;
using System.Collections.Generic;

namespace CalculationLib
{
	class CalculationModel : ICalculationModel
	{
		public void CalculateWeeklyDependecys(List<ProductSales> productSales)
		{
			/// Find action free periods.
			/// Divide on week periods.
			/// Find holydays in periods (Irvin criterium (IC)).
			/// Check by every of 7 week day dynamic:
			/// Calculate weekly diferents;
			/// Check by IC.
			/// Mark diferents as weather infulence;
			/// Find AVG.
			/// Send to save in db.
		}
	}
}
