using Library_BlazorUI_Group_A_R53.Data.Models;
using System.Net.Http.Json;

namespace Library_BlazorUI_Group_A_R53.Services
{
    public class SubscriptionPlanService : ISubscriptionPlanService
    {
        private readonly HttpClient _httpClient;
        public SubscriptionPlanService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<IEnumerable<SubscriptionPlan>> GetSubscriptionPlans()
        {
            return await _httpClient.GetFromJsonAsync<SubscriptionPlan[]>("api/subscriptionPlans");        
        }
        public async Task<SubscriptionPlan> GetSubscriptionById(int id)
        {
            return await _httpClient.GetFromJsonAsync<SubscriptionPlan>($"api/subscriptionPlans/{id}");
        }
     
        public async Task CreateSubscriptionPlan(SubscriptionPlan subscriptionPlan)
        {
           await _httpClient.PostAsJsonAsync("api/subscriptionPlans", subscriptionPlan);
        }
        public async Task UpdateSubscriptionPlan(SubscriptionPlan subscriptionPlan)
        {
            await _httpClient.PutAsJsonAsync($"api/subscriptionPlans/{subscriptionPlan.SubscriptionPlanId}", subscriptionPlan);
        }

        public async Task DeleteSubscriptionPlan(int id)
        {
           await _httpClient.DeleteAsync($"api/subscriptionPlans/{id}");
        }

      

      
    }
}
