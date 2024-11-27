using Microsoft.AspNetCore.Mvc;

namespace Group7FinalProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Properties");
        }
    }
}
