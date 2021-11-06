namespace MicroserviceEducation.Domain.Model
{
    public interface IProduct
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string EAN { get; set; }
    }
}