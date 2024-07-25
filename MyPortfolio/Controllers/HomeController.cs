using MyPortfolio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace MyPortFolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["headingText"] = "I'm trying to be a programmer.";
            ViewBag.headingText = "I'm trying to be a programmer.";
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact model)
        {
            return Json(Ok());
        }

        public IActionResult Projects()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public PartialViewResult Test()
        {
            return PartialView("Footer");
        }
    }
}
