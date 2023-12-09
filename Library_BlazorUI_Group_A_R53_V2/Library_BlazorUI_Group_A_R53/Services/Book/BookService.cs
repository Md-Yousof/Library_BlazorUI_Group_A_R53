using Library_BlazorUI_Group_A_R53.Data.Models;
namespace Library_BlazorUI_Group_A_R53.Services
{
    public class BookService : IBookService
    {

        private readonly HttpClient _httpClient;
       // private readonly IAuthorService _authorService;

        public BookService(HttpClient httpClient /*, IAuthorService authorService*/)
        {
            _httpClient = httpClient;
            //_authorService = authorService;
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await _httpClient.GetFromJsonAsync<Book[]>("api/Book");
        }
        //public async Task<IEnumerable<Book>> GetBooks()
        //{
        //    var books = await _httpClient.GetFromJsonAsync<Book[]>("api/Book");

        //     Fetch author names for each book
        //    foreach (var book in books)
        //    {
        //        var authorNames = new List<string>();
        //        foreach (var authorId in book.AuthorIds)
        //        {
        //            var author = await _authorService.GetAuthorById(authorId);
        //            if (author != null)
        //                authorNames.Add($"{author.FirstName} {author.LastName}");
        //        }
        //        book.AuthorNames = authorNames;
        //    }

        //    return books;
        //}

        public async Task<Book> GetBookById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Book>($"api/Book/{id}");
        }
        //public async Task CreateBook(Book book)
        //{
        //    await _httpClient.PostAsJsonAsync("api/Book", book);
        //}

        public async Task DeleteBook(int id)
        {
            await _httpClient.DeleteAsync($"api/Book/{id}");
        }

        public async Task UpdateBook(Book book)
        {
            await _httpClient.PutAsJsonAsync($"api/Book/{book.BookId}", book);
        }


        public async Task<Book> CreateBookAsync(MultipartFormDataContent formData)
        {
            try
            {
                // Send an HTTP POST request to the API with the form data
                var response = await _httpClient.PostAsync("api/Book", formData);

                if (response.IsSuccessStatusCode)
                {
                    // Product created successfully, read and return the response as a Product
                    return await response.Content.ReadFromJsonAsync<Book>();
                }
                else
                {
                    // If the response is not successful, handle the error
                    throw new Exception("Failed to create the product. HTTP Status Code: " + response.StatusCode);
                }
            }
            catch (HttpRequestException ex)
            {
                // Handle any network or HTTP-related errors and log the error if needed.
                throw new Exception("Failed to create the product. Error: " + ex.Message, ex);
            }
        }

    }
}
