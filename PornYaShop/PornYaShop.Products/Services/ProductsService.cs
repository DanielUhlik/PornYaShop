using Microsoft.EntityFrameworkCore;
using PornYaShop.DataContext.Data;
using PornYaShop.DataContext.Entities;
using PornYaShop.Products.Services.Interfaces;
using PornYaShop.Shared.Models.Requests;
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

        #region Products
        public async Task<BaseResponse<Product>> CreateProductAsync(Product product)
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

        public async Task<BaseResponse<Product>> GetProductByIdAsync(int id)
        {
            BaseResponse<Product> response = new BaseResponse<Product>();

            _ = await response.SafeCall(async () =>
            {
                response.Results = await _context.Product.Include(p => p.Variants).ThenInclude(pv => pv.Sizes).FirstAsync(p => p.Id == id);
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

        public async Task<BaseResponse<IEnumerable<Product>>> Filter(ProductsFilter productsFilter)
        {
            BaseResponse<IEnumerable<Product>> response = new BaseResponse<IEnumerable<Product>>();

            _ = await response.SafeCall(async () =>
            {
                var allByFilter = _context.Product.Include(p => p.Variants)
                    .Where(p => p.CategoryId == productsFilter.CategoryId);
                    
                response.Results = allByFilter.Skip(productsFilter.Page * productsFilter.PerPage).Take(productsFilter.PerPage);
                response.Page = productsFilter.Page;
                response.TotalPages = allByFilter.Count() / productsFilter.PerPage;
            });

            return response;
        }

        #endregion

        #region ProductVariants

        public BaseResponse<IEnumerable<ProductVariant>> GetProductVariants(int productId) {
            BaseResponse<IEnumerable<ProductVariant>> response = new BaseResponse<IEnumerable<ProductVariant>>();

            _ = response.SafeCall(async () =>
            {
                response.Results = _context.ProductVariant.Include(pv => pv.Product).Where(pv => pv.ProductId == productId);
            });

            return response;
        }

        public async Task<BaseResponse<ProductVariant>> GetProductVariant(int id) {
            BaseResponse<ProductVariant> response = new BaseResponse<ProductVariant>();

            _ = await response.SafeCall(async () =>
            {
                response.Results = await _context.ProductVariant.Include(pv => pv.ProductId).FirstAsync(pv => pv.Id == id);
            });

            return response;
        }

        public async Task<BaseResponse<ProductVariant>> CreateProductVariantAsync(ProductVariant productVariant) {
            BaseResponse<ProductVariant> response = new BaseResponse<ProductVariant>();

            _ = await response.SafeCall(async () =>
            {
                _context.Add(productVariant);
                await _context.SaveChangesAsync();
                response.Results = productVariant;
            });

            return response;
        }
        public async Task<BaseResponse<ProductVariant>> EditProductVariantAsync(ProductVariant productVariant) {
            BaseResponse<ProductVariant> response = new BaseResponse<ProductVariant>();

            _ = await response.SafeCall(async () =>
            {
                _context.Update(productVariant);
                await _context.SaveChangesAsync();
                response.Results = productVariant;
            });

            return response;
        }

        #endregion
    }
}
