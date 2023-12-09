using Library_BlazorUI_Group_A_R53.Data.Models;
namespace Library_BlazorUI_Group_A_R53.Services
{
    public interface ISubscriptionPlanService
    {
        Task<IEnumerable<SubscriptionPlan>> GetSubscriptionPlans();
        Task<SubscriptionPlan> GetSubscriptionById(int id);

        Task CreateSubscriptionPlan(SubscriptionPlan subscriptionPlan);
        Task UpdateSubscriptionPlan(SubscriptionPlan subscriptionPlan);
        Task DeleteSubscriptionPlan(int id);

    }
}
