using CS5227_A1_YICHE32405.Areas.Identity.Data;
using CS5227_A1_YICHE32405.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Threading.Tasks;

namespace CS5227_A1_YICHE32405.Pages.Contact
{
    public class ContactModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ContactModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Customer Customer { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Customer.CreatedDate = DateTime.Now;
            _context.Customer.Add(Customer);
            await _context.SaveChangesAsync();

            // Add code to send email here

            TempData["Message"] = "Thank you for your message. We will get back to you soon.";
            return RedirectToPage("/Contact/Contact");
        }
    }
}
