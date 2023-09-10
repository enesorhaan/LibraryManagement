using LibraryManagement_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LibraryManagement_CodeFirst.Initializer
{
    public static class DataInitializer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            string password1 = BCrypt.Net.BCrypt.HashPassword("123");
            string password2 = BCrypt.Net.BCrypt.HashPassword("1234");
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser() { ID = 1, UserName = "administrator", Password = password1, Role = Enums.Role.admin },
                new AppUser() { ID = 2, UserName = "enes", Password = password2, Role = Enums.Role.user }
            );

            modelBuilder.Entity<Student>().HasData(
                new Student() { ID = 1, FirstName = "Furkan", LastName = "Orhan", Gender = Enums.Gender.Male },
                new Student() { ID = 2, FirstName = "Serhan", LastName = "Orhan", Gender = Enums.Gender.Male },
                new Student() { ID = 3, FirstName = "Çiğdem", LastName = "Öztutan", Gender = Enums.Gender.Female },
                new Student() { ID = 4, FirstName = "Enes", LastName = "Esen", Gender = Enums.Gender.Male }
            );

            modelBuilder.Entity<StudentDetail>().HasData(
                new StudentDetail() { ID = 1, StudentID = 1, SchoolNumber = "100", BirthDay = new DateTime(1999, 6, 15) },
                new StudentDetail() { ID = 2, StudentID = 2, SchoolNumber = "101", BirthDay = new DateTime(1988, 8, 19) },
                new StudentDetail() { ID = 3, StudentID = 3, SchoolNumber = "102", BirthDay = new DateTime(1997, 1, 10) },
                new StudentDetail() { ID = 4, StudentID = 4, SchoolNumber = "103", BirthDay = new DateTime(1999, 8, 18) }
            );
        }
    }
}
