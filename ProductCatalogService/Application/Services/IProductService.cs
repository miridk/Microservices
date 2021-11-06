using MicroserviceEducation.Application.Model;

namespace MicroserviceEducation.Application.Services
{
    public interface IProductService
    {
        public ProductDto Get(int productId);
        public ProductDto Create(ProductDto productDto);
    }
}
