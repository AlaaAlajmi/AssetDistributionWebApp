using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetDistributionWebApp.Data;
using AssetDistributionWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssetDistributionWebApp.Controllers
{
    public class AreaLeaderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
