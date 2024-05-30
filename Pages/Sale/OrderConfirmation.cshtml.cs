using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace CS5227_A1_YICHE32405.Pages.Sale
{
    public class OrderConfirmationModel : PageModel
    {
        public string CustomerName { get; set; }
        public DateTime OrderedTime { get; set; }

        public void OnGet(string customerName, DateTime orderedTime)
        {
            CustomerName = customerName;
            OrderedTime = orderedTime;
        }
    }
}
