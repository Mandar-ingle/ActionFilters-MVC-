using ActionFilters.Models;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ActionFilters.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
       // [System.Web.Mvc.OutputCache(Duration=10)]
       // [Authorize]
        public ActionResult Index()
        {
           // ViewBag.SysTime = DateTime.Now.ToLongTimeString();
            return View();
        }
        [HttpPost]
        //[System.Web.Mvc.ValidateInput(false)]
        public ActionResult Index(string txtDemo)
        {
            //ViewBag.SysTime = DateTime.Now.ToLongTimeString();
            ViewBag.Demo = txtDemo;
            return View();
        }

       // [Authorize]
        public ActionResult Contact()
        {
            throw new ApplicationException("error...");
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
    }
}
