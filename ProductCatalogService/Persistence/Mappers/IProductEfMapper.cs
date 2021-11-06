using MicroserviceEducation.Domain.Model;
using MicroserviceEducation.Persistence.Model;

namespace MicroserviceEducation.Persistence.Mappers
{
    public interface IProductEfMapper
    {
        IProduct Map(ProductEf productEf);
        ProductEf Create(IProduct product);
    }
}