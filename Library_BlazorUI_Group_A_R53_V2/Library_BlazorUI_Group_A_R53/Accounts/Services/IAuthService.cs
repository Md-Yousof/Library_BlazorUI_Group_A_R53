using Library_BlazorUI_Group_A_R53.Accounts.Models;

namespace Library_BlazorUI_Group_A_R53.Accounts.Services
{
    public interface IAuthService
    {
        Task<UserDto> Login(LoginDto loginDto);
        Task Logout();
        Task<UserDto> Register(RegisterDto registerDto);
    }
}
