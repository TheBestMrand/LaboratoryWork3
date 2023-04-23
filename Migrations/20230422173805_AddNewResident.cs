using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LaboratoryWork3.Migrations
{
    /// <inheritdoc />
    public partial class AddNewResident : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Residents",
                columns: new[] { "Id", "Address", "Surname" },
                values: new object[] { 4, "123 Main St", "Brown" });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "Date", "ResidentId", "ServiceType" },
                values: new object[,]
                {
                    { 37, 100m, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 0 },
                    { 38, 100m, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 39, 100m, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 40, 100m, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3 },
                    { 41, 100m, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 0 },
                    { 42, 100m, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 43, 100m, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 44, 100m, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3 },
                    { 45, 100m, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 0 },
                    { 46, 100m, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1 },
                    { 47, 100m, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 48, 100m, new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Residents",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
