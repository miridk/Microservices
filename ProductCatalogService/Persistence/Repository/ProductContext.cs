using MicroserviceEducation.Persistence.Model;
using Microsoft.EntityFrameworkCore;

namespace ProductCatalog.Persistence.Repository
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        public DbSet<ProductEf> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEf>().ToTable("Product");
        }

        public DbSet<MicroserviceEducation.Application.Model.ProductDto> ProductDto { get; set; }
    }
}
