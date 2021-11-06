using MicroServiceEduDocumentGenerator.Application.Service;
using MicroServiceEduDocumentGenerator.Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceEduDocumentGenerator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentController : ControllerBase
    {
        private readonly IFileService _FileService;
        public DocumentController(IFileService fileService)
        {
            _FileService = fileService;
        }
        // POST action
        [HttpPost]
        public IActionResult Create(Order order)
        {
            if (order == null)
                return BadRequest();

            _FileService.ExportToFile(order);
            return Ok();
        }
    }
}
