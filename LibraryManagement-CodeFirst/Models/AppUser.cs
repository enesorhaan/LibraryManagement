using LibraryManagement_CodeFirst.Enums;

namespace LibraryManagement_CodeFirst.Models
{
    public class AppUser : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
