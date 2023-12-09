using System.Text.Json.Serialization;

namespace Library_BlazorUI_Group_A_R53.Data.Models
{
    public class BookAuthor
    {
        public int BookId { get; set; }
        [JsonIgnore]
        public Book? Book { get; set; }
        public int AuthorId { get; set; }
        [JsonIgnore]
        public Author? Author { get; set; }

    }
}
