using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace API.Migrations
{
    public partial class Autorizados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notificaciones_Profesionales_ProfesionalId",
                table: "Notificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Notificaciones_Tutores_TutorId",
                table: "Notificaciones");

            migrationBuilder.AddColumn<string>(
                name: "HorarioFin",
                table: "Profesionales",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HorarioInicio",
                table: "Profesionales",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TutorId",
                table: "Notificaciones",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProfesionalId",
                table: "Notificaciones",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "UsuarioEmisorId",
                table: "Notificaciones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioReceptorId",
                table: "Notificaciones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Notificaciones_Profesionales_ProfesionalId",
                table: "Notificaciones",
                column: "ProfesionalId",
                principalTable: "Profesionales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Notificaciones_Tutores_TutorId",
                table: "Notificaciones",
                column: "TutorId",
                principalTable: "Tutores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notificaciones_Profesionales_ProfesionalId",
                table: "Notificaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Notificaciones_Tutores_TutorId",
                table: "Notificaciones");

            migrationBuilder.DropColumn(
                name: "HorarioFin",
                table: "Profesionales");

            migrationBuilder.DropColumn(
                name: "HorarioInicio",
                table: "Profesionales");

            migrationBuilder.DropColumn(
                name: "UsuarioEmisorId",
                table: "Notificaciones");

            migrationBuilder.DropColumn(
                name: "UsuarioReceptorId",
                table: "Notificaciones");

            migrationBuilder.AlterColumn<int>(
                name: "TutorId",
                table: "Notificaciones",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProfesionalId",
                table: "Notificaciones",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Notificaciones_Profesionales_ProfesionalId",
                table: "Notificaciones",
                column: "ProfesionalId",
                principalTable: "Profesionales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notificaciones_Tutores_TutorId",
                table: "Notificaciones",
                column: "TutorId",
                principalTable: "Tutores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
