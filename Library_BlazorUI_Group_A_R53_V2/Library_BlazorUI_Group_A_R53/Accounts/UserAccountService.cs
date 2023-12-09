using Library_BlazorUI_Group_A_R53.Accounts.Models;

namespace Library_BlazorUI_Group_A_R53.Accounts
{
    public class UserAccountService
    {
        private List<LoginDto> _users;

        public UserAccountService()
        {   
            _users = new List<LoginDto>
            {
                new LoginDto{Username= "admin@mail.com", Password="123456", Role = "Admin"},
                new LoginDto{Username = "user", Password="user", Role = "User"}
            };
        }
        public LoginDto? GetByUserName(string userName)
        {
            return _users.FirstOrDefault(x => x.Username == userName);
        }
    }
}