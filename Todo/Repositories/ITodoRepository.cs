using Todo.Models;

namespace Todo.Repositories;

public interface ITodoRepository
{
    Task<List<TodoModel>> GetAllAsync();

    Task<TodoModel> GetByIdAsync(int id);
    
    Task<List<TodoModel>> GetAllAsync(bool IsActive = true);
}
