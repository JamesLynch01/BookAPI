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

        protected override void OnConfiguring(DbContextOptionsBuilder myBuilder)
        {
            myBuilder.UseSqlite("Data Source= Books.db");
        }

        protected override void OnModelCreating(ModelBuilder myModelBuilder)
        {
            base.OnModelCreating(myModelBuilder);

            myModelBuilder.Entity<Book>().HasData(
                new Book { Title = "The Hobbit", Author = "Tolkien", Category = "Fantasy"},
                new Book { Title = "Mistborn", Author = "Brandson", Category = "Fantasy"},
                new Book { Title = "Super Powereds: Year 1", Author = "Drew Hayes", Category = "Ubran Fantasy"}
                
                );
        }
    }
}
