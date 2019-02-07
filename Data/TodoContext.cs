using Microsoft.EntityFrameworkCore;
using ServerlessTodoApi.Models;

namespace ServerlessTodoApi.Data
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> Todos { get; set; }

        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }
    }
}