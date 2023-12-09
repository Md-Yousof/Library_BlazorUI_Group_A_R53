using Library_BlazorUI_Group_A_R53.Data.Models;
using Library_BlazorUI_Group_A_R53.Services;

namespace Library_BlazorUI_Group_A_R53
{
    public class BookCopyService : IBookCopyService
    {
        private readonly HttpClient httpClient;
        public BookCopyService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<BookCopy>> GetBookCopies()
        {
            return await httpClient.GetFromJsonAsync<BookCopy[]>("api/BookCopy");
        }
        public async Task<BookCopy> GetBookCopyById(int id)
        {
            return await httpClient.GetFromJsonAsync<BookCopy>($"api/BookCopy/{id}");
        }
        public async Task CreateBookCopy(BookCopy copy)
        {
            await httpClient.PostAsJsonAsync("api/BookCopy", copy);
        }
        public async Task UpdateBookCopy(BookCopy copy)
        {
            await httpClient.PutAsJsonAsync($"api/BookCopy/{copy.BookCopyId}", copy);
        }
        public async Task DeleteBookCopy(int id)
        {
            await httpClient.DeleteAsync($"api/BookCopy/{id}");
        }

       
    }
}
