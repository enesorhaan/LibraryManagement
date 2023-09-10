using LibraryManagement_CodeFirst.Context;
using LibraryManagement_CodeFirst.Dto;
using LibraryManagement_CodeFirst.Models;
using LibraryManagement_CodeFirst.RepositoryPattern.Base;
using LibraryManagement_CodeFirst.RepositoryPattern.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement_CodeFirst.RepositoryPattern.Concrete
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(MyDbContext db) : base(db)
        {}

        public List<AuthorDto> SelectAuthorDto()
        {
            return table.Where(x => x.Status != Enums.DataStatus.Deleted).Select(x =>
            new AuthorDto()
            {
                ID = x.ID,
                FirstName = x.FirstName,
                LastName = x.LastName
            }).ToList();
        }
    }
}
