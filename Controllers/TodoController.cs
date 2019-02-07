using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServerlessTodoApi.Models;
using ServerlessTodoApi.Data;

namespace ServerlessTodoApi.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        //private readonly ITodoService _TodoService;
        private readonly TodoContext _context;

        public TodoController(TodoContext context)
        {
            _context = context;
        }

        // GET api/Todo
        [HttpGet]
        public IList<TodoItem> GetTodoItems()
        {
            return _context.Todos.ToList();
        }

        // The GET (by ID)
        [HttpGet("{id}")]
        public TodoItem GetById(long id)
        {
            var todoItem = _context.Todos.Find(id);

            //if (todoItem == null)
            //{
                //return NotFound();
            //}

            return todoItem;
        }

        // POST api/Todo
        [HttpPost]
        public IActionResult AddTodoItem([FromBody]TodoItem todoItem)
        {
            _context.Add(todoItem);
            _context.SaveChanges();
            return Ok();
        }
        // Delete api/Todo
        [HttpDelete]
        public IActionResult DeleteTodoItem([FromBody] TodoItem todoItem)
        {
            _context.Remove(todoItem);
            _context.SaveChanges();
            return Ok();
        }
    }
}