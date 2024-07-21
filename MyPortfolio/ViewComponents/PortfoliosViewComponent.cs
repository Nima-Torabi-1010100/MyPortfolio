using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using System.Collections.Generic;

namespace MyPortfolio.ViewComponents
{
    public class PortfoliosViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Portfolio> _portfolios = new List<Portfolio>()
            {
                new Portfolio(1,"Web Page","Web.jpg"),
                new Portfolio(2,"Mobile App","Mobile.jpg")
            };
            return View("_Portfolios", _portfolios);
        }
    }
}
