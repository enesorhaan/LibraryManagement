﻿using LibraryManagement_CodeFirst.Configurations;
using LibraryManagement_CodeFirst.Initializer;
using LibraryManagement_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement_CodeFirst.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DataInitializer.Seed(modelBuilder);
            modelBuilder.ApplyConfiguration(new OperationConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<AppUser> Users { get; set; }
    }
}
