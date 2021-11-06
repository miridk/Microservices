using WebApplication1.Domain.Model;
using WebApplication1.Persistence.Model;

namespace WebApplication1.Persistence.Mappers
{
    public class OrderEfMapper : IOrderEfMapper
    {
        public IOrder Map(OrderEf orderEf)
        {
            return new Order
            {
                ID = orderEf.ID,
                CustomerId = orderEf.CustomerId,
                OrderNo = orderEf.OrderNo,
            };
        }
        public OrderEf Create(IOrder order)
        {
            return new OrderEf
            {
                ID = order.ID,
                CustomerId = order.CustomerId,
                OrderNo = order.OrderNo,
            };
        }
    }
}
