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
        public DbSet<Resident> Residents { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resident>()
                .HasMany(r => r.Payments)
                .WithOne()
                .HasForeignKey(p => p.ResidentId)
                .OnDelete(DeleteBehavior.Cascade);

            SeedData(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resident>().HasData(
                new Resident { Id = 1, Surname = "Smith", Address = "123 Main St" },
                new Resident { Id = 2, Surname = "Johnson", Address = "456 Elm St" },
                new Resident { Id = 3, Surname = "Williams", Address = "789 Oak St" }
            );

            modelBuilder.Entity<Payment>().HasData(
                new Payment { Id = 1, ResidentId = 1, ServiceType = ServiceType.Electricity, Amount = 50.0m, Date = DateTime.Parse("2023-01-15") },
                new Payment { Id = 2, ResidentId = 1, ServiceType = ServiceType.Gas, Amount = 40.0m, Date = DateTime.Parse("2023-01-20") },
                new Payment { Id = 3, ResidentId = 2, ServiceType = ServiceType.Internet, Amount = 60.0m, Date = DateTime.Parse("2023-01-10") },
                new Payment { Id = 4, ResidentId = 3, ServiceType = ServiceType.Water, Amount = 30.0m, Date = DateTime.Parse("2023-01-25") }
            );  
        }

    }
}