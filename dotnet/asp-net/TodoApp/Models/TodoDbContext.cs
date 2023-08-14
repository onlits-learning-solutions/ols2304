using Microsoft.EntityFrameworkCore;

namespace TodoApp.Models;

public class TodoDbContext: DbContext
{
    public TodoDbContext(DbContextOptions dbContextOptions)
        :base(dbContextOptions)
    {
        
    }

    public DbSet<Todo> Todos { get; set; }
}