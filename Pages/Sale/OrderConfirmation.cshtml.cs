using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace CS5227_A1_YICHE32405.Pages.Sale
{
    public class OrderConfirmationModel : PageModel
    {
        public int SaleId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public DateTime OrderTime { get; set; }

        public void OnGet(int id, string customerName, string customerEmail, string customerPhone, DateTime orderTime)
        {
            SaleId = id;
            CustomerName = customerName;
            CustomerEmail = customerEmail;
            CustomerPhone = customerPhone;
            OrderTime = orderTime;
        }
    }
}
