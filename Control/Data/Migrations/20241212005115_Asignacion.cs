using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Control.Migrations
{
    /// <inheritdoc />
    public partial class Asignacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_asignacionRecursos_incidencias_IncidenciasIdIncidencias",
                table: "asignacionRecursos");

            migrationBuilder.DropForeignKey(
                name: "FK_asignacionRecursos_recursos_RecursosIdRecursos",
                table: "asignacionRecursos");

            migrationBuilder.DropForeignKey(
                name: "FK_equipos_laboratorios_LaboratorioIdLaboratorio",
                table: "equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_historialIncidencias_incidencias_IncidenciasIdIncidencias",
                table: "historialIncidencias");

            migrationBuilder.DropForeignKey(
                name: "FK_incidencias_equipos_EquiposIdEquipos",
                table: "incidencias");

            migrationBuilder.DropForeignKey(
                name: "FK_incidencias_laboratorios_LaboratorioIdLaboratorio",
                table: "incidencias");

            migrationBuilder.DropForeignKey(
                name: "FK_incidencias_usuarios_UsuarioIdUsuario",
                table: "incidencias");

            migrationBuilder.DropIndex(
                name: "IX_incidencias_EquiposIdEquipos",
                table: "incidencias");

            migrationBuilder.DropIndex(
                name: "IX_incidencias_LaboratorioIdLaboratorio",
                table: "incidencias");

            migrationBuilder.DropIndex(
                name: "IX_incidencias_UsuarioIdUsuario",
                table: "incidencias");

            migrationBuilder.DropIndex(
                name: "IX_historialIncidencias_IncidenciasIdIncidencias",
                table: "historialIncidencias");

            migrationBuilder.DropIndex(
                name: "IX_equipos_LaboratorioIdLaboratorio",
                table: "equipos");

            migrationBuilder.DropIndex(
                name: "IX_asignacionRecursos_IncidenciasIdIncidencias",
                table: "asignacionRecursos");

            migrationBuilder.DropIndex(
                name: "IX_asignacionRecursos_RecursosIdRecursos",
                table: "asignacionRecursos");

            migrationBuilder.DeleteData(
                table: "laboratorios",
                keyColumn: "IdLaboratorio",
                keyValue: 23532);

            migrationBuilder.DropColumn(
                name: "EquiposIdEquipos",
                table: "incidencias");

            migrationBuilder.DropColumn(
                name: "IdEquipos",
                table: "incidencias");

            migrationBuilder.DropColumn(
                name: "IdLaboratorio",
                table: "incidencias");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "incidencias");

            migrationBuilder.DropColumn(
                name: "LaboratorioIdLaboratorio",
                table: "incidencias");

            migrationBuilder.DropColumn(
                name: "UsuarioIdUsuario",
                table: "incidencias");

            migrationBuilder.DropColumn(
                name: "IdIncidencias",
                table: "historialIncidencias");

            migrationBuilder.DropColumn(
                name: "IncidenciasIdIncidencias",
                table: "historialIncidencias");

            migrationBuilder.DropColumn(
                name: "IdLaboratorio",
                table: "equipos");

            migrationBuilder.DropColumn(
                name: "LaboratorioIdLaboratorio",
                table: "equipos");

            migrationBuilder.DropColumn(
                name: "IdIncidencias",
                table: "asignacionRecursos");

            migrationBuilder.DropColumn(
                name: "IdRecursos",
                table: "asignacionRecursos");

            migrationBuilder.DropColumn(
                name: "IncidenciasIdIncidencias",
                table: "asignacionRecursos");

            migrationBuilder.DropColumn(
                name: "RecursosIdRecursos",
                table: "asignacionRecursos");

            migrationBuilder.RenameColumn(
                name: "UsuarioResponsable",
                table: "historialIncidencias",
                newName: "UsuarioRes");

            migrationBuilder.InsertData(
                table: "asignacionRecursos",
                columns: new[] { "IdAsignacion", "CantidadUtilizada" },
                values: new object[] { 123512, 34522 });

            migrationBuilder.InsertData(
                table: "equipos",
                columns: new[] { "IdEquipos", "FechaInst", "Modelo", "NombreEquipos" },
                values: new object[] { 34112, new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lenovo", "LAB-01" });

            migrationBuilder.InsertData(
                table: "historialIncidencias",
                columns: new[] { "IdHistorial", "Accion", "Comentarios", "UsuarioRes" },
                values: new object[] { 123553, "Reparada", "Esta computadora fue raparada", "Jorgito" });

            migrationBuilder.InsertData(
                table: "incidencias",
                columns: new[] { "IdIncidencias", "DescInc", "FechaReporte", "FechaSolucion" },
                values: new object[] { 1251222, "Sucedio mientras alguien movia..", new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "laboratorios",
                columns: new[] { "IdLaboratorio", "Capacidad", "NombreLab", "Ubicacion" },
                values: new object[] { 34123, 25, "LAB-01", "Upla-Huancayo" });

            migrationBuilder.InsertData(
                table: "recursos",
                columns: new[] { "IdRecursos", "DesRec", "NombreRec" },
                values: new object[] { 235121, "Se necesito el recurso", "Recurso compartido" });

            migrationBuilder.InsertData(
                table: "usuarios",
                columns: new[] { "IdUsuario", "CorreoUsuario", "NombreUsuario", "RolUsuario", "TipoUsuario" },
                values: new object[] { 312122, "Jorgito@upla.edu.pe", "Jorgito", "Docente", "Principal" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "asignacionRecursos",
                keyColumn: "IdAsignacion",
                keyValue: 123512);

            migrationBuilder.DeleteData(
                table: "equipos",
                keyColumn: "IdEquipos",
                keyValue: 34112);

            migrationBuilder.DeleteData(
                table: "historialIncidencias",
                keyColumn: "IdHistorial",
                keyValue: 123553);

            migrationBuilder.DeleteData(
                table: "incidencias",
                keyColumn: "IdIncidencias",
                keyValue: 1251222);

            migrationBuilder.DeleteData(
                table: "laboratorios",
                keyColumn: "IdLaboratorio",
                keyValue: 34123);

            migrationBuilder.DeleteData(
                table: "recursos",
                keyColumn: "IdRecursos",
                keyValue: 235121);

            migrationBuilder.DeleteData(
                table: "usuarios",
                keyColumn: "IdUsuario",
                keyValue: 312122);

            migrationBuilder.RenameColumn(
                name: "UsuarioRes",
                table: "historialIncidencias",
                newName: "UsuarioResponsable");

            migrationBuilder.AddColumn<int>(
                name: "EquiposIdEquipos",
                table: "incidencias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEquipos",
                table: "incidencias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdLaboratorio",
                table: "incidencias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "incidencias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LaboratorioIdLaboratorio",
                table: "incidencias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioIdUsuario",
                table: "incidencias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdIncidencias",
                table: "historialIncidencias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IncidenciasIdIncidencias",
                table: "historialIncidencias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdLaboratorio",
                table: "equipos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LaboratorioIdLaboratorio",
                table: "equipos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdIncidencias",
                table: "asignacionRecursos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdRecursos",
                table: "asignacionRecursos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IncidenciasIdIncidencias",
                table: "asignacionRecursos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RecursosIdRecursos",
                table: "asignacionRecursos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "laboratorios",
                columns: new[] { "IdLaboratorio", "Capacidad", "NombreLab", "Ubicacion" },
                values: new object[] { 23532, 34, "LAB-01", "Upla-Huancayo" });

            migrationBuilder.CreateIndex(
                name: "IX_incidencias_EquiposIdEquipos",
                table: "incidencias",
                column: "EquiposIdEquipos");

            migrationBuilder.CreateIndex(
                name: "IX_incidencias_LaboratorioIdLaboratorio",
                table: "incidencias",
                column: "LaboratorioIdLaboratorio");

            migrationBuilder.CreateIndex(
                name: "IX_incidencias_UsuarioIdUsuario",
                table: "incidencias",
                column: "UsuarioIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_historialIncidencias_IncidenciasIdIncidencias",
                table: "historialIncidencias",
                column: "IncidenciasIdIncidencias");

            migrationBuilder.CreateIndex(
                name: "IX_equipos_LaboratorioIdLaboratorio",
                table: "equipos",
                column: "LaboratorioIdLaboratorio");

            migrationBuilder.CreateIndex(
                name: "IX_asignacionRecursos_IncidenciasIdIncidencias",
                table: "asignacionRecursos",
                column: "IncidenciasIdIncidencias");

            migrationBuilder.CreateIndex(
                name: "IX_asignacionRecursos_RecursosIdRecursos",
                table: "asignacionRecursos",
                column: "RecursosIdRecursos");

            migrationBuilder.AddForeignKey(
                name: "FK_asignacionRecursos_incidencias_IncidenciasIdIncidencias",
                table: "asignacionRecursos",
                column: "IncidenciasIdIncidencias",
                principalTable: "incidencias",
                principalColumn: "IdIncidencias",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_asignacionRecursos_recursos_RecursosIdRecursos",
                table: "asignacionRecursos",
                column: "RecursosIdRecursos",
                principalTable: "recursos",
                principalColumn: "IdRecursos",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_equipos_laboratorios_LaboratorioIdLaboratorio",
                table: "equipos",
                column: "LaboratorioIdLaboratorio",
                principalTable: "laboratorios",
                principalColumn: "IdLaboratorio",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_historialIncidencias_incidencias_IncidenciasIdIncidencias",
                table: "historialIncidencias",
                column: "IncidenciasIdIncidencias",
                principalTable: "incidencias",
                principalColumn: "IdIncidencias",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_incidencias_equipos_EquiposIdEquipos",
                table: "incidencias",
                column: "EquiposIdEquipos",
                principalTable: "equipos",
                principalColumn: "IdEquipos",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_incidencias_laboratorios_LaboratorioIdLaboratorio",
                table: "incidencias",
                column: "LaboratorioIdLaboratorio",
                principalTable: "laboratorios",
                principalColumn: "IdLaboratorio",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_incidencias_usuarios_UsuarioIdUsuario",
                table: "incidencias",
                column: "UsuarioIdUsuario",
                principalTable: "usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
