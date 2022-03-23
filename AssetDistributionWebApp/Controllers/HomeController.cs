using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AssetDistributionWebApp.Data;
using AssetDistributionWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;

namespace AssetDistributionWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
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




        public async Task<IActionResult> AreaLeaderHP()
        {


            return View();
        }

        //[HttpPost]
        //public ActionResult AreaLeaderHP()
        //{

        //        return View();

        //    //string name = asset.name;
        //    //int amount = asset.amount;
        //    //string imageurl = asset.imageurl;
        //    //string description = asset.description;
        //    //string focalpoint = asset.focalPoint;
        //    //Console.WriteLine("success");
        //    //return View();
        //}


        public ActionResult Create(assets asset)
        {

            //if (ModelState.IsValid)
            //{
            //    Console.WriteLine(asset);
            //    return View(asset);
            //}
            //_service.Add(asset);

            //return RedirectToAction(nameof(ApprovalPage));

            return View();

        }




        public IActionResult ApprovalPage()
        {
            return View();
        }

        public string OpenPopup()
        {
            return "<h1> This Is Modeless Popup Window</h1>";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
