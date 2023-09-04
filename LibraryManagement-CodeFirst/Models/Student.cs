using LibraryManagement_CodeFirst.Enums;
using System;
using System.Collections.Generic;

namespace LibraryManagement_CodeFirst.Models
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }


        // Relational Property
        public virtual List<Operation> Operations { get; set; }

        public virtual StudentDetail StudentDetail { get; set; }

    }
}
