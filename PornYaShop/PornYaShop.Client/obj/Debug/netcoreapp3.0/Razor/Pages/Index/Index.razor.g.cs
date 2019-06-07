#pragma checksum "D:\pornya\PornYaShop\PornYaShop.Client\Pages\Index\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe5ef9f31c1ddf97e383f2291eb4e25863282133"
// <auto-generated/>
#pragma warning disable 1591
namespace PornYaShop.Client.Pages.Index
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Components.Forms;
    using Microsoft.AspNetCore.Components.Layouts;
    using Microsoft.AspNetCore.Components.Routing;
    using Microsoft.JSInterop;
    using PornYaShop.Client.Shared;
    using PornYaShop.Client.Pages.Index.Components;
    using PornYaShop.Client.Pages.Components;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "content");
            builder.AddMarkupContent(2, "\r\n    ");
            builder.AddMarkupContent(3, @"<div class=""benefits card"">
        <div>
            <i class=""material-icons"">alarm</i>
            <h2>Rýchle doručenie</h2>
            <p>Tovar objednaný do 13:30 príde na druhý deň</p>
        </div>
        <hr>
        <div>
            <i class=""material-icons"">high_quality</i>
            <h2>Kvalita</h2>
            <p>Kvalitný materiál a spracovanie je priorita</p>
        </div>
        <hr>
        <div>
            <i class=""material-icons"">landscape</i>
            <h2>Príroda</h2>
            <p>Pri balení a iných blbostiach sa staráme o prírodu</p>
        </div>
    </div>
    ");
            builder.OpenElement(4, "div");
            builder.AddAttribute(5, "class", "products-slider card");
            builder.OpenComponent<PornYaShop.Client.Pages.Index.Components.ProductsSlider>(6);
            builder.CloseComponent();
            builder.CloseElement();
            builder.AddMarkupContent(7, "\r\n    ");
            builder.OpenElement(8, "div");
            builder.AddAttribute(9, "class", "products");
            builder.AddMarkupContent(10, "\r\n");
#line 27 "D:\pornya\PornYaShop\PornYaShop.Client\Pages\Index\Index.razor"
         foreach (var product in Products)
        {

#line default
#line hidden
            builder.AddContent(11, "            ");
            builder.OpenComponent<PornYaShop.Client.Pages.Components.ProductCard>(12);
            builder.AddAttribute(13, "Title", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.String>(product.Title));
            builder.AddAttribute(14, "Price", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.Decimal>(product.Price));
            builder.CloseComponent();
            builder.AddMarkupContent(15, "\r\n");
#line 30 "D:\pornya\PornYaShop\PornYaShop.Client\Pages\Index\Index.razor"
        }

#line default
#line hidden
            builder.AddContent(16, "    ");
            builder.CloseElement();
            builder.AddMarkupContent(17, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 36 "D:\pornya\PornYaShop\PornYaShop.Client\Pages\Index\Index.razor"
           
    public class Product
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
    }

    public List<Product> Products = new List<Product>() {
        new Product{Title = "Mikina basic, čierna", Price = 55M},
        new Product {Title = "Tričko dobré, biele", Price = 20M },
        new Product {Title = "Kabelka Michal, tmavá", Price = 17.50M },
        new Product {Title = "Tričko PornYa, čierne", Price = 20M },
        new Product {Title = "Mikina s textom, biele", Price = 18.14M },
    };


    protected override async Task OnInitAsync()
    {
    }


#line default
#line hidden
    }
}
#pragma warning restore 1591