using Microsoft.EntityFrameworkCore.Migrations;

namespace AssetDistributionWebApp.Migrations
{
    public partial class SenderEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "senderemail",
                table: "distributions",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "senderemail",
                table: "distributions");
        }
    }
}
