using LibraryManagement_CodeFirst.Context;
using LibraryManagement_CodeFirst.Dto;
using LibraryManagement_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement_CodeFirst.Controllers
{
    public class BookController : Controller
    {
        MyDbContext _db;
        public BookController(MyDbContext db)
        {
            _db = db;
        }
        public IActionResult BookList()
        {
            return View();
        }

        public IActionResult Create()
        {
            List<AuthorDto> authors = _db.Authors.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x =>
            new AuthorDto()
            {
                ID = x.ID,
                FirstName = x.FirstName,
                LastName = x.LastName
            }).ToList();


            List<BookTypeDto> booktypes = _db.BookTypes.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x =>
            new BookTypeDto()
            {
                ID = x.ID,
                Name = x.Name,
            }).ToList();

            return View((new Book(),authors,booktypes));
        }
        [HttpPost]
        public IActionResult Create([Bind(Prefix = "Item1")] Book book)
        {
            _db.Books.Add(book);
            _db.SaveChanges();
            return RedirectToAction("BookList");
        }
    }
}
