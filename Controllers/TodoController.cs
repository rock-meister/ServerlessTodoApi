using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServerlessTodoApi.Models;
using ServerlessTodoApi.Services;

namespace ServerlessTodoApi.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        // GET api/Todo
        [HttpGet]
        public IList<TodoItem> GetTodoItems()
        {
            return _todoService.GetTodoItems();
        }

        // The GET (by ID)
        [HttpGet("{id}")]
        public TodoItem GetById(int id)
        {
            var todoItem = _todoService.Find(id);
            return todoItem;
        }

        // POST api/Todo
        [HttpPost]
        public IActionResult AddTodoItem([FromBody]TodoItem todoItem)
        {
            _todoService.AddTodoItem(todoItem);
            return Ok();
        }
        // Delete api/Todo
        [HttpDelete]
        public IActionResult DeleteTodoItem([FromBody] TodoItem todoItem)
        {
            _todoService.RemoveTodoItem(todoItem.Id);
            return Ok();
        }
    }
}