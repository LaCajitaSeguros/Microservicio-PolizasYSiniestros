using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class DbPolizaYSiniestros : Migration
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
                name: "TipoDeSiniestro",
                columns: table => new
                {
                    TipoDeSiniestroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDeSiniestro", x => x.TipoDeSiniestroId);
                });

            migrationBuilder.CreateTable(
                name: "Ubicacion",
                columns: table => new
                {
                    UbicacionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinciaId = table.Column<int>(type: "int", nullable: false),
                    LocalidadId = table.Column<int>(type: "int", nullable: false),
                    Calle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Altura = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubicacion", x => x.UbicacionId);
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
                name: "BienAsegurado",
                columns: table => new
                {
                    BienAseguradoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patente = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CodChasis = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CodMotor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TieneGnc = table.Column<bool>(type: "bit", nullable: false),
                    UsoParticular = table.Column<bool>(type: "bit", nullable: false),
                    UbicacionId = table.Column<int>(type: "int", nullable: false),
                    VersionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BienAsegurado", x => x.BienAseguradoId);
                    table.ForeignKey(
                        name: "FK_BienAsegurado_Ubicacion_UbicacionId",
                        column: x => x.UbicacionId,
                        principalTable: "Ubicacion",
                        principalColumn: "UbicacionId",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "Poliza",
                columns: table => new
                {
                    PolizaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanId = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NroDePoliza = table.Column<int>(type: "int", maxLength: 9, nullable: false),
                    Prima = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaVencimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BienAseguradoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poliza", x => x.PolizaId);
                    table.ForeignKey(
                        name: "FK_Poliza_BienAsegurado_BienAseguradoId",
                        column: x => x.BienAseguradoId,
                        principalTable: "BienAsegurado",
                        principalColumn: "BienAseguradoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Siniestro",
                columns: table => new
                {
                    SiniestroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imagenes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PolizaId = table.Column<int>(type: "int", nullable: false),
                    UbicacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siniestro", x => x.SiniestroId);
                    table.ForeignKey(
                        name: "FK_Siniestro_Poliza_PolizaId",
                        column: x => x.PolizaId,
                        principalTable: "Poliza",
                        principalColumn: "PolizaId");
                    table.ForeignKey(
                        name: "FK_Siniestro_Ubicacion_UbicacionId",
                        column: x => x.UbicacionId,
                        principalTable: "Ubicacion",
                        principalColumn: "UbicacionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiniestroTipoDeSiniestro",
                columns: table => new
                {
                    SiniestroId = table.Column<int>(type: "int", nullable: false),
                    TipoDeSiniestroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiniestroTipoDeSiniestro", x => new { x.SiniestroId, x.TipoDeSiniestroId });
                    table.ForeignKey(
                        name: "FK_SiniestroTipoDeSiniestro_Siniestro_SiniestroId",
                        column: x => x.SiniestroId,
                        principalTable: "Siniestro",
                        principalColumn: "SiniestroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiniestroTipoDeSiniestro_TipoDeSiniestro_TipoDeSiniestroId",
                        column: x => x.TipoDeSiniestroId,
                        principalTable: "TipoDeSiniestro",
                        principalColumn: "TipoDeSiniestroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tercero",
                columns: table => new
                {
                    TerceroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Patente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompaniaDeSeguro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    UbicacionId = table.Column<int>(type: "int", nullable: false),
                    SiniestroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tercero", x => x.TerceroId);
                    table.ForeignKey(
                        name: "FK_Tercero_Siniestro_SiniestroId",
                        column: x => x.SiniestroId,
                        principalTable: "Siniestro",
                        principalColumn: "SiniestroId");
                    table.ForeignKey(
                        name: "FK_Tercero_Ubicacion_UbicacionId",
                        column: x => x.UbicacionId,
                        principalTable: "Ubicacion",
                        principalColumn: "UbicacionId",
                        onDelete: ReferentialAction.Cascade);
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
                table: "TipoDeSiniestro",
                columns: new[] { "TipoDeSiniestroId", "Nombre" },
                values: new object[,]
                {
                    { 1, "Robo" },
                    { 2, "Incendio" },
                    { 3, "Choque" },
                    { 4, "Granizo" }
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
                name: "IX_BienAsegurado_UbicacionId",
                table: "BienAsegurado",
                column: "UbicacionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Modelo_MarcaId",
                table: "Modelo",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Poliza_BienAseguradoId",
                table: "Poliza",
                column: "BienAseguradoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Siniestro_PolizaId",
                table: "Siniestro",
                column: "PolizaId");

            migrationBuilder.CreateIndex(
                name: "IX_Siniestro_UbicacionId",
                table: "Siniestro",
                column: "UbicacionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SiniestroTipoDeSiniestro_TipoDeSiniestroId",
                table: "SiniestroTipoDeSiniestro",
                column: "TipoDeSiniestroId");

            migrationBuilder.CreateIndex(
                name: "IX_Tercero_SiniestroId",
                table: "Tercero",
                column: "SiniestroId");

            migrationBuilder.CreateIndex(
                name: "IX_Tercero_UbicacionId",
                table: "Tercero",
                column: "UbicacionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Version_ModeloId",
                table: "Version",
                column: "ModeloId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SiniestroTipoDeSiniestro");

            migrationBuilder.DropTable(
                name: "Tercero");

            migrationBuilder.DropTable(
                name: "Version");

            migrationBuilder.DropTable(
                name: "TipoDeSiniestro");

            migrationBuilder.DropTable(
                name: "Siniestro");

            migrationBuilder.DropTable(
                name: "Modelo");

            migrationBuilder.DropTable(
                name: "Poliza");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropTable(
                name: "BienAsegurado");

            migrationBuilder.DropTable(
                name: "Ubicacion");
        }
    }
}
