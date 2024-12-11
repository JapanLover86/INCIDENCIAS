using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Control.Migrations
{
    /// <inheritdoc />
    public partial class Laboratorios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "laboratorios",
                columns: table => new
                {
                    IdLaboratorio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreLab = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ubicacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    capacidad = table.Column<int>(type: "int", nullable: false),
                    horario = table.Column<TimeOnly>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_laboratorios", x => x.IdLaboratorio);
                });

            migrationBuilder.CreateTable(
                name: "recursos",
                columns: table => new
                {
                    IdRecursos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreRec = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cantidad = table.Column<double>(type: "float", nullable: false),
                    desRec = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recursos", x => x.IdRecursos);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correoUsuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoUsuario = table.Column<float>(type: "real", nullable: false),
                    rolUsuario = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "equipos",
                columns: table => new
                {
                    IdEquipos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreEquipos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estado = table.Column<float>(type: "real", nullable: false),
                    modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fecha_inst = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdLaboratorio = table.Column<int>(type: "int", nullable: false),
                    LaboratoriosIdLaboratorio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipos", x => x.IdEquipos);
                    table.ForeignKey(
                        name: "FK_equipos_laboratorios_LaboratoriosIdLaboratorio",
                        column: x => x.LaboratoriosIdLaboratorio,
                        principalTable: "laboratorios",
                        principalColumn: "IdLaboratorio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "incidencias",
                columns: table => new
                {
                    IdIncidencias = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descInc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaReportado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaResolucion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdEquipos = table.Column<int>(type: "int", nullable: false),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdLaboratorio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_incidencias", x => x.IdIncidencias);
                    table.ForeignKey(
                        name: "FK_incidencias_equipos_IdEquipos",
                        column: x => x.IdEquipos,
                        principalTable: "equipos",
                        principalColumn: "IdEquipos",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_incidencias_laboratorios_IdLaboratorio",
                        column: x => x.IdLaboratorio,
                        principalTable: "laboratorios",
                        principalColumn: "IdLaboratorio",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_incidencias_usuarios_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "usuarios",
                        principalColumn: "IdUsuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "asignacionRecursos",
                columns: table => new
                {
                    IdAsignacion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cantidadUtilizada = table.Column<double>(type: "float", nullable: false),
                    IdIncidencias = table.Column<int>(type: "int", nullable: false),
                    IdRecursos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asignacionRecursos", x => x.IdAsignacion);
                    table.ForeignKey(
                        name: "FK_asignacionRecursos_incidencias_IdIncidencias",
                        column: x => x.IdIncidencias,
                        principalTable: "incidencias",
                        principalColumn: "IdIncidencias",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_asignacionRecursos_recursos_IdRecursos",
                        column: x => x.IdRecursos,
                        principalTable: "recursos",
                        principalColumn: "IdRecursos",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "historialIncidencias",
                columns: table => new
                {
                    IdHistorial = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaHistorial = table.Column<DateOnly>(type: "date", nullable: false),
                    Accion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comentarios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioResponsable = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdIncidencias = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historialIncidencias", x => x.IdHistorial);
                    table.ForeignKey(
                        name: "FK_historialIncidencias_incidencias_IdIncidencias",
                        column: x => x.IdIncidencias,
                        principalTable: "incidencias",
                        principalColumn: "IdIncidencias",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "laboratorios",
                columns: new[] { "IdLaboratorio", "capacidad", "horario", "nombreLab", "ubicacion" },
                values: new object[,]
                {
                    { 1, 50, new TimeOnly(8, 0, 0), "Laboratorio A", "Edificio 1" },
                    { 2, 40, new TimeOnly(9, 0, 0), "Laboratorio B", "Edificio 2" }
                });

            migrationBuilder.InsertData(
                table: "recursos",
                columns: new[] { "IdRecursos", "cantidad", "desRec", "nombreRec" },
                values: new object[,]
                {
                    { 1, 5.0, "Proyector multimedia", "Proyector" },
                    { 2, 20.0, "Computadoras de escritorio", "PC" }
                });

            migrationBuilder.InsertData(
                table: "usuarios",
                columns: new[] { "IdUsuario", "correoUsuario", "nombreUsuario", "rolUsuario", "tipoUsuario" },
                values: new object[,]
                {
                    { 1, "juan.perez@upla.edu", "Juan Perez", 10f, 1f },
                    { 2, "maria.lopez@upla.edu", "Maria Lopez", 20f, 2f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_asignacionRecursos_IdIncidencias",
                table: "asignacionRecursos",
                column: "IdIncidencias");

            migrationBuilder.CreateIndex(
                name: "IX_asignacionRecursos_IdRecursos",
                table: "asignacionRecursos",
                column: "IdRecursos");

            migrationBuilder.CreateIndex(
                name: "IX_equipos_LaboratoriosIdLaboratorio",
                table: "equipos",
                column: "LaboratoriosIdLaboratorio");

            migrationBuilder.CreateIndex(
                name: "IX_historialIncidencias_IdIncidencias",
                table: "historialIncidencias",
                column: "IdIncidencias");

            migrationBuilder.CreateIndex(
                name: "IX_incidencias_IdEquipos",
                table: "incidencias",
                column: "IdEquipos");

            migrationBuilder.CreateIndex(
                name: "IX_incidencias_IdLaboratorio",
                table: "incidencias",
                column: "IdLaboratorio");

            migrationBuilder.CreateIndex(
                name: "IX_incidencias_IdUsuario",
                table: "incidencias",
                column: "IdUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "asignacionRecursos");

            migrationBuilder.DropTable(
                name: "historialIncidencias");

            migrationBuilder.DropTable(
                name: "recursos");

            migrationBuilder.DropTable(
                name: "incidencias");

            migrationBuilder.DropTable(
                name: "equipos");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "laboratorios");
        }
    }
}
