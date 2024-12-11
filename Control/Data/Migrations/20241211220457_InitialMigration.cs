using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Control.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_asignacionRecursos_incidencias_IdIncidencias",
                table: "asignacionRecursos");

            migrationBuilder.DropForeignKey(
                name: "FK_asignacionRecursos_recursos_IdRecursos",
                table: "asignacionRecursos");

            migrationBuilder.DropForeignKey(
                name: "FK_equipos_laboratorios_LaboratoriosIdLaboratorio",
                table: "equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_historialIncidencias_incidencias_IdIncidencias",
                table: "historialIncidencias");

            migrationBuilder.DropForeignKey(
                name: "FK_incidencias_equipos_IdEquipos",
                table: "incidencias");

            migrationBuilder.DropForeignKey(
                name: "FK_incidencias_laboratorios_IdLaboratorio",
                table: "incidencias");

            migrationBuilder.DropForeignKey(
                name: "FK_incidencias_usuarios_IdUsuario",
                table: "incidencias");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_equipos_LaboratoriosIdLaboratorio",
                table: "equipos");

            migrationBuilder.DeleteData(
                table: "laboratorios",
                keyColumn: "IdLaboratorio",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "laboratorios",
                keyColumn: "IdLaboratorio",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "recursos",
                keyColumn: "IdRecursos",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "recursos",
                keyColumn: "IdRecursos",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "usuarios",
                keyColumn: "IdUsuario",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "usuarios",
                keyColumn: "IdUsuario",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "cantidad",
                table: "recursos");

            migrationBuilder.DropColumn(
                name: "horario",
                table: "laboratorios");

            migrationBuilder.DropColumn(
                name: "FechaReportado",
                table: "incidencias");

            migrationBuilder.DropColumn(
                name: "FechaHistorial",
                table: "historialIncidencias");

            migrationBuilder.DropColumn(
                name: "LaboratoriosIdLaboratorio",
                table: "equipos");

            migrationBuilder.DropColumn(
                name: "estado",
                table: "equipos");

            migrationBuilder.RenameColumn(
                name: "tipoUsuario",
                table: "usuarios",
                newName: "TipoUsuario");

            migrationBuilder.RenameColumn(
                name: "rolUsuario",
                table: "usuarios",
                newName: "RolUsuario");

            migrationBuilder.RenameColumn(
                name: "nombreUsuario",
                table: "usuarios",
                newName: "NombreUsuario");

            migrationBuilder.RenameColumn(
                name: "correoUsuario",
                table: "usuarios",
                newName: "CorreoUsuario");

            migrationBuilder.RenameColumn(
                name: "nombreRec",
                table: "recursos",
                newName: "NombreRec");

            migrationBuilder.RenameColumn(
                name: "desRec",
                table: "recursos",
                newName: "DesRec");

            migrationBuilder.RenameColumn(
                name: "ubicacion",
                table: "laboratorios",
                newName: "Ubicacion");

            migrationBuilder.RenameColumn(
                name: "nombreLab",
                table: "laboratorios",
                newName: "NombreLab");

            migrationBuilder.RenameColumn(
                name: "capacidad",
                table: "laboratorios",
                newName: "Capacidad");

            migrationBuilder.RenameColumn(
                name: "descInc",
                table: "incidencias",
                newName: "DescInc");

            migrationBuilder.RenameColumn(
                name: "FechaResolucion",
                table: "incidencias",
                newName: "FechaReporte");

            migrationBuilder.RenameColumn(
                name: "nombreEquipos",
                table: "equipos",
                newName: "NombreEquipos");

            migrationBuilder.RenameColumn(
                name: "modelo",
                table: "equipos",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "fecha_inst",
                table: "equipos",
                newName: "FechaInst");

            migrationBuilder.RenameColumn(
                name: "cantidadUtilizada",
                table: "asignacionRecursos",
                newName: "CantidadUtilizada");

            migrationBuilder.AlterColumn<string>(
                name: "TipoUsuario",
                table: "usuarios",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "RolUsuario",
                table: "usuarios",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "NombreUsuario",
                table: "usuarios",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CorreoUsuario",
                table: "usuarios",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NombreRec",
                table: "recursos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DesRec",
                table: "recursos",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Ubicacion",
                table: "laboratorios",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombreLab",
                table: "laboratorios",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DescInc",
                table: "incidencias",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaSolucion",
                table: "incidencias",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioResponsable",
                table: "historialIncidencias",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Comentarios",
                table: "historialIncidencias",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Accion",
                table: "historialIncidencias",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NombreEquipos",
                table: "equipos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Modelo",
                table: "equipos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CantidadUtilizada",
                table: "asignacionRecursos",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.CreateIndex(
                name: "IX_equipos_IdLaboratorio",
                table: "equipos",
                column: "IdLaboratorio");

            migrationBuilder.AddForeignKey(
                name: "FK_asignacionRecursos_incidencias_IdIncidencias",
                table: "asignacionRecursos",
                column: "IdIncidencias",
                principalTable: "incidencias",
                principalColumn: "IdIncidencias",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_asignacionRecursos_recursos_IdRecursos",
                table: "asignacionRecursos",
                column: "IdRecursos",
                principalTable: "recursos",
                principalColumn: "IdRecursos",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_equipos_laboratorios_IdLaboratorio",
                table: "equipos",
                column: "IdLaboratorio",
                principalTable: "laboratorios",
                principalColumn: "IdLaboratorio",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_historialIncidencias_incidencias_IdIncidencias",
                table: "historialIncidencias",
                column: "IdIncidencias",
                principalTable: "incidencias",
                principalColumn: "IdIncidencias",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_incidencias_equipos_IdEquipos",
                table: "incidencias",
                column: "IdEquipos",
                principalTable: "equipos",
                principalColumn: "IdEquipos",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_incidencias_laboratorios_IdLaboratorio",
                table: "incidencias",
                column: "IdLaboratorio",
                principalTable: "laboratorios",
                principalColumn: "IdLaboratorio",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_incidencias_usuarios_IdUsuario",
                table: "incidencias",
                column: "IdUsuario",
                principalTable: "usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_asignacionRecursos_incidencias_IdIncidencias",
                table: "asignacionRecursos");

            migrationBuilder.DropForeignKey(
                name: "FK_asignacionRecursos_recursos_IdRecursos",
                table: "asignacionRecursos");

            migrationBuilder.DropForeignKey(
                name: "FK_equipos_laboratorios_IdLaboratorio",
                table: "equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_historialIncidencias_incidencias_IdIncidencias",
                table: "historialIncidencias");

            migrationBuilder.DropForeignKey(
                name: "FK_incidencias_equipos_IdEquipos",
                table: "incidencias");

            migrationBuilder.DropForeignKey(
                name: "FK_incidencias_laboratorios_IdLaboratorio",
                table: "incidencias");

            migrationBuilder.DropForeignKey(
                name: "FK_incidencias_usuarios_IdUsuario",
                table: "incidencias");

            migrationBuilder.DropIndex(
                name: "IX_equipos_IdLaboratorio",
                table: "equipos");

            migrationBuilder.DropColumn(
                name: "FechaSolucion",
                table: "incidencias");

            migrationBuilder.RenameColumn(
                name: "TipoUsuario",
                table: "usuarios",
                newName: "tipoUsuario");

            migrationBuilder.RenameColumn(
                name: "RolUsuario",
                table: "usuarios",
                newName: "rolUsuario");

            migrationBuilder.RenameColumn(
                name: "NombreUsuario",
                table: "usuarios",
                newName: "nombreUsuario");

            migrationBuilder.RenameColumn(
                name: "CorreoUsuario",
                table: "usuarios",
                newName: "correoUsuario");

            migrationBuilder.RenameColumn(
                name: "NombreRec",
                table: "recursos",
                newName: "nombreRec");

            migrationBuilder.RenameColumn(
                name: "DesRec",
                table: "recursos",
                newName: "desRec");

            migrationBuilder.RenameColumn(
                name: "Ubicacion",
                table: "laboratorios",
                newName: "ubicacion");

            migrationBuilder.RenameColumn(
                name: "NombreLab",
                table: "laboratorios",
                newName: "nombreLab");

            migrationBuilder.RenameColumn(
                name: "Capacidad",
                table: "laboratorios",
                newName: "capacidad");

            migrationBuilder.RenameColumn(
                name: "DescInc",
                table: "incidencias",
                newName: "descInc");

            migrationBuilder.RenameColumn(
                name: "FechaReporte",
                table: "incidencias",
                newName: "FechaResolucion");

            migrationBuilder.RenameColumn(
                name: "NombreEquipos",
                table: "equipos",
                newName: "nombreEquipos");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "equipos",
                newName: "modelo");

            migrationBuilder.RenameColumn(
                name: "FechaInst",
                table: "equipos",
                newName: "fecha_inst");

            migrationBuilder.RenameColumn(
                name: "CantidadUtilizada",
                table: "asignacionRecursos",
                newName: "cantidadUtilizada");

            migrationBuilder.AlterColumn<float>(
                name: "tipoUsuario",
                table: "usuarios",
                type: "real",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<float>(
                name: "rolUsuario",
                table: "usuarios",
                type: "real",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "nombreUsuario",
                table: "usuarios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "correoUsuario",
                table: "usuarios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "nombreRec",
                table: "recursos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "desRec",
                table: "recursos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<double>(
                name: "cantidad",
                table: "recursos",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<string>(
                name: "ubicacion",
                table: "laboratorios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "nombreLab",
                table: "laboratorios",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<TimeOnly>(
                name: "horario",
                table: "laboratorios",
                type: "time",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));

            migrationBuilder.AlterColumn<string>(
                name: "descInc",
                table: "incidencias",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaReportado",
                table: "incidencias",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "UsuarioResponsable",
                table: "historialIncidencias",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Comentarios",
                table: "historialIncidencias",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Accion",
                table: "historialIncidencias",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<DateOnly>(
                name: "FechaHistorial",
                table: "historialIncidencias",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AlterColumn<string>(
                name: "nombreEquipos",
                table: "equipos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "modelo",
                table: "equipos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "LaboratoriosIdLaboratorio",
                table: "equipos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "estado",
                table: "equipos",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AlterColumn<double>(
                name: "cantidadUtilizada",
                table: "asignacionRecursos",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
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
                name: "IX_equipos_LaboratoriosIdLaboratorio",
                table: "equipos",
                column: "LaboratoriosIdLaboratorio");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_asignacionRecursos_incidencias_IdIncidencias",
                table: "asignacionRecursos",
                column: "IdIncidencias",
                principalTable: "incidencias",
                principalColumn: "IdIncidencias",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_asignacionRecursos_recursos_IdRecursos",
                table: "asignacionRecursos",
                column: "IdRecursos",
                principalTable: "recursos",
                principalColumn: "IdRecursos",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_equipos_laboratorios_LaboratoriosIdLaboratorio",
                table: "equipos",
                column: "LaboratoriosIdLaboratorio",
                principalTable: "laboratorios",
                principalColumn: "IdLaboratorio",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_historialIncidencias_incidencias_IdIncidencias",
                table: "historialIncidencias",
                column: "IdIncidencias",
                principalTable: "incidencias",
                principalColumn: "IdIncidencias",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_incidencias_equipos_IdEquipos",
                table: "incidencias",
                column: "IdEquipos",
                principalTable: "equipos",
                principalColumn: "IdEquipos",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_incidencias_laboratorios_IdLaboratorio",
                table: "incidencias",
                column: "IdLaboratorio",
                principalTable: "laboratorios",
                principalColumn: "IdLaboratorio",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_incidencias_usuarios_IdUsuario",
                table: "incidencias",
                column: "IdUsuario",
                principalTable: "usuarios",
                principalColumn: "IdUsuario",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
