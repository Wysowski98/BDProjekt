using Microsoft.EntityFrameworkCore.Migrations;

namespace BD_UI.Migrations
{
    public partial class Employees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DoucmentNumber",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DocumentNumber",
                table: "Clients",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoucmentNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DocumentNumber",
                table: "Clients");
        }
    }
}
