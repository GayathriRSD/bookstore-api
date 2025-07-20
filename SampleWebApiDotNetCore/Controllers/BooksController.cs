using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleWebApiDotNetCore.Data;
using SampleWebApiDotNetCore.Model;

namespace SampleWebApiDotNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //static private List<Book> books = new List<Book>
        //{
        //    new Book
        //    {
        //        Id=1, Title="tesT",YearPublished=1991
        //    },
        //    new Book
        //    {
        //        Id=2, Title="tesT2",YearPublished=1993
        //    },
        //    new Book
        //    {
        //        Id=3, Title="tesT3",YearPublished=1945
        //    }
        //};
        private  readonly FirstAPIContext _context;
        public BooksController(FirstAPIContext context)
        {
            _context=context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetBooks()
        {
            return Ok(await _context.books.ToListAsync());
        }

        //[HttpGet("{id}")]
        //public ActionResult<List<Book>> GetbookById(int id)
        //{
        //    var book = books.FirstOrDefault(x => x.Id==id);
        //    if (book ==null)
        //        return NotFound();

        //    return Ok(book);
        //}

        //[HttpPost]
        //public ActionResult<Book> Addbook(Book newBook)
        //{
        //    if (newBook == null)
        //        return BadRequest();
        //    books.Add(newBook);
        //    return CreatedAtAction(nameof(GetbookById), new { id = newBook.Id }, newBook);
        //}

        //[HttpPut("{id}")]
        //public IActionResult UpdateBook(int id, Book updateBook)
        //{ 
        //    var book = books.FirstOrDefault(x=>x.Id==id);
        //    if (book == null)
        //    {
        //        return NotFound();
        //    }

        //    book.Id= updateBook.Id;
        //    book.Title=updateBook.Title;
        //    book.Author=updateBook.Author;
        //    book.YearPublished=updateBook.YearPublished;
        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public IActionResult DeleteBook(int id) {
        //    var book = books.FirstOrDefault(x => x.Id==id);
        //    if (book == null)
        //    {
        //        return NotFound();
        //    }
        //    books.Remove(book);
        //    return NoContent();

        //}

    }
}
