using System.Text.Json.Serialization;

namespace Library_BlazorUI_Group_A_R53.Data.Models
{
    public class BookRack
    {
        public int BookRackId { get; set; }
        public string? BookRackName { get; set; }
        public int ShelfId { get; set; }
        [JsonIgnore]
        public Shelf? Shelf { get; set; }
    }
}
