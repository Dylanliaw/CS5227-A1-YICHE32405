using CS5227_A1_YICHE32405.Areas.Identity.Data;
using CS5227_A1_YICHE32405.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace CS5227_A1_YICHE32405.Pages.Sale
{
    public class ShopModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ShopModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Menu> Menus { get; set; }
        public List<CartItem> CartItems { get; set; }
        public string Query { get; set; } // Add this property

        [TempData]
        public string Message { get; set; }

        public void OnGet(string category, string query) // Modify OnGet to accept query parameter
        {
            Query = query; // Set the Query property

            // Fetch menu items based on the specified category
            if (!string.IsNullOrEmpty(category))
            {
                Menus = _context.Menus.Where(m => m.Category == category).ToList();
            }
            else
            {
                // If no category is specified, return all menu items
                Menus = _context.Menus.ToList();
            }

            // Add Main Dishes to the menu
            var mainDishes = _context.Menus.Where(m => m.Category == "Main").ToList();
            if (mainDishes.Any())
            {
                Menus.AddRange(mainDishes);
            }

            // Filter menu items based on the search query
            if (!string.IsNullOrEmpty(query))
            {
                Menus = Menus.Where(m => m.FoodName.Contains(query)).ToList();
            }

            // Retrieve cart items
            var cart = HttpContext.Session.GetString("cart");
            CartItems = string.IsNullOrEmpty(cart) ? new List<CartItem>() : JsonConvert.DeserializeObject<List<CartItem>>(cart);
        }

        public IActionResult OnPostAddToCart(int foodId)
        {
            var foodItem = _context.Menus.Find(foodId);
            if (foodItem == null)
            {
                return NotFound();
            }

            var cart = HttpContext.Session.GetString("cart");
            List<CartItem> cartItems = cart == null ? new List<CartItem>() : JsonConvert.DeserializeObject<List<CartItem>>(cart);

            var cartItem = cartItems.SingleOrDefault(c => c.FoodId == foodId);
            if (cartItem == null)
            {
                cartItems.Add(new CartItem
                {
                    FoodId = foodId,
                    FoodName = foodItem.FoodName,
                    Price = foodItem.Price,
                    Quantity = 1,
                    ImageUrl = foodItem.ImageUrl // Assuming Menu model has ImageUrl property
                });
            }
            else
            {
                cartItem.Quantity++;
            }

            HttpContext.Session.SetString("cart", JsonConvert.SerializeObject(cartItems));

            // Set message for item added
            Message = $"{foodItem.FoodName} added to cart.";

            return RedirectToPage();
        }
    }
}
