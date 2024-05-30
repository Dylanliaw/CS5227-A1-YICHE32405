using System.ComponentModel.DataAnnotations;

namespace CS5227_A1_YICHE32405.Model
{
    public class Checkout
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime OrderTime { get; set; }
    }
}
