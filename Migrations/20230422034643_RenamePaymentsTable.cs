using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaboratoryWork3.Migrations
{
    /// <inheritdoc />
    public partial class RenamePaymentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "Payments");

            migrationBuilder.AddColumn<int>(
                name: "ResidentId1",
                table: "Payments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ResidentId2",
                table: "Payments",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ResidentId1",
                table: "Payments",
                column: "ResidentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Residents_ResidentId1",
                table: "Payments",
                column: "ResidentId1",
                principalTable: "Residents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Residents_ResidentId1",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_ResidentId1",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "ResidentId1",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "ResidentId2",
                table: "Payments");
        }
    }
}
