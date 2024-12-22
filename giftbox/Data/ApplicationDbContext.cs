using Microsoft.EntityFrameworkCore;

namespace giftbox.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Define DbSets for your entities
        public DbSet<Employee> Employees { get; set; }
    }
}
