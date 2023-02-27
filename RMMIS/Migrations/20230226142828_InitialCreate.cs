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
                    Id = table.Column<int>(type: "INTEGER", nullable: true)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    ContactNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Manager = table.Column<string>(type: "TEXT", nullable: true),
                    NoOfProjects = table.Column<int>(type: "INTEGER", nullable: true),
                    NoOfEmployees = table.Column<int>(type: "INTEGER", nullable: true)
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
