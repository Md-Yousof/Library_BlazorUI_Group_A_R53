namespace Library_BlazorUI_Group_A_R53.Data.Models
{
    public class Subcategory
    {
        public int SubcategoryId { get; set; }
        public string? DDCCode { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; } //this is extra for CategoryName show in Shelf list 
        public Category? Category { get; set; }

    }
}
