#pragma checksum "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex03_Bakery\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63f6ede8e48f3749e91af18e8d734fc41e22fa5f"
// <auto-generated/>
#pragma warning disable 1591
namespace S04_Ex03_Bakery.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex03_Bakery\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex03_Bakery\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex03_Bakery\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex03_Bakery\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex03_Bakery\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex03_Bakery\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex03_Bakery\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex03_Bakery\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex03_Bakery\_Imports.razor"
using S04_Ex03_Bakery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex03_Bakery\_Imports.razor"
using S04_Ex03_Bakery.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-liq8ygx6bj");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-liq8ygx6bj");
            __builder.OpenComponent<S04_Ex03_Bakery.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-liq8ygx6bj");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4");
            __builder.AddAttribute(13, "b-liq8ygx6bj");
            __builder.AddMarkupContent(14, "<a class=\"navbar-brand\" asp-page=\"/index\" b-liq8ygx6bj><img class=\"img-fluid\" src=\"Images/brand.png\" alt=\"Fourth Coffee\" b-liq8ygx6bj></a>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(15);
            __builder.AddAttribute(16, "href", "about");
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(18, "\r\n                About\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "content px-4");
            __builder.AddAttribute(22, "b-liq8ygx6bj");
            __builder.AddContent(23, 
#nullable restore
#line 19 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex03_Bakery\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591