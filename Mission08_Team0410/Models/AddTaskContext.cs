using Microsoft.EntityFrameworkCore;

namespace Mission08_Team0411.Models
{
    public class AddTaskContext : DbContext
    {
        public AddTaskContext(DbContextOptions<AddTaskContext> options) : base(options)
        {
        }

        public DbSet<Task> AddTask { get; set; } // this DBSET creates my ratings table
    }
}
