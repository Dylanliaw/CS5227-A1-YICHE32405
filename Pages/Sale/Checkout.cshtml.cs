using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using CS5227_A1_YICHE32405.Model;

namespace CS5227_A1_YICHE32405.Pages.Sale
{
    public class CheckoutModel : PageModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CheckoutModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public List<CartItem> CartItems { get; set; }

        [BindProperty]
        public Checkout CheckoutInfo { get; set; }

        public void OnGet()
        {
            LoadCart();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                // Reload cart items and return to checkout page if model is not valid
                LoadCart();
                return Page();
            }

            // Save order details and cart items to TempData
            TempData["CustomerName"] = CheckoutInfo.Name;
            TempData["CustomerEmail"] = CheckoutInfo.Email;
            TempData["CustomerPhone"] = CheckoutInfo.Phone;
            TempData["OrderTime"] = CheckoutInfo.OrderTime;
            TempData["CartItems"] = JsonConvert.SerializeObject(CartItems);

            SaveOrderToDatabase();

            HttpContext.Session.Remove("cart");

            return RedirectToPage("/Sale/OrderConfirmation");
        }

        private void LoadCart()
        {
            var cart = _httpContextAccessor.HttpContext.Session.GetString("cart");
            CartItems = cart == null ? new List<CartItem>() : JsonConvert.DeserializeObject<List<CartItem>>(cart);
        }

        private void SaveOrderToDatabase()
        {
            // Implement logic to save order details to the database
        }
    }
}
