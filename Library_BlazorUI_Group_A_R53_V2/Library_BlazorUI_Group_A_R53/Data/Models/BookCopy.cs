using System.Text.Json.Serialization;

namespace Library_BlazorUI_Group_A_R53.Data.Models
{
    public enum BookCondition
    {
        Good,
        ToRepair,
        Damaged,
    }

    public class BookCopy
    {
        public int BookCopyId { get; set; }
        public string? CallNumber { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsActive { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public BookCondition? condition { get; set; }
        public int BookId { get; set; }
        [JsonIgnore]
        public Book? Book { get; set; }
        public string DDC { get; set; }
        public int ShelfId { get; set; }
        [JsonIgnore]
        public Shelf? Shelf { get; set; }
        //[JsonIgnore]
        //public ICollection<BorrowedBook>? BorrowBook { get; set; }
        // [JsonIgnore]
        //public ICollection<Inspection>? Inspections { get; set; }

        public string? Title { get; set; }   //this is Extra for Title maping in GetTitle Methood in List of BookCopy;
        public string? ShelfName { get; set; } //this is Extra for ShelfName maping in GetTitle Methood in List of BookCopy;
    }
}
