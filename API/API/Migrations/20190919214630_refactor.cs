using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace API.Migrations
{
    public partial class refactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Notificaciones");

            migrationBuilder.DropColumn(
                name: "FechaHora",
                table: "Notificaciones");

            migrationBuilder.AddColumn<string>(
                name: "NroDocumento",
                table: "Alumnos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NroDocumento",
                table: "Alumnos");

            migrationBuilder.AddColumn<string>(
                name: "Fecha",
                table: "Notificaciones",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FechaHora",
                table: "Notificaciones",
                nullable: true);
        }
    }
}
