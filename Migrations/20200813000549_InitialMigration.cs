using Microsoft.EntityFrameworkCore.Migrations;

namespace Growler.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Introduction = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Styles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    OverallImpression = table.Column<string>(nullable: false),
                    Aroma = table.Column<string>(nullable: false),
                    Appearance = table.Column<string>(nullable: false),
                    Flavor = table.Column<string>(nullable: false),
                    Mouthfeel = table.Column<string>(nullable: false),
                    Comments = table.Column<string>(nullable: false),
                    History = table.Column<string>(nullable: false),
                    CharacteristicIngredients = table.Column<string>(nullable: false),
                    OG = table.Column<string>(nullable: false),
                    IBUs = table.Column<string>(nullable: false),
                    FG = table.Column<string>(nullable: false),
                    SRM = table.Column<string>(nullable: false),
                    ABV = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Styles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    StyleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brews_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Brews_Styles_StyleId",
                        column: x => x.StyleId,
                        principalTable: "Styles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Brews_CategoryId",
                table: "Brews",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Brews_StyleId",
                table: "Brews",
                column: "StyleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brews");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Styles");
        }
    }
}
