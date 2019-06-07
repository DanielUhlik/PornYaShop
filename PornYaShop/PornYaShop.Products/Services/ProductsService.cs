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
    public class ProductsService : IProductsService
    {
        private ShopContext _context;

        public ProductsService(ShopContext context)
        {
            _context = context;
        }

        public async Task<BaseResponse<Product>> CreateAsync(Product product)
        {
            var response = new BaseResponse<Product>();
            _ = await  response.SafeCall(async () =>
            {
                _context.Add(product);
                await _context.SaveChangesAsync();
                response.Results = product;
            });
            return response;
        }

        public async Task<BaseResponse<Product>> EditProductAsync(Product product)
        {
            BaseResponse<Product> response = new BaseResponse<Product>();

            _ = await response.SafeCall( async () =>
            {
                _context.Update(product);
                await _context.SaveChangesAsync();
                response.Results = product;
            });

            return response;
        }

        public async Task<BaseResponse<Product>> GetByIdAsync(int id)
        {
            BaseResponse<Product> response = new BaseResponse<Product>();

            _ = await response.SafeCall(async () =>
            {
                response.Results = await _context.Product.Include(p => p.Variants).FirstAsync(p => p.Id == id);
            });
            return response;
        }

        public BaseResponse<IEnumerable<Product>> GetProducts()
        {
            BaseResponse<IEnumerable<Product>> response = new BaseResponse<IEnumerable<Product>>();

            _ = response.SafeCall(async () =>
            {
                response.Results = _context.Product.Include(p => p.Variants);
            });

            return response;
        }
    }
}
