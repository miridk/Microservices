using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduDocumentGenerator.Domain.Model
{
    public class Order
    {
        public string OrderNo { get; set; }
        public int CustomerNo { get; set; }
        public string CustomerName { get; set; }
        public decimal Price { get; set; }
        public DateTime OrderDate { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
