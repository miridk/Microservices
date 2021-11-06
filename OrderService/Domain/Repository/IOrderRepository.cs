using WebApplication1.Domain.Model;

namespace WebApplication1.Domain.Repository
{
    public interface IOrderRepository
    {
        public IOrder GetOrder(int orderId);
        public IOrder CreateOrder(IOrder order);
    }
}
