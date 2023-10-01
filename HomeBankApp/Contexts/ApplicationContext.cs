using HomeBankApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeBankApp.Contexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Operation> Operations { get; set; } = null!;
        public string Path { get; set; } = "Data Source = homebank.db";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Path);
        }
    }
}
