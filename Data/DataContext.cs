using expensetrackerbackend.Models;
using Microsoft.EntityFrameworkCore;

namespace expensetrackerbackend.Data
{
    public class DataContext: DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=uniTestApi.db");
            }
        }
        
    }
}