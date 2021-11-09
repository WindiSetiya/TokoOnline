using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcTokoOnline.Migrations
{
    public partial class Updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProdukID",
                table: "transaksi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_transaksi_ProdukID",
                table: "transaksi",
                column: "ProdukID");

            migrationBuilder.AddForeignKey(
                name: "FK_transaksi_product_ProdukID",
                table: "transaksi",
                column: "ProdukID",
                principalTable: "product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transaksi_product_ProdukID",
                table: "transaksi");

            migrationBuilder.DropIndex(
                name: "IX_transaksi_ProdukID",
                table: "transaksi");

            migrationBuilder.DropColumn(
                name: "ProdukID",
                table: "transaksi");
        }
    }
}
