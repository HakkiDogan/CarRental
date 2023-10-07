using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class table_edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarDailyPrice");

            migrationBuilder.AddColumn<int>(
                name: "DailyPriceId",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_DailyPriceId",
                table: "Cars",
                column: "DailyPriceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_DailyPrices_DailyPriceId",
                table: "Cars",
                column: "DailyPriceId",
                principalTable: "DailyPrices",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_DailyPrices_DailyPriceId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_DailyPriceId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "DailyPriceId",
                table: "Cars");

            migrationBuilder.CreateTable(
                name: "CarDailyPrice",
                columns: table => new
                {
                    CarsId = table.Column<int>(type: "int", nullable: false),
                    DailyPricesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDailyPrice", x => new { x.CarsId, x.DailyPricesId });
                    table.ForeignKey(
                        name: "FK_CarDailyPrice_Cars_CarsId",
                        column: x => x.CarsId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarDailyPrice_DailyPrices_DailyPricesId",
                        column: x => x.DailyPricesId,
                        principalTable: "DailyPrices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarDailyPrice_DailyPricesId",
                table: "CarDailyPrice",
                column: "DailyPricesId");
        }
    }
}
