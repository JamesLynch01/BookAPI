using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAPIpart1.Model;
using BookAPIpart1.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace BookAPIpart1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksService _booksService;

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_booksService.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = _booksService.Get(id);
            if (book == null) return NotFound();
            return Ok(book);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Book myNewBook)
        {
            var book = _booksService.Add(myNewBook);
            if (book == null) return BadRequest();
            return CreatedAtAction("Get", new { Id = myNewBook.Id }, myNewBook);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Book myUpdatedBook)
        {
            var book = _booksService.Update(myUpdatedBook);
            if (book == null) return BadRequest();
            return Ok(book);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var book = _booksService.Get(id);
            _booksService.Delete(book);
            return NoContent();
        }
    }
}
