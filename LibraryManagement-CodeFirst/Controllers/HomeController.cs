using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement_CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
