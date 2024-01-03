using Microsoft.EntityFrameworkCore;

namespace TestTask.Server.Entities
{
    public class AppDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }

        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-QSL5KI2;Database=TestTaskDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
