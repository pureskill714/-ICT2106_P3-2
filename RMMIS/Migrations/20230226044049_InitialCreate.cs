using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RMMIS.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceCentre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    EstablishedDate = table.Column<string>(type: "TEXT", nullable: false),
                    Manager = table.Column<string>(type: "TEXT", nullable: false),
                    NoOfProjects = table.Column<int>(type: "INTEGER", nullable: true),
                    NoOfEmployees = table.Column<int>(type: "INTEGER", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceCentre", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceCentre");
        }
    }
}
