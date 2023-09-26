using HomeBankApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeBankApp.Contexts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Operation> Operations { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=homebank.db");
        }
    }
}
