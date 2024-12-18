using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Control.Migrations
{
    /// <inheritdoc />
    public partial class Incidencias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
            name: "Rol",
            table: "incidencias",
            nullable: false,
            defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Razon",
                table: "incidencias",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
