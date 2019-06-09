using Microsoft.EntityFrameworkCore.Migrations;

namespace PornYaShop.DataContext.Migrations
{
    public partial class ProductVariantSizesFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSize_ProductVariant_ProdiczVariantId",
                table: "ProductSize");

            migrationBuilder.RenameColumn(
                name: "ProdiczVariantId",
                table: "ProductSize",
                newName: "ProductVariantId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSize_ProdiczVariantId",
                table: "ProductSize",
                newName: "IX_ProductSize_ProductVariantId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSize_ProductVariant_ProductVariantId",
                table: "ProductSize",
                column: "ProductVariantId",
                principalTable: "ProductVariant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductSize_ProductVariant_ProductVariantId",
                table: "ProductSize");

            migrationBuilder.RenameColumn(
                name: "ProductVariantId",
                table: "ProductSize",
                newName: "ProdiczVariantId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSize_ProductVariantId",
                table: "ProductSize",
                newName: "IX_ProductSize_ProdiczVariantId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSize_ProductVariant_ProdiczVariantId",
                table: "ProductSize",
                column: "ProdiczVariantId",
                principalTable: "ProductVariant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
