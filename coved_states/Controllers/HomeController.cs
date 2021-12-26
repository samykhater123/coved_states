using coved_states.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace coved_states.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

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

        public JsonResult pibchartjson()
        {
            List<bibchart> list = new List<bibchart>();
            list.Add(new bibchart { categoryname = "samy", postcount = 10 });
            list.Add(new bibchart { categoryname = "ahmrd", postcount = 40 });
            list.Add(new bibchart { categoryname = "ali", postcount = 50 });

            return Json(new { jsonlist = list });
        }
    }
}
