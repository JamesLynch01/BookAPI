using BookAPIpart1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPIpart1.Services
{
    interface IAuthorService
    {
        //get all authors
        IEnumerable<Author> GetAll();
        
        //Get a author by id
        Author Get(int id);

        //Add a new author
        Author Add(Author newAuthor);

        //Update a author
        Author Update(Author updatedAuthor);

        //Delete a author
        void Delete(Author author);
    }
}
