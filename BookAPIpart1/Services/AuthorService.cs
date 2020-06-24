using BookAPIpart1.Data;
using BookAPIpart1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPIpart1.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly DbContext _authorContext;

        public AuthorService(DbContext myContext)
        {
            _authorContext = myContext;
        }
        public Author Add(Author newAuthor)
        {
            _authorContext.Author.Add(newAuthor);
            _authorContext.SaveChanges();
            return newAuthor;
        }

        public void Delete(Author author)
        {
            var currentAuthor = _authorContext.Author.FirstOrDefault(a => a.Id == author.Id);
            if (currentAuthor != null)
            {
                _authorContext.Author.Remove(author);
                _authorContext.SaveChanges();
            }

        }

        public Author Get(int id)
        {
            return _authorContext.Author.FirstOrDefault(b => b.Id == id);
        }

        public IEnumerable<Author> GetAll()
        {
            return _authorContext.Author;
        }

        public Author Update(Author updatedBook)
        {
            return _authorContext.Author;
        }
    }
}
}
