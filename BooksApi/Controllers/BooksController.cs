using System.Collections.Generic;
using BooksApi.Models;
using BooksApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BooksApi.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class BooksController : ControllerBase
    {

        // Retrieve All Books
        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get(bool includeSongs = false)
        {
            var books = Data.Books;
            return Ok(Data.Books);
        }


        // Retrieve Single book  - GET

        // Create Book // POST

        // Update Book // PUT

        // Delete Book  // DELETE
    }
}