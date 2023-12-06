using Bibliotekarz.Server.Data.Context;
using Bibliotekarz.Shared.Model;

namespace Bibliotekarz.Server.Services;

public interface IBookService
{
    Task<IEnumerable<BookDto>> GetBooks();
}

public class BookService(ApplicationDbContext dbContext) : IBookService
{
    public async Task<IEnumerable<BookDto>> GetBooks()
    {
        //lepszy jest AutoMapper
        IEnumerable<BookDto> books = dbContext.Books.Select(b => new BookDto
        {
            Id = b.Id,
            Author = b.Author,
            IsBorrowed = b.IsBorrowed,
            PageCount = b.PageCount,
            Title = b.Title,
            Borrower = b.Borrower == null ? null : new CustomerDto()
            {
                Id = b.Borrower.Id,
                FirstName = b.Borrower.FirstName,
                LastName = b.Borrower.LastName
            }
        });

        return books;
    }
}
