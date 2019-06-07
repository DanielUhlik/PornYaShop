#pragma checksum "D:\pornya\PornYaShop.Admin\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd4fa9e7704f6feabca3e0668a2e03f2a924d2a2"
// <auto-generated/>
#pragma warning disable 1591
namespace PornYaShop.Admin.Shared
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
    public class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            builder.AddMarkupContent(2, "\r\n    ");
            builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>PornYaShop.Admin</a>\r\n    ");
            builder.OpenElement(4, "button");
            builder.AddAttribute(5, "class", "navbar-toggler");
            builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, ToggleNavMenu));
            builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(8, "\r\n");
            builder.CloseElement();
            builder.AddMarkupContent(9, "\r\n\r\n");
            builder.OpenElement(10, "div");
            builder.AddAttribute(11, "class", NavMenuCssClass);
            builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.UIMouseEventArgs>(this, ToggleNavMenu));
            builder.AddMarkupContent(13, "\r\n    ");
            builder.OpenElement(14, "ul");
            builder.AddAttribute(15, "class", "nav flex-column");
            builder.AddMarkupContent(16, "\r\n        ");
            builder.OpenElement(17, "li");
            builder.AddAttribute(18, "class", "nav-item px-3");
            builder.AddMarkupContent(19, "\r\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            builder.AddAttribute(21, "class", "nav-link");
            builder.AddAttribute(22, "href", "");
            builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(NavLinkMatch.All));
            builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(25, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(26, "\r\n        ");
            builder.CloseElement();
            builder.AddMarkupContent(27, "\r\n        ");
            builder.OpenElement(28, "li");
            builder.AddAttribute(29, "class", "nav-item px-3");
            builder.AddMarkupContent(30, "\r\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            builder.AddAttribute(32, "class", "nav-link");
            builder.AddAttribute(33, "href", "categories");
            builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(35, "\r\n                <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Produkty\r\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddMarkupContent(36, "\r\n        ");
            builder.CloseElement();
            builder.AddMarkupContent(37, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(38, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 23 "D:\pornya\PornYaShop.Admin\Shared\NavMenu.razor"
            
    bool collapseNavMenu = true;

    string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
