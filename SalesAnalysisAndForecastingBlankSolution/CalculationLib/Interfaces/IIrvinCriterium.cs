using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationLib.Interfaces
{
	/// <summary>
	/// Calculate irvin cruterium.
	/// </summary>
	public interface IIrvinCriterium
	{
		/// <summary>
		/// Get anomal value in array.
		/// </summary>
		/// <returns></returns>
		int GetAbromalValueIndex();
	}
}
