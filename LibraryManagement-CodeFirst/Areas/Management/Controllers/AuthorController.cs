using LibraryManagement_CodeFirst.Models;
using LibraryManagement_CodeFirst.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LibraryManagement_CodeFirst.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy = "AdminPolicy")]
    public class AuthorController : Controller
    {
        IAuthorRepository _repoAuthor;
        public AuthorController(IAuthorRepository repoAuthor)
        {
            _repoAuthor = repoAuthor;
        }
        public IActionResult AuthorList()
        {
            List<Author> authors = _repoAuthor.GetActives();
            return View(authors);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Author author)
        {
            _repoAuthor.Add(author);
            return RedirectToAction("Authorlist", "Author", new { area = "Management" });
        }

        public IActionResult Edit(int id)
        {
            Author author = _repoAuthor.GetById(id);
            return View(author);
        }
        [HttpPost]
        public IActionResult Edit(Author author)
        {
            _repoAuthor.Update(author);
            return RedirectToAction("AuthorList", "Author", new { area = "Management" });
        }

        public IActionResult Delete(int id)
        {
            _repoAuthor.Delete(id);
            return RedirectToAction("AuthorList", "Author", new { area = "Management" });
        }
    }
}
