using System.Linq;
using WebApplication1.Persistence.Model;

namespace WebApplication1.Persistence.Data
{
    public class DbInitializer
    {
        public static void Initialize(OrderContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Orders.Any())
            {
                return;   // DB has been seeded
            }

            var orders = new OrderEf[]
            {
            new OrderEf{CustomerId=1, OrderNo="OD4385464389" }
            };
            foreach (OrderEf s in orders)
            {
                context.Orders.Add(s);
            }
            context.SaveChanges();



        }
    }
}
