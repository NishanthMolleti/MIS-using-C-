using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MISApp.Data;
using MISApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MISApp.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly MISContext _context;

        public IndexModel(MISContext context)
        {
            _context = context;
        }

        public IList<Order> Orders { get; set; }

        public async Task OnGetAsync()
        {
            Orders = await _context.Orders.ToListAsync();
        }
    }
}
