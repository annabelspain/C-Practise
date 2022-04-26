using Microsoft.EntityFrameworkCore;
using ToDoItems.Models;

namespace ToDoItems.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
