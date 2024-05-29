namespace CS5227_A1_YICHE32405.Model
{
    public class Cart
    {
        public int CartId { get; set; }
        public string UserId { get; set; }
        public List<CartItem> CartItems { get; set; }
    }
}