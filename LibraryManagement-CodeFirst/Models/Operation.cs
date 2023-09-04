using System;
using System.Collections.Generic;

namespace LibraryManagement_CodeFirst.Models
{
    public class Operation : BaseEntity
    {
        public int StudentID { get; set; }
        public int BookID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Relational Property

        public virtual Student Student { get; set; }
        public virtual Book Book { get; set; }
    }
}
