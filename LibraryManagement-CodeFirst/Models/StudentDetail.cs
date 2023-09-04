using System;

namespace LibraryManagement_CodeFirst.Models
{
    public class StudentDetail : BaseEntity
    {
        public string SchoolNumber { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; }
        public int StudentID { get; set; }

        // Relational Property

        public virtual Student Student { get; set; }
    }
}
