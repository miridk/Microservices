using WebApplication1.Domain.Model;
using WebApplication1.Persistence.Model;

namespace WebApplication1.Persistence.Mappers
{
    public interface IOrderEfMapper
    {
        public IOrder Map(OrderEf orderEf);
        public OrderEf Create(IOrder order);
    }
}
