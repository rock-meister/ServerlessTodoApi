using System;
using System.Collections.Generic;
using ServerlessTodoApi.Models;
using ServerlessTodoApi.Data;
using System.Linq;


namespace ServerlessTodoApi.Services
{
    public class TodoService : ITodoService
    {
        private readonly TodoContext _todoContext;
        public TodoService(TodoContext todoContext)
        {
            _todoContext = todoContext;
        }
        public IList<TodoItem> GetTodoItems()
        {
            return _todoContext.Todos.ToList();
        }

        public TodoItem Find(int id)
        {
            return _todoContext.Todos.Find(id);
        }
        public void AddTodoItem(TodoItem todoItem)
        {
            _todoContext.Add(todoItem);
            _todoContext.SaveChanges();
        }

        public void RemoveTodoItem(int id)
        {
            _todoContext.Remove(Find(id));
            _todoContext.SaveChanges();
        }
    }
}