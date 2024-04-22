using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Evaluacion1PMatiasRobayo.Migrations
{
    /// <inheritdoc />
    public partial class CambiosBdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carrera",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_carrera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    campus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    numero_semestres = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrera", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MRobayo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Promedio = table.Column<float>(type: "real", nullable: false),
                    Estudia = table.Column<bool>(type: "bit", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CarreraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MRobayo", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MRobayo_Carrera_CarreraId",
                        column: x => x.CarreraId,
                        principalTable: "Carrera",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MRobayo_CarreraId",
                table: "MRobayo",
                column: "CarreraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MRobayo");

            migrationBuilder.DropTable(
                name: "Carrera");
        }
    }
}
