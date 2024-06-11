using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MISApp.Data;
using MISApp.Models;
using System.Threading.Tasks;

namespace MISApp.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly MISContext _context;

        public DetailsModel(MISContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Products.FindAsync(id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
