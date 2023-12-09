using Library_BlazorUI_Group_A_R53.Data.Models;
using System;

namespace Library_BlazorUI_Group_A_R53
{
    public interface IBorrowedBookService
    {
        Task<IEnumerable<BorrowedBook>> GetBorrowedBooks();
        Task<IEnumerable<BorrowedBook>> GetUserName(string username); //Add this method for filtering
        Task ApproveBorrowedBook(int borrowedBookId);
        Task CancelBorrowedBook(int borrowedBookId, string comment);
        Task ReturnBorrowedBook(int borrowedBookId, string remarks, decimal miscFine);

    }
}
