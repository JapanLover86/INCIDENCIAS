using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Control.Migrations
{
    /// <inheritdoc />
    public partial class AgregarColumnasRazonesYRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rol",
                table: "incidencias",
                newName: "Roles");

            migrationBuilder.RenameColumn(
                name: "Razon",
                table: "incidencias",
                newName: "Razones");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Roles",
                table: "incidencias",
                newName: "Rol");

            migrationBuilder.RenameColumn(
                name: "Razones",
                table: "incidencias",
                newName: "Razon");
        }
    }
}
