using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ServerlessTodoApi.Models;

namespace ServerlessTodoApi.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TodoContext(serviceProvider
                .GetRequiredService<DbContextOptions<TodoContext>>()))
            {
                if (!context.Todos.Any())
                {
                    context.Todos.AddRange(
                        new TodoItem { Id = 1, Title = "get milk", IsComplete = false },
                        new TodoItem { Id = 2, Title = "get bread", IsComplete = false }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}