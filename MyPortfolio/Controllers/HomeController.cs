using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyPortfolio.Models;
using MyPortFolio.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace MyPortFolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //private readonly List<Portfolio> _portfolios = new List<Portfolio>()
        //{
        //    new Portfolio()
        //    {
        //        Title="Web Page", Description="Web Projects.", Image = "Web.jpg"
        //    },
        //    new Portfolio()
        //    {
        //        Title = "Mobile App", Description = "Mobile Projects.", Image = "Mobile.jpg"
        //    }
        //};
        //private readonly List<Portfolio> _projects = new List<Portfolio>()
        //{
        //    new Portfolio()
        //    {
        //        Title = "Web Page",
        //        Description = "Nullam et orci eu lorem consequat tincidunt vivamus et sagittis magna sed nunc rhoncus condimentum sem. In efficitur ligula tate urna." +
        //        " Maecenas massa sed magna lacinia magna pellentesque lorem ipsum dolor. Nullam et orci eu lorem consequat tincidunt. Vivamus et sagittis tempus.",
        //        Image = "Web.jpg"
        //    },
        //    new Portfolio()
        //    {
        //        Title = "Application",
        //        Description = "Nullam et orci eu lorem consequat tincidunt vivamus et sagittis magna sed nunc rhoncus condimentum sem. In efficitur ligula tate urna." +
        //        " Maecenas massa sed magna lacinia magna pellentesque lorem ipsum dolor. Nullam et orci eu lorem consequat tincidunt. Vivamus et sagittis tempus.",
        //        Image = "Mobile.jpg"
        //    }
        //};
        public HomeController(ILogger<HomeController> logger)
        {
        }

        public IActionResult Index()
        {
            ViewData["headingText"] = "I'm trying to be a programmer.";
            ViewBag.headingText = "I'm trying to be a programmer.";
            return View();
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
    }
}
