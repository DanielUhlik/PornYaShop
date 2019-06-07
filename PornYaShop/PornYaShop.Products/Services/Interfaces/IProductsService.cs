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
        BaseResponse<IEnumerable<Product>> GetProducts();
        Task<BaseResponse<Product>> CreateAsync(Product product);
        Task<BaseResponse<Product>> GetByIdAsync(int id);
        Task<BaseResponse<Product>> EditProductAsync(Product product);
    }
}
