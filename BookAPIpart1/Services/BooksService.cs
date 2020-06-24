using BookAPIpart1.Model;
using BookAPIpart1.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace BookAPIpart1.Services
{
    public class BooksService : IBooksService
    {
        private readonly DbContext _bookContext;

        public BooksService(DbContext myContext)
        {
            _bookContext = myContext;
        }
        public Book Add(Book newBook)
        {
            _bookContext.Books.Add(newBook);
            _bookContext.SaveChanges();
            return newBook;
        }

        public void Delete(Book book)
        {
            var currentBook = _bookContext.Book.FirstOrDefault(b => b.Id == book.Id);
            if (currentBook != null)
            {
                _bookContext.Book.Remove(book);
                _bookContext.SaveChanges();
            }

        }

        public Book Get(int id)
        {
            return _bookContext.Books.FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<Book> GetAll()
        {
            return _bookContext.Books;
        }

        public Book Update(Book updatedBook)
        {
            return _bookContext.Books;
        }
    }
}
