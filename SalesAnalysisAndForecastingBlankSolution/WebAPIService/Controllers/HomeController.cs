using DataBaseLayerLib;
using Microsoft.AspNetCore.Mvc;
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
		#endregion

		#region Fields
		/// <summary>
		/// DB connection layer;
		/// </summary>
		private IDBFactory _dbContext;
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
