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
            //var data = appDbContext.assets.ToList();
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

        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]

        public async Task<IActionResult> Create([Bind("id,name,amount,imageurl,describtion,focalpoint")] assets assets)
        {
            if (!ModelState.IsValid)
            {
                return View(assets);
            }
            await (assets);
            return RedirectToAction(nameof(Index));
        }

        //Get: Actors/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);

            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        //Get: Actors/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
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
