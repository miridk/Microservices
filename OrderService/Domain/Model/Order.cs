namespace WebApplication1.Domain.Model
{
    public class Order : IOrder
    {
        
        public int ID { get; set; }
        public int CustomerId { get; set; }
        public string OrderNo { get; set; }
        
    }
}
