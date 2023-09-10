using LibraryManagement_CodeFirst.Models;
using LibraryManagement_CodeFirst.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement_CodeFirst.Controllers
{
    public class AuthController : Controller
    {
        IRepository<AppUser> _repoUser;
        public AuthController(IRepository<AppUser> repoUser)
        {
            _repoUser = repoUser;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(AppUser user)
        {
            if (_repoUser.Any(x => x.UserName == user.UserName && x.Status != Enums.DataStatus.Deleted))
            {
                AppUser selectedUser = _repoUser.Default(x => x.UserName == user.UserName && x.Status != Enums.DataStatus.Deleted );
                bool isValid = BCrypt.Net.BCrypt.Verify(user.Password,selectedUser.Password);
                if(isValid)
                {
                    if (selectedUser.Role == Enums.Role.admin)
                    {
                        return RedirectToAction("Index","Home",new {area="Management"});
                    }else if (selectedUser.Role == Enums.Role.user)
                    {
                        return RedirectToAction("Index","Home",null);
                    }
                }
            }
            return View();
        }
    }
}
