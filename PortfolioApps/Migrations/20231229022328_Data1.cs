using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioApps.Migrations
{
    /// <inheritdoc />
    public partial class Data1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ElementoReaccion",
                columns: new[] { "ElementoId", "ReaccionesId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 3, 3 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ElementoReaccion",
                keyColumns: new[] { "ElementoId", "ReaccionesId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ElementoReaccion",
                keyColumns: new[] { "ElementoId", "ReaccionesId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ElementoReaccion",
                keyColumns: new[] { "ElementoId", "ReaccionesId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "ElementoReaccion",
                keyColumns: new[] { "ElementoId", "ReaccionesId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "ElementoReaccion",
                keyColumns: new[] { "ElementoId", "ReaccionesId" },
                keyValues: new object[] { 3, 8 });
        }
    }
}
