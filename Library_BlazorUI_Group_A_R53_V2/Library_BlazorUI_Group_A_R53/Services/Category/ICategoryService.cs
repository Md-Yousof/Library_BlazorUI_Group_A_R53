
using Library_BlazorUI_Group_A_R53.Data.Models;
namespace Library_BlazorUI_Group_A_R53.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategories();
        Task<Category> GetCategoryById(int id);
        Task CreateCategory(Category bookFloor);
        Task UpdateCategory(Category bookFloor);
        Task DeleteCategory(int id);

    }
}
