using ASPNETMVCCRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPNETMVCCRUD.Data
{
    public class MVCDemoDbContext : DbContext // MVCDemoDbContext is inherit from DbContext which is coming from Microsoft.EntityFrameworkCore
    {
        // this is a constructor for class -> MVCDemoDbContext 
        public MVCDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
}
