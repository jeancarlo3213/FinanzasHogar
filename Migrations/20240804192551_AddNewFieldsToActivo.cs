using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanzasHogar.Migrations
{
    /// <inheritdoc />
    public partial class AddNewFieldsToActivo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Condicion",
                table: "Activos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaAdquisicion",
                table: "Activos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Ubicacion",
                table: "Activos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Condicion",
                table: "Activos");

            migrationBuilder.DropColumn(
                name: "FechaAdquisicion",
                table: "Activos");

            migrationBuilder.DropColumn(
                name: "Ubicacion",
                table: "Activos");
        }
    }
}
