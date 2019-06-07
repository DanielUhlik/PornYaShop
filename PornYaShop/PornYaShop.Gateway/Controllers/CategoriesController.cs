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
    public class CategoriesController : ControllerBase
    {
        private CategoriesService _categoriesService;

        public CategoriesController(CategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _categoriesService.GetAllAsync();
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("products")]
        public async Task<IActionResult> GetAllWithProducts()
        {
            var response = await _categoriesService.GetAllWithProductsAsync();
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var response = await _categoriesService.GetByIdAsync(id);
            if (response.IsSuccess)
                return Ok(response);
            return BadRequest(response);
        }

    }
}