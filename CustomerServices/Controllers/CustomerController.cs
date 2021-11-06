using MicroserviceEducation.Application.Model;
using MicroserviceEducation.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviceEducation.Controllers
{
    //The controller handles incoming HTTP requests and send response back to the caller
    [ApiController] //Declaring that this is a controller
    [Route("[controller]")]//Making sure to route the information to the browser https//host/1/2/3
    public class CustomerController : ControllerBase //Creating the class CustomerController and inherit from ControllerBase
    {
        private readonly ICustomerService _CustomerService;
        
        public CustomerController(ICustomerService customerService)
        {
            _CustomerService = customerService;
        }
     
        // GET by Id action
        [HttpGet("{id}")]
        public ActionResult<CustomerDto> Get(int id)
        {
            var customer = _CustomerService.Get(id);

            if (customer == null)

                return NotFound();

            return customer;
        }

                // POST action

        [HttpPost]

        public IActionResult Create(CustomerDto customer)

        {

            _CustomerService.Create(customer);

            return CreatedAtAction(nameof(Create), new { id = customer.ID}, customer);

        }
    }



}
