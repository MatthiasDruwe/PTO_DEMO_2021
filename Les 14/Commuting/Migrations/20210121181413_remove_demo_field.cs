using Microsoft.EntityFrameworkCore.Migrations;

namespace Commuting.Migrations
{
    public partial class remove_demo_field : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Demo",
                table: "Cars");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Demo",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
