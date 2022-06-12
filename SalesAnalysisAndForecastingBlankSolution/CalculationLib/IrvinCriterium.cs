using CalculationLib.Interfaces;
using System;

namespace CalculationLib
{
	/// <summary>
	/// Calculate irvin cruterium.
	/// </summary>
	class IrvinCriterium : CommonStatisticCalculations, IIrvinCriterium
	{
		/// <summary>
		/// Get abromal value index.
		/// </summary>
		/// <returns></returns>
		public int GetAbromalValueIndex()
		{
			double[] irvinCriterium = new double[valuesArray.Length];

			for (int valueIndex = 0;
				valueIndex < valuesArray.Length - 1;
				valueIndex++)
			{
				irvinCriterium[valueIndex] = Math.Abs((
					valuesArray[valueIndex] - valuesArray[valueIndex + 1]) 
					/ arrayVariance);
			}

			for (int valueIndex = 0;
				valueIndex < valuesArray.Length - 1;
				valueIndex++)
			{
				if (irvinCriterium[valueIndex] > 1.5)
				{
					return valueIndex;
				}
			}

			return -1;
		}
		public IrvinCriterium(double[] valuesArray) : base(valuesArray)
		{
		}
	}
}
