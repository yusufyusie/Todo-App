using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options)
        {

        }
        public DbSet<Todo> Todos { get; set; }

    }
}
