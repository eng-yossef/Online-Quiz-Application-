using Online_Quiz_Application.Models;
using System.Collections.Generic;
using System.Reflection.Emit;




using Microsoft.EntityFrameworkCore;

namespace Online_Quiz_Application.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Option> Options { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure constraints or relationships (if needed)
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
        }
    }
}
