using System.Collections.Generic;
using System.Threading.Tasks;
using S07_Ex01_TodoWebAPI.Models;

namespace S07_Ex01_TodoWebAPI.Data
{
    public interface ITodoService
    {
        Task<IList<Todo>> GetTodosAsync();
        Task<Todo> AddTodoAsync(Todo todo);
        Task RemoveTodoAsync(int todoId);
        Task<Todo> UpdateAsync(Todo todo);
    }
}