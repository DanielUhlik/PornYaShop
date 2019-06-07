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

        public async Task<BaseResponse<Product>> CreateAsync(Product product)
        {
            return await RestClient.Post<Product>(Endpoints.Products.Create, product);
        }

        public async Task<BaseResponse<IEnumerable<Product>>> GetAllAsync()
        {
            return await RestClient.Get<IEnumerable<Product>>(Endpoints.Products.GetAll);
        }

        public async Task<BaseResponse<Product>> GetByIdAsync(int id)
        {
            return await RestClient.Get<Product>(Endpoints.Products.GetById(id));
        }

        public async Task<BaseResponse<Product>> EditAsync(Product product)
        {
            return await RestClient.Put<Product>(Endpoints.Products.Edit, product);
        }
    }
}
