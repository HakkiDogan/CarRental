using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class edit3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "DailyPrices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DailyPrices_CarId",
                table: "DailyPrices",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_DailyPrices_Cars_CarId",
                table: "DailyPrices",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DailyPrices_Cars_CarId",
                table: "DailyPrices");

            migrationBuilder.DropIndex(
                name: "IX_DailyPrices_CarId",
                table: "DailyPrices");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "DailyPrices");

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
    }
}
