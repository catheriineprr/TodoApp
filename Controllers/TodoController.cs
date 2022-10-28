using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Data;
using TodoApp.Models;
using TodoApp.Services;

namespace TodoApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;
        
        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpPost("addTodo")]
        public IActionResult AddTodo(TodoItem newItem)
        {
            _todoService.AddTodo(newItem);
            return Ok();
        }

        [HttpGet("getTodo")]
        public IActionResult GetTodos()
        {
            return Ok(_todoService.GetTodos());
        }

        [HttpPut("updateTodo")]
        public IActionResult UpdateTodos(TodoItem itemToUpdate)
        {
            _todoService.UpdateTodo(itemToUpdate);
            return Ok();
        }

        [HttpPut("updateStatus/{id}/{status}")]
        public IActionResult UpdateTodoStatus(int id, TodoStatus status)
        {
            _todoService.UpdateTodoStatus(id, status);
            return Ok();
        }

    }
}
