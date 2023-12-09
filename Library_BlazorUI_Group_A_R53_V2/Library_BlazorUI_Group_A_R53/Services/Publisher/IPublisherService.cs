using Library_BlazorUI_Group_A_R53.Data.Models;
namespace Library_BlazorUI_Group_A_R53.Services
{

    public interface IPublisherService
    {
        Task<IEnumerable<Publisher>> GetPublishers();
        Task<Publisher> GetPublisherById(int id);
        Task CreatePublisher(Publisher bookFloor);
        Task UpdatePublisher(Publisher bookFloor);
        Task DeletePublisher(int id);
    }
}
