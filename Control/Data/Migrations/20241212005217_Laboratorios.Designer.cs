﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Control.Migrations
{
    [DbContext(typeof(AplicacionDbContext))]
    [Migration("20241212005217_Laboratorios")]
    partial class Laboratorios
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Control.Data.Entidades.AsignacionRecursos", b =>
                {
                    b.Property<int>("IdAsignacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAsignacion"));

                    b.Property<int>("CantidadUtilizada")
                        .HasColumnType("int");

                    b.HasKey("IdAsignacion");

                    b.ToTable("asignacionRecursos");

                    b.HasData(
                        new
                        {
                            IdAsignacion = 123512,
                            CantidadUtilizada = 34522
                        });
                });

            modelBuilder.Entity("Control.Data.Entidades.Equipos", b =>
                {
                    b.Property<int>("IdEquipos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEquipos"));

                    b.Property<DateTime>("FechaInst")
                        .HasColumnType("datetime2");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NombreEquipos")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdEquipos");

                    b.ToTable("equipos");

                    b.HasData(
                        new
                        {
                            IdEquipos = 34112,
                            FechaInst = new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Modelo = "Lenovo",
                            NombreEquipos = "LAB-01"
                        });
                });

            modelBuilder.Entity("Control.Data.Entidades.HistorialIncidencias", b =>
                {
                    b.Property<int>("IdHistorial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdHistorial"));

                    b.Property<string>("Accion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Comentarios")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("UsuarioRes")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdHistorial");

                    b.ToTable("historialIncidencias");

                    b.HasData(
                        new
                        {
                            IdHistorial = 123553,
                            Accion = "Reparada",
                            Comentarios = "Esta computadora fue raparada",
                            UsuarioRes = "Jorgito"
                        });
                });

            modelBuilder.Entity("Control.Data.Entidades.Incidencias", b =>
                {
                    b.Property<int>("IdIncidencias")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdIncidencias"));

                    b.Property<string>("DescInc")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("FechaReporte")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaSolucion")
                        .HasColumnType("datetime2");

                    b.HasKey("IdIncidencias");

                    b.ToTable("incidencias");

                    b.HasData(
                        new
                        {
                            IdIncidencias = 1251222,
                            DescInc = "Sucedio mientras alguien movia..",
                            FechaReporte = new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FechaSolucion = new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Control.Data.Entidades.Laboratorios", b =>
                {
                    b.Property<int>("IdLaboratorio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLaboratorio"));

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<string>("NombreLab")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("IdLaboratorio");

                    b.ToTable("laboratorios");

                    b.HasData(
                        new
                        {
                            IdLaboratorio = 34123,
                            Capacidad = 25,
                            NombreLab = "LAB-01",
                            Ubicacion = "Upla-Huancayo"
                        });
                });

            modelBuilder.Entity("Control.Data.Entidades.Recursos", b =>
                {
                    b.Property<int?>("IdRecursos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("IdRecursos"));

                    b.Property<string>("DesRec")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("NombreRec")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdRecursos");

                    b.ToTable("recursos");

                    b.HasData(
                        new
                        {
                            IdRecursos = 235121,
                            DesRec = "Se necesito el recurso",
                            NombreRec = "Recurso compartido"
                        });
                });

            modelBuilder.Entity("Control.Data.Entidades.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUsuario"));

                    b.Property<string>("CorreoUsuario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RolUsuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TipoUsuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdUsuario");

                    b.ToTable("usuarios");

                    b.HasData(
                        new
                        {
                            IdUsuario = 312122,
                            CorreoUsuario = "Jorgito@upla.edu.pe",
                            NombreUsuario = "Jorgito",
                            RolUsuario = "Docente",
                            TipoUsuario = "Principal"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
