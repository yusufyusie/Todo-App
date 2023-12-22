using Contracts;
using Entity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodo _todoService;
        public TodosController(ITodo todoService)
        {
            _todoService = todoService;
        }
        [HttpGet]
        public List<Todo> GetAll()
        {
            return _todoService.GetTasks();
        }
        [HttpPost]
        public int AddTodo(Todo todo)
        {
            return _todoService.CreateTask(todo);
        }

        [HttpDelete]
      public int DeleteTodo(int id)
        {
            return _todoService.DeleteTask(id);
        }

    }
}
