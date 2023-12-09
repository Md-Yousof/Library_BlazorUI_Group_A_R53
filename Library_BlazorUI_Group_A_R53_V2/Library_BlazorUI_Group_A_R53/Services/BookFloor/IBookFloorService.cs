using Library_BlazorUI_Group_A_R53.Data.Models;

namespace Library_BlazorUI_Group_A_R53.Services
{
    public interface IBookFloorService
    {
        Task<IEnumerable<BookFloor>> GetBookFloors();
        Task<BookFloor> GetBookFloorById(int id);
        Task CreateBookFloor(BookFloor bookFloor);
        Task UpdateBookFloor(BookFloor bookFloor);
        Task DeleteBookFloor(int id);
    }
}
