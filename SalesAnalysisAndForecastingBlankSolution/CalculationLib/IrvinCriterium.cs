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
		/// Irvin criterium values.
		/// </summary>
		private double[] irvinCriteriumValues;

		/// <summary>
		/// Get abromal value index.
		/// </summary>
		/// <returns></returns>
		public int GetAbromalValueIndex()
		{
			for (int valueIndex = 0;
				valueIndex < valuesArray.Length - 1;
				valueIndex++)
			{
				if (irvinCriteriumValues[valueIndex] > 1.5)
				{
					return valueIndex;
				}
			}

			return -1;
		}

		/// <summary>
		/// Calculate irvin Criterium values.
		/// </summary>
		private void CalculateIrvinCruteriums()
		{
			irvinCriteriumValues = new double[valuesArray.Length];

			for (int valueIndex = 0;
				valueIndex < valuesArray.Length - 1;
				valueIndex++)
			{
				irvinCriteriumValues[valueIndex] = Math.Abs((
					valuesArray[valueIndex] - valuesArray[valueIndex + 1])
					/ arrayVariance);
			}
		}

		/// <summary>
		/// Calculate vasic math paramatrs before calculate irvin criterium.
		/// </summary>
		/// <param name="valuesArray"></param>
		public IrvinCriterium(double[] valuesArray) : base(valuesArray)
		{
			CalculateIrvinCruteriums();
		}
	}
}
