﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using testTask.Models;

namespace testTask.Controllers
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
        

        [HttpPost]
        public IActionResult Index(string stringToReverse)
        {
            string stringReversed = Reverse.ShowReverseString(stringToReverse);
            
            ViewBag.Name = "REVERSED STRING ====> " + stringReversed;
            return View();
        }






    }
}