using CS5227_A1_YICHE32405.Areas.Identity.Data;
using CS5227_A1_YICHE32405.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CS5227_A1_YICHE32405.Pages.Admin
{
    public class EditMenuItemModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;

        [BindProperty]
        public Menu Menu { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }

        public EditMenuItemModel(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Menu = await _context.Menus.FindAsync(id);
            if (Menu == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var menuInDb = await _context.Menus.FindAsync(id);
            if (menuInDb == null)
            {
                return NotFound();
            }

            if (Image != null)
            {
                var uploads = Path.Combine(_environment.WebRootPath, "uploads");
                if (!Directory.Exists(uploads))
                {
                    Directory.CreateDirectory(uploads);
                }
                var filePath = Path.Combine(uploads, Image.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await Image.CopyToAsync(stream);
                }
                menuInDb.ImageUrl = "/uploads/" + Image.FileName;
            }

            menuInDb.FoodName = Menu.FoodName;
            menuInDb.Description = Menu.Description;
            menuInDb.Price = Menu.Price;

            await _context.SaveChangesAsync();

            return RedirectToPage("/Admin/Admin");
        }
    }
}
