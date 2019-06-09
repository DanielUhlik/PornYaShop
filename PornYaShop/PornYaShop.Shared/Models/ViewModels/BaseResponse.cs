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
        public int Page { get; set; } = 0;
        public int TotalPages { get; set; } = 0;

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

        public override string ToString()
        {
            return string.Join(Environment.NewLine, Errors.Errors.Select(e => e.Description));
        }
    }
}
