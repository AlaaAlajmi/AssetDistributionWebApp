using Microsoft.EntityFrameworkCore.Migrations;

namespace AssetDistributionWebApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "assets",
                columns: table => new
                {
                    assetid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    amount = table.Column<int>(type: "int", nullable: false),
                    imageurl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    focalPoint = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assets", x => x.assetid);
                });

            migrationBuilder.CreateTable(
                name: "distributions",
                columns: table => new
                {
                    distributionid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    amount = table.Column<int>(type: "int", nullable: false),
                    useremail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    approved = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    assetid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_distributions", x => x.distributionid);
                    table.ForeignKey(
                        name: "FK_distributions_assets_assetid",
                        column: x => x.assetid,
                        principalTable: "assets",
                        principalColumn: "assetid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_distributions_assetid",
                table: "distributions",
                column: "assetid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "distributions");

            migrationBuilder.DropTable(
                name: "assets");
        }
    }
}
