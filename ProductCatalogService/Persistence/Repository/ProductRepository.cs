using MicroserviceEducation.Domain.Model;
using MicroserviceEducation.Domain.Repository;
using MicroserviceEducation.Persistence.Mappers;
using MicroserviceEducation.Persistence.Model;
using ProductCatalog.Persistence.Repository;
using System.Linq;

namespace MicroserviceEducation.Persistence
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _Context;
        private readonly IProductEfMapper _ProductEfMapper;
        public ProductRepository(ProductContext context, IProductEfMapper productEfMapper)
        {
            _Context = context;
            _ProductEfMapper = productEfMapper;
        }
        public IProduct CreateProduct(IProduct product)
        {
            var productEf = _ProductEfMapper.Create(product);
            _Context.Add(productEf);
            _Context.SaveChanges();
            return _ProductEfMapper.Map(productEf);
        }



        public IProduct GetProduct(int productId)
        {
            var productEf = GetProductEf(productId);
            return _ProductEfMapper.Map(productEf);
        }
        private ProductEf GetProductEf(int productId)
        {
            return _Context.Products.FirstOrDefault(c => c.ID == productId);
        }
    }
}
