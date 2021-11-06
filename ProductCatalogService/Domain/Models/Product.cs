namespace MicroserviceEducation.Domain.Model
{
    public class Product : IProduct
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string EAN { get; set; }
    }
}
