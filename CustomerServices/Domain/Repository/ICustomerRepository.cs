using MicroserviceEducation.Domain.Model;

namespace MicroserviceEducation.Domain.Repository
{
    public interface ICustomerRepository
    {
        public ICustomer GetCustomer(int customerId);
        public ICustomer CreateCustomer(ICustomer customer);
    }
}
