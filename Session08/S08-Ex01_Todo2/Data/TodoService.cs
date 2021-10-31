using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using S08_Ex01_Todo2.Models;

namespace S08_Ex01_Todo2.Data
{
    public class TodoJSONData: ITodosServices
    {
        private string todoURL = "https://jsonplaceholder.typicode.com";
        private IList<Todo> todos;
        
        public TodoJSONData()
        {
            // ...
        }

        public async Task<IList<Todo>> GetTodosAsync()
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync(todoURL + "/Todos");

            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            string result = await responseMessage.Content.ReadAsStringAsync();

            IList<Todo> todos = JsonSerializer.Deserialize<IList<Todo>>(result, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            
            return todos;
        }

        
        public async Task AddTodoAsync(Todo todo)
        {
            using HttpClient client = new HttpClient();

            string todoAsJson = JsonSerializer.Serialize(todo);

            StringContent content = new StringContent(
                todoAsJson,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage responseMessage = await client.PostAsync(todoURL + "/Todos", content);

            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
        }
        
        public async Task RemoveTodoAsync(int todoId)
        {
            using HttpClient client = new HttpClient();

            HttpResponseMessage responseMessage = await client.DeleteAsync(todoURL + $"/Todos/{todoId}");

            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
        }
        
        public async Task UpdateAsync(Todo todo)
        {
            // PATCH or PUT, if updating, Patch is the one to use
            using HttpClient client = new HttpClient();

            string todoAsJson = JsonSerializer.Serialize(todo);

            StringContent content = new StringContent(
                todoAsJson,
                Encoding.UTF8,
                "application/json"
            );

            string patchUrl = todoURL + "/Todos/" + todo.TodoId;
            //HttpResponseMessage responseMessage = await client.PostAsync(todoURL + "/Todos", content);
            HttpResponseMessage responseMessage = await client.PatchAsync(patchUrl, content);

            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
        }
        
        /*
        public Task<Todo> Get(int id)
        {
            return todos.FirstOrDefault(t => t.TodoId == id);
        }*/
    }
}