using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PornYaShop.DataContext.Entities;
using PornYaShop.Products.Services.Interfaces;

namespace PornYaShop.Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductVariantsController : ControllerBase
    {
        private IProductsService _productsService;

        public ProductVariantsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet("/product/{productId}")]
        public async Task<IActionResult> GetProductVariants([FromRoute] int productId)
        {
            return Ok( _productsService.GetProductVariants(productId));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductVariant([FromRoute] int id)
        {
            return Ok(await _productsService.GetProductVariant(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductVariant([FromBody] ProductVariant productVariant)
        {
            return Ok(await _productsService.CreateProductVariantAsync(productVariant));
        }

        [HttpPut]
        public async Task<IActionResult> EditProductVariant([FromBody] ProductVariant productVariant)
        {
            return Ok(await _productsService.EditProductVariantAsync(productVariant));
        }

    }
}