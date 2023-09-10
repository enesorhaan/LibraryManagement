﻿using LibraryManagement_CodeFirst.Dto;
using LibraryManagement_CodeFirst.Models;
using System.Collections.Generic;

namespace LibraryManagement_CodeFirst.RepositoryPattern.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        List<AuthorDto> SelectAuthorDto();
    }
}
