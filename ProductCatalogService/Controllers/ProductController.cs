using MicroserviceEducation.Application.Model;
using MicroserviceEducation.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroserviceEducation.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _ProductService;
        
        public ProductController(IProductService productService)
        {
            _ProductService = productService;
        }
     
        // GET by Id action
        [HttpGet("{id}")]
        public ActionResult<ProductDto> Get(int id)
        {
            var product = _ProductService.Get(id);

            if (product == null)

                return NotFound();

            return product;
        }

                // POST action

        [HttpPost]

        public IActionResult Create(ProductDto product)

        {

            _ProductService.Create(product);

            return CreatedAtAction(nameof(Create), new { id = product.ID}, product);

        }
    }
}
