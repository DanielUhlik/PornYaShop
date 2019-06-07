using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PornYaShop.CommunicationServices;
using PornYaShop.DataContext.Entities;

namespace PornYaShop.Gateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private ProductsService _productsService;

        public ProductsController(ProductsService productsService)
        {
            _productsService = productsService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _productsService.GetAllAsync();
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _productsService.GetByIdAsync(id);
            if (response.IsSuccess)
                return Ok(response);
            return NotFound();
        }
    }
}