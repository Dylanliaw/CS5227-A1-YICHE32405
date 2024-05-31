using System.Collections.Generic;
using System.Linq;
using CS5227_A1_YICHE32405.Areas.Identity.Data;
using CS5227_A1_YICHE32405.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CS5227_A1_YICHE32405.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _context;

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public List<Menu> SpecialOffers { get; set; }

        public void OnGet()
        {
            // Fetch special offer menu items
            SpecialOffers = _context.Menus
                .Where(m => m.Category == "Special Offers") // Assuming "Special Offers" is a category
                .Take(3) // Limit to 4 special offers
                .ToList();
        }
    }
}
