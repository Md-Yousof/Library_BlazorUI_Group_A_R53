using Library_BlazorUI_Group_A_R53.Data.Models;

namespace Library_BlazorUI_Group_A_R53.Services
{
    public class SubscriptionUserService : ISubscriptionUserService
    {
        private readonly HttpClient httpClient;

        public SubscriptionUserService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<SubscriptionUser>> GetSubscriptionUserAll()
        {          
             var response = await httpClient.GetFromJsonAsync<IEnumerable<SubscriptionUser>>("api/SubscriptionUser");
             return response;
           
        }

        public async Task AcceptSubscriptionUserRequest(int subsUserId)
        {
                await httpClient.PutAsync($"api/SubscriptionUser/accept/{subsUserId}", null);         
        }
        public async Task RejectSubscriptionRequest(int subsUserId)
        {
            await httpClient.PutAsync($"api/SubscriptionUser/reject/{subsUserId}", null);        
        }
    }
}
