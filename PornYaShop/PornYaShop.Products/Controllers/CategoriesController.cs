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
    public class CategoriesController : ControllerBase
    {
        private ICategoriesService _categoriesService;

        public CategoriesController(ICategoriesService categoriesService)
        {
            _categoriesService = categoriesService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_categoriesService.GetCategories());
        }

        [HttpGet("products")]
        public IActionResult GetAllWithProducts()
        {
            return Ok(_categoriesService.GetCategoriesWithProducts());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            return Ok(await _categoriesService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Category category)
        {
            return Ok(await _categoriesService.CreateAsync(category));
        }

    }
}