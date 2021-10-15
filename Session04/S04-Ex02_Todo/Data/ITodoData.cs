﻿using System.Collections;
using System.Collections.Generic;
using S04_Ex02_Todo.Models;

namespace S04_Ex02_Todo.Data
{
    public interface ITodoData
    {
        IList<Todo> GetTodos();
        void AddTodo(Todo todo);
        void RemoveTodo(int todoId);
        void Update(Todo todo);
        Todo Get(int id);
    }
}