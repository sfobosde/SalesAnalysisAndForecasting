using System;

namespace CalculationLib
{
	/// <summary>
	/// Common Statistics calculations.
	/// </summary>
	public class CommonStatisticCalculations
	{
		#region Fields
		/// <summary>
		/// Elements array;
		/// </summary>
		protected double[] valuesArray;

		/// <summary>
		/// Mathematics expectation (AVG value);
		/// </summary>
		protected double mathExpectation => CalculateMathExpectation();

		/// <summary>
		/// Dispersium.
		/// </summary>
		protected double arrayVariance => CalculateVariance();
		#endregion

		#region Methods
		/// <summary>
		/// Calculate mathematic expectation.
		/// </summary>
		protected double CalculateMathExpectation()
		{
			var valuesSum = 0.0;

			for (int valueIndex = 0;
				valueIndex < valuesArray.Length;
				valueIndex++)
			{
				valuesSum += valuesArray[valueIndex];
			}

			return valuesSum / valuesArray.Length;
		}

		/// <summary>
		/// Calculate dispersium.
		/// </summary>
		protected double CalculateVariance()
		{
			var devitation = 0.0;

			for (int valueIndex = 0;
				valueIndex < valuesArray.Length;
				valueIndex++)
			{
				devitation += Math.Pow(mathExpectation - valuesArray[valueIndex], 2);
			}

			return Math.Sqrt(devitation / valuesArray.Length - 1);
		}
		#endregion

		public CommonStatisticCalculations(double[] valuesArray)
		{
			this.valuesArray = valuesArray;
		}
	}
}
