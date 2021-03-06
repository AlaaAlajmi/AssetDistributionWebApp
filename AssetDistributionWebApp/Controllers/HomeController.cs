using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AssetDistributionWebApp.Data;
using AssetDistributionWebApp.Data.ViewModel;
using AssetDistributionWebApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;

namespace AssetDistributionWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<ApplicationUsers> _userManager;
        private readonly SignInManager<ApplicationUsers> _signInManager;
        public HomeController(UserManager<ApplicationUsers> userManager, SignInManager<ApplicationUsers> signInManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
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




        public IActionResult Login() => View(new LoginVM());
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
                return View(loginVM);
            var user = await _userManager.FindByEmailAsync(loginVM.EmailAddress);
            if (user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginVM.Password);
                if (passwordCheck)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("AreaLeaderHP");
                    }

                }
                TempData["Error"] = "Wrong credentials. Please, try again!"; return View(loginVM);
            }
            TempData["Error"] = "Wrong credentials. Please, try again!"; return View(loginVM);
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
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
          public IActionResult ThankYou()
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
