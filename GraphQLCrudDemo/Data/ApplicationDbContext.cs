using GraphQLCrudDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLCrudDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}

