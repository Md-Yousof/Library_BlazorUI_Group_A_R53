
using Library_BlazorUI_Group_A_R53.Data.Models;
namespace Library_BlazorUI_Group_A_R53.Services.ShelfService
{
    public interface IShelfService
    {
        Task<IEnumerable<Shelf>> GetShelves();
        Task<Shelf> GetShelfById(int id);
        Task CreateShelf(Shelf shelf);
        Task UpdateShelf(Shelf shelf);
        Task DeleteShelf(int id);
        //Task CreateShelfWithBookRacks(Shelf shelf, List<BookRack> bookRacks);
    }
}
