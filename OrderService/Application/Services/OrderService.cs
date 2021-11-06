using WebApplication1.Application.Mappers;
using WebApplication1.Domain.Repository;

namespace WebApplication1.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _OrderRepository;
        private readonly IOrderDtoMapper _OrderDtoMapper;
        public OrderService(IOrderRepository orderRepository, IOrderDtoMapper orderDtoMapper)
        {
            _OrderRepository = orderRepository;
            _OrderDtoMapper = orderDtoMapper;
        }
        public Model.OrderDto Create(Model.OrderDto orderDto)
        {
            var order = _OrderDtoMapper.Create(orderDto);




            var createdOrder = _OrderRepository.CreateOrder(order);



            return _OrderDtoMapper.Map(createdOrder);
        }



        public Model.OrderDto Get(int orderId)
        {
            var order = _OrderRepository.GetOrder(orderId);
            return _OrderDtoMapper.Map(order);
        }
    }
}
