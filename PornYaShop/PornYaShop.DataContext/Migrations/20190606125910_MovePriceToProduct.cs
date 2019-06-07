using Microsoft.EntityFrameworkCore.Migrations;

namespace PornYaShop.DataContext.Migrations
{
    public partial class MovePriceToProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "ProductVariant");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Product",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Product");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "ProductVariant",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
