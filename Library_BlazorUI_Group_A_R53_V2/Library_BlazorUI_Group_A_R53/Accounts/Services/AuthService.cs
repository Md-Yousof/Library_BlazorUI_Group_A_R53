using Microsoft.JSInterop;
using Library_BlazorUI_Group_A_R53.Accounts.Models;
namespace Library_BlazorUI_Group_A_R53.Accounts.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly IJSRuntime _jsRuntime;

        public AuthService(HttpClient httpClient, IJSRuntime jsRuntime)
        {
            _httpClient = httpClient;
            _jsRuntime = jsRuntime;
        }

        public async Task<UserDto> Register(RegisterDto registerDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Account/register", registerDto);

            if (response.IsSuccessStatusCode)
            {
                var user = await response.Content.ReadFromJsonAsync<UserDto>();
                if (user != null)
                {
                    // Store the user's display name and token in local storage
                    await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "userName", user.UserName);
                    await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "userJWT", user.JWT);
                }
                return user;
            }
            else
            {
                // Handle error here
                return null;
            }
        }

        public async Task<UserDto> Login(LoginDto loginDto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Account/login", loginDto);

            if (response.IsSuccessStatusCode)
            {
                var user = await response.Content.ReadFromJsonAsync<UserDto>();
                if (user != null)
                {
                    // Store the user's display name and token in local storage
                    await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "userName", user.UserName);
                    await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "userJWT", user.JWT);
                }
                return user;
            }
            else
            {
                // Handle error here
                return null;
            }
        }


        public async Task Logout()
        {
            // Clear user authentication data from local storage
            await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", "userName");
            await _jsRuntime.InvokeVoidAsync("localStorage.removeItem", "userJWT");
        }





    }
}
