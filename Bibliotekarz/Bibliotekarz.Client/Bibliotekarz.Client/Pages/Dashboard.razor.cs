using Bibliotekarz.Client.Services;
using Bibliotekarz.Shared.Model;
using Microsoft.AspNetCore.Components;

namespace Bibliotekarz.Client.Pages;

public partial class Dashboard
{
    private List<BookDto> bookList = new();

    [Inject]
    public IBookService BookService { get; set; }

    public IMessageService Messages { get; set; }


    protected override async Task OnInitializedAsync()
    {
        bookList = (await BookService.GetBooks()).ToList();
        await base.OnInitializedAsync();
    }

    private async void OnDeleteClicked(int bookId)
    {
        bool confirmed = await Messages.Confirm("Czy na pewno chcesz usunąć wybraną pozycję?", "Usuwanie książki", options =>
        {
            options.CancelButtonText = "Anuluj";
            options.ConfirmButtonText = "Usuń";
        });

        if (confirmed)
        {
            bool isDeleted = await BookService.DeleteBook(bookId);
            await Messages.Success("Książka została usunięta.");
            bookList = (await BookService.GetBooks()).ToList();
        }

    }
}