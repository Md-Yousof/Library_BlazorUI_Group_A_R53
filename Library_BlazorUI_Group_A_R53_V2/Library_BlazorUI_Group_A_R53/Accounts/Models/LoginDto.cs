using System.ComponentModel.DataAnnotations;

namespace Library_BlazorUI_Group_A_R53.Accounts.Models
{
    // ----- Step 08
    public class LoginDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string Role { get; set; } //this is Extra for Roll Create
    }
}
