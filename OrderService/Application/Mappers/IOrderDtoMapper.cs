using WebApplication1.Application.Model;
using WebApplication1.Domain.Model;

namespace WebApplication1.Application.Mappers
{
    public interface IOrderDtoMapper
    {
        public OrderDto Map(IOrder order);
        public IOrder Create(OrderDto orderDto);
    }
}
