using Bibliotekarz.Shared.Model;
using System.Net.Http.Json;

namespace Bibliotekarz.Client.Services;

public interface IBookService
{
    Task<IEnumerable<BookDto>> GetBooks();
    Task<BookDto> GetBook(int id);
    Task<bool> AddBook(BookDto book);
    Task<bool> DeleteBook(int id);
}

public class BookService(HttpClient httpClient) : IBookService
{
    public async Task<bool> AddBook(BookDto book)
    {
        HttpResponseMessage response = await httpClient.PostAsJsonAsync("api/Book/Add", book);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteBook(int id)
    {
        HttpResponseMessage response = await httpClient.DeleteAsync($"api/Book/Delete/{id}");
        return response.IsSuccessStatusCode;
    }

    public async Task<BookDto> GetBook(int id)
    {
        BookDto? book = await httpClient.GetFromJsonAsync<BookDto>($"api/Book/Get/{id}");
        return book;
    }

    public async Task<IEnumerable<BookDto>> GetBooks()
    {
        IEnumerable<BookDto>? books = await httpClient.GetFromJsonAsync<IEnumerable<BookDto>>("api/Book/GetAll");
        return books;
    }
}
