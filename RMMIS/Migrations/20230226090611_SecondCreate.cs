using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RMMIS.Migrations
{
    /// <inheritdoc />
    public partial class SecondCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EstablishedDate",
                table: "ServiceCentre",
                newName: "ContactNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactNumber",
                table: "ServiceCentre",
                newName: "EstablishedDate");
        }
    }
}
