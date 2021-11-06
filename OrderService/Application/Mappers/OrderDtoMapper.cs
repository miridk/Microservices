using WebApplication1.Application.Model;
using WebApplication1.Domain.Model;

namespace WebApplication1.Application.Mappers
{
    public class OrderDtoMapper : IOrderDtoMapper
    {
        public OrderDto Map(IOrder order)
        {
            return new OrderDto
            {
                ID = order.ID,
                CustomerId = order.CustomerId,
                OrderNo = order.OrderNo,
            };
        }
        public IOrder Create(OrderDto orderDto)
        {
            return new Order
            {
                ID = orderDto.ID,
                CustomerId = orderDto.CustomerId,
                OrderNo = orderDto.OrderNo,
            };
        }
    }
}
