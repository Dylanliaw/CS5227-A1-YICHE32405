using System.ComponentModel.DataAnnotations;

namespace CS5227_A1_YICHE32405.Model
{
    public class OrderItem
    {
        [Key]
        public int OrderId { get; set; }
        public string FoodName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
    }
}