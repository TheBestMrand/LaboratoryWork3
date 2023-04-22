using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LaboratoryWork3.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePaymentTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Residents_ResidentId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Residents_ResidentId1",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_ResidentId1",
                table: "Payments",
                newName: "IX_Payments_ResidentId1");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_ResidentId",
                table: "Payments",
                newName: "IX_Payments_ResidentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Residents_ResidentId",
                table: "Payments",
                column: "ResidentId",
                principalTable: "Residents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Residents_ResidentId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Residents_ResidentId1",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_ResidentId1",
                table: "Payments",
                newName: "IX_Payments_ResidentId1");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_ResidentId",
                table: "Payments",
                newName: "IX_Payments_ResidentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Residents_ResidentId",
                table: "Payments",
                column: "ResidentId",
                principalTable: "Residents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Residents_ResidentId1",
                table: "Payments",
                column: "ResidentId1",
                principalTable: "Residents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
