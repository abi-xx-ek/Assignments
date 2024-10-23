using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Card.Management.Infrastructure.Migrations
{
    public partial class rename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Accounts_AccoundID",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "AccoundID",
                table: "Transactions",
                newName: "AccountID");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_AccoundID",
                table: "Transactions",
                newName: "IX_Transactions_AccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Accounts_AccountID",
                table: "Transactions",
                column: "AccountID",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Accounts_AccountID",
                table: "Transactions");

            migrationBuilder.RenameColumn(
                name: "AccountID",
                table: "Transactions",
                newName: "AccoundID");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_AccountID",
                table: "Transactions",
                newName: "IX_Transactions_AccoundID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Accounts_AccoundID",
                table: "Transactions",
                column: "AccoundID",
                principalTable: "Accounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
