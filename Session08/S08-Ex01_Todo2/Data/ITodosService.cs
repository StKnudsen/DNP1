using System.Collections.Generic;
using System.Threading.Tasks;
using S08_Ex01_Todo2.Models;

namespace S08_Ex01_Todo2.Data
{
    public interface ITodosServices
    {
        Task<IList<Todo>> GetTodosAsync();
        Task AddTodoAsync(Todo todo);
        Task RemoveTodoAsync(int todoId);
        Task UpdateAsync(Todo todo);
        
        //Task<Todo> Get(int id);
    }
}