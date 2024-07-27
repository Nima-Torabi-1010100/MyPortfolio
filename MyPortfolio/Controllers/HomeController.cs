using MyPortfolio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyPortFolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly List<Service> _services = new List<Service>()
        {
            new Service(1,"Golden"),
            new Service(2,"Silver"),
            new Service(3,"Bronze")
        };
        [HttpGet]
        public IActionResult Index()
        {
            Contact model = new Contact()
            {
                Services = new SelectList(_services, "Key", "Value")
            };
            ViewData["headingText"] = "I'm trying to be a programmer.";
            ViewBag.headingText = "I'm trying to be a programmer.";
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(Contact model)
        {
            model.Services = new SelectList(_services, "Key", "Value");
            if (!ModelState.IsValid)
            {
                ViewBag.error = "The entered information is not correct, Please try again";
                return View(model);
            }
            ModelState.Clear();
            model = new Contact()
            {
                Services = new SelectList(_services, "Key", "Value")
            };
            ViewBag.success = "Thank you! Your message has been successfully sent.";
            return View(model);
        }
        //public IActionResult Index(Contact model)
        //{
        //    return Json(Ok());
        //}

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
