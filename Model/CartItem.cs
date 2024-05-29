using System.ComponentModel.DataAnnotations;

namespace CS5227_A1_YICHE32405.Model
{
    public class CartItem
    {
        public int CartItemId { get; set; }
        public int CartId { get; set; }
        public Cart Cart { get; set; }
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
    }
}