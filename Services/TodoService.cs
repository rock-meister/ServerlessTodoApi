using System.Collections.Generic;
using ServerlessTodoApi.Models;

namespace ServerlessTodoApi.Services
{
    public class TodoService : ITodoService
    {
        private readonly Dictionary<string, string> _todo = new Dictionary<string, string>();
        public Dictionary<string, string> GetTodoItems()
        {
            return _todo;
        }

        public void AddTodoItem(TodoItem todoItem)
        {
            _todo.Add(todoItem.Id, todoItem.Title);
        }

        public void RemoveTodoItem(string Id)
        {
            _todo.Remove(Id);
        }
    }
}