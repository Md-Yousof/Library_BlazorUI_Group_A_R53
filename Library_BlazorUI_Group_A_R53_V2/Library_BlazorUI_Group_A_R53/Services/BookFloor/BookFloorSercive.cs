using Library_BlazorUI_Group_A_R53.Data.Models;
using System.Net.Http;

namespace Library_BlazorUI_Group_A_R53.Services
{
    public class BookFloorSercive : IBookFloorService
    {
        private readonly HttpClient httpClient;
        public BookFloorSercive(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<BookFloor>> GetBookFloors()
        {
            return await httpClient.GetFromJsonAsync<BookFloor[]>("api/BookFloors");
        }
      
        public async Task<BookFloor> GetBookFloorById(int id)
        {
            return await httpClient.GetFromJsonAsync<BookFloor>($"api/BookFloors/{id}");
        }

        public async Task CreateBookFloor(BookFloor bookFloor)
        {
            await httpClient.PostAsJsonAsync("api/BookFloors", bookFloor);
        }

        public async Task DeleteBookFloor(int id)
        {
            await httpClient.DeleteAsync($"api/BookFloors/{id}");
        }
        public async Task UpdateBookFloor(BookFloor bookFloor)
        {
            await httpClient.PutAsJsonAsync($"api/BookFloors/{bookFloor.BookFloorId}", bookFloor);
        }
        
    }
}


