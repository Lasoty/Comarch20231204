using Bibliotekarz.Client.Services;
using Bibliotekarz.Shared.Model;
using Microsoft.AspNetCore.Components;
using System.Collections.ObjectModel;

namespace Bibliotekarz.Client.Pages;

public partial class Dashboard
{
    private ObservableCollection<BookDto> BookList { get; set; } = new();

    [Inject]
    public IBookService BookService { get; set; }

    [Inject]
    public IMessageService Messages { get; set; }

    [Inject]
    public NavigationManager NavigationManager { get; set; }

    private async Task LoadBooks()
    {
        List<BookDto> bookList = (await BookService.GetBooks()).ToList();
        BookList.Clear();
        foreach (BookDto book in bookList)
            BookList.Add(book);
    }

    protected override async Task OnInitializedAsync()
    {
        await LoadBooks();
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

            if (isDeleted)
            {
                await Messages.Success("Książka została usunięta.");
            }
            else
            {
                await Messages.Error("Nie udało się usunąć książki.");
            }
            //NavigationManager.NavigateTo("/");
            await LoadBooks();
        }

    }
}