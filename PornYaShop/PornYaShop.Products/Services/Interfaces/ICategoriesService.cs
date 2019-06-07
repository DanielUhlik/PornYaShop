using PornYaShop.DataContext.Entities;
using PornYaShop.Shared.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PornYaShop.Products.Services.Interfaces
{
    public interface ICategoriesService
    {
        BaseResponse<IEnumerable<Category>> GetCategories();
        BaseResponse<IEnumerable<Category>> GetCategoriesWithProducts();
        Task<BaseResponse<Category>> GetByIdAsync(int id);
        Task<BaseResponse<Category>> CreateAsync(Category category);
    }
}
