using MicroserviceEducation.Application.Model;
using MicroserviceEducation.Domain.Model;

namespace MicroserviceEducation.Application.Mappers
{
    public class CustomerDtoMapper : ICustomerDtoMapper
    {
        public ICustomer Create(CustomerDto customerDto)
        {
            return new Customer
            {
                ID = customerDto.ID,
                FirstName = customerDto.FirstName,
                LastName = customerDto.LastName,
                Street = customerDto.Street,
                PostCode = customerDto.PostCode,
                City = customerDto.City,
                Country = customerDto.Country,
                Phone = customerDto.Phone,
                Email = customerDto.Email,
            };


        }
        public CustomerDto Map(ICustomer customer)
        {
            return new CustomerDto
            {
                ID = customer.ID,
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
