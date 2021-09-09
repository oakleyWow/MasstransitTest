using Microsoft.EntityFrameworkCore;

namespace Alpha
{
    public class AppContext : DbContext
    {
        public DbSet<ProcessTask> ProcessTasks { get; set; }
        public AppContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=test;Username=postgres;Password=11111");
        }
        
        public AppContext(DbContextOptions<AppContext> options)
            : base(options)
        { }
    }
}