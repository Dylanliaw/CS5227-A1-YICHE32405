using System.ComponentModel.DataAnnotations;

namespace CS5227_A1_YICHE32405.Model
{
    public class Menu
    {
        [Key]
        public int FoodId { get; set; }
        public string? FoodName { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? Category { get; set; } // Category represented as string
    }
}
