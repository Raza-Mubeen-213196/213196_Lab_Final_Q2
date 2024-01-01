using Microsoft.AspNetCore.Mvc;

namespace final1.Views
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
