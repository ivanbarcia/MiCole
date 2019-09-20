using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace API.Migrations
{
    public partial class padres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autorizaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlumnoId = table.Column<int>(nullable: false),
                    Autorizado = table.Column<bool>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true),
                    Estado = table.Column<int>(nullable: false),
                    Fecha = table.Column<string>(nullable: true),
                    FechaHora = table.Column<string>(nullable: true),
                    FechaHoraEstado = table.Column<string>(nullable: true),
                    FechaNovedad = table.Column<DateTime>(nullable: false),
                    ProfesionalId = table.Column<int>(nullable: false),
                    TutorId = table.Column<int>(nullable: false),
                    UsuarioNovedad = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autorizaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Autorizaciones_Alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Autorizaciones_Profesionales_ProfesionalId",
                        column: x => x.ProfesionalId,
                        principalTable: "Profesionales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Autorizaciones_Tutores_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Autorizados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlumnoId = table.Column<int>(nullable: false),
                    Apellido = table.Column<string>(nullable: true),
                    Domicilio = table.Column<string>(nullable: true),
                    Estado = table.Column<int>(nullable: false),
                    FechaNacimiento = table.Column<string>(nullable: true),
                    FechaNovedad = table.Column<DateTime>(nullable: false),
                    Mail = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    UsuarioNovedad = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autorizados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Autorizados_Alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Padres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlumnoId = table.Column<int>(nullable: false),
                    Apellido1 = table.Column<string>(nullable: false),
                    Apellido2 = table.Column<string>(nullable: false),
                    Documento1 = table.Column<string>(nullable: false),
                    Documento2 = table.Column<string>(nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    FechaNovedad = table.Column<DateTime>(nullable: false),
                    Nombre1 = table.Column<string>(nullable: false),
                    Nombre2 = table.Column<string>(nullable: false),
                    Telefono1 = table.Column<string>(nullable: false),
                    Telefono2 = table.Column<string>(nullable: false),
                    UsuarioNovedad = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Padres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Padres_Alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Autorizaciones_AlumnoId",
                table: "Autorizaciones",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Autorizaciones_ProfesionalId",
                table: "Autorizaciones",
                column: "ProfesionalId");

            migrationBuilder.CreateIndex(
                name: "IX_Autorizaciones_TutorId",
                table: "Autorizaciones",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Autorizados_AlumnoId",
                table: "Autorizados",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Padres_AlumnoId",
                table: "Padres",
                column: "AlumnoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Autorizaciones");

            migrationBuilder.DropTable(
                name: "Autorizados");

            migrationBuilder.DropTable(
                name: "Padres");
        }
    }
}
