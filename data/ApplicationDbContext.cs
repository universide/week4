using Microsoft.EntityFrameworkCore;
using WebApiPractice.Models; 

namespace WebApiPractice.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = default!;

        
    }
}