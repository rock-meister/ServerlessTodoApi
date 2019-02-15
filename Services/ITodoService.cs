using System.Collections.Generic;
using ServerlessTodoApi.Models;

namespace ServerlessTodoApi.Services
{
    public interface ITodoService
    {
        IList<TodoItem> GetTodoItems();
        TodoItem Find(int id);
        void AddTodoItem(TodoItem todoItem);
        void RemoveTodoItem(int id);
        void UpdateTodoItem(TodoItem todoItem);
    }
}