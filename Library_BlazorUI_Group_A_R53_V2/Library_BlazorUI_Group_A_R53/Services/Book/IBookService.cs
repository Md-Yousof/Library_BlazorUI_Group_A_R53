using Library_BlazorUI_Group_A_R53.Data.Models;
using System.Text.Json;

namespace Library_BlazorUI_Group_A_R53
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetBooks();
        Task<Book> GetBookById(int id);
        //Task CreateBook(Book book);
        Task<Book> CreateBookAsync(MultipartFormDataContent formData);
        
        Task UpdateBook(Book book);
        Task DeleteBook(int id);
    }
}
