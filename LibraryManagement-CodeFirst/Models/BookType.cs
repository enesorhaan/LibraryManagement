using System.Collections.Generic;

namespace LibraryManagement_CodeFirst.Models
{
    public class BookType : BaseEntity
    {
        public string Name { get; set; }

        //Relational Property

        public virtual List<Book> Books { get; set; }
    }
}
