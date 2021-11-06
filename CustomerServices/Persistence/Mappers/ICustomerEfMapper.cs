using MicroserviceEducation.Domain.Model;
using MicroserviceEducation.Persistence.Model;

namespace MicroserviceEducation.Persistence.Mappers
{
    public interface ICustomerEfMapper
    {
        ICustomer Map(CustomerEf customerEf);
        CustomerEf Create(ICustomer customer);
    }
}