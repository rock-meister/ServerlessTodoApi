using System.Collections.Generic;
using ServerlessTodoApi.Model;

namespace ServerlessTodoApi.Services
{
    public class TodoService : ITodoService
    {
        private readonly Dictionary<int, string> _todo = new Dictionary<int, string>();
        public Dictionary<int, string> GetTodoItems()
        {
            return _todo;
        }

        public void AddTodoItem(TodoItem todoItem)
        {
            _todo.Add(todoItem.id, todoItem.title);
        }

        public void RemoveTodoItem(int id)
        {
            _todo.Remove(id);
        }
    }
}