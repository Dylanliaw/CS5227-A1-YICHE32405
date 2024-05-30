using CS5227_A1_YICHE32405.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

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
                return Page();
            }

            SaveOrderToDatabase();

            HttpContext.Session.Remove("cart");

            return RedirectToPage("/OrderConfirmation");
        }

        private void LoadCart()
        {
            var cart = _httpContextAccessor.HttpContext.Session.GetString("cart");
            CartItems = cart == null ? new List<CartItem>() : JsonConvert.DeserializeObject<List<CartItem>>(cart);
        }

        private void SaveOrderToDatabase()
        {
            // Save the order details to the database
        }
    }
}
