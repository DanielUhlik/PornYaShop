using System;
using System.Collections.Generic;
using System.Text;

namespace PornYaShop.DataContext.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ICollection<ProductVariant> Variants { get; set; } = new List<ProductVariant>();
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
