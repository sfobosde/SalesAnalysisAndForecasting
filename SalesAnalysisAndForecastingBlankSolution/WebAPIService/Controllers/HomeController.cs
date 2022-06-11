using DataBaseLayerLib;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Text.Json.Serialization;
using WebAPIService.Models;
using System.Text.Json;

namespace WebAPIService.Controllers
{
	public class HomeController : Controller
	{
		#region API
		/// <summary>
		/// User domain API.
		/// </summary>
		/// <returns></returns>
		public string GetUserDomain()
		{
			return Environment.UserDomainName;
		}

		/// <summary>
		/// Get Product List.
		/// </summary>
		/// <returns></returns>
		public string ProductList()
		{
			/// Use it as example to get values.
			var productList = _dbContext.GetProductList();
			return JsonSerializer.Serialize(productList.ToArray()[0].salesDataTableName);
		}

		/// <summary>
		/// Get product sales history by product id.
		/// </summary>
		/// <returns></returns>
		public string GetProductSalesByProductId(string productId)
		{
			var productSales = _dbContext.GetProductSales("D3BD999C-43C8-4E4A-B5BF-4846989D1552");
			return JsonSerializer.Serialize(productSales.ToArray()[0].saleId);
		}
		#endregion

		#region Fields
		/// <summary>
		/// DB connection layer;
		/// </summary>
		private IDBContext _dbContext;
		#endregion

		#region Constructions

		/// <summary>
		/// 
		/// </summary>
		/// <param name="dbContext"></param>
		public HomeController(DBContext dbContext)
		{
			_dbContext = dbContext;
		}
		#endregion

		#region Default routes
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
		#endregion

	}
}
