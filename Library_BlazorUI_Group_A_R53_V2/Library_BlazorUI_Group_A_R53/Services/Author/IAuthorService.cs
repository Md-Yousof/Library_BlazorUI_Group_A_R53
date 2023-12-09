
using Library_BlazorUI_Group_A_R53.Data.Models;
namespace Library_BlazorUI_Group_A_R53
{
    public interface IAuthorService
    {
        Task<IEnumerable<Author>> GetAuthors();
        Task<Author> GetAuthorById(int id);
        Task CreateAuthor(Author author);
        Task UpdateAuthor(Author author);
        Task DeleteAuthor(int id);

    }
}
