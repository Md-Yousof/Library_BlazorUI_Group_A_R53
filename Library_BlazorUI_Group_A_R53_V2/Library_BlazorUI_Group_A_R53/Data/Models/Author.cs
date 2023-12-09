using System.Text.Json.Serialization;

namespace Library_BlazorUI_Group_A_R53.Data.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Biography { get; set; } //country of origin, famous for, brief description
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public bool? IsActive { get; set; }

        public ICollection<BookAuthor>? BookAuthor { get; set; } = null!;
        [JsonIgnore]
        public ICollection<UserPreference>? UserPreferences { get; set; } = null!;
    }
}
