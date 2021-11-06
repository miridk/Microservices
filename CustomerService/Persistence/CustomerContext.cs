using MicroserviceEducation.Persistence.Model;
using Microsoft.EntityFrameworkCore;

namespace MicroserviceEducation.Persistence
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {

        }
        public DbSet<CustomerEf> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerEf>().ToTable("Customer");
        }

        public DbSet<MicroserviceEducation.Application.Model.CustomerDto> CustomerDto { get; set; }
    }
}
