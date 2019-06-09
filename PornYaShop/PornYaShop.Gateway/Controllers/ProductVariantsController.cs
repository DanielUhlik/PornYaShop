using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PornYaShop.CommunicationServices;

namespace PornYaShop.Gateway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductVariantsController : ControllerBase
    {
        private ProductsService _productsService;

        public ProductVariantsController(ProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet("product/{productId}")]
        public async Task<IActionResult> GetProductVariants([FromRoute] int productId)
        {
            var response = await _productsService.GetProductVariantsAsync(productId);
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductVariant([FromRoute] int id)
        {
            var response = await _productsService.GetProductVariantAsync(id);
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response);
        }

    }
}