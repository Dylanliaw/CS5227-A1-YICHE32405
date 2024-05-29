using System.ComponentModel.DataAnnotations;

namespace CS5227_A1_YICHE32405.Model
{
    public class SpecialOffer
    {
        [Key]
        public int FoodId { get; set; }
        public string? FoodName { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }
        public DateTime EndDate { get; set; }
        public string? ImageUrl { get; set; }
    }
}
