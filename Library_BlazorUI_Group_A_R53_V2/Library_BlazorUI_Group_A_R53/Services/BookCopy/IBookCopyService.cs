using Library_BlazorUI_Group_A_R53.Data.Models;

namespace Library_BlazorUI_Group_A_R53.Services
{
    public interface IBookCopyService
    {
        Task<IEnumerable<BookCopy>> GetBookCopies();
        Task<BookCopy> GetBookCopyById(int id);
        Task CreateBookCopy(BookCopy copy);
        Task UpdateBookCopy(BookCopy copy);
        Task DeleteBookCopy(int id);
    }
}

