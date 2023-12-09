using Library_BlazorUI_Group_A_R53.Data.Models;
namespace Library_BlazorUI_Group_A_R53.Services
{
    public class SubcatergoryService : ISubcategoryService
    {
        private readonly HttpClient httpClient;
        public SubcatergoryService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Subcategory>> GetSubcategories()
        {
            return await httpClient.GetFromJsonAsync<Subcategory[]>("api/Subcategory");
        }

        public async Task<Subcategory> GetSubategoryById(int id)
        {
            return await httpClient.GetFromJsonAsync<Subcategory>($"api/Subcategory/{id}");
        }

        public async Task CreateSubcategory(Subcategory Subcategory)
        {
            await httpClient.PostAsJsonAsync("api/Subcategory", Subcategory);
        }
        public async Task UpdateSubcategory(Subcategory Subcategory)
        {
            await httpClient.PutAsJsonAsync($"api/Subcategory/{Subcategory.SubcategoryId}", Subcategory);
        }

        public async Task DeleteSubcategory(int id)
        {
            await httpClient.DeleteAsync($"api/Subcategory/{id}");
        }
    }
}