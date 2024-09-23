using Microsoft.AspNetCore.Mvc;

namespace LA4_MVC_F2024.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello World")
            return View("Index");
        }
        // Minnesota contoller
        public IActionResult MN()
        {
            return View("MN");
        }
        // Wisconsin Controller
        public IActionResult WI()
        {
            return View("WI");
        }
    }
}
