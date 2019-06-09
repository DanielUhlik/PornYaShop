using System;
using System.Collections.Generic;
using System.Text;

namespace PornYaShop.DataContext.Entities
{
    public class ProductSize
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AvailableCount { get; set; }

        public int ProductVariantId { get; set; }
        public ProductVariant ProductVariant { get; set; }
    }
}
