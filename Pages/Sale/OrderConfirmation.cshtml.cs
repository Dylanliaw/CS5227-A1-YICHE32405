using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using CS5227_A1_YICHE32405.Model;

namespace CS5227_A1_YICHE32405.Pages.Sale
{
    public class OrderConfirmationModel : PageModel
    {
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPhone { get; set; }
        public string OrderTime { get; set; }

        public void OnGet()
        {
            // Retrieve order details from TempData
            CustomerName = TempData["CustomerName"]?.ToString();
            CustomerEmail = TempData["CustomerEmail"]?.ToString();
            CustomerPhone = TempData["CustomerPhone"]?.ToString();
            OrderTime = TempData["OrderTime"]?.ToString();
        }
    }
}
