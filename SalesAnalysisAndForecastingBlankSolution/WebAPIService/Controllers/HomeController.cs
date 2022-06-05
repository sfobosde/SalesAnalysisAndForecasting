using DataBaseLayerLib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using WebAPIService.Models;

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

		public string ProductList()
		{
			var tryQuerry = dbContext.GetProductList();

			try
			{
				if (tryQuerry != null)
				{
					return "Seccess";
				}

				return "Not success";
			}
			catch (Exception e)
			{
				return e.Message;
			}
		}
		#endregion

		#region Fields
		/// <summary>
		/// Logger interface.
		/// </summary>
		private readonly ILogger<HomeController> _logger;

		/// <summary>
		/// DB connection layer;
		/// </summary>
		private IDBFactory dbContext;
		#endregion

		#region Constructions
		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public HomeController(IDBFactory dBContext)
		{
			this.dbContext = dbContext;
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
