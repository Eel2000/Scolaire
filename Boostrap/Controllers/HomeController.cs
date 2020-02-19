using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boostrap.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {
            //default controller
        }

        //Get/Home/index
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]//home/Films
        public IActionResult Films()
        {
            return View();
        }

        [HttpGet]//GEt/Home/Habillements
        public IActionResult Habillements()
        {
            return View();
        }

        [HttpGet]//Get/Home/Tourisme
        public IActionResult Tourisme()
        {
            return View();
        }
    }
}
