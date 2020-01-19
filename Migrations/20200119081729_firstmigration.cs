using Microsoft.EntityFrameworkCore.Migrations;

namespace Core_WebApp.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryRowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<string>(nullable: false),
                    CategoryName = table.Column<string>(nullable: false),
                    BasePrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryRowID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductRowID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductID = table.Column<string>(nullable: false),
                    ProductName = table.Column<string>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CategoryRowID = table.Column<int>(nullable: false),
                    CategoryRowID1 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductRowID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryRowID1",
                        column: x => x.CategoryRowID1,
                        principalTable: "Categories",
                        principalColumn: "CategoryRowID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryRowID1",
                table: "Products",
                column: "CategoryRowID1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
