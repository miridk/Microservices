using MicroserviceEducation.Application.Model;
using MicroserviceEducation.Domain.Model;

namespace MicroserviceEducation.Application.Mappers
{
    public interface IProductDtoMapper
    {
        
            public ProductDto Map(IProduct product);
            public IProduct Create(ProductDto productDto);
        
    }
}
