using System.Text.Json.Serialization;
using System;

namespace Library_BlazorUI_Group_A_R53.Data.Models
{
    public class BookFloor
    {
        public int BookFloorId { get; set; }
        public string? BookFloorName { get; set; }
        public bool IsActive { get; set; }
        [JsonIgnore]
        public virtual List<Shelf> Shelves { get; set; } = new List<Shelf>();
    }
}
