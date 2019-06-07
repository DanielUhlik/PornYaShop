using PornYaShop.DataContext.Entities;
using PornYaShop.Shared.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PornYaShop.Products.Services.Interfaces
{
    public interface IProductsService
    {
        #region Products
        BaseResponse<IEnumerable<Product>> GetProducts();
        Task<BaseResponse<Product>> CreateProductAsync(Product product);
        Task<BaseResponse<Product>> GetProductByIdAsync(int id);
        Task<BaseResponse<Product>> EditProductAsync(Product product);

        #endregion

        #region ProductVariants
        BaseResponse<IEnumerable<ProductVariant>> GetProductVariants(int productId);
        Task<BaseResponse<ProductVariant>> GetProductVariant(int id);
        Task<BaseResponse<ProductVariant>> CreateProductVariantAsync(ProductVariant productVariant);
        Task<BaseResponse<ProductVariant>> EditProductVariantAsync(ProductVariant productVariant);

        #endregion
    }
}
