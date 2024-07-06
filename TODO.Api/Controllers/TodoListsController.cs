using Microsoft.AspNetCore.Mvc;
using TODO.Domain.Services;
using TODO.SharedKernel.Dtos;

namespace TODO.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoListsController : ControllerBase
    {
        private readonly ITodoListsService _todoListsService;

        public TodoListsController(ITodoListsService todoListsService)
        {
            _todoListsService = todoListsService;
        }

        // GET: api/<TodoListsController>
        [HttpGet]
        public ActionResult<IEnumerable<TodoListDto>> Get()
        {
            var todoLists = _todoListsService.GetAll();

            return Ok(todoLists);
        }

        // GET api/<TodoListsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoListDto>> Get(int id)
        {
            var todoList = await _todoListsService.GetByIdAsync(id);

            return Ok(todoList);
        }

        // POST api/<TodoListsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TodoListsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TodoListsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
