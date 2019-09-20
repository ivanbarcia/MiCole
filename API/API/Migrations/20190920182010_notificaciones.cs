using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace API.Migrations
{
    public partial class notificaciones : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notificaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Estado = table.Column<int>(nullable: false),
                    FechaHoraLeido = table.Column<string>(nullable: true),
                    FechaNovedad = table.Column<DateTime>(nullable: false),
                    MarcaLeido = table.Column<bool>(nullable: false),
                    Mensaje = table.Column<string>(nullable: true),
                    UsuarioEmisorId = table.Column<int>(nullable: false),
                    UsuarioNovedad = table.Column<string>(maxLength: 256, nullable: true),
                    UsuarioReceptorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notificaciones", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Notificaciones_UsuarioEmisorId",
                table: "Notificaciones",
                column: "UsuarioEmisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Notificaciones_UsuarioReceptorId",
                table: "Notificaciones",
                column: "UsuarioReceptorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notificaciones_Usuarios_UsuarioEmisorId",
                table: "Notificaciones",
                column: "UsuarioEmisorId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Notificaciones_Usuarios_UsuarioReceptorId",
                table: "Notificaciones",
                column: "UsuarioReceptorId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
