﻿// <auto-generated />
using API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Models.Alumno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Domicilio");

                    b.Property<int>("Estado");

                    b.Property<string>("FechaNacimiento");

                    b.Property<DateTime>("FechaNovedad");

                    b.Property<string>("Mail");

                    b.Property<string>("Nombre");

                    b.Property<string>("NroDocumento");

                    b.Property<string>("Telefono");

                    b.Property<string>("UsuarioNovedad")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Alumnos");
                });

            modelBuilder.Entity("API.Models.Asignatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo");

                    b.Property<string>("Descripcion");

                    b.Property<int>("Estado");

                    b.Property<DateTime>("FechaNovedad");

                    b.Property<string>("UsuarioNovedad")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Asignaturas");
                });

            modelBuilder.Entity("API.Models.Autorizacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AlumnoId");

                    b.Property<bool>("Autorizado");

                    b.Property<string>("Descripcion");

                    b.Property<int>("Estado");

                    b.Property<string>("Fecha");

                    b.Property<string>("FechaHora");

                    b.Property<DateTime>("FechaNovedad");

                    b.Property<int?>("ProfesionalId");

                    b.Property<int?>("TutorId");

                    b.Property<string>("UsuarioNovedad")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("AlumnoId");

                    b.HasIndex("ProfesionalId");

                    b.HasIndex("TutorId");

                    b.ToTable("Autorizaciones");
                });

            modelBuilder.Entity("API.Models.AutorizacionRetiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AlumnoId");

                    b.Property<string>("Apellido");

                    b.Property<int>("Estado");

                    b.Property<DateTime>("FechaNovedad");

                    b.Property<string>("Nombre");

                    b.Property<string>("NroDocumento");

                    b.Property<string>("Parentesco");

                    b.Property<string>("TipoDocumento");

                    b.Property<int?>("TutorId");

                    b.Property<string>("UsuarioNovedad")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("AlumnoId");

                    b.HasIndex("TutorId");

                    b.ToTable("AutorizacionesRetiro");
                });

            modelBuilder.Entity("API.Models.ConfiguracionHoraria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DiaSemana");

                    b.Property<int>("Estado");

                    b.Property<string>("FechaDesde");

                    b.Property<string>("FechaHasta");

                    b.Property<DateTime>("FechaNovedad");

                    b.Property<string>("HoraDesde");

                    b.Property<string>("HoraHasta");

                    b.Property<int>("ProfesionalId");

                    b.Property<string>("UsuarioNovedad")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("ProfesionalId");

                    b.ToTable("ConfiguracionesHorarias");
                });

            modelBuilder.Entity("API.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AlumnoId");

                    b.Property<string>("Codigo");

                    b.Property<string>("Descripcion");

                    b.Property<int>("Estado");

                    b.Property<DateTime>("FechaNovedad");

                    b.Property<string>("UsuarioNovedad")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("AlumnoId");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("API.Models.CursoAsignatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AsignaturaId");

                    b.Property<int>("CursoId");

                    b.Property<int>("Estado");

                    b.Property<DateTime>("FechaNovedad");

                    b.Property<string>("UsuarioNovedad")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("AsignaturaId");

                    b.HasIndex("CursoId");

                    b.ToTable("CursoAsignaturas");
                });

            modelBuilder.Entity("API.Models.ErrorDetails", b =>
                {
                    b.Property<int>("StatusCode")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Message");

                    b.HasKey("StatusCode");

                    b.ToTable("ErrorDetails");
                });

            modelBuilder.Entity("API.Models.Notificacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Estado");

                    b.Property<string>("FechaHoraLeido");

                    b.Property<DateTime>("FechaNovedad");

                    b.Property<bool>("MarcaLeido");

                    b.Property<string>("Mensaje");

                    b.Property<int>("UsuarioEmisorId");

                    b.Property<string>("UsuarioNovedad")
                        .HasMaxLength(256);

                    b.Property<int>("UsuarioReceptorId");

                    b.HasKey("Id");

                    b.ToTable("Notificaciones");
                });

            modelBuilder.Entity("API.Models.Profesional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<string>("Domicilio");

                    b.Property<int>("Estado");

                    b.Property<string>("FechaNacimiento");

                    b.Property<DateTime>("FechaNovedad");

                    b.Property<string>("HorarioFin");

                    b.Property<string>("HorarioInicio");

                    b.Property<string>("Mail");

                    b.Property<string>("Nombre");

                    b.Property<string>("Telefono");

                    b.Property<int>("TipoProfesionalId");

                    b.Property<string>("UsuarioNovedad")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("TipoProfesionalId");

                    b.ToTable("Profesionales");
                });

            modelBuilder.Entity("API.Models.ProfesionalCurso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CursoId");

                    b.Property<int>("Estado");

                    b.Property<DateTime>("FechaNovedad");

                    b.Property<int>("ProfesionalId");

                    b.Property<string>("UsuarioNovedad")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.HasIndex("ProfesionalId");

                    b.ToTable("ProfesionalCursos");
                });

            modelBuilder.Entity("API.Models.TipoProfesional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo");

                    b.Property<string>("Descripcion");

                    b.Property<int>("Estado");

                    b.Property<DateTime>("FechaNovedad");

                    b.Property<string>("UsuarioNovedad")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("TipoProfesionales");
                });

            modelBuilder.Entity("API.Models.TipoUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo");

                    b.Property<string>("Descripcion");

                    b.Property<int>("Estado");

                    b.Property<DateTime>("FechaNovedad");

                    b.Property<string>("UsuarioNovedad")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("TipoUsuarios");
                });

            modelBuilder.Entity("API.Models.Tutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AlumnoId");

                    b.Property<string>("Apellido");

                    b.Property<string>("Domicilio");

                    b.Property<int>("Estado");

                    b.Property<string>("FechaNacimiento");

                    b.Property<DateTime>("FechaNovedad");

                    b.Property<string>("Mail");

                    b.Property<string>("Nombre");

                    b.Property<string>("NroDocumento");

                    b.Property<string>("Telefono");

                    b.Property<string>("UsuarioNovedad")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("AlumnoId");

                    b.ToTable("Tutores");
                });

            modelBuilder.Entity("API.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Apellido");

                    b.Property<int>("Estado");

                    b.Property<DateTime>("FechaNovedad");

                    b.Property<string>("Nombre");

                    b.Property<string>("Password");

                    b.Property<int>("TipoUsuarioId");

                    b.Property<string>("UserName");

                    b.Property<string>("UsuarioNovedad")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("TipoUsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("API.Models.Autorizacion", b =>
                {
                    b.HasOne("API.Models.Alumno", "Alumno")
                        .WithMany()
                        .HasForeignKey("AlumnoId");

                    b.HasOne("API.Models.Profesional", "Profesional")
                        .WithMany()
                        .HasForeignKey("ProfesionalId");

                    b.HasOne("API.Models.Tutor", "Tutor")
                        .WithMany()
                        .HasForeignKey("TutorId");
                });

            modelBuilder.Entity("API.Models.AutorizacionRetiro", b =>
                {
                    b.HasOne("API.Models.Alumno", "Alumno")
                        .WithMany()
                        .HasForeignKey("AlumnoId");

                    b.HasOne("API.Models.Tutor", "Tutor")
                        .WithMany()
                        .HasForeignKey("TutorId");
                });

            modelBuilder.Entity("API.Models.ConfiguracionHoraria", b =>
                {
                    b.HasOne("API.Models.Profesional", "Profesional")
                        .WithMany()
                        .HasForeignKey("ProfesionalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("API.Models.Curso", b =>
                {
                    b.HasOne("API.Models.Alumno", "Alumno")
                        .WithMany()
                        .HasForeignKey("AlumnoId");
                });

            modelBuilder.Entity("API.Models.CursoAsignatura", b =>
                {
                    b.HasOne("API.Models.Asignatura", "Asignatura")
                        .WithMany()
                        .HasForeignKey("AsignaturaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("API.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("API.Models.Profesional", b =>
                {
                    b.HasOne("API.Models.TipoProfesional", "TipoProfesional")
                        .WithMany()
                        .HasForeignKey("TipoProfesionalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("API.Models.ProfesionalCurso", b =>
                {
                    b.HasOne("API.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("API.Models.Profesional", "Profesional")
                        .WithMany()
                        .HasForeignKey("ProfesionalId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("API.Models.Tutor", b =>
                {
                    b.HasOne("API.Models.Alumno", "Alumno")
                        .WithMany()
                        .HasForeignKey("AlumnoId");
                });

            modelBuilder.Entity("API.Models.Usuario", b =>
                {
                    b.HasOne("API.Models.TipoUsuario", "TipoUsuario")
                        .WithMany()
                        .HasForeignKey("TipoUsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
