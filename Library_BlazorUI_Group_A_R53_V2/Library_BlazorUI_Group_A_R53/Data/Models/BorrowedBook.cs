using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Library_BlazorUI_Group_A_R53.Data.Models
{
    public class BorrowedBook
    {
        [Key]
        public int BorrowedBookId { get; set; }
        public string? UserId { get; set; }
       // [JsonIgnore]
       // public ApplicationUser? UserInfo { get; set; }
        public int BookId { get; set; }
        [JsonIgnore]
        public Book? Book { get; set; }
        public int BookCopyId { get; set; }
        //in frontend get call number by this id
        [JsonIgnore]
        public BookCopy? BookCopy { get; set; }
        public DateTime? BorrowDate { get; set; }
        public DateTime? DueDate { get; set; }
        public string? Status { get; set; }
        //public bool IsReturned { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ActualReturnDate { get; set; }
        public string? Comment { get; set; }
        public DateTime? RequestTimestamp { get; set; }
        // [JsonIgnore]
        // public ICollection<Inspection>? Inspection { get; set; }
        // [JsonIgnore]
        // public ICollection<Fine>? Fine { get; set; }

        public string? Title { get; set; } //this is extra for show in List
        public string? CallNumber { get; set; } //this is extra for show in List
    }
}
