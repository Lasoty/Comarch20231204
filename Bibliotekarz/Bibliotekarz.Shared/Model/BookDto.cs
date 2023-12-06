using System.ComponentModel.DataAnnotations;

namespace Bibliotekarz.Shared.Model;

public class BookDto
{
    public int Id { get; set; }

    [Required]
    public string Author { get; set; }

    public string Title { get; set; }

    public int PageCount { get; set; }

    public bool IsBorrowed { get; set; }

    public CustomerDto Borrower { get; set; }
}