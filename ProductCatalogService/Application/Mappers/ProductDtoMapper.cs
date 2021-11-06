using MicroserviceEducation.Application.Model;
using MicroserviceEducation.Domain.Model;

namespace MicroserviceEducation.Application.Mappers
{
    public class ProductDtoMapper : IProductDtoMapper
    {
        public IProduct Create(ProductDto productDto)
        {
            return new Product
            {
                ID = productDto.ID,
                Name = productDto.Name,
                Price = productDto.Price,
                EAN = productDto.EAN

            };


        }
        public ProductDto Map(IProduct product)
        {
            return new ProductDto
            {
                ID = product.ID,
                Name = product.Name,
                Price = product.Price,
                EAN = product.EAN
            };
        }
    }
}
