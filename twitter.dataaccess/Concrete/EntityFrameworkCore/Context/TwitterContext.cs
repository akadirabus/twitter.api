using Microsoft.EntityFrameworkCore;

namespace twitter.dataaccess.Concrete.EntityFrameworkCore.Context
{
    public class TwitterContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=AKADIRABUS;Initial Catalog=TWITTER;User ID=sa; Password=1122;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}