using CS5227_A1_YICHE32405.Areas.Identity.Data;
using CS5227_A1_YICHE32405.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

public class ShopModel : PageModel
{
    private readonly ApplicationDbContext _context;

    public ShopModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Menu> Menus { get; set; }
    public List<CartItem> CartItems { get; set; }

    [TempData]
    public string Message { get; set; }

    public void OnGet()
    {
        Menus = _context.Menus.ToList();

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

    public IActionResult OnGetSearch(string query)
    {
        if (string.IsNullOrEmpty(query))
        {
            // If the search query is empty, return all food items
            Menus = _context.Menus.ToList();
        }
        else
        {
            // Filter food items based on the search query
            Menus = _context.Menus.Where(m => m.FoodName.Contains(query)).ToList();
        }

        if (Menus.Count == 0)
        {
            // If no food items match the search query, display a message
            Message = "No matching food items found.";
        }
        else
        {
            // Clear any previous message
            Message = null;
        }

        // Refresh the page to display the search results
        return Page();
    }
}
