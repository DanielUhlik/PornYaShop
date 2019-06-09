using System;
using System.Collections.Generic;
using System.Text;

namespace PornYaShop.DataContext.Entities
{
    public class ProductVariant
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Discount { get; set; }
        public ICollection<ProductSize> Sizes { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
