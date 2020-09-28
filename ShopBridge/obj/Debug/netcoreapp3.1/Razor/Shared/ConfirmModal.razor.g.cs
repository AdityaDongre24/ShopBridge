#pragma checksum "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\Shared\ConfirmModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17aab3763d29ef5eaf32e3a198ac6e2f0b208acc"
// <auto-generated/>
#pragma warning disable 1591
namespace ShopBridge.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\_Imports.razor"
using ShopBridge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\_Imports.razor"
using ShopBridge.Shared;

#line default
#line hidden
#nullable disable
    public partial class ConfirmModal : ConfirmModalBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\Shared\ConfirmModal.razor"
 if (ShowConfirmation)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal fade show d-block");
            __builder.AddAttribute(3, "tabindex", "-1");
            __builder.AddAttribute(4, "role", "dialog");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-dialog");
            __builder.AddAttribute(8, "role", "document");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-content");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "modal-header");
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.AddMarkupContent(16, "<h5 class=\"modal-title\">Confirm Delete</h5>\r\n                    ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "class", "close");
            __builder.AddAttribute(20, "data-dismiss", "modal");
            __builder.AddAttribute(21, "aria-label", "Close");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\Shared\ConfirmModal.razor"
                                      () => OnConfirmationChanged(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.AddMarkupContent(24, "<span aria-hidden=\"true\">&times;</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                ");
            __builder.AddMarkupContent(27, "<div class=\"modal-body\">\r\n                    <p>Are you sure you want to delete?</p>\r\n                </div>\r\n                ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "modal-footer");
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "type", "button");
            __builder.AddAttribute(33, "class", "btn btn-primary");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\Shared\ConfirmModal.razor"
                                      ()=>OnConfirmationChanged(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Cancel");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "type", "button");
            __builder.AddAttribute(39, "class", "btn btn-danger");
            __builder.AddAttribute(40, "data-dismiss", "modal");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\Shared\ConfirmModal.razor"
                                      ()=> OnConfirmationChanged(true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
#nullable restore
#line 27 "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\Shared\ConfirmModal.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591