using Library_BlazorUI_Group_A_R53.Data.Models;

namespace Library_BlazorUI_Group_A_R53
{
    public interface ISubscriptionUserService
    {
        Task<IEnumerable<SubscriptionUser>> GetSubscriptionUserAll();
       
        Task AcceptSubscriptionUserRequest(int subsUserId);
        Task RejectSubscriptionRequest(int subsUserId);
    }
}
