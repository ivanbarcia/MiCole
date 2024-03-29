﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace API.Migrations
{
    public partial class initial_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apellido = table.Column<string>(nullable: true),
                    Domicilio = table.Column<string>(nullable: true),
                    Estado = table.Column<int>(nullable: false),
                    FechaNacimiento = table.Column<string>(nullable: true),
                    FechaNovedad = table.Column<DateTime>(nullable: false),
                    Mail = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    NroDocumento = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    UsuarioNovedad = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Asignaturas",
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
                    table.PrimaryKey("PK_Asignaturas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cursos",
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
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ErrorDetails",
                columns: table => new
                {
                    StatusCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorDetails", x => x.StatusCode);
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
                name: "TipoProfesionales",
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
                    table.PrimaryKey("PK_TipoProfesionales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoUsuarios",
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
                    table.PrimaryKey("PK_TipoUsuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tutores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                    table.PrimaryKey("PK_Tutores", x => x.Id);
                });

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
                name: "CursoAsignaturas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AsignaturaId = table.Column<int>(nullable: false),
                    CursoId = table.Column<int>(nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    FechaNovedad = table.Column<DateTime>(nullable: false),
                    UsuarioNovedad = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CursoAsignaturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CursoAsignaturas_Asignaturas_AsignaturaId",
                        column: x => x.AsignaturaId,
                        principalTable: "Asignaturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CursoAsignaturas_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
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

            migrationBuilder.CreateTable(
                name: "Profesionales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apellido = table.Column<string>(nullable: true),
                    Domicilio = table.Column<string>(nullable: true),
                    Estado = table.Column<int>(nullable: false),
                    FechaNacimiento = table.Column<string>(nullable: true),
                    FechaNovedad = table.Column<DateTime>(nullable: false),
                    HorarioFin = table.Column<string>(nullable: true),
                    HorarioInicio = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    TipoProfesionalId = table.Column<int>(nullable: false),
                    UsuarioNovedad = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesionales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profesionales_TipoProfesionales_TipoProfesionalId",
                        column: x => x.TipoProfesionalId,
                        principalTable: "TipoProfesionales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Apellido = table.Column<string>(nullable: true),
                    Estado = table.Column<int>(nullable: false),
                    FechaNovedad = table.Column<DateTime>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    TipoUsuarioId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    UsuarioNovedad = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_TipoUsuarios_TipoUsuarioId",
                        column: x => x.TipoUsuarioId,
                        principalTable: "TipoUsuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AutorizacionesRetiro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AlumnoId = table.Column<int>(nullable: false),
                    Apellido = table.Column<string>(nullable: true),
                    Estado = table.Column<int>(nullable: false),
                    FechaNovedad = table.Column<DateTime>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    NroDocumento = table.Column<string>(nullable: true),
                    Parentesco = table.Column<string>(nullable: true),
                    TipoDocumento = table.Column<string>(nullable: true),
                    TutorId = table.Column<int>(nullable: false),
                    UsuarioNovedad = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorizacionesRetiro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AutorizacionesRetiro_Alumnos_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "Alumnos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutorizacionesRetiro_Tutores_TutorId",
                        column: x => x.TutorId,
                        principalTable: "Tutores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "ConfiguracionesHorarias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DiaSemana = table.Column<int>(nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    FechaDesde = table.Column<string>(nullable: true),
                    FechaHasta = table.Column<string>(nullable: true),
                    FechaNovedad = table.Column<DateTime>(nullable: false),
                    HoraDesde = table.Column<string>(nullable: true),
                    HoraHasta = table.Column<string>(nullable: true),
                    ProfesionalId = table.Column<int>(nullable: false),
                    UsuarioNovedad = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfiguracionesHorarias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConfiguracionesHorarias_Profesionales_ProfesionalId",
                        column: x => x.ProfesionalId,
                        principalTable: "Profesionales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfesionalCursos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CursoId = table.Column<int>(nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    FechaNovedad = table.Column<DateTime>(nullable: false),
                    ProfesionalId = table.Column<int>(nullable: false),
                    UsuarioNovedad = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfesionalCursos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfesionalCursos_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfesionalCursos_Profesionales_ProfesionalId",
                        column: x => x.ProfesionalId,
                        principalTable: "Profesionales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.CreateTable(
            //    name: "Notificaciones",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Estado = table.Column<int>(nullable: false),
            //        FechaHoraLeido = table.Column<string>(nullable: true),
            //        FechaNovedad = table.Column<DateTime>(nullable: false),
            //        MarcaLeido = table.Column<bool>(nullable: false),
            //        Mensaje = table.Column<string>(nullable: true),
            //        UsuarioEmisorId = table.Column<int>(nullable: false),
            //        UsuarioNovedad = table.Column<string>(maxLength: 256, nullable: true),
            //        UsuarioReceptorId = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Notificaciones", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Notificaciones_Usuarios_UsuarioEmisorId",
            //            column: x => x.UsuarioEmisorId,
            //            principalTable: "Usuarios",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Notificaciones_Usuarios_UsuarioReceptorId",
            //            column: x => x.UsuarioReceptorId,
            //            principalTable: "Usuarios",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            migrationBuilder.CreateIndex(
                name: "IX_AlumnoCursos_AlumnoId",
                table: "AlumnoCursos",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_AlumnoCursos_CursoId",
                table: "AlumnoCursos",
                column: "CursoId");

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
                name: "IX_AutorizacionesRetiro_AlumnoId",
                table: "AutorizacionesRetiro",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_AutorizacionesRetiro_TutorId",
                table: "AutorizacionesRetiro",
                column: "TutorId");

            migrationBuilder.CreateIndex(
                name: "IX_ConfiguracionesHorarias_ProfesionalId",
                table: "ConfiguracionesHorarias",
                column: "ProfesionalId");

            migrationBuilder.CreateIndex(
                name: "IX_CursoAsignaturas_AsignaturaId",
                table: "CursoAsignaturas",
                column: "AsignaturaId");

            migrationBuilder.CreateIndex(
                name: "IX_CursoAsignaturas_CursoId",
                table: "CursoAsignaturas",
                column: "CursoId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Notificaciones_UsuarioEmisorId",
            //    table: "Notificaciones",
            //    column: "UsuarioEmisorId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Notificaciones_UsuarioReceptorId",
            //    table: "Notificaciones",
            //    column: "UsuarioReceptorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfesionalCursos_CursoId",
                table: "ProfesionalCursos",
                column: "CursoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfesionalCursos_ProfesionalId",
                table: "ProfesionalCursos",
                column: "ProfesionalId");

            migrationBuilder.CreateIndex(
                name: "IX_Profesionales_TipoProfesionalId",
                table: "Profesionales",
                column: "TipoProfesionalId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_TipoUsuarioId",
                table: "Usuarios",
                column: "TipoUsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlumnoCursos");

            migrationBuilder.DropTable(
                name: "Autorizaciones");

            migrationBuilder.DropTable(
                name: "AutorizacionesRetiro");

            migrationBuilder.DropTable(
                name: "ConfiguracionesHorarias");

            migrationBuilder.DropTable(
                name: "CursoAsignaturas");

            migrationBuilder.DropTable(
                name: "ErrorDetails");

            migrationBuilder.DropTable(
                name: "Notificaciones");

            migrationBuilder.DropTable(
                name: "ProfesionalCursos");

            migrationBuilder.DropTable(
                name: "RolFunciones");

            migrationBuilder.DropTable(
                name: "TutorAlumnos");

            migrationBuilder.DropTable(
                name: "Asignaturas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Cursos");

            migrationBuilder.DropTable(
                name: "Profesionales");

            migrationBuilder.DropTable(
                name: "Funciones");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Alumnos");

            migrationBuilder.DropTable(
                name: "Tutores");

            migrationBuilder.DropTable(
                name: "TipoUsuarios");

            migrationBuilder.DropTable(
                name: "TipoProfesionales");
        }
    }
}
