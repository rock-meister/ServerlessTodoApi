using System;
using System.Collections.Generic;
using ServerlessTodoApi.Models;



namespace ServerlessTodoApi.Services
{
    public class TodoService : ITodoService
    {
        private readonly IList<TodoItem> _todo = new List<TodoItem>();
        public IList<TodoItem> GetTodoItems()
        {
            return _todo;
        }

        public void AddTodoItem(TodoItem todoItem)
        {
            _todo.Add(todoItem);
        }

        public void RemoveTodoItem(string Id)
        {
            //_todo.Remove(_todo.Contains(x => x.Id() == Id)
            throw new NotImplementedException();
        }
    }
}