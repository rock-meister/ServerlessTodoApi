using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServerlessTodoApi.Services;
using ServerlessTodoApi.Model;

namespace ServerlessTodoApi.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private readonly ITodoService _TodoService;

        public TodoController(ITodoService todoService)
        {
            _TodoService = todoService;
        }
        
        // GET api/values
        [HttpGet]
        public IActionResult GetTodoItems()
        {
            var result = _TodoService.GetTodoItems();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddTodoItem([FromBody]TodoItem todoItem)
        {
            _TodoService.AddTodoItem(todoItem);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTodoItem([FromBody] TodoItem todoItem)
        {
            _TodoService.RemoveTodoItem(todoItem.id);
            return Ok();
        }
    }
}