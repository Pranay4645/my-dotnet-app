using Microsoft.AspNetCore.Mvc;

namespace MyDotnetApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Welcome to My .NET Web App!";
            return View();
        }
    }
}
