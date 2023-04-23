﻿// <auto-generated />
using System;
using LaboratoryWork3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LaboratoryWork3.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230422170705_SeedResidentData")]
    partial class SeedResidentData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("LaboratoryWork3.Models.Data.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("ResidentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ServiceType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ResidentId");

                    b.ToTable("Payments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amount = 100m,
                            Date = new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 1,
                            ServiceType = 0
                        },
                        new
                        {
                            Id = 2,
                            Amount = 100m,
                            Date = new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 1,
                            ServiceType = 1
                        },
                        new
                        {
                            Id = 3,
                            Amount = 100m,
                            Date = new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 1,
                            ServiceType = 2
                        },
                        new
                        {
                            Id = 4,
                            Amount = 100m,
                            Date = new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 1,
                            ServiceType = 3
                        },
                        new
                        {
                            Id = 5,
                            Amount = 100m,
                            Date = new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 1,
                            ServiceType = 0
                        },
                        new
                        {
                            Id = 6,
                            Amount = 100m,
                            Date = new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 1,
                            ServiceType = 1
                        },
                        new
                        {
                            Id = 7,
                            Amount = 100m,
                            Date = new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 1,
                            ServiceType = 2
                        },
                        new
                        {
                            Id = 8,
                            Amount = 100m,
                            Date = new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 1,
                            ServiceType = 3
                        },
                        new
                        {
                            Id = 9,
                            Amount = 100m,
                            Date = new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 1,
                            ServiceType = 0
                        },
                        new
                        {
                            Id = 10,
                            Amount = 100m,
                            Date = new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 1,
                            ServiceType = 1
                        },
                        new
                        {
                            Id = 11,
                            Amount = 100m,
                            Date = new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 1,
                            ServiceType = 2
                        },
                        new
                        {
                            Id = 12,
                            Amount = 100m,
                            Date = new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 1,
                            ServiceType = 3
                        },
                        new
                        {
                            Id = 13,
                            Amount = 100m,
                            Date = new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 2,
                            ServiceType = 0
                        },
                        new
                        {
                            Id = 14,
                            Amount = 100m,
                            Date = new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 2,
                            ServiceType = 1
                        },
                        new
                        {
                            Id = 15,
                            Amount = 100m,
                            Date = new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 2,
                            ServiceType = 2
                        },
                        new
                        {
                            Id = 16,
                            Amount = 100m,
                            Date = new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 2,
                            ServiceType = 3
                        },
                        new
                        {
                            Id = 17,
                            Amount = 100m,
                            Date = new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 2,
                            ServiceType = 0
                        },
                        new
                        {
                            Id = 18,
                            Amount = 100m,
                            Date = new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 2,
                            ServiceType = 1
                        },
                        new
                        {
                            Id = 19,
                            Amount = 100m,
                            Date = new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 2,
                            ServiceType = 2
                        },
                        new
                        {
                            Id = 20,
                            Amount = 100m,
                            Date = new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 2,
                            ServiceType = 3
                        },
                        new
                        {
                            Id = 21,
                            Amount = 100m,
                            Date = new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 2,
                            ServiceType = 0
                        },
                        new
                        {
                            Id = 22,
                            Amount = 100m,
                            Date = new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 2,
                            ServiceType = 1
                        },
                        new
                        {
                            Id = 23,
                            Amount = 100m,
                            Date = new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 2,
                            ServiceType = 2
                        },
                        new
                        {
                            Id = 24,
                            Amount = 100m,
                            Date = new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 2,
                            ServiceType = 3
                        },
                        new
                        {
                            Id = 25,
                            Amount = 100m,
                            Date = new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 3,
                            ServiceType = 0
                        },
                        new
                        {
                            Id = 26,
                            Amount = 100m,
                            Date = new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 3,
                            ServiceType = 1
                        },
                        new
                        {
                            Id = 27,
                            Amount = 100m,
                            Date = new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 3,
                            ServiceType = 2
                        },
                        new
                        {
                            Id = 28,
                            Amount = 100m,
                            Date = new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 3,
                            ServiceType = 3
                        },
                        new
                        {
                            Id = 29,
                            Amount = 100m,
                            Date = new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 3,
                            ServiceType = 0
                        },
                        new
                        {
                            Id = 30,
                            Amount = 100m,
                            Date = new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 3,
                            ServiceType = 1
                        },
                        new
                        {
                            Id = 31,
                            Amount = 100m,
                            Date = new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 3,
                            ServiceType = 2
                        },
                        new
                        {
                            Id = 32,
                            Amount = 100m,
                            Date = new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 3,
                            ServiceType = 3
                        },
                        new
                        {
                            Id = 33,
                            Amount = 100m,
                            Date = new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 3,
                            ServiceType = 0
                        },
                        new
                        {
                            Id = 34,
                            Amount = 100m,
                            Date = new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 3,
                            ServiceType = 1
                        },
                        new
                        {
                            Id = 35,
                            Amount = 100m,
                            Date = new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 3,
                            ServiceType = 2
                        },
                        new
                        {
                            Id = 36,
                            Amount = 100m,
                            Date = new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ResidentId = 3,
                            ServiceType = 3
                        });
                });

            modelBuilder.Entity("LaboratoryWork3.Models.Data.Resident", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Residents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main St",
                            Surname = "Smith"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Pine St",
                            Surname = "Johnson"
                        },
                        new
                        {
                            Id = 3,
                            Address = "789 Oak St",
                            Surname = "Williams"
                        });
                });

            modelBuilder.Entity("LaboratoryWork3.Models.Data.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LaboratoryWork3.Models.Data.Payment", b =>
                {
                    b.HasOne("LaboratoryWork3.Models.Data.Resident", null)
                        .WithMany("Payments")
                        .HasForeignKey("ResidentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LaboratoryWork3.Models.Data.Resident", b =>
                {
                    b.Navigation("Payments");
                });
#pragma warning restore 612, 618
        }
    }
}