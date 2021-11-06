using MicroserviceEducation.Domain.Model;

namespace MicroserviceEducation.Domain.Repository
{
    public interface IProductRepository
    {
        public IProduct GetProduct(int productId);
        public IProduct CreateProduct(IProduct product);
    }
}
