using Bibliotekarz.Client.Services;
using Bibliotekarz.Shared.Model;
using Microsoft.AspNetCore.Components;

namespace Bibliotekarz.Client.Pages;

public partial class AddBookPage
{
    public BookDto Vm { get; set; } = new()
    {
        Borrower = new CustomerDto()
    };

    [Inject]
    public IBookService BookService { get; set; }

    public NavigationManager Navigation { get; set; }

    protected override Task OnInitializedAsync()
    {
        return base.OnInitializedAsync();
    }

    private async void OnSaveClicked()
    {
        if (!Vm.IsBorrowed)
        {
            Vm.Borrower = null;
        }

        bool isSaved = await BookService.AddBook(Vm);

        if (isSaved)
        {
            Navigation.NavigateTo("/");
        }
    }

}
