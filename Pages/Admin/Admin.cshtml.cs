using CS5227_A1_YICHE32405.Areas.Identity.Data;
using CS5227_A1_YICHE32405.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CS5227_A1_YICHE32405.Pages.Admin
{
    [Authorize(Roles = "admin")]
    public class AdminModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;

        [BindProperty]
        public Menu? Menu { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }

        public List<Menu>? Menus { get; set; }

        public AdminModel(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public void OnGet()
        {
            Menus = _context.Menus?.ToList() ?? new List<Menu>();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Image == null || Image.Length == 0)
            {
                ModelState.AddModelError("Image", "Please upload an image.");
                return Page();
            }

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

            if (Menu != null)
            {
                Menu.ImageUrl = "/uploads/" + Image.FileName;
                _context.Menus.Add(Menu);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("/Admin/Admin");
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var menu = await _context.Menus.FindAsync(id);
            if (menu != null)
            {
                _context.Menus.Remove(menu);
                await _context.SaveChangesAsync();
            }
            return RedirectToPage("/Admin/Admin");
        }
    }
}
