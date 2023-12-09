using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Library_BlazorUI_Group_A_R53.Data.Models
{
    public class ApplicationUser  //IdentityUser er jn9 1ta Pk install korte hoice
    {
        public string? UserId { get; set; }
        public bool IsActive { get; set; }      
        public ICollection<Invoice>? Invoices { get; set; }
    }
}
