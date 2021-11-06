namespace WebApplication1.Domain.Model
{
    public interface IOrder
    {
        public int ID { get; set; }
        public int CustomerId { get; set; }
        public string OrderNo { get; set; }
    }
}
