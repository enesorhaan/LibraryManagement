using LibraryManagement_CodeFirst.Context;
using LibraryManagement_CodeFirst.Models;
using LibraryManagement_CodeFirst.RepositoryPattern.Concrete;
using LibraryManagement_CodeFirst.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement_CodeFirst.Areas.Management.Controllers
{
    [Area("Management")]
    public class BookTypeController : Controller
    {
        IBookTypeRepository _repoBookType;
        public BookTypeController(IBookTypeRepository repoBookType)
        {
            _repoBookType = repoBookType;
        }

        public IActionResult BookTypeList()
        {
            List<BookType> bookTypes = _repoBookType.GetAll();
            return View(bookTypes);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BookType bookType)
        {
            _repoBookType.Add(bookType);
            return RedirectToAction("BookTypeList", "BookType", new { area = "Management"});
        }

        public IActionResult Edit(int id) 
        {
            BookType bookType = _repoBookType.GetById(id);
            return View(bookType); 
        }

        [HttpPost]
        public IActionResult Edit(BookType bookType)
        {
            _repoBookType.Update(bookType);
            return RedirectToAction("BookTypeList", "BookType", new { area = "Management" });
        }

        public IActionResult HardDelete (int id)
        {
            _repoBookType.SpecialDelete(id);
            return RedirectToAction("BookTypeList", "BookType", new { area = "Management" });
        }
    }
}
