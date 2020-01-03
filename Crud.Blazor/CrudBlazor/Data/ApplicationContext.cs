using Microsoft.EntityFrameworkCore;

namespace CrudBlazor.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
