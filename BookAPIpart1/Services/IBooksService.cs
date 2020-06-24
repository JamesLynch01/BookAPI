using BookAPIpart1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPIpart1.Services
{
    public interface IBooksService
    {
        //get all books
        IEnumerable<Book> GetAll();
        //Get a book by id
        Book Get(int id);

        //Add a new book
        Book Add(Book newBooks);

        //Update a book
        Book Update(Book updatedBook);

        //Delete a book
        void Delete(Book book);
    }
}
