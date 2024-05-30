using CS5227_A1_YICHE32405.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace CS5227_A1_YICHE32405.Pages.Sale
{
    public class CartModel : PageModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CartModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public List<CartItem> CartItems { get; set; }

        public void OnGet()
        {
            LoadCart();
        }

        public IActionResult OnPostChangeQuantity(int id, string action, int quantity)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                var cartItems = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                var itemToChange = cartItems.FirstOrDefault(item => item.FoodId == id);
                if (itemToChange != null)
                {
                    if (action == "increase")
                    {
                        itemToChange.Quantity++;
                    }
                    else if (action == "decrease" && itemToChange.Quantity > 1)
                    {
                        itemToChange.Quantity--;
                    }
                    HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cartItems));
                }
            }
            return RedirectToPage();
        }

        public IActionResult OnPostRemoveFromCart(int id)
        {
            var cart = HttpContext.Session.GetString("cart");
            if (cart != null)
            {
                var cartItems = JsonConvert.DeserializeObject<List<CartItem>>(cart);
                var itemToRemove = cartItems.FirstOrDefault(item => item.FoodId == id);
                if (itemToRemove != null)
                {
                    cartItems.Remove(itemToRemove);
                    HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cartItems));
                }
            }
            return RedirectToPage();
        }

        public IActionResult OnPostClearCart()
        {
            HttpContext.Session.Remove("cart");
            return RedirectToPage();
        }

        private void LoadCart()
        {
            var cart = HttpContext.Session.GetString("cart");
            CartItems = cart == null ? new List<CartItem>() : JsonConvert.DeserializeObject<List<CartItem>>(cart);
        }
    }
}
