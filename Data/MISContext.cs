using Microsoft.EntityFrameworkCore;
using MISApp.Models;

namespace MISApp.Data
{
    public class MISContext : DbContext
    {
        public MISContext(DbContextOptions<MISContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
