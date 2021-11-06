using MicroserviceEducation.Domain.Model;
using MicroserviceEducation.Domain.Repository;
using MicroserviceEducation.Persistence.Mappers;

using MicroserviceEducation.Persistence.Model;
using System.Linq;

namespace MicroserviceEducation.Persistence
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerContext _Context;
        private readonly ICustomerEfMapper _CustomerEfMapper;
        public CustomerRepository(CustomerContext context, ICustomerEfMapper customerEfMapper)
        {
            _Context = context;
            _CustomerEfMapper = customerEfMapper;
        }
        public ICustomer CreateCustomer(ICustomer customer)
        {
            var customerEf = _CustomerEfMapper.Create(customer);
            _Context.Add(customerEf);
            _Context.SaveChanges();
            return _CustomerEfMapper.Map(customerEf);
        }



        public ICustomer GetCustomer(int customerId)
        {
            var customerEf = GetCustomerEf(customerId);
            return _CustomerEfMapper.Map(customerEf);
        }
        private CustomerEf GetCustomerEf(int customerId)
        {
            return _Context.Customers.FirstOrDefault(c => c.ID == customerId);
        }
    }
}
