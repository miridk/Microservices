using MicroserviceEducation.Persistence.Model;
using System.Linq;

namespace MicroserviceEducation.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(CustomerContext context)
        {
            context.Database.EnsureCreated();

            // Look for any customer.
            //if (context.Customers.Any())
            //{
            //    return;   // DB has been seeded
            //}

            var customers = new CustomerEf[]
            {
            new CustomerEf{FirstName="Michael",LastName="Alexander",Street="Almine Oestergade 3", City="Almind", Country="Denmark", Email="rinkovski@live.dk", Phone="22725300", PostCode="6051"},
            new CustomerEf{FirstName="Jonas",LastName="Alexander",Street="Almine Oestergade 3", City="Almind", Country="Denmark", Email="rinkovski@live.dk", Phone="22725300", PostCode="6051"},
            new CustomerEf{FirstName="Carson",LastName="Alexander",Street="Almine Oestergade 3", City="Almind", Country="Denmark", Email="rinkovski@live.dk", Phone="22725300", PostCode="6051"},
            new CustomerEf{FirstName="Carson",LastName="Alexander",Street="Almine Oestergade 3", City="Almind", Country="Denmark", Email="rinkovski@live.dk", Phone="22725300", PostCode="6051"},
            new CustomerEf{FirstName="Carson",LastName="Alexander",Street="Almine Oestergade 3", City="Almind", Country="Denmark", Email="rinkovski@live.dk", Phone="22725300", PostCode="6051"},
            new CustomerEf{FirstName="Carson",LastName="Alexander",Street="Almine Oestergade 3", City="Almind", Country="Denmark", Email="rinkovski@live.dk", Phone="22725300", PostCode="6051"},
            new CustomerEf{FirstName="Carson",LastName="Alexander",Street="Almine Oestergade 3", City="Almind", Country="Denmark", Email="rinkovski@live.dk", Phone="22725300", PostCode="6051"}
            };
            foreach (CustomerEf s in customers)
            {
                context.Customers.Add(s);
            }
            context.SaveChanges();


            
        }
    }
}
