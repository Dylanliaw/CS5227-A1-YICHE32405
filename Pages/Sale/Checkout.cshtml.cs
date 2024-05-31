using CS5227_A1_YICHE32405.Areas.Identity.Data;
using CS5227_A1_YICHE32405.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CS5227_A1_YICHE32405.Pages.Sale
{
    public class CheckoutModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();

        [BindProperty]
        public CS5227_A1_YICHE32405.Model.Sale Sale { get; set; }

        public void OnGet()
        {
            LoadCart();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                LoadCart();
                return Page();
            }

            var sale = new CS5227_A1_YICHE32405.Model.Sale
            {
                CustomerName = Sale.CustomerName,
                CustomerEmail = Sale.CustomerEmail,
                CustomerPhone = Sale.CustomerPhone,
                OrderTime = DateTime.Now,
                Quantity = CartItems.Sum(item => item.Quantity)
            };

            _context.Sales.Add(sale);
            await _context.SaveChangesAsync();

            // Clear the cart after successful checkout
            HttpContext.Session.Remove("cart");

            // Redirect to the order confirmation page after successfully processing the order
            return RedirectToPage("/Sale/OrderConfirmation", new { id = sale.Id, customerName = sale.CustomerName, customerEmail = sale.CustomerEmail, customerPhone = sale.CustomerPhone, orderTime = sale.OrderTime });
        }

        private void LoadCart()
        {
            var cart = HttpContext.Session.GetString("cart");
            CartItems = cart == null ? new List<CartItem>() : JsonConvert.DeserializeObject<List<CartItem>>(cart);
        }
    }
}
