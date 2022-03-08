using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AssetDistributionWebApp.Data;
using AssetDistributionWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AssetDistributionWebApp.Controllers
{
	public class HomeController : Controller
	{
        private readonly AppDbContext appDbContext;
        public HomeController(AppDbContext context)
        {
            appDbContext = context;

        }
  //      private readonly ILogger<HomeController> _logger;
		
		//public HomeController(ILogger<HomeController> logger)
		//{
		//	_logger = logger;
		//}

		public IActionResult Index()
		{
			var data = appDbContext.assets.ToList();
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}
		public IActionResult AreaLeaderHP()
		{
			return View();
		}
		public IActionResult ApprovalPage()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
