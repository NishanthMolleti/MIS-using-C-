using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MISApp.Data;
using MISApp.Models;
using System.Threading.Tasks;

namespace MISApp.Pages.Orders
{
    public class CreateModel : PageModel
    {
        private readonly MISContext _context;

        public CreateModel(MISContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Order Order { get; set; }

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

            _context.Orders.Add(Order);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
