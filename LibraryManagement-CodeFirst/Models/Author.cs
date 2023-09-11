using LibraryManagement_CodeFirst.Models.MetaDataTypes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LibraryManagement_CodeFirst.Models
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }

        // Relational Property

        public virtual List<Book> Books { get; set; }
    }
}
