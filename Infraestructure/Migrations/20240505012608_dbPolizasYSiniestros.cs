﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class dbPolizasYSiniestros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    MarcaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreMarca = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.MarcaId);
                });

            migrationBuilder.CreateTable(
                name: "Modelo",
                columns: table => new
                {
                    ModeloId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreModelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarcaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelo", x => x.ModeloId);
                    table.ForeignKey(
                        name: "FK_Modelo_Marca_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marca",
                        principalColumn: "MarcaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Version",
                columns: table => new
                {
                    VersionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioBase = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ModeloId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Version", x => x.VersionId);
                    table.ForeignKey(
                        name: "FK_Version_Modelo_ModeloId",
                        column: x => x.ModeloId,
                        principalTable: "Modelo",
                        principalColumn: "ModeloId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "MarcaId", "NombreMarca" },
                values: new object[,]
                {
                    { 1, "Fiat" },
                    { 2, "Ford" },
                    { 3, "BMW" }
                });

            migrationBuilder.InsertData(
                table: "Modelo",
                columns: new[] { "ModeloId", "MarcaId", "NombreModelo" },
                values: new object[,]
                {
                    { 1, 1, "Siena" },
                    { 2, 1, "Uno" },
                    { 3, 1, "Palio" },
                    { 4, 2, "Fiesta" },
                    { 5, 2, "Ranger" },
                    { 6, 2, "Focus" },
                    { 7, 3, "320" },
                    { 8, 3, "530" },
                    { 9, 3, "750" }
                });

            migrationBuilder.InsertData(
                table: "Version",
                columns: new[] { "VersionId", "ModeloId", "NombreVersion", "PrecioBase" },
                values: new object[,]
                {
                    { 1, 1, "1.4 Fire", 5200000m },
                    { 2, 1, "1.4 Fire Way", 6700000m },
                    { 3, 1, "1.7 ELX TD L/N", 3600000m },
                    { 4, 2, "Cargo 1.3 Fire", 3200000m },
                    { 5, 2, "Fire 1.3 3P LN", 4500000m },
                    { 6, 2, "Fire 1.3 5P LN Pack C II", 8500000m },
                    { 7, 3, "WE 1.8 Adventure", 6487999m },
                    { 8, 3, "1.4 3P ELX Active", 8000000m },
                    { 9, 3, "WE 1.7 TD Adventure X-Treme", 4500000m },
                    { 10, 4, "1.6 5P Energy", 12900000m },
                    { 11, 4, "1.4 5P Edge TDCI", 5000000m },
                    { 12, 4, "Max 1.4 4P Ambiente TDCI", 5200000m },
                    { 13, 5, "2.3 DC 4X2 L/05 XL Plus", 12600000m },
                    { 14, 5, "3.0 TDI DC 4x2 L/06 XL", 58500000m },
                    { 15, 5, "3.0 Cd Xl Plus", 9800000m },
                    { 16, 6, "2.0 Se Plus At6", 8933000m },
                    { 17, 6, "1.6 S", 12000000m },
                    { 18, 6, "2.0 Se Plus At", 10610000m },
                    { 19, 7, "2.0 320i Sedan 184cv", 34900000m },
                    { 20, 7, "2.0 320i Sedan Executive", 19900000m },
                    { 21, 7, "2.0 Sdrive 20i Sportline 192cv", 45000000m },
                    { 22, 8, "3.0 530ia Sportline Sedan", 82900000m },
                    { 23, 8, "3.0 530ia Executive 258cv", 17000000m },
                    { 24, 8, "3.0 530ia Sportline", 47900000m },
                    { 25, 9, "Serie 7 4.8 750i Premium 407cv", 38000000m },
                    { 26, 9, "erie 7 4.8 750ia Premium Stept", 38000000m },
                    { 27, 9, "750i ", 150000000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Modelo_MarcaId",
                table: "Modelo",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Version_ModeloId",
                table: "Version",
                column: "ModeloId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Version");

            migrationBuilder.DropTable(
                name: "Modelo");

            migrationBuilder.DropTable(
                name: "Marca");
        }
    }
}
