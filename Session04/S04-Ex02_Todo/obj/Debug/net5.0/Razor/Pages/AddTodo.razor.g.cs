#pragma checksum "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex02_Todo\Pages\AddTodo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "133a024f7afe96ec843e3c62a6a88dc59562f61c"
// <auto-generated/>
#pragma warning disable 1591
namespace S04_Ex02_Todo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex02_Todo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex02_Todo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex02_Todo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex02_Todo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex02_Todo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex02_Todo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex02_Todo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex02_Todo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex02_Todo\_Imports.razor"
using S04_Ex02_Todo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex02_Todo\_Imports.razor"
using S04_Ex02_Todo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex02_Todo\Pages\AddTodo.razor"
using S04_Ex02_Todo.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex02_Todo\Pages\AddTodo.razor"
using S04_Ex02_Todo.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddTodo")]
    public partial class AddTodo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AddTodo</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex02_Todo\Pages\AddTodo.razor"
                  newTodoItem

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex02_Todo\Pages\AddTodo.razor"
                                               AddNewTodo

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "\r\n        User Id:\r\n        <br>\r\n        ");
                __Blazor.S04_Ex02_Todo.Pages.AddTodo.TypeInference.CreateInputNumber_0(__builder2, 12, 13, 
#nullable restore
#line 16 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex02_Todo\Pages\AddTodo.razor"
                                  newTodoItem.UserId

#line default
#line hidden
#nullable disable
                , 14, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTodoItem.UserId = __value, newTodoItem.UserId)), 15, () => newTodoItem.UserId);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group");
                __builder2.AddMarkupContent(19, "\r\n        Title:\r\n        <br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(20);
                __builder2.AddAttribute(21, "rows", "4");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex02_Todo\Pages\AddTodo.razor"
                                             newTodoItem.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newTodoItem.Title = __value, newTodoItem.Title))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newTodoItem.Title));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n    ");
                __builder2.AddMarkupContent(26, "<p class=\"actions\"><button class=\"btn btn-outline-dark\" type=\"submit\">\r\n            Create\r\n        </button></p>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\zteph\RiderProjects\DNP1\Session04\S04-Ex02_Todo\Pages\AddTodo.razor"
       
    private Todo newTodoItem = new Todo();

    private void AddNewTodo()
    {
        TodoData.AddTodo(newTodoItem);
        NavigationManager.NavigateTo("/Todos");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITodoData TodoData { get; set; }
    }
}
namespace __Blazor.S04_Ex02_Todo.Pages.AddTodo
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591