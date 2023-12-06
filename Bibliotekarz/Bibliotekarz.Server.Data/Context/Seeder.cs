using Bibliotekarz.Shared.Model;

namespace Bibliotekarz.Server.Data.Context;

public class Seeder(ApplicationDbContext dbContext)
{
    public void Seed()
    {
        if (dbContext.Books.Any())
            return;

        List<Book> books = new()
        {
            new Book { Author = "John Sharp", Title = "Design patterns", PageCount = 456, IsBorrowed = true, Borrower = new() 
            { FirstName = "Jan", LastName = "Nowak" } },
            new Book { Author = "Leszek Lewandowski", Title = "Programowanie w C#", PageCount = 345, IsBorrowed = false},
        };

        dbContext.Books.AddRange(books);
        dbContext.SaveChanges();
    }
}
