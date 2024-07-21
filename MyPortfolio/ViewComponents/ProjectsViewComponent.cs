using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using System.Collections.Generic;
using System.Security.Permissions;

namespace MyPortfolio.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Project> _projects = new List<Project>()
            {
                new Project(1,"Web Page","Nullam et orci eu lorem consequat tincidunt vivamus " +
                "et sagittis magna sed nunc rhoncus condimentum sem. In efficitur ligula tate urna." +
                " Maecenas massa sed magna lacinia magna pellentesque lorem ipsum dolor. Nullam et " +
                "orci eu lorem consequat tincidunt. Vivamus et sagittis tempus.", "Web.jpg"),
                new Project(2,"Application","Nullam et orci eu lorem consequat tincidunt vivamus " +
                "et sagittis magna sed nunc rhoncus condimentum sem. In efficitur ligula tate urna." +
                " Maecenas massa sed magna lacinia magna pellentesque lorem ipsum dolor. Nullam et " +
                "orci eu lorem consequat tincidunt. Vivamus et sagittis tempus.", "Mobile.jpg")
            };
            return View("_Projects", _projects);
        }
    }
}
