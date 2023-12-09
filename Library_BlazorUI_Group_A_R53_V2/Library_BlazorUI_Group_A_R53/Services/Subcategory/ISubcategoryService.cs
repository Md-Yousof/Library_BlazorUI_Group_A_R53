using Library_BlazorUI_Group_A_R53.Data.Models;
namespace Library_BlazorUI_Group_A_R53.Services
{
    public interface ISubcategoryService
    {
        Task<IEnumerable<Subcategory>> GetSubcategories();
        Task<Subcategory> GetSubategoryById(int id);
        Task CreateSubcategory(Subcategory subcategory);
        Task UpdateSubcategory(Subcategory subcategory);
        Task DeleteSubcategory(int id);
    }
}
