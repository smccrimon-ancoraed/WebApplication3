using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class MasterDataController : Controller
    {
        public string Index()
        {
            // return View();
            return "Maintence menu coming soon...";
        }

        public IActionResult MainEditMenu()
        {
            return View();
           
        }
    }
}