using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LaboratoryWork3.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Residents",
                columns: new[] { "Id", "Address", "Surname" },
                values: new object[,]
                {
                    { 1, "123 Main St", "Smith" },
                    { 2, "456 Elm St", "Johnson" },
                    { 3, "789 Oak St", "Williams" }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "Date", "ResidentId", "ServiceType" },
                values: new object[,]
                {
                    { 1, 50.0m, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0 },
                    { 2, 40.0m, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 3, 60.0m, new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 4, 30.0m, new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
