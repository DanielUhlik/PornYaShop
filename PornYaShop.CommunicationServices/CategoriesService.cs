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
    public class CategoriesService
    {
        public async Task<BaseResponse<Category>> CreateAsync(Category category)
        {
            return await RestClient.Post<Category>(Endpoints.Categories.Create, category);
        }

        public async Task<BaseResponse<IEnumerable<Category>>> GetAllAsync()
        {
            return await RestClient.Get<IEnumerable<Category>>(Endpoints.Categories.GetAll);
        }

        public async Task<BaseResponse<Category>> GetByIdAsync(int id)
        {
            return await RestClient.Get<Category>(Endpoints.Categories.GetById(id));
        }

        public async Task<BaseResponse<IEnumerable<Category>>> GetAllWithProductsAsync()
        {
            return await RestClient.Get<IEnumerable<Category>>(Endpoints.Categories.GetAllWithProducts);
        }
    }
}
