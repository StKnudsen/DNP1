#pragma checksum "C:\Users\zteph\RiderProjects\DNP1\Session05\S05-Ex02_AuthWithTailwind\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0ff3115baecfa2f90e78283d11eb887219f7fb5"
// <auto-generated/>
#pragma warning disable 1591
namespace LoginComponent
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\zteph\RiderProjects\DNP1\Session05\S05-Ex02_AuthWithTailwind\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zteph\RiderProjects\DNP1\Session05\S05-Ex02_AuthWithTailwind\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zteph\RiderProjects\DNP1\Session05\S05-Ex02_AuthWithTailwind\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zteph\RiderProjects\DNP1\Session05\S05-Ex02_AuthWithTailwind\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zteph\RiderProjects\DNP1\Session05\S05-Ex02_AuthWithTailwind\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\zteph\RiderProjects\DNP1\Session05\S05-Ex02_AuthWithTailwind\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\zteph\RiderProjects\DNP1\Session05\S05-Ex02_AuthWithTailwind\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\zteph\RiderProjects\DNP1\Session05\S05-Ex02_AuthWithTailwind\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\zteph\RiderProjects\DNP1\Session05\S05-Ex02_AuthWithTailwind\_Imports.razor"
using S05_Ex02_AuthWithTailwind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\zteph\RiderProjects\DNP1\Session05\S05-Ex02_AuthWithTailwind\_Imports.razor"
using S05_Ex02_AuthWithTailwind.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zteph\RiderProjects\DNP1\Session05\S05-Ex02_AuthWithTailwind\Pages\Login.razor"
using S05_Ex02_AuthWithTailwind.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "mt-12 px-8 pt-6 pb-8 mb-4 w-4/5 sm:w-3/5 md:w-2/5 lg:w-1/3 mx-auto flex flex-col");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "mb-4");
                __builder2.AddMarkupContent(6, "<label class=\"block text-red-900 font-bold mb-2\" for=\"username\">\r\n                    Username\r\n                </label>\r\n                ");
                __builder2.OpenElement(7, "input");
                __builder2.AddAttribute(8, "class", "w-full py-2 px-3 rounded border border-red-800 hover:border-red-600 text-grey-900 bg-gray-50 outline-none focus:ring focus:border-red-600 transition duration-500");
                __builder2.AddAttribute(9, "id", "username");
                __builder2.AddAttribute(10, "type", "text");
                __builder2.AddAttribute(11, "placeholder", "username");
                __builder2.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\zteph\RiderProjects\DNP1\Session05\S05-Ex02_AuthWithTailwind\Pages\Login.razor"
                                 username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "mb-6");
                __builder2.AddMarkupContent(17, "<label class=\"block text-red-900 font-bold mb-2\" for=\"password\">\r\n                    Password\r\n                </label>\r\n                ");
                __builder2.OpenElement(18, "input");
                __builder2.AddAttribute(19, "class", "w-full py-2 px-3 mb-3 rounded border border-red-800 hover:border-red-600 text-grey-900 bg-gray-50 outline-none focus:ring focus:border-red-600 transition duration-500");
                __builder2.AddAttribute(20, "id", "password");
                __builder2.AddAttribute(21, "type", "password");
                __builder2.AddAttribute(22, "placeholder", "password");
                __builder2.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\zteph\RiderProjects\DNP1\Session05\S05-Ex02_AuthWithTailwind\Pages\Login.razor"
                                 password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.OpenElement(26, "p");
                __builder2.AddAttribute(27, "class", "text-red-500 text-medium italic transition duration-500");
                __builder2.AddContent(28, 
#nullable restore
#line 34 "C:\Users\zteph\RiderProjects\DNP1\Session05\S05-Ex02_AuthWithTailwind\Pages\Login.razor"
                                                                                    errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "flex items-center justify-between");
                __builder2.OpenElement(32, "button");
                __builder2.AddAttribute(33, "class", "bg-red-200 hover:bg-red-300 text-yellow-800 font-bold py-2 px-4 rounded transition duration-500");
                __builder2.AddAttribute(34, "type", "button");
                __builder2.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\zteph\RiderProjects\DNP1\Session05\S05-Ex02_AuthWithTailwind\Pages\Login.razor"
                              PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(36, "\r\n                    Sign In\r\n                ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(37, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "mt-12 px-8 pt-6 pb-8 mb-4 w-4/5 sm:w-3/5 md:w-2/5 lg:w-1/3 mx-auto flex flex-col");
                __builder2.OpenElement(40, "button");
                __builder2.AddAttribute(41, "class", "bg-red-200 hover:bg-red-300 text-yellow-800 font-bold py-2 px-4 rounded transition duration-500");
                __builder2.AddAttribute(42, "type", "button");
                __builder2.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\zteph\RiderProjects\DNP1\Session05\S05-Ex02_AuthWithTailwind\Pages\Login.razor"
                          PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(44, "\r\n                Log out\r\n            ");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\zteph\RiderProjects\DNP1\Session05\S05-Ex02_AuthWithTailwind\Pages\Login.razor"
       
    private string username;
    private string password;
    private string errorMessage;

    public async Task PerformLogin()
    {
        errorMessage = "";
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(username, password);
            username = "";
            password = "";
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }

    public async Task PerformLogout()
    {
        errorMessage = "";
        username = "";
        password = "";
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
            NavigationManager.NavigateTo("/");
        }
        catch (Exception e)
        {
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
