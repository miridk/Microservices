using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication1.Application.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _OrderService;

        public OrderController(IOrderService orderService)
        {
            _OrderService = orderService;
        }

        // GET by Id action
        [HttpGet("{id}")]
        public ActionResult<Application.Model.OrderDto> Get(int id)
        {
            var order = _OrderService.Get(id);

            if (order == null)

                return NotFound();

            return order;
        }

        //getting data from Customer
        [HttpPost("{customerId}")]
        public async Task<ActionResult> Post(int customerId)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new System.Uri("http://host.docker.internal:3001/");

            var jsonResponse = await httpClient.GetStringAsync($"Customer/{customerId}");
            //var customer2 = await httpClient.GetAsync<CustomerDto>($"Customer/{customerId}");

            //Creating my customer as an object
            var customer = JsonConvert.DeserializeObject<CustomerDto>(jsonResponse);

            var jsonResult = JsonConvert.SerializeObject(customer);

            return Ok(jsonResult);
        }

        [HttpPost]
        //Collected order
        public async Task<ActionResult> Create(Application.Model.OrderDto order)
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new System.Uri("http://host.docker.internal:3001/");
            var jsonResponse = await httpClient.GetStringAsync($"Customer/{order.CustomerId}");
            var customer = JsonConvert.DeserializeObject<CustomerDto>(jsonResponse);

            var httpClientProduct = new HttpClient();
            httpClientProduct.BaseAddress = new System.Uri("http://host.docker.internal:3003/");
            var jsonResponseProduct = await httpClientProduct.GetStringAsync($"Product/1");
            var product = JsonConvert.DeserializeObject<ProductDto>(jsonResponseProduct);

            var orderDto = new OrderDto();
            orderDto.CustomerName = $"{customer.FirstName} {customer.LastName}";
            orderDto.OrderNo = order.OrderNo;
            orderDto.CustomerNo = customer.ID;
            orderDto.Price = product.Price;
            orderDto.Name = product.Name;
            orderDto.Email = customer.Email;

            var jsonOrderResult = JsonConvert.SerializeObject(orderDto);

            HttpRequestMessage requestMessage = new HttpRequestMessage();
            requestMessage.Method = HttpMethod.Post;
            requestMessage.RequestUri = new System.Uri("http://documentgenerator/Document");
            requestMessage.Content = new StringContent(jsonOrderResult, System.Text.Encoding.UTF8, "application/json");
            var result = httpClient.Send(requestMessage);
            //var jsonResult = JsonConvert.SerializeObject(customer);
     
            _OrderService.Create(order);

            return CreatedAtAction(nameof(Create), new { id = order.ID }, order);

        }

        public class CustomerDto
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Street { get; set; }
            public string PostCode { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
        }
        public class OrderDto
        {
            public string OrderNo { get; set; }
            public int CustomerNo { get; set; }
            public string CustomerName { get; set; }
            public decimal Price { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
        }

        public class ProductDto
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string EAN { get; set; }
        }
    }

}
