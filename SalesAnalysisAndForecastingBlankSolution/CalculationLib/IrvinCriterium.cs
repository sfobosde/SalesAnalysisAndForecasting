using CalculationLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationLib
{
	/// <summary>
	/// Calculate irvin cruterium.
	/// </summary>
	class IrvinCriterium : IIrvinCriterium
	{
		/// <summary>
		/// Elements array;
		/// </summary>
		private double[] valuesArray;

		/// <summary>
		/// Mathematics expectation (AVG value);
		/// </summary>
		private double mathExpectation;

		/// <summary>
		/// Dispersium.
		/// </summary>
		private double arrayVariance;

		public int GetAbromalValueIndex()
		{
			double[] irvinCriterium = new double[valuesArray.Length];

			for (int valueIndex = 0;
				valueIndex < valuesArray.Length - 1;
				valueIndex++)
			{
				irvinCriterium[valueIndex] = Math.Abs((
					valuesArray[valueIndex] - valuesArray[valueIndex+1]) 
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

		/// <summary>
		/// Calculate mathematic expectation.
		/// </summary>
		private void CalculateMathExpectation()
		{
			double valuesSum = 0;

			for (int valueIndex = 0;
				valueIndex < valuesArray.Length;
				valueIndex++)
			{
				valuesSum += valuesArray[valueIndex];
			}

			mathExpectation = valuesSum / valuesArray.Length;
		}

		/// <summary>
		/// Calculate dispersium.
		/// </summary>
		private void CalculateVariance()
		{
			double devitation = 0;

			for (int valueIndex = 0;
				valueIndex < valuesArray.Length;
				valueIndex++)
			{
				devitation += Math.Pow(mathExpectation - valuesArray[valueIndex], 2);
			}

			arrayVariance = Math.Sqrt(devitation / valuesArray.Length - 1);
		}

		public IrvinCriterium(double[] valuesArray)
		{
			this.valuesArray = valuesArray;
		}

	}
}
