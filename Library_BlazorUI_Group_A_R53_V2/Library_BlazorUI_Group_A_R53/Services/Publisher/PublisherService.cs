
using Library_BlazorUI_Group_A_R53.Data.Models;
namespace Library_BlazorUI_Group_A_R53.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly HttpClient httpClient;
        public PublisherService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Publisher>> GetPublishers()
        {
            return await httpClient.GetFromJsonAsync<Publisher[]>("api/Publishers");
        }

        public async Task<Publisher> GetPublisherById(int id)
        {
            return await httpClient.GetFromJsonAsync<Publisher>($"api/Publishers/{id}");
        }

        public async Task CreatePublisher(Publisher Publisher)
        {
            await httpClient.PostAsJsonAsync("api/Publishers", Publisher);
        }     
        public async Task UpdatePublisher(Publisher Publisher)
        {
            await httpClient.PutAsJsonAsync($"api/Publishers/{Publisher.PublisherId}", Publisher);
        }

        public async Task DeletePublisher(int id)
        {
            await httpClient.DeleteAsync($"api/Publishers/{id}");
        }
    }
}
