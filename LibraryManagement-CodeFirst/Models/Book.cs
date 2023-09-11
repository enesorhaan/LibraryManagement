using System.Collections.Generic;

namespace LibraryManagement_CodeFirst.Models
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string PageCount { get; set; }
        public int AuthorID { get; set; }
        public int BookTypeID { get; set; }

        // Relational Property

        public virtual Author Author { get; set; }
        public virtual BookType BookType { get; set; }
        public virtual List<Operation> Operations { get; set; }
    }
}
