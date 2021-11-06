using MicroserviceEducation.Application.Model;
using MicroserviceEducation.Domain.Model;

namespace MicroserviceEducation.Application.Mappers
{
    public interface ICustomerDtoMapper
    {
        
            public CustomerDto Map(ICustomer customer);
            public ICustomer Create(CustomerDto customerDto);
        
    }
}
