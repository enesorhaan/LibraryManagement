using LibraryManagement_CodeFirst.Context;
using LibraryManagement_CodeFirst.Dto;
using LibraryManagement_CodeFirst.Models;
using LibraryManagement_CodeFirst.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement_CodeFirst.Areas.Management.Controllers
{
    [Area("Management")]
    public class BookController : Controller
    {
        MyDbContext _db;
        IBookRepository _repoBook;
        IAuthorRepository _repoAuthor;
        IBookTypeRepository _repoBookType;

        public BookController(MyDbContext db, 
            IBookRepository repoBook,
            IAuthorRepository repoAuthor,
            IBookTypeRepository repoBookType)
        {
            _db = db;
            _repoBook = repoBook;
            _repoAuthor = repoAuthor;
            _repoBookType = repoBookType;
        }
        public IActionResult BookList()
        {
            List<BookDto> books = _db.Books.Where(b => b.Status != Enums.DataStatus.Deleted).Include(x => x.Author).Include(x => x.BookType).Select(x => 
            new BookDto()
            {
                ID = x.ID,
                Name = x.Name,
                PageCount = x.PageCount,
                AuthorName = x.Author.FullName,
                BookTypeName = x.BookType.Name
            }).ToList();
            return View(books);
        }

        public IActionResult Create()
        {
            List<AuthorDto> authors = _repoAuthor.SelectAuthorDto();
            List<BookTypeDto> booktypes = _repoBookType.SelectBookTypeDto();

            return View((new Book(),authors,booktypes));
        }
        [HttpPost]
        public IActionResult Create([Bind(Prefix = "Item1")] Book book)
        {
            _repoBook.Add(book);
            return RedirectToAction("BookList", "BookController", new {area = "Management"});
        }

        public IActionResult Edit(int id)
        {
            Book book = _db.Books.Find(id);
            List<AuthorDto> authors = _repoAuthor.SelectAuthorDto();
            List<BookTypeDto> booktypes = _repoBookType.SelectBookTypeDto();

            return View((book,authors,booktypes));
        }
        [HttpPost]
        public IActionResult Edit([Bind(Prefix = "Item1")] Book book)
        {
            if (book != null)
            {
                _repoBook.Update(book);
            }
            return RedirectToAction("BookList", "BookController", new { area = "Management" });
        }

        public IActionResult Delete(int id)
        {
            _repoBook.Delete(id);
            // _repoBook.SpecialDelete(id); // Hard Delete
            return RedirectToAction("BookList", "BookController", new { area = "Management" });
        }
    }
}
