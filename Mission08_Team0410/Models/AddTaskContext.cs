using Microsoft.EntityFrameworkCore;

namespace Mission08_Team0411.Models
{
    public class AddTaskContext : DbContext
    {
        public AddTaskContext(DbContextOptions<AddTaskContext> options) : base(options)
        {
        }

        public DbSet<Task> AddTask { get; set; } // this DBSET creates the AddTask table
        public DbSet<Categories> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>().HasData(
                new Categories { CategoryId = 1, CategoryName = "Home" },
                new Categories { CategoryId = 2, CategoryName = "School" },
                new Categories { CategoryId = 3, CategoryName = "Work" },
                new Categories { CategoryId = 4, CategoryName = "Church" }
                );
        }
    }
}
