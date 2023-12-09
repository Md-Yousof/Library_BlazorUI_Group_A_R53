using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Library_BlazorUI_Group_A_R53.Data.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public string? ISBN { get; set; }
        public int PublisherId { get; set; }
        public DateTime PublishedYear { get; set; }
        public string? Edition { get; set; }
        public int? TotalCopies { get; set; }
        public string? Language { get; set; }
        public string? Description { get; set; }
        public decimal? BookPrice { get; set; }

        public string? DDCCode { get; set; }
        public bool IsActive { get; set; }

        public IFormFile? Cover { get; set; }
        public bool IsDigital { get; set; }
        public IFormFile? EBook { get; set; }
        public bool PublisherAgreement { get; set; }
        public IFormFile? AgreementBookCopy { get; set; }
        public int CategoryId { get; set; }
        //[JsonIgnore]
        public ICollection<BookAuthor>? BookAuthor { get; set; } = new List<BookAuthor>();
        public ICollection<int>? AuthorIds { get; set; }
        public ICollection<int>? AuthorIdsToRemove { get; set; }



        public string? CoverFileName { get; set; }
        public string? EBookFileName { get; set; }
        public string? AgreementFileName { get; set; }
        public List<int> SelectedAuthorIds { get; set; } = new List<int>();
        public string? CategoryName { get; set; }    //this is extra for Get Name in list
        public string? PublisherName { get; set; }   //this is extra for Get Name in list

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        // public ICollection<int>? AuthorIds { get; set; }
        // public ICollection<string> AuthorNames { get; set; }
        //public ICollection<int> AuthorIds { get; set; } = new List<int>();
        public ICollection<string> AuthorNames { get; set; } = new List<string>(); // New property for author names

    }
}
