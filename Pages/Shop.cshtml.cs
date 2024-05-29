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

    public void OnGet()
    {
        Menus = _context.Menus.ToList();
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

        return RedirectToPage();
    }

    public void OnGetCart()
    {
        var cart = HttpContext.Session.GetString("cart");
        CartItems = string.IsNullOrEmpty(cart) ? new List<CartItem>() : JsonConvert.DeserializeObject<List<CartItem>>(cart);
    }
}
