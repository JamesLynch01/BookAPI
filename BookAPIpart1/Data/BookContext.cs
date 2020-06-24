using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAPIpart1.Model;
using System.Reflection;

namespace BookAPIpart1.Data
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder myBuilder)
        {
            myBuilder.UseSqlite("Data Source= Books.db");
        }

        protected override void OnModelCreating(ModelBuilder myModelBuilder)
        {
            base.OnModelCreating(myModelBuilder);

            myModelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "The Hobbit", Author = "Tolkien", Category = "Fantasy"},
                new Book { Id = 2, Title = "Mistborn", Author = "Brandson", Category = "Fantasy"},
                new Book { Id = 3, Title = "Super Powereds: Year 1", Author = "Drew Hayes", Category = "Ubran Fantasy"}
                
                );

            myModelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, firstName = "Clive", lastName = "Lewis", birthday = DateTime(1819, 11, 29)},
                new Author { Id = 2, firstName = "Brandon", lastName = "Sanderson", birthday = DateTime(1974, 5, 25) },
                new Author { Id = 3, firstName = "Drew", lastName = "Hayes", birthday = DateTime(1988, 10, 14)}
                
                );
        }
    }
}
