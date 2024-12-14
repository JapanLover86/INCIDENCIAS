using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Control.Migrations
{
    /// <inheritdoc />
    public partial class AsignacionRecursosDouble : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "CantidadUtilizada",
                table: "asignacionRecursos",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "asignacionRecursos",
                keyColumn: "IdAsignacion",
                keyValue: 123512,
                column: "CantidadUtilizada",
                value: 350.44999999999999);

            migrationBuilder.UpdateData(
                table: "incidencias",
                keyColumn: "IdIncidencias",
                keyValue: 1251222,
                column: "DescInc",
                value: "Sucedió mientras alguien movía..");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CantidadUtilizada",
                table: "asignacionRecursos",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "asignacionRecursos",
                keyColumn: "IdAsignacion",
                keyValue: 123512,
                column: "CantidadUtilizada",
                value: 34522);

            migrationBuilder.UpdateData(
                table: "incidencias",
                keyColumn: "IdIncidencias",
                keyValue: 1251222,
                column: "DescInc",
                value: "Sucedio mientras alguien movia..");
        }
    }
}
