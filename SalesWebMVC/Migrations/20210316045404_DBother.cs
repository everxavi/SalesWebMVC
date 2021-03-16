using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMVC.Migrations
{
    public partial class DBother : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "birthDate",
                table: "Seller",
                newName: "BirthDate");

            migrationBuilder.RenameColumn(
                name: "baseSalary",
                table: "Seller",
                newName: "BaseSalary");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Seller",
                newName: "birthDate");

            migrationBuilder.RenameColumn(
                name: "BaseSalary",
                table: "Seller",
                newName: "baseSalary");
        }
    }
}
