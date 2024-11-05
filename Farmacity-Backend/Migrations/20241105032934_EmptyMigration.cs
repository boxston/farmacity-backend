using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Farmacity_Backend.Migrations
{
    /// <inheritdoc />
    public partial class EmptyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CodigoBarras",
                table: "CodigoBarras");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CodigoBarras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CodigoBarras",
                table: "CodigoBarras",
                columns: new[] { "ProductoId", "Codigo" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CodigoBarras",
                table: "CodigoBarras");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CodigoBarras");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CodigoBarras",
                table: "CodigoBarras",
                column: "ProductoId");
        }
    }
}
