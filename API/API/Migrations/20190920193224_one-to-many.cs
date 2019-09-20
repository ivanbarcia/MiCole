using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace API.Migrations
{
    public partial class onetomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Autorizaciones_Alumnos_AlumnoId",
                table: "Autorizaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_AutorizacionesRetiro_Alumnos_AlumnoId",
                table: "AutorizacionesRetiro");

            migrationBuilder.DropTable(
                name: "AlumnoCursos");

            migrationBuilder.DropTable(
                name: "RolFunciones");

            migrationBuilder.DropTable(
                name: "TutorAlumnos");

            migrationBuilder.DropTable(
                name: "Funciones");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_AutorizacionesRetiro_AlumnoId",
                table: "AutorizacionesRetiro");

            migrationBuilder.DropIndex(
                name: "IX_Autorizaciones_AlumnoId",
                table: "Autorizaciones");

            migrationBuilder.DropColumn(
                name: "AlumnoId",
                table: "AutorizacionesRetiro");

            migrationBuilder.DropColumn(
                name: "AlumnoId",
                table: "Autorizaciones");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "AutorizacionesRetiro",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AlumnoId",
                table: "Autorizaciones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AlumnoCursos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlumnoId = table.Column<int>(nullable: false),
                    CursoId = table.Column<int>(nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    FechaNovedad = table.Column<DateTime>(nullable: false),
                    UsuarioNovedad = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlumnoCursos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlumnoCursos_Alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlumnoCursos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Funciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Estado = table.Column<int>(nullable: false),
                    FechaNovedad = table.Column<DateTime>(nullable: false),
                    UsuarioNovedad = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Codigo = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Estado = table.Column<int>(nullable: false),
                    FechaNovedad = table.Column<DateTime>(nullable: false),
                    UsuarioNovedad = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TutorAlumnos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlumnoId = table.Column<int>(nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    FechaNovedad = table.Column<DateTime>(nullable: false),
                    TutorId = table.Column<int>(nullable: false),
                    UsuarioNovedad = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TutorAlumnos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TutorAlumnos_Alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TutorAlumnos_Tutores_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolFunciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Estado = table.Column<int>(nullable: false),
                    FechaNovedad = table.Column<DateTime>(nullable: false),
                    FuncionId = table.Column<int>(nullable: false),
                    RolId = table.Column<int>(nullable: false),
                    UsuarioNovedad = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolFunciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RolFunciones_Funciones_FuncionId",
                        column: x => x.FuncionId,
                        principalTable: "Funciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolFunciones_Roles_RolId",
                        column: x => x.RolId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacionesRetiro_AlumnoId",
                table: "AutorizacionesRetiro",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_Autorizaciones_AlumnoId",
                table: "Autorizaciones",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlumnoCursos_AlumnoId",
                table: "AlumnoCursos",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlumnoCursos_CursoId",
                table: "AlumnoCursos",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_RolFunciones_FuncionId",
                table: "RolFunciones",
                column: "FuncionId");

            migrationBuilder.CreateIndex(
                name: "IX_RolFunciones_RolId",
                table: "RolFunciones",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_TutorAlumnos_AlumnoId",
                table: "TutorAlumnos",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_TutorAlumnos_TutorId",
                table: "TutorAlumnos",
                column: "TutorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Autorizaciones_Alumnos_AlumnoId",
                table: "Autorizaciones",
                column: "AlumnoId",
                principalTable: "Alumnos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutorizacionesRetiro_Alumnos_AlumnoId",
                table: "AutorizacionesRetiro",
                column: "AlumnoId",
                principalTable: "Alumnos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
