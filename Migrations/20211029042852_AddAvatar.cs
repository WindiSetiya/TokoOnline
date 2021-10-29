using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcTokoOnline.Migrations
{
    public partial class AddAvatar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "transaksi",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "AspNetUsers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_transaksiDetails_ProdukID",
                table: "transaksiDetails",
                column: "ProdukID");

            migrationBuilder.CreateIndex(
                name: "IX_transaksiDetails_TransaksiID",
                table: "transaksiDetails",
                column: "TransaksiID");

            migrationBuilder.CreateIndex(
                name: "IX_transaksi_CustomerID",
                table: "transaksi",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_transaksi_SistemPembayaranID",
                table: "transaksi",
                column: "SistemPembayaranID");

            migrationBuilder.AddForeignKey(
                name: "FK_transaksi_AspNetUsers_CustomerID",
                table: "transaksi",
                column: "CustomerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_transaksi_sistemPembayarans_SistemPembayaranID",
                table: "transaksi",
                column: "SistemPembayaranID",
                principalTable: "sistemPembayarans",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transaksiDetails_product_ProdukID",
                table: "transaksiDetails",
                column: "ProdukID",
                principalTable: "product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_transaksiDetails_transaksi_TransaksiID",
                table: "transaksiDetails",
                column: "TransaksiID",
                principalTable: "transaksi",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transaksi_AspNetUsers_CustomerID",
                table: "transaksi");

            migrationBuilder.DropForeignKey(
                name: "FK_transaksi_sistemPembayarans_SistemPembayaranID",
                table: "transaksi");

            migrationBuilder.DropForeignKey(
                name: "FK_transaksiDetails_product_ProdukID",
                table: "transaksiDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_transaksiDetails_transaksi_TransaksiID",
                table: "transaksiDetails");

            migrationBuilder.DropIndex(
                name: "IX_transaksiDetails_ProdukID",
                table: "transaksiDetails");

            migrationBuilder.DropIndex(
                name: "IX_transaksiDetails_TransaksiID",
                table: "transaksiDetails");

            migrationBuilder.DropIndex(
                name: "IX_transaksi_CustomerID",
                table: "transaksi");

            migrationBuilder.DropIndex(
                name: "IX_transaksi_SistemPembayaranID",
                table: "transaksi");

            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerID",
                table: "transaksi",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
