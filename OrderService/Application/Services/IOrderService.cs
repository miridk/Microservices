using WebApplication1.Application.Model;

namespace WebApplication1.Application.Services
{
    public interface IOrderService
    {
        public OrderDto Get(int orderId);
        public OrderDto Create(OrderDto orderDto);
    }
}
