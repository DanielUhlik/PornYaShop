using PornYaShop.DataContext.Entities;
using PornYaShop.Shared.Models.ViewModels;
using PornYaShop.Shared.RestClient;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PornYaShop.CommunicationServices
{
    public class ProductsService
    {
        #region Products
        public async Task<BaseResponse<Product>> CreateProductAsync(Product product)
        {
            return await RestClient.Post<Product>(Endpoints.Products.Create, product);
        }

        public async Task<BaseResponse<IEnumerable<Product>>> GetAllProductsAsync()
        {
            return await RestClient.Get<IEnumerable<Product>>(Endpoints.Products.GetAll);
        }

        public async Task<BaseResponse<Product>> GetProductByIdAsync(int id)
        {
            return await RestClient.Get<Product>(Endpoints.Products.GetById(id));
        }

        public async Task<BaseResponse<Product>> EditproductAsync(Product product)
        {
            return await RestClient.Put<Product>(Endpoints.Products.Edit, product);
        }

        #endregion

        #region ProductVariants

        public async Task<BaseResponse<ProductVariant>> CreateProductVariantAsync(ProductVariant productVariant)
        {
            return await RestClient.Post<ProductVariant>(Endpoints.ProductVariants.Create, productVariant);
        }

        public async Task<BaseResponse<IEnumerable<ProductVariant>>> GetProductVariantsAsync(int productId)
        {
            return await RestClient.Get<IEnumerable<ProductVariant>>(Endpoints.ProductVariants.GetProductVariants(productId));
        }

        public async Task<BaseResponse<ProductVariant>> GetProductVariantAsync(int id)
        {
            return await RestClient.Get<ProductVariant>(Endpoints.ProductVariants.GetById(id));
        }

        public async Task<BaseResponse<ProductVariant>> EditProductVariantAsync(ProductVariant productVariant) {
            return await RestClient.Put<ProductVariant>(Endpoints.ProductVariants.Edit, productVariant);
        }

        #endregion
    }
}
