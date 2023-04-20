using LaboratoryWork3.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace LaboratoryWork3.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}