using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Farmacity_Backend.Migrations
{
    /// <inheritdoc />
    public partial class Propiedades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CodigoBarra_Productos_ProductoId",
                table: "CodigoBarra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CodigoBarra",
                table: "CodigoBarra");

            migrationBuilder.RenameTable(
                name: "CodigoBarra",
                newName: "CodigoBarras");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Productos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "CodigoBarras",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CodigoBarras",
                table: "CodigoBarras",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CodigoBarras_Productos_ProductoId",
                table: "CodigoBarras",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CodigoBarras_Productos_ProductoId",
                table: "CodigoBarras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CodigoBarras",
                table: "CodigoBarras");

            migrationBuilder.RenameTable(
                name: "CodigoBarras",
                newName: "CodigoBarra");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Codigo",
                table: "CodigoBarra",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(13)",
                oldMaxLength: 13);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CodigoBarra",
                table: "CodigoBarra",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_CodigoBarra_Productos_ProductoId",
                table: "CodigoBarra",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
