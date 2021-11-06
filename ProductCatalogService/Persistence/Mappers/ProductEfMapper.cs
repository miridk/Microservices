using MicroserviceEducation.Domain.Model;
using MicroserviceEducation.Persistence.Model;

namespace MicroserviceEducation.Persistence.Mappers
{
    public class ProductEfMapper : IProductEfMapper
    {
        public IProduct Map(ProductEf productEf)
        {
            return new Product
            {
                ID = productEf.ID,
                Name = productEf.Name,
                Price = productEf.Price,
                EAN = productEf.EAN,

            };
        }
        public ProductEf Create(IProduct product)
        {
            return new ProductEf
            {
                ID = product.ID,
                Name = product.Name,
                Price = product.Price,
                EAN = product.EAN,
               
            };
        }
    }
}
