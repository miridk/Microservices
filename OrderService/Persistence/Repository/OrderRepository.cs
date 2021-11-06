using System.Linq;
using WebApplication1.Domain.Model;
using WebApplication1.Domain.Repository;
using WebApplication1.Persistence.Mappers;
using WebApplication1.Persistence.Model;

namespace WebApplication1.Persistence.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderContext _Context;
        private readonly IOrderEfMapper _OrderEfMapper;
        public OrderRepository(OrderContext context, IOrderEfMapper orderEfMapper)
        {
            _Context = context;
            _OrderEfMapper = orderEfMapper;
        }
        public IOrder CreateOrder(IOrder order)
        {
            var orderEf = _OrderEfMapper.Create(order);
            _Context.Add(orderEf);
            _Context.SaveChanges();
            return _OrderEfMapper.Map(orderEf);
        }



        public IOrder GetOrder(int orderId)
        {
            var orderEf = GetOrderEf(orderId);
            return _OrderEfMapper.Map(orderEf);
        }
        private OrderEf GetOrderEf(int orderId)
        {
            return _Context.Orders.FirstOrDefault(c => c.ID == orderId);
        }
    }
}
