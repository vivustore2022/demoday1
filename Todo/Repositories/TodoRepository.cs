using Microsoft.EntityFrameworkCore;
using Todo.Models;

namespace Todo.Repositories;

public class TodoRepository : ITodoRepository
{
    private readonly TodoDbContext context;

    public TodoRepository(TodoDbContext context)
    {
        this.context = context;
    }

    public async Task<List<TodoModel>> GetAllAsync()
    {
        return await context.Todos.ToListAsync();
    }

    public async Task<TodoModel> GetByIdAsync(int id)
    {
        return await context.Todos.FindAsync(id);
    }
}