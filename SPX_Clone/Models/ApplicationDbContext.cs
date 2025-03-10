using Microsoft.EntityFrameworkCore;

namespace SPX_Clone.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Order> DonHangs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
    }
}