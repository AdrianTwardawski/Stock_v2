using Microsoft.EntityFrameworkCore.Migrations;

namespace Stock_v2.Migrations
{
    public partial class addPortfelWalorId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WalorId",
                table: "Portfels",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WalorId",
                table: "Portfels");
        }
    }
}
