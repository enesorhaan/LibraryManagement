using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement_CodeFirst.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy = "AdminPolicy")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
