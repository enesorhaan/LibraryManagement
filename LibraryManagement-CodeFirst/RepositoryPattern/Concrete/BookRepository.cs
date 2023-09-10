using LibraryManagement_CodeFirst.Context;
using LibraryManagement_CodeFirst.Dto;
using LibraryManagement_CodeFirst.Models;
using LibraryManagement_CodeFirst.RepositoryPattern.Base;
using LibraryManagement_CodeFirst.RepositoryPattern.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement_CodeFirst.RepositoryPattern.Concrete
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(MyDbContext db) : base(db)
        {}

        public List<BookDto> GetBooks()
        {
            return table.Where(b => b.Status != Enums.DataStatus.Deleted).Include(x => x.Author).Include(x => x.BookType).Select(x =>
            new BookDto()
            {
                ID = x.ID,
                Name = x.Name,
                PageCount = x.PageCount,
                AuthorName = x.Author.FullName,
                BookTypeName = x.BookType.Name
            }).ToList();
        }
    }
}
