using System;
using System.Collections.Generic;
using System.Text;

namespace PornYaShop.Shared.Models.Requests
{
    public class ProductsFilter
    {
        public int Page { get; set; }
        public int PerPage { get; set; } = 12;
        public int CategoryId { get; set; }
    }
}
