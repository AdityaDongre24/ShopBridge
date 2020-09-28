#pragma checksum "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\Shared\AlertModal.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ed31f0b51a116f31db45233c83eeda4ce86d860"
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
    public partial class AlertModal : AlertModalBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\Shared\AlertModal.razor"
 if (ShowAlert)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal fade show d-block");
            __builder.AddAttribute(3, "id", "exampleModalCenter");
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddAttribute(6, "aria-labelledby", "exampleModalCenterTitle");
            __builder.AddAttribute(7, "aria-hidden", "true");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(11, "role", "document");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "modal-content");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "modal-header");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "h5");
            __builder.AddAttribute(20, "class", "modal-title");
            __builder.AddAttribute(21, "id", "exampleModalLongTitle");
            __builder.AddContent(22, 
#nullable restore
#line 9 "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\Shared\AlertModal.razor"
                                                                        ModalHeader

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.AddMarkupContent(24, "<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                        <span aria-hidden=\"true\">&times;</span>\r\n                    </button>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "modal-body");
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.AddContent(29, 
#nullable restore
#line 15 "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\Shared\AlertModal.razor"
                     ModalBody

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "modal-footer");
            __builder.AddMarkupContent(34, "\r\n                    ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "type", "button");
            __builder.AddAttribute(37, "class", "btn btn-primary");
            __builder.AddAttribute(38, "data-dismiss", "modal");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\Shared\AlertModal.razor"
                                                                                                   ()=>CloseAlert()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, 
#nullable restore
#line 18 "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\Shared\AlertModal.razor"
                                                                                                                       ModalButtonText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 23 "C:\Users\Aditya\source\repos\BlazorApplication\ShopBridge\Shared\AlertModal.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
