using Library_BlazorUI_Group_A_R53.Services;
using Library_BlazorUI_Group_A_R53.Data.Models;
namespace Library_BlazorUI_Group_A_R53
{

   
    public class AuthorService : IAuthorService
    {
        private readonly HttpClient httpClient;
        public AuthorService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<Author>> GetAuthors()
        {
            return await httpClient.GetFromJsonAsync<Author[]>("api/Author");
        }

        public async Task<Author> GetAuthorById(int id)
        {
            return await httpClient.GetFromJsonAsync<Author>($"api/Author/{id}");
        }

        public async Task CreateAuthor(Author author)
        {
            await httpClient.PostAsJsonAsync("api/Author", author);
        }

        public async Task DeleteAuthor(int id)
        {
            await httpClient.DeleteAsync($"api/Author/{id}");
        }
        public async Task UpdateAuthor(Author author)
        {
            await httpClient.PutAsJsonAsync($"api/Author/{author.AuthorId}", author);
        }

    }
}


