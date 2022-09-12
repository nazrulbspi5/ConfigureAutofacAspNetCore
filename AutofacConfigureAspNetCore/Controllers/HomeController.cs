using AutofacConfigureAspNetCore.Models;
using AutofacConfigureAspNetCore.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AutofacConfigureAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StudentService _student;
        public HomeController(ILogger<HomeController> logger,StudentService student)
        {
            _logger = logger;
            _student = student;
        }

        public IActionResult Index()
        {
            ViewBag.Message= _student.GetFullName();
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