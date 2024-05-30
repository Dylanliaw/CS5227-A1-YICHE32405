using System;

namespace CS5227_A1_YICHE32405.Model
{
    public class Sale
    {
        public int Id { get; set; }
        public int CheckoutId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public DateTime OrderTime { get; set; }
        public int Quantity { get; set; }

       
    }
}