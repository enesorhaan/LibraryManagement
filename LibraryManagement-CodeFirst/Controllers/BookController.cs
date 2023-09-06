using LibraryManagement_CodeFirst.Context;
using LibraryManagement_CodeFirst.Dto;
using LibraryManagement_CodeFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
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

        public IActionResult Edit(int id)
        {
            Book book = _db.Books.Find(id);
            List<AuthorDto> authors = _db.Authors.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x =>
            new AuthorDto
            {
                ID = x.ID,
                FirstName = x.FirstName,
                LastName = x.LastName
            }).ToList();

            List<BookTypeDto> booktypes = _db.BookTypes.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x =>
            new BookTypeDto
            {
                ID= x.ID,
                Name = x.Name
            }).ToList();
            return View((book,authors,booktypes));
        }
        [HttpPost]
        public IActionResult Edit([Bind(Prefix = "Item1")] Book book)
        {
            if (book != null)
            {
                book.Status = Enums.DataStatus.Updated;
                book.ModifiedDate = DateTime.Now;
                _db.Books.Update(book);
                _db.SaveChanges();
            }
            return RedirectToAction("BookList");
        }

        public IActionResult Delete(int id)
        {
            Book book = _db.Books.Find(id);
            book.Status = Enums.DataStatus.Deleted;
            book.ModifiedDate = DateTime.Now;
            //_db.Books.Remove(book); Hard Delete
            _db.SaveChanges();
            return RedirectToAction("BookList");
        }
    }
}
