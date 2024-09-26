using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcKap.Migrations
{
    /// <inheritdoc />
    public partial class AgeMonths : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Patient",
                newName: "AgeYears");

            migrationBuilder.AddColumn<int>(
                name: "AgeMonths",
                table: "Patient",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgeMonths",
                table: "Patient");

            migrationBuilder.RenameColumn(
                name: "AgeYears",
                table: "Patient",
                newName: "Age");
        }
    }
}
