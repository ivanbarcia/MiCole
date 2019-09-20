using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace API.Migrations
{
    public partial class AuditableEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "Usuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNovedad",
                table: "Usuarios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioNovedad",
                table: "Usuarios",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "Tutores",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNovedad",
                table: "Tutores",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioNovedad",
                table: "Tutores",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "TutorAlumnos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNovedad",
                table: "TutorAlumnos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioNovedad",
                table: "TutorAlumnos",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "TipoUsuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNovedad",
                table: "TipoUsuarios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioNovedad",
                table: "TipoUsuarios",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "TipoProfesionales",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNovedad",
                table: "TipoProfesionales",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioNovedad",
                table: "TipoProfesionales",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "RolFunciones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNovedad",
                table: "RolFunciones",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioNovedad",
                table: "RolFunciones",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "Roles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNovedad",
                table: "Roles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioNovedad",
                table: "Roles",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "Profesionales",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNovedad",
                table: "Profesionales",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioNovedad",
                table: "Profesionales",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "ProfesionalCursos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNovedad",
                table: "ProfesionalCursos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioNovedad",
                table: "ProfesionalCursos",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "Notificaciones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNovedad",
                table: "Notificaciones",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioNovedad",
                table: "Notificaciones",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "Funciones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNovedad",
                table: "Funciones",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioNovedad",
                table: "Funciones",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "Cursos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNovedad",
                table: "Cursos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioNovedad",
                table: "Cursos",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "CursoAsignaturas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNovedad",
                table: "CursoAsignaturas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioNovedad",
                table: "CursoAsignaturas",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "Asignaturas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNovedad",
                table: "Asignaturas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioNovedad",
                table: "Asignaturas",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "Alumnos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNovedad",
                table: "Alumnos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioNovedad",
                table: "Alumnos",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "AlumnoCursos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNovedad",
                table: "AlumnoCursos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UsuarioNovedad",
                table: "AlumnoCursos",
                maxLength: 256,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "FechaNovedad",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "UsuarioNovedad",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Tutores");

            migrationBuilder.DropColumn(
                name: "FechaNovedad",
                table: "Tutores");

            migrationBuilder.DropColumn(
                name: "UsuarioNovedad",
                table: "Tutores");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "TutorAlumnos");

            migrationBuilder.DropColumn(
                name: "FechaNovedad",
                table: "TutorAlumnos");

            migrationBuilder.DropColumn(
                name: "UsuarioNovedad",
                table: "TutorAlumnos");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "TipoUsuarios");

            migrationBuilder.DropColumn(
                name: "FechaNovedad",
                table: "TipoUsuarios");

            migrationBuilder.DropColumn(
                name: "UsuarioNovedad",
                table: "TipoUsuarios");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "TipoProfesionales");

            migrationBuilder.DropColumn(
                name: "FechaNovedad",
                table: "TipoProfesionales");

            migrationBuilder.DropColumn(
                name: "UsuarioNovedad",
                table: "TipoProfesionales");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "RolFunciones");

            migrationBuilder.DropColumn(
                name: "FechaNovedad",
                table: "RolFunciones");

            migrationBuilder.DropColumn(
                name: "UsuarioNovedad",
                table: "RolFunciones");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "FechaNovedad",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "UsuarioNovedad",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Profesionales");

            migrationBuilder.DropColumn(
                name: "FechaNovedad",
                table: "Profesionales");

            migrationBuilder.DropColumn(
                name: "UsuarioNovedad",
                table: "Profesionales");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "ProfesionalCursos");

            migrationBuilder.DropColumn(
                name: "FechaNovedad",
                table: "ProfesionalCursos");

            migrationBuilder.DropColumn(
                name: "UsuarioNovedad",
                table: "ProfesionalCursos");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Notificaciones");

            migrationBuilder.DropColumn(
                name: "FechaNovedad",
                table: "Notificaciones");

            migrationBuilder.DropColumn(
                name: "UsuarioNovedad",
                table: "Notificaciones");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Funciones");

            migrationBuilder.DropColumn(
                name: "FechaNovedad",
                table: "Funciones");

            migrationBuilder.DropColumn(
                name: "UsuarioNovedad",
                table: "Funciones");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "FechaNovedad",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "UsuarioNovedad",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "CursoAsignaturas");

            migrationBuilder.DropColumn(
                name: "FechaNovedad",
                table: "CursoAsignaturas");

            migrationBuilder.DropColumn(
                name: "UsuarioNovedad",
                table: "CursoAsignaturas");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Asignaturas");

            migrationBuilder.DropColumn(
                name: "FechaNovedad",
                table: "Asignaturas");

            migrationBuilder.DropColumn(
                name: "UsuarioNovedad",
                table: "Asignaturas");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "FechaNovedad",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "UsuarioNovedad",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "AlumnoCursos");

            migrationBuilder.DropColumn(
                name: "FechaNovedad",
                table: "AlumnoCursos");

            migrationBuilder.DropColumn(
                name: "UsuarioNovedad",
                table: "AlumnoCursos");
        }
    }
}
