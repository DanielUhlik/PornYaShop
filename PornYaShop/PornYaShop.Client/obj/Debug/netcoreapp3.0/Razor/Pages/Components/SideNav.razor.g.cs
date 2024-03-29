#pragma checksum "D:\pornya\PornYaShop\PornYaShop.Client\Pages\Components\SideNav.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b10fc00293caaa96e7935d4faa0d2043855b3ba0"
// <auto-generated/>
#pragma warning disable 1591
namespace PornYaShop.Client.Pages.Components
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
    using PornYaShop.CommunicationServices;
    using PornYaShop.DataContext.Entities;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    public class SideNav : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "side-nav");
            builder.AddMarkupContent(2, "\r\n    ");
            builder.AddMarkupContent(3, @"<div>
        <h1>P<span class=""red-text"">o</span>rn<span class=""ya"">Ya</span></h1>
        <input type=""search"" placeholder=""Search..."">
        <div>
            <i class=""material-icons large"">
                shopping_cart
            </i>
            <div><p>2 / 98.50€</p></div>
        </div>
    </div>
    ");
            builder.OpenElement(4, "ul");
            builder.AddMarkupContent(5, "\r\n");
#line 18 "D:\pornya\PornYaShop\PornYaShop.Client\Pages\Components\SideNav.razor"
         foreach (var category in Categories)
        {

#line default
#line hidden
            builder.AddContent(6, "            ");
            builder.OpenElement(7, "li");
            builder.OpenElement(8, "a");
            builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, () => GoToCategory(category.Id)));
            builder.AddContent(10, category.Name);
            builder.CloseElement();
            builder.CloseElement();
            builder.AddMarkupContent(11, "\r\n");
#line 21 "D:\pornya\PornYaShop\PornYaShop.Client\Pages\Components\SideNav.razor"
        }

#line default
#line hidden
            builder.AddContent(12, "        ");
            builder.AddMarkupContent(13, "<li><a>Zľavy</a></li>\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(14, "\r\n    ");
            builder.AddMarkupContent(15, "<div>\r\n        <a>Kontakt</a>\r\n        <a>Obchodné podmienky</a>\r\n        <a>Doprava a platba</a>\r\n        <p>© PornYa s.r.o. 2019-2020</p>\r\n    </div>\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 32 "D:\pornya\PornYaShop\PornYaShop.Client\Pages\Components\SideNav.razor"
           
    List<Category> Categories { get; set; } = new List<Category>();

    protected override async Task OnInitAsync()
    {
        var response = await _gatewayService.categories.GetCategories();
        Categories = response.Results;
    }

    void GoToCategory(int id)
    {
        UriHelper.NavigateTo($"kategoria/{id}/produkty");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Components.IUriHelper UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GatewayService _gatewayService { get; set; }
    }
}
#pragma warning restore 1591
