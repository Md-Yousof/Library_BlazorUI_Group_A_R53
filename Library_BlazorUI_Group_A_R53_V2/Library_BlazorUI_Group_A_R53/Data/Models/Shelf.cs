
using System.Runtime.CompilerServices;

namespace Library_BlazorUI_Group_A_R53.Data.Models
{
    public class Shelf
    {
        public int ShelfId { get; set; }
        public bool IsActive { get; set; }
        public string? ShelfName { get; set; }
        public int BookFloorId { get; set; }
        public BookFloor? BookFloor { get; set; }
        public string? BookFloorName { get; set; } //this is extra for BookFloorName show in list of Shelf 
        public virtual List<BookRack> BookRacks { get; set; } = new List<BookRack>();
      
    
        //[JsonIgnore]
        //public List<BookCopy> Copies { get; set; } = new List<BookCopy>();
    }
}
