using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AssetDistributionWebApp.Controllers
{
    public class AssetsController : Controller
    {
        "id,name,amount,imageurl,describtion,focalpoint"
        public IActionResult Index()
        {
            return View();
        }
    }
}
