using LibraryManagement_CodeFirst.Context;
using LibraryManagement_CodeFirst.Dto;
using LibraryManagement_CodeFirst.Models;
using LibraryManagement_CodeFirst.RepositoryPattern.Base;
using LibraryManagement_CodeFirst.RepositoryPattern.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement_CodeFirst.RepositoryPattern.Concrete
{
    public class BookTypeRepository : Repository<BookType>, IBookTypeRepository
    {
        public BookTypeRepository(MyDbContext db) : base(db)
        {}

        public List<BookTypeDto> SelectBookTypeDto()
        {
            return table.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x =>
            new BookTypeDto()
            {
                ID = x.ID,
                Name = x.Name,
            }).ToList();
        }
    }
}
