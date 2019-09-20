using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace API.Migrations
{
    public partial class onetomany2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Alumnos_Autorizaciones_AutorizacionId",
                table: "Alumnos");

            migrationBuilder.DropForeignKey(
                name: "FK_Alumnos_AutorizacionesRetiro_AutorizacionRetiroId",
                table: "Alumnos");

            migrationBuilder.DropForeignKey(
                name: "FK_Alumnos_Cursos_CursoId",
                table: "Alumnos");

            migrationBuilder.DropForeignKey(
                name: "FK_Alumnos_Tutores_TutorId",
                table: "Alumnos");

            migrationBuilder.DropForeignKey(
                name: "FK_Autorizaciones_Profesionales_ProfesionalId",
                table: "Autorizaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Autorizaciones_Tutores_TutorId",
                table: "Autorizaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_AutorizacionesRetiro_Tutores_TutorId",
                table: "AutorizacionesRetiro");

            migrationBuilder.DropIndex(
                name: "IX_Alumnos_AutorizacionId",
                table: "Alumnos");

            migrationBuilder.DropIndex(
                name: "IX_Alumnos_AutorizacionRetiroId",
                table: "Alumnos");

            migrationBuilder.DropIndex(
                name: "IX_Alumnos_CursoId",
                table: "Alumnos");

            migrationBuilder.DropIndex(
                name: "IX_Alumnos_TutorId",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "AutorizacionId",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "AutorizacionRetiroId",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "TutorId",
                table: "Alumnos");

            migrationBuilder.AddColumn<int>(
                name: "AlumnoId",
                table: "Tutores",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlumnoId",
                table: "Cursos",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TutorId",
                table: "AutorizacionesRetiro",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "AlumnoId",
                table: "AutorizacionesRetiro",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TutorId",
                table: "Autorizaciones",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProfesionalId",
                table: "Autorizaciones",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "AlumnoId",
                table: "Autorizaciones",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tutores_AlumnoId",
                table: "Tutores",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cursos_AlumnoId",
                table: "Cursos",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacionesRetiro_AlumnoId",
                table: "AutorizacionesRetiro",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Autorizaciones_AlumnoId",
                table: "Autorizaciones",
                column: "AlumnoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Autorizaciones_Alumnos_AlumnoId",
                table: "Autorizaciones",
                column: "AlumnoId",
                principalTable: "Alumnos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Autorizaciones_Profesionales_ProfesionalId",
                table: "Autorizaciones",
                column: "ProfesionalId",
                principalTable: "Profesionales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Autorizaciones_Tutores_TutorId",
                table: "Autorizaciones",
                column: "TutorId",
                principalTable: "Tutores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AutorizacionesRetiro_Alumnos_AlumnoId",
                table: "AutorizacionesRetiro",
                column: "AlumnoId",
                principalTable: "Alumnos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AutorizacionesRetiro_Tutores_TutorId",
                table: "AutorizacionesRetiro",
                column: "TutorId",
                principalTable: "Tutores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cursos_Alumnos_AlumnoId",
                table: "Cursos",
                column: "AlumnoId",
                principalTable: "Alumnos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tutores_Alumnos_AlumnoId",
                table: "Tutores",
                column: "AlumnoId",
                principalTable: "Alumnos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autorizaciones_Alumnos_AlumnoId",
                table: "Autorizaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Autorizaciones_Profesionales_ProfesionalId",
                table: "Autorizaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Autorizaciones_Tutores_TutorId",
                table: "Autorizaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_AutorizacionesRetiro_Alumnos_AlumnoId",
                table: "AutorizacionesRetiro");

            migrationBuilder.DropForeignKey(
                name: "FK_AutorizacionesRetiro_Tutores_TutorId",
                table: "AutorizacionesRetiro");

            migrationBuilder.DropForeignKey(
                name: "FK_Cursos_Alumnos_AlumnoId",
                table: "Cursos");

            migrationBuilder.DropForeignKey(
                name: "FK_Tutores_Alumnos_AlumnoId",
                table: "Tutores");

            migrationBuilder.DropIndex(
                name: "IX_Tutores_AlumnoId",
                table: "Tutores");

            migrationBuilder.DropIndex(
                name: "IX_Cursos_AlumnoId",
                table: "Cursos");

            migrationBuilder.DropIndex(
                name: "IX_AutorizacionesRetiro_AlumnoId",
                table: "AutorizacionesRetiro");

            migrationBuilder.DropIndex(
                name: "IX_Autorizaciones_AlumnoId",
                table: "Autorizaciones");

            migrationBuilder.DropColumn(
                name: "AlumnoId",
                table: "Tutores");

            migrationBuilder.DropColumn(
                name: "AlumnoId",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "AlumnoId",
                table: "AutorizacionesRetiro");

            migrationBuilder.DropColumn(
                name: "AlumnoId",
                table: "Autorizaciones");

            migrationBuilder.AlterColumn<int>(
                name: "TutorId",
                table: "AutorizacionesRetiro",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TutorId",
                table: "Autorizaciones",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProfesionalId",
                table: "Autorizaciones",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutorizacionId",
                table: "Alumnos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AutorizacionRetiroId",
                table: "Alumnos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CursoId",
                table: "Alumnos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TutorId",
                table: "Alumnos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_AutorizacionId",
                table: "Alumnos",
                column: "AutorizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_AutorizacionRetiroId",
                table: "Alumnos",
                column: "AutorizacionRetiroId");

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_CursoId",
                table: "Alumnos",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_TutorId",
                table: "Alumnos",
                column: "TutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnos_Autorizaciones_AutorizacionId",
                table: "Alumnos",
                column: "AutorizacionId",
                principalTable: "Autorizaciones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnos_AutorizacionesRetiro_AutorizacionRetiroId",
                table: "Alumnos",
                column: "AutorizacionRetiroId",
                principalTable: "AutorizacionesRetiro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnos_Cursos_CursoId",
                table: "Alumnos",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Alumnos_Tutores_TutorId",
                table: "Alumnos",
                column: "TutorId",
                principalTable: "Tutores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Autorizaciones_Profesionales_ProfesionalId",
                table: "Autorizaciones",
                column: "ProfesionalId",
                principalTable: "Profesionales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Autorizaciones_Tutores_TutorId",
                table: "Autorizaciones",
                column: "TutorId",
                principalTable: "Tutores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutorizacionesRetiro_Tutores_TutorId",
                table: "AutorizacionesRetiro",
                column: "TutorId",
                principalTable: "Tutores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
