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
                new Resident { Id = 2, Surname = "Johnson", Address = "456 Pine St" },
                new Resident { Id = 3, Surname = "Williams", Address = "789 Oak St" },
                new Resident { Id = 4, Surname = "Brown", Address = "123 Main St" }
            );

            int paymentId = 1;
            DateTime startDate = new DateTime(2023, 2, 1);
            ServiceType[] serviceTypes = Enum.GetValues(typeof(ServiceType)).Cast<ServiceType>().ToArray();

            for (int residentId = 1; residentId <= 4; residentId++)
            {
                for (int monthOffset = 0; monthOffset < 3; monthOffset++)
                {
                    DateTime paymentDate = startDate.AddMonths(monthOffset);

                    foreach (ServiceType serviceType in serviceTypes)
                    {
                        modelBuilder.Entity<Payment>().HasData(new Payment
                        {
                            Id = paymentId++,
                            ResidentId = residentId,
                            ServiceType = serviceType,
                            Amount = 100,
                            Date = paymentDate
                        });
                    }
                }
            }
        }

    }
}