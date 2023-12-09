
using Library_BlazorUI_Group_A_R53.Data.Models;


namespace Library_BlazorUI_Group_A_R53.Services.ShelfService
{
    public class ShelfService : IShelfService
    {
        private readonly HttpClient _httpClient;
        public ShelfService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<IEnumerable<Shelf>> GetShelves()
        {
            return await _httpClient.GetFromJsonAsync<Shelf[]>("api/Shelf");
        }
        public async Task<Shelf> GetShelfById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Shelf>($"api/Shelf/{id}");
        }
        public async Task CreateShelf(Shelf shelf)
        {
            await _httpClient.PostAsJsonAsync("api/Shelf", shelf);
        }
   
        public async Task DeleteShelf(int id)
        {
            await _httpClient.DeleteAsync($"api/Shelf/{id}");
        }

        public async Task UpdateShelf(Shelf shelf)
        {
            await _httpClient.PutAsJsonAsync($"api/Shelf/{shelf.ShelfId}", shelf);
        }

    }
}

