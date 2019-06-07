using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PornYaShop.Shared.Models.ViewModels
{
    public class CustomError
    {
        public int Code { get; set; }
        public string Description { get; set; }
        public string Field { get; set; }

        public CustomError() { }

        public CustomError(int code, string description = "", string field = "")
        {
            this.Code = code;
            this.Description = description;
            this.Field = field;
        }
    }

    public class ErrorViewModel
    {
        public List<CustomError> Errors = new List<CustomError>();
        public bool IsSuccess => !Errors.Any();

        public void Add(int code, string description = "", string field = "")
        {
            Errors.Add(new CustomError(code, description, field));
        }
    }
}
