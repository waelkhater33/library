using Microsoft.AspNetCore.Mvc;

namespace My_Data
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
