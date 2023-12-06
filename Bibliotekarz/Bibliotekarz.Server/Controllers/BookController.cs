using Bibliotekarz.Shared.Model;
using Microsoft.AspNetCore.Mvc;

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
    public BookController()
    {

    }



    [HttpGet("[action]")]
    public async Task<IActionResult> GetAll()
    {
        return Ok(BooksRepository.books);
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
