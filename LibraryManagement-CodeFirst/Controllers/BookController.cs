using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement_CodeFirst.Controllers
{
    public class BookController : Controller
    {
        public IActionResult BookList()
        {
            return View();
        }
    }
}
