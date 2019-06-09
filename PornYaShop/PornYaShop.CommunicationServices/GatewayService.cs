using PornYaShop.DataContext.Entities;
using PornYaShop.Shared.Models.ViewModels;
using PornYaShop.Shared.RestClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PornYaShop.CommunicationServices
{
    public class GatewayService
    {

        public Products products;
        public Categories categories;
        public ProductVariants productVariants;

        public GatewayService()
        {
            products = new Products();
            categories = new Categories();
            productVariants = new ProductVariants();
        }

        public class Products
        {
            public async Task<BaseResponse<Product>> CreateProduct(Product model)
            {
                var x = await RestClient.Post<Product>(Endpoints.Gateway.Products.Create, model);
                return x;
            }

            public async Task<BaseResponse<Product>> GetByIdAsync(int id)
            {
                var x = await RestClient.Get<Product>(Endpoints.Products.GetById(id));
                return x;
            }

            public async Task<BaseResponse<Product>> EditAsync(Product model)
            {
                var x = await RestClient.Put<Product>(Endpoints.Gateway.Products.Edit, model);
                return x;
            }
        }

        public class ProductVariants
        {
            public async Task<BaseResponse<ProductVariant>> CreateProductVariant(ProductVariant model)
            {
                var x = await RestClient.Post<ProductVariant>(Endpoints.Gateway.ProductVariants.Create, model);
                return x;
            }

            public async Task<BaseResponse<ProductVariant>> EditProductVariant(ProductVariant model)
            {
                var x = await RestClient.Put<ProductVariant>(Endpoints.Gateway.ProductVariants.Edit, model);
                return x;
            }

            public async Task<BaseResponse<IEnumerable<ProductVariant>>> GetProductVariants(int productId)
            {
                var x = await RestClient.Get<IEnumerable<ProductVariant>>(Endpoints.Gateway.ProductVariants.GetProductVariants(productId));
                return x;
            }

            public async Task<BaseResponse<ProductVariant>> GetproductVariant(int id)
            {
                var x = await RestClient.Get<ProductVariant>(Endpoints.Gateway.ProductVariants.GetById(id));
                return x;
            }
        }

        public class Categories
        {
            public async Task<BaseResponse<List<Category>>> GetCategoriesWithProductsAsync()
            {
                var x = await RestClient.Get<List<Category>>(Endpoints.Gateway.Categories.GetAllWithProducts);
                return x;
            }

            public async Task<BaseResponse<Category>> CreateCategory(Category model)
            {
                var x = await RestClient.Post<Category>(Endpoints.Gateway.Categories.Create, model);
                return x;
            }

            public async Task<BaseResponse<List<Category>>> GetCategories()
            {
                var x = await RestClient.Get<List<Category>>(Endpoints.Gateway.Categories.GetAll);
                return x;
            }
        }
    }
}
