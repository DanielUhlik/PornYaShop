using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PornYaShop.Shared.Models.ViewModels
{
    public class BaseResponse<T>
    {
        public ErrorViewModel Errors = new ErrorViewModel();
        public T Results { get; set; }
        public bool IsSuccess => !Errors.Errors.Any();

        public async Task<bool> SafeCall(Func<Task> function)
        {
            try
            {
                await function();
            }
            catch (Exception e)
            {
                Errors.Add(e.HResult, e.Message);
            }

            return IsSuccess;
        }
    }
}
