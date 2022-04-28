using Microsoft.AspNetCore.Mvc;

namespace WebApplicationComputersProject.Controllers
{
    public class OverviewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
