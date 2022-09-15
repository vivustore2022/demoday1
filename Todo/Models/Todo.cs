namespace Todo.Models;

public class TodoModel : BaseEntity
{
    private string? title;

    public string? Title { get => title; set => title = value; }
    public bool IsCompleted { get; set; }
}