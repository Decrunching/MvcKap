using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcKap.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calculations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IvftRate = table.Column<double>(type: "float", nullable: false),
                    IvftBolusVolume = table.Column<double>(type: "float", nullable: false),
                    EphedrineConc = table.Column<double>(type: "float", nullable: false),
                    GlycopyrrolateConc = table.Column<double>(type: "float", nullable: false),
                    TranexamicAcidConc = table.Column<double>(type: "float", nullable: false),
                    KetamineConc = table.Column<double>(type: "float", nullable: false),
                    FentanylConc = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calculations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Species = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    BodyWeight = table.Column<double>(type: "float", nullable: false),
                    LeanBodyWeight = table.Column<double>(type: "float", nullable: false),
                    Bcs = table.Column<int>(type: "int", nullable: false),
                    RespRate = table.Column<int>(type: "int", nullable: false),
                    HeartRate = table.Column<int>(type: "int", nullable: false),
                    BpSystolic = table.Column<int>(type: "int", nullable: false),
                    BpMean = table.Column<int>(type: "int", nullable: false),
                    BpDiastolic = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calculations");

            migrationBuilder.DropTable(
                name: "Patient");
        }
    }
}
