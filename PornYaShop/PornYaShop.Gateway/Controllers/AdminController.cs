﻿using System;
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
    public class AdminController : ControllerBase
    {
        private CategoriesService _categoriesService;
        private ProductsService _productsService;

        public AdminController(CategoriesService categoriesService, ProductsService productsService)
        {
            _categoriesService = categoriesService;
            _productsService = productsService;
        }

        [HttpPost("categories")]
        public async Task<IActionResult> CreateCategory([FromBody] Category model)
        {
            var response = await _categoriesService.CreateAsync(model);
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response);
        }


        [HttpPost("products")]
        public async Task<IActionResult> CreateProduct([FromBody] Product model)
        {
            var response = await _productsService.CreateProductAsync(model);
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut("products")]
        public async Task<IActionResult> EditProduct([FromBody] Product model)
        {
            var response = await _productsService.EditproductAsync(model);
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost("productVariants")]
        public async Task<IActionResult> CreateProductVariant([FromBody] ProductVariant productVariant)
        {
            var response = await _productsService.CreateProductVariantAsync(productVariant);
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut("productVariants")]
        public async Task<IActionResult> EditProductVariant([FromBody] ProductVariant productVariant)
        {
            var response = await _productsService.EditProductVariantAsync(productVariant);
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response);
        }
    }
}