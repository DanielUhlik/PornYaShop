using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PornYaShop.Client.Data
{
    public class CartService
    {
        public event Action OnChange;
        public int cartItemsCount { get; set; } = 0;

        public void AddToCart()
        {
            cartItemsCount++;
            OnChange?.Invoke();
        }
    }
}
