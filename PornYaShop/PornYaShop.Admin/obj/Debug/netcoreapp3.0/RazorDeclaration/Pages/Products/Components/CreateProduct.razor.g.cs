#pragma checksum "D:\pornya\PornYaShop\PornYaShop.Admin\Pages\Products\Components\CreateProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18eac59087983f523d19c28ce02e03c97beb4974"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PornYaShop.Admin.Pages.Products.Components
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
    using PornYaShop.Admin.Shared;
    using PornYaShop.Admin.Pages;
    using PornYaShop.DataContext.Entities;
    using PornYaShop.CommunicationServices;
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    public class CreateProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 32 "D:\pornya\PornYaShop\PornYaShop.Admin\Pages\Products\Components\CreateProduct.razor"
           
    [Parameter]
    private Category Category { get; set; }

    [Parameter]
    private EventCallback<UIMouseEventArgs> OnProductCreated { get; set; }

    private Product product = new Product();

    private string ModalId { get; set; }

    protected override void OnParametersSet()
    {
        product.CategoryId = Category.Id;
        ModalId = "create-product-category" + Category.Id;
        base.OnParametersSet();
    }

    private async Task CreateNewProduct(UIMouseEventArgs e)
    {
        var results = await _gatewayService.products.CreateProduct(product);
        if (results != null)
        {
            await OnProductCreated.InvokeAsync(null);
        }
    }


#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private GatewayService _gatewayService { get; set; }
    }
}
#pragma warning restore 1591