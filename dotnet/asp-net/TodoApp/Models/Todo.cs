namespace TodoApp.Models;

public class Todo
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Notes { get; set; }
    public DateOnly DueDate { get; set; }
    public char Priority { get; set; }
    public char Status { get; set; }
}