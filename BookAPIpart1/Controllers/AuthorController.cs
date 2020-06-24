using BookAPIpart1.Model;
using BookAPIpart1.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPIpart1.Controllers
{
    public class AuthorController : ControllerBase
    {
        [Route("api/[controller]")]
        [ApiController]
        public class AuthorsController : ControllerBase
        {
            private readonly IAuthorService _authorService;

            // GET api/values
            [HttpGet]
            public IActionResult Get()
            {
                return Ok(_authorService.GetAll());
            }

            // GET api/values/5
            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                var author = _authorService.Get(id);
                if (author == null) return NotFound();
                return Ok(author);
            }

            // POST api/values
            [HttpPost]
            public IActionResult Post([FromBody] Author myNewAuthor)
            {
                var author = _authorService.Add(myNewAuthor);
                if (author == null) return BadRequest();
                return CreatedAtAction("Get", new { Id = myNewAuthor.Id }, myNewAuthor);
            }

            // PUT api/values/5
            [HttpPut("{id}")]
            public IActionResult Put(int id, [FromBody] Author myUpdatedAuthor)
            {
                var author = _authorService.Update(myUpdatedAuthor);
                if (author == null) return BadRequest();
                return Ok(author);
            }

            // DELETE api/values/5
            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                var author = _authorService.Get(id);
                _authorService.Delete(author);
                return NoContent();
            }
        }
    }
}
