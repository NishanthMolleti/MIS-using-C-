using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MISApp.Data;
using MISApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MISApp.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly MISContext _context;

        public IndexModel(MISContext context)
        {
            _context = context;
        }

        public IList<Product> Products { get; set; }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }
    }
}
