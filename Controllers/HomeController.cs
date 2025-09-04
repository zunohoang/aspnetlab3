﻿using Microsoft.AspNetCore.Mvc;
using PDPDay3View.Models;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Xml.Linq;

namespace PDPDay3View.Controllers
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
            var p = new List<Item>
            {
                new Item  { Name = "Nồi cơm điện zuno A100 5090", Img = "image/noicom.jpg" },
                new Item  { Name = "Nồi cơm điện zuno A100 5091", Img = "image/noicom.jpg" },
                new Item  { Name = "Nồi cơm điện zuno A100 5092", Img = "image/noicom.jpg" }
                
            }; 

            return View(p);
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
