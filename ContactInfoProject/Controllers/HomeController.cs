using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ContactInfoProject.Models;

namespace ContactInfoProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Contact()
        {
            List<string> cities = new List<string> { "İstanbul", "Ankara", "İzmir", "Bursa", "Antalya" };
            ViewBag.Cities = cities;
            return View();
        }

        [HttpPost]
        public IActionResult SubmitContactForm(string name, string surname, string date, int age, string city)
        {
            return Json(new { success = true, message = "Form başarıyla gönderildi." });
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
    }
}