using System.Collections.Generic;
using ServerlessTodoApi.Models;

namespace ServerlessTodoApi.Services
{
    public interface ITodoService
    {
        IList<TodoItem> GetTodoItems();
        void AddTodoItem(TodoItem todoItem);
        void RemoveTodoItem(string Id);
    }
}