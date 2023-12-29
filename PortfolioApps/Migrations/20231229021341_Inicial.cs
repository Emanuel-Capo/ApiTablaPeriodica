using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioApps.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reacciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reacciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Elementos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NroAtomico = table.Column<int>(type: "int", nullable: false),
                    Simbolo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValenciaM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValenciaNM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Especial = table.Column<bool>(type: "bit", nullable: false),
                    Posicion = table.Column<int>(type: "int", nullable: false),
                    Wiki = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prefijo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GrupoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elementos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Elementos_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElementoReaccion",
                columns: table => new
                {
                    ElementoId = table.Column<int>(type: "int", nullable: false),
                    ReaccionesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementoReaccion", x => new { x.ElementoId, x.ReaccionesId });
                    table.ForeignKey(
                        name: "FK_ElementoReaccion_Elementos_ElementoId",
                        column: x => x.ElementoId,
                        principalTable: "Elementos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElementoReaccion_Reacciones_ReaccionesId",
                        column: x => x.ReaccionesId,
                        principalTable: "Reacciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Grupos",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Metal alcalino" },
                    { 2, "Metal alcalinotérreo" },
                    { 3, "Metal transicional" },
                    { 4, "Metal postransicional" },
                    { 5, "No metal reactivo" },
                    { 6, "Metaloides" },
                    { 7, "Halógeno" },
                    { 8, "Gas noble" },
                    { 9, "Lantánido" },
                    { 10, "Actínido" },
                    { 11, "Desconocido" }
                });

            migrationBuilder.InsertData(
                table: "Reacciones",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Óxido metálico" },
                    { 2, "Óxido no metálico" },
                    { 3, "Hidróxido" },
                    { 4, "Ácido" },
                    { 5, "Hidrácido" },
                    { 6, "Hidruro metálico" },
                    { 7, "Sal" },
                    { 8, "Sal de hidrácido" }
                });

            migrationBuilder.InsertData(
                table: "Elementos",
                columns: new[] { "Id", "Especial", "GrupoId", "Nombre", "NroAtomico", "Posicion", "Prefijo", "Simbolo", "ValenciaM", "ValenciaNM", "Wiki" },
                values: new object[,]
                {
                    { 1, false, 5, "Hidrógeno", 1, 1, null, "H", "[]", "[]", "Hidrógeno" },
                    { 2, false, 8, "Helio", 2, 18, null, "He", "[]", "[]", "Helio" },
                    { 3, false, 1, "Litio", 3, 19, null, "Li", "[1]", "[]", "Litio" },
                    { 4, false, 2, "Berilio", 4, 20, null, "Be", "[2]", "[]", "Berilio" },
                    { 5, false, 6, "Boro", 5, 31, "bor", "B", "[]", "[3]", "Boro" },
                    { 6, false, 5, "Carbono", 6, 32, "carbon", "C", "[]", "[2,4]", "Carbono" },
                    { 7, false, 5, "Nitrógeno", 7, 33, "nitr", "N", "[]", "[3,5]", "Nitrógeno" },
                    { 8, false, 5, "Oxígeno", 8, 34, null, "O", "[]", "[]", "Oxígeno" },
                    { 9, false, 5, "Flúor", 9, 35, "fluor", "F", "[]", "[1]", "Flúor" },
                    { 10, false, 8, "Neón", 10, 36, null, "Ne", "[]", "[]", "Neón" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElementoReaccion_ReaccionesId",
                table: "ElementoReaccion",
                column: "ReaccionesId");

            migrationBuilder.CreateIndex(
                name: "IX_Elementos_GrupoId",
                table: "Elementos",
                column: "GrupoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElementoReaccion");

            migrationBuilder.DropTable(
                name: "Elementos");

            migrationBuilder.DropTable(
                name: "Reacciones");

            migrationBuilder.DropTable(
                name: "Grupos");
        }
    }
}
