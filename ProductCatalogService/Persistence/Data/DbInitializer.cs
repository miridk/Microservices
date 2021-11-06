using MicroserviceEducation.Persistence.Model;
using ProductCatalog.Persistence.Repository;
using System.Linq;

namespace MicroserviceEducation.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(ProductContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            var products = new ProductEf[]
            {
            new ProductEf{Name="Carson", Price=135, EAN="EAN05765+547"}
            };
            foreach (ProductEf s in products)
            {
                context.Products.Add(s);
            }
            context.SaveChanges();


            
        }
    }
}
