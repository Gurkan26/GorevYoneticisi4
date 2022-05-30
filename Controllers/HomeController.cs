using Microsoft.AspNetCore.Mvc;

namespace GorevYoneticisi4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
