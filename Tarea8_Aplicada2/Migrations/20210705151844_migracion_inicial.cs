using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tarea8_Aplicada2.Migrations
{
    public partial class migracion_inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Nombres = table.Column<string>(type: "TEXT", nullable: false),
                    NombreUsuario = table.Column<string>(type: "TEXT", nullable: false),
                    Clave = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UsuarioIdCreacion = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioId", "Clave", "Email", "Fecha", "FechaCreacion", "FechaModificacion", "NombreUsuario", "Nombres", "UsuarioIdCreacion" },
                values: new object[] { 1, "YQBkAG0AaQBuAA==", "Admin@outlook.com", new DateTime(2021, 7, 5, 17, 18, 41, 476, DateTimeKind.Local).AddTicks(9986), new DateTime(2021, 7, 5, 17, 18, 41, 489, DateTimeKind.Local).AddTicks(1063), new DateTime(2021, 7, 5, 17, 18, 41, 489, DateTimeKind.Local).AddTicks(1190), "admin", "Administrador", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
