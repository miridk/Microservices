using MicroserviceEducation.Domain.Model;
using MicroserviceEducation.Persistence.Model;

namespace MicroserviceEducation.Persistence.Mappers
{
    public class CustomerEfMapper : ICustomerEfMapper
    {
        public ICustomer Map(CustomerEf customerEf)
        {
            return new Customer
            {
                ID = customerEf.ID,
                FirstName = customerEf.FirstName,
                LastName = customerEf.LastName,
                Street = customerEf.Street,
                PostCode = customerEf.PostCode,
                City = customerEf.City,
                Country = customerEf.Country,
                Phone = customerEf.Phone,
                Email = customerEf.Email,
            };
        }
        public CustomerEf Create(ICustomer customer)
        {
            return new CustomerEf
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Street = customer.Street,
                PostCode = customer.PostCode,
                City = customer.City,
                Country = customer.Country,
                Phone = customer.Phone,
                Email = customer.Email,
            };
        }
    }
}
