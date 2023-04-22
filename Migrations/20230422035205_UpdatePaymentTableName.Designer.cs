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
    [Migration("20230422035205_UpdatePaymentTableName")]
    partial class UpdatePaymentTableName
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

                    b.Property<int>("ResidentId1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ResidentId2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ServiceType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ResidentId");

                    b.HasIndex("ResidentId1");

                    b.ToTable("Payments", (string)null);
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

                    b.HasOne("LaboratoryWork3.Models.Data.Resident", "Resident")
                        .WithMany()
                        .HasForeignKey("ResidentId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resident");
                });

            modelBuilder.Entity("LaboratoryWork3.Models.Data.Resident", b =>
                {
                    b.Navigation("Payments");
                });
#pragma warning restore 612, 618
        }
    }
}
