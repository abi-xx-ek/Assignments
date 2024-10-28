using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Card.Management.Infrastructure.Migrations
{
    public partial class firstfdsdfs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerID",
                table: "Accounts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerID",
                table: "Accounts");
        }
    }
}
