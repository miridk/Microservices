using Microsoft.EntityFrameworkCore;
using WebApplication1.Persistence.Model;

namespace WebApplication1.Persistence
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {

        }
        public DbSet<OrderEf> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderEf>().ToTable("Order");
        }

        public DbSet<OrderEf> Order { get; set; }
    }
}
