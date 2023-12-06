using Bibliotekarz.Server.Data.Context;
using Bibliotekarz.Server.Services;
using Bibliotekarz.Shared.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Bibliotekarz.Server.Controllers;

public static class BooksRepository
{
    public static List<BookDto> books = new()
        {
            new BookDto { Id = 1, Author = "Leszek Lewandowski", Title = "Programowanie w C#", PageCount = 345, IsBorrowed = false},
            new BookDto { Id = 2, Author = "John Sharp", Title = "Design patterns", PageCount = 456, IsBorrowed = true, Borrower = new() { Id = 1, FirstName = "Jan", LastName = "Nowak" } }
        };
}

[ApiController]
[Route("api/[controller]")]
public class BookController : ControllerBase
{
    private readonly IBookService bookService;

    public BookController(ApplicationDbContext dbContext, IBookService bookService, Seeder seeder)
    {
        this.bookService = bookService;
        
        dbContext.Database.Migrate();
        seeder.Seed();
    }



    [HttpGet("[action]")]
    public async Task<IActionResult> GetAll()
    {
        IEnumerable<BookDto> books = await bookService.GetBooks();
        return Ok(books);
        //return BadRequest();
        //return NoContent();
        //return StatusCode(StatusCodes.Status201Created);
    }


    [HttpGet("[action]/{id}")]
    public async Task<IActionResult> Get(int id)
    {
        try
        {
            BookDto book = BooksRepository.books.First(x => x.Id == id);
            return Ok(book);
        }
        catch (Exception ex)
        {
            return BadRequest("Nie znaleziono książki");
        }
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Add([FromBody] BookDto book)
    {
        BooksRepository.books.Add(book);
        return Created($"api/Book/{book.Id}", book);
    }

    [HttpDelete("[action]/{id}")]
    public async Task<IActionResult> Delete(long id)
    {
        try
        {
            BookDto book = BooksRepository.books.First(x => x.Id == id);
            BooksRepository.books.Remove(book);
            return NoContent();
        }
        catch (Exception ex)
        {
            return NotFound($"Książka o id {id} nie istnieje w bazie danych.");
        }
    }
}
