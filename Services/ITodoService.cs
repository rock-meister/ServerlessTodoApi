using System.Collections.Generic;
using ServerlessTodoApi.Model;

namespace ServerlessTodoApi.Services
{
    public interface ITodoService
    {
        Dictionary<int, string> GetTodoItems();
        void AddTodoItem(TodoItem todoItem);
        void RemoveTodoItem(int id);
    }
}