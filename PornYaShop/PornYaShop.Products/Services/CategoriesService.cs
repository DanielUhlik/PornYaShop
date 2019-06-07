using Microsoft.EntityFrameworkCore;
using PornYaShop.DataContext.Data;
using PornYaShop.DataContext.Entities;
using PornYaShop.Products.Services.Interfaces;
using PornYaShop.Shared.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PornYaShop.Products.Services
{
    public class CategoriesService : ICategoriesService
    {
        private ShopContext _context;

        public CategoriesService(ShopContext context)
        {
            _context = context;
        }

        public async Task<BaseResponse<Category>> CreateAsync(Category category)
        {
            var response = new BaseResponse<Category>();

            _ = await response.SafeCall(async () =>
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                response.Results = category;
            });
            return response;
        }

        public async Task<BaseResponse<Category>> GetByIdAsync(int id)
        {
            BaseResponse<Category> response = new BaseResponse<Category>();
            _ = response.SafeCall(async () =>
            {
                response.Results = await _context.Category.FindAsync(id);
            });

            return response;
        }

        public BaseResponse<IEnumerable<Category>> GetCategories()
        {
            BaseResponse<IEnumerable<Category>> response = new BaseResponse<IEnumerable<Category>>();

            _ = response.SafeCall(async () =>
            {
                response.Results = _context.Category;
            });

            return response;
        }

        public BaseResponse<IEnumerable<Category>> GetCategoriesWithProducts()
        {
            BaseResponse<IEnumerable<Category>> response = new BaseResponse<IEnumerable<Category>>();

            _ = response.SafeCall(async () =>
            {
                response.Results = _context.Category.Include(c => c.Products);
            });
            return response;
        }
    }
}
