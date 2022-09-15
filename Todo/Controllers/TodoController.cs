using Microsoft.AspNetCore.Mvc;
using Todo.Repositories;

namespace Todo.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{
    private readonly ITodoRepository repository;

    public TodoController(ITodoRepository repository)
    {
        this.repository = repository;
    }

    [HttpGet(Name = "GetTodos")]
    public async Task<IActionResult> GetAllAsync()
    {
        return Ok(await repository.GetAllAsync());
    }

    [HttpGet()]
    [Route("{id}")]
    public async Task<IActionResult> GetByIdAsync(int id)
    {
        return Ok(await repository.GetByIdAsync(id));
    }
}