using Microsoft.EntityFrameworkCore.Migrations;

namespace TI.Migrations
{
    public partial class extendemployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "PremiiBrute",
                table: "Employees",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Spor",
                table: "Employees",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ViratCard",
                table: "Employees",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PremiiBrute",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Spor",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ViratCard",
                table: "Employees");
        }
    }
}
