namespace Todo.Models;
public class BaseEntity
{
    public int Id { get; set; }
    public DateTime InsertedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime IsActive { get; set; }
}