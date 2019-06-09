using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PornYaShop.DataContext.Entities;
using PornYaShop.Products.Services.Interfaces;
using PornYaShop.Shared.Models.Requests;

namespace PornYaShop.Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        public IActionResult GetProducts()
        {
            return Ok(_productsService.GetProducts());
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Product product)
        {
            var response = await _productsService.CreateProductAsync(product);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            return Ok(await _productsService.GetProductByIdAsync(id));
        }

        [HttpPut]
        public async Task<IActionResult> Edit([FromBody] Product product)
        {
            var response = await _productsService.EditProductAsync(product);
            return Ok(response);
        }

        [HttpPost("filter")]
        public async Task<IActionResult> Filter([FromBody] ProductsFilter productsFilter)
        {
            var response = await _productsService.Filter(productsFilter);
            return Ok(response);
        }

    }
}