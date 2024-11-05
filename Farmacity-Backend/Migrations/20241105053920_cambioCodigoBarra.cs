using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Farmacity_Backend.Migrations
{
    /// <inheritdoc />
    public partial class cambioCodigoBarra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaModificacion",
                table: "CodigoBarras");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CodigoBarras");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaModificacion",
                table: "CodigoBarras",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CodigoBarras",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
