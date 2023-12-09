using Library_BlazorUI_Group_A_R53.Data.Models;

namespace Library_BlazorUI_Group_A_R53.Services
{
    public class CategoryService: ICategoryService
    {
        private readonly HttpClient httpClient;
        public CategoryService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await httpClient.GetFromJsonAsync<Category[]>("api/Categories");
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await httpClient.GetFromJsonAsync<Category>($"api/Categories/{id}");
        }

        public async Task CreateCategory(Category Category)
        {
            await httpClient.PostAsJsonAsync("api/Categories", Category);
        }
        public async Task UpdateCategory(Category Category)
        {
            await httpClient.PutAsJsonAsync($"api/Categories/{Category.CategoryId}", Category);
        }

        public async Task DeleteCategory(int id)
        {
            await httpClient.DeleteAsync($"api/Categories/{id}");
        }
    }
}