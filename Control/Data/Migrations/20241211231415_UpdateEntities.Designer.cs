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
    [Migration("20241211231415_UpdateEntities")]
    partial class UpdateEntities
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
                    b.Property<int?>("IdAsignacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("IdAsignacion"));

                    b.Property<int>("CantidadUtilizada")
                        .HasColumnType("int");

                    b.Property<int?>("IdIncidencias")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("IdRecursos")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("IncidenciasIdIncidencias")
                        .HasColumnType("int");

                    b.Property<int>("RecursosIdRecursos")
                        .HasColumnType("int");

                    b.HasKey("IdAsignacion");

                    b.HasIndex("IncidenciasIdIncidencias");

                    b.HasIndex("RecursosIdRecursos");

                    b.ToTable("asignacionRecursos");
                });

            modelBuilder.Entity("Control.Data.Entidades.Equipos", b =>
                {
                    b.Property<int?>("IdEquipos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("IdEquipos"));

                    b.Property<DateTime>("FechaInst")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdLaboratorio")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("LaboratorioIdLaboratorio")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NombreEquipos")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdEquipos");

                    b.HasIndex("LaboratorioIdLaboratorio");

                    b.ToTable("equipos");
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

                    b.Property<int?>("IdIncidencias")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("IncidenciasIdIncidencias")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioResponsable")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdHistorial");

                    b.HasIndex("IncidenciasIdIncidencias");

                    b.ToTable("historialIncidencias");
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

                    b.Property<int>("EquiposIdEquipos")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaReporte")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaSolucion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdEquipos")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("IdLaboratorio")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("IdUsuario")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("LaboratorioIdLaboratorio")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioIdUsuario")
                        .HasColumnType("int");

                    b.HasKey("IdIncidencias");

                    b.HasIndex("EquiposIdEquipos");

                    b.HasIndex("LaboratorioIdLaboratorio");

                    b.HasIndex("UsuarioIdUsuario");

                    b.ToTable("incidencias");
                });

            modelBuilder.Entity("Control.Data.Entidades.Laboratorios", b =>
                {
                    b.Property<int?>("IdLaboratorio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("IdLaboratorio"));

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
                            IdLaboratorio = 23532,
                            Capacidad = 34,
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
                });

            modelBuilder.Entity("Control.Data.Entidades.AsignacionRecursos", b =>
                {
                    b.HasOne("Control.Data.Entidades.Incidencias", "Incidencias")
                        .WithMany("AsignacionRecursos")
                        .HasForeignKey("IncidenciasIdIncidencias")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Control.Data.Entidades.Recursos", "Recursos")
                        .WithMany("AsignacionRecursos")
                        .HasForeignKey("RecursosIdRecursos")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Incidencias");

                    b.Navigation("Recursos");
                });

            modelBuilder.Entity("Control.Data.Entidades.Equipos", b =>
                {
                    b.HasOne("Control.Data.Entidades.Laboratorios", "Laboratorio")
                        .WithMany("Equipos")
                        .HasForeignKey("LaboratorioIdLaboratorio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Laboratorio");
                });

            modelBuilder.Entity("Control.Data.Entidades.HistorialIncidencias", b =>
                {
                    b.HasOne("Control.Data.Entidades.Incidencias", "Incidencias")
                        .WithMany("HistorialIncidencias")
                        .HasForeignKey("IncidenciasIdIncidencias")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Incidencias");
                });

            modelBuilder.Entity("Control.Data.Entidades.Incidencias", b =>
                {
                    b.HasOne("Control.Data.Entidades.Equipos", "Equipos")
                        .WithMany("Incidencias")
                        .HasForeignKey("EquiposIdEquipos")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Control.Data.Entidades.Laboratorios", "Laboratorio")
                        .WithMany("Incidencias")
                        .HasForeignKey("LaboratorioIdLaboratorio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Control.Data.Entidades.Usuario", "Usuario")
                        .WithMany("Incidencias")
                        .HasForeignKey("UsuarioIdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipos");

                    b.Navigation("Laboratorio");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Control.Data.Entidades.Equipos", b =>
                {
                    b.Navigation("Incidencias");
                });

            modelBuilder.Entity("Control.Data.Entidades.Incidencias", b =>
                {
                    b.Navigation("AsignacionRecursos");

                    b.Navigation("HistorialIncidencias");
                });

            modelBuilder.Entity("Control.Data.Entidades.Laboratorios", b =>
                {
                    b.Navigation("Equipos");

                    b.Navigation("Incidencias");
                });

            modelBuilder.Entity("Control.Data.Entidades.Recursos", b =>
                {
                    b.Navigation("AsignacionRecursos");
                });

            modelBuilder.Entity("Control.Data.Entidades.Usuario", b =>
                {
                    b.Navigation("Incidencias");
                });
#pragma warning restore 612, 618
        }
    }
}
