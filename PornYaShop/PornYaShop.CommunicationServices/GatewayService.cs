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

        public GatewayService()
        {
            products = new Products();
            categories = new Categories();
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
