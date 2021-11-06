using MicroserviceEducation.Application.Model;

namespace MicroserviceEducation.Application.Services
{
    public interface ICustomerService
    {
        public CustomerDto Get(int customerId);
        public CustomerDto Create(CustomerDto customerDto);
    }
}
