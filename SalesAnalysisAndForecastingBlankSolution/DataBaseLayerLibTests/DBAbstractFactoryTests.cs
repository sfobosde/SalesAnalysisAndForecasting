using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataBaseLayerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLayerLib.Tests
{
	[TestClass()]
	public class DBAbstractFactoryTests
	{
		[TestMethod()]
		public void GetConnectionStringTest()
		{
			var dBFactory = new DBAbstractFactory();

			var actualConnectionString = dBFactory.GetConnectionString();

			var expectedConnectionString = 
				@"Server=LAPTOP-D01LT47H\SQLEXPRESS01;Database=SalesAnalyseAndForecast;Trusted_Connection=True;MultipleActiveResultSets=true";

			Assert.AreEqual(expectedConnectionString,
				actualConnectionString,
				false,
				"Comparsion resault: not equal.");
		}
	}
}