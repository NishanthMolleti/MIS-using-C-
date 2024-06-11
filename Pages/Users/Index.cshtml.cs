using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MISApp.Data;
using MISApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MISApp.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly MISContext _context;

        public IndexModel(MISContext context)
        {
            _context = context;
        }

        public IList<User> Users { get; set; }

        public async Task OnGetAsync()
        {
            Users = await _context.Users.ToListAsync();
        }
    }
}
