using Microsoft.EntityFrameworkCore.Migrations;

namespace Stock_v2.Migrations
{
    public partial class addPortfelWalorIl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfels_Stocks_CategoryId",
                table: "Portfels");

            migrationBuilder.DropIndex(
                name: "IX_Portfels_CategoryId",
                table: "Portfels");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Portfels");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Portfels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Portfels_CategoryId",
                table: "Portfels",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfels_Stocks_CategoryId",
                table: "Portfels",
                column: "CategoryId",
                principalTable: "Stocks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
