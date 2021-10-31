// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace S08_Ex01_Todo2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\zteph\RiderProjects\DNP1\Session08\S08-Ex01_Todo2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zteph\RiderProjects\DNP1\Session08\S08-Ex01_Todo2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zteph\RiderProjects\DNP1\Session08\S08-Ex01_Todo2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\zteph\RiderProjects\DNP1\Session08\S08-Ex01_Todo2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\zteph\RiderProjects\DNP1\Session08\S08-Ex01_Todo2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\zteph\RiderProjects\DNP1\Session08\S08-Ex01_Todo2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\zteph\RiderProjects\DNP1\Session08\S08-Ex01_Todo2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\zteph\RiderProjects\DNP1\Session08\S08-Ex01_Todo2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\zteph\RiderProjects\DNP1\Session08\S08-Ex01_Todo2\_Imports.razor"
using S08_Ex01_Todo2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\zteph\RiderProjects\DNP1\Session08\S08-Ex01_Todo2\_Imports.razor"
using S08_Ex01_Todo2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zteph\RiderProjects\DNP1\Session08\S08-Ex01_Todo2\Pages\Todos.razor"
using S08_Ex01_Todo2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\zteph\RiderProjects\DNP1\Session08\S08-Ex01_Todo2\Pages\Todos.razor"
using S08_Ex01_Todo2.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Todos")]
    public partial class Todos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "C:\Users\zteph\RiderProjects\DNP1\Session08\S08-Ex01_Todo2\Pages\Todos.razor"
       
    private IList<Todo> todosToShow;
    private IList<Todo> allTodos;

    private bool? filterByIsCompleted = null;
    private int? filterById = null;

    protected override async Task OnInitializedAsync()
    {
        allTodos = await _todosServices.GetTodosAsync();
        todosToShow = allTodos;
    }
    
    private void FilterByUserId(ChangeEventArgs changeEventArgs)
    {
        filterById = null;
        
        try
        {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e) { }
        
        ExecuteFilter();
    }
    
    private void FilterByCompletedStatus(ChangeEventArgs changeEventArgs)
    {
        filterByIsCompleted = null;

        try
        {
            filterByIsCompleted = bool.Parse(changeEventArgs.Value.ToString());
        }
        catch (Exception e) { }

        ExecuteFilter();
    }
    
    private void ExecuteFilter()
    {
        todosToShow = allTodos.Where(t => 
            (filterById != null && t.UserId == filterById || filterById == null) 
            
            
            
            &&
            (filterByIsCompleted != null && t.IsCompleted == filterByIsCompleted || filterByIsCompleted == null)
            ).ToList();
    }
    
    private void Edit(int id)
    {
        NavigationManager.NavigateTo($"Edit/{id}");
    }

    private void RemoveTodo(int todoId)
    {
        Todo todoToRemove = allTodos.First(t => t.TodoId == todoId);
        _todosServices.RemoveTodoAsync(todoId); // Remove from storage
        allTodos.Remove(todoToRemove); // Update the todo list in view
        todosToShow.Remove(todoToRemove); // Update the todo list in view
    }
    
    private void CompletedChange(ChangeEventArgs evt, Todo todo)
    {
        todo.IsCompleted = (bool) evt.Value;
       // _todosServices.UpdateAsync(todo);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITodosServices _todosServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591