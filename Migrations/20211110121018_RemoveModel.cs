using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcTokoOnline.Migrations
{
    public partial class RemoveModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transaksi_sistemPembayarans_SistemPembayaranID",
                table: "transaksi");

            migrationBuilder.DropTable(
                name: "sistemPembayarans");

            migrationBuilder.DropIndex(
                name: "IX_transaksi_SistemPembayaranID",
                table: "transaksi");

            migrationBuilder.DropColumn(
                name: "SistemPembayaranID",
                table: "transaksi");

            migrationBuilder.AddColumn<string>(
                name: "MetodePembayaran",
                table: "transaksi",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Warna",
                table: "transaksi",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MetodePembayaran",
                table: "transaksi");

            migrationBuilder.DropColumn(
                name: "Warna",
                table: "transaksi");

            migrationBuilder.AddColumn<int>(
                name: "SistemPembayaranID",
                table: "transaksi",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "sistemPembayarans",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MetodePembayaran = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sistemPembayarans", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_transaksi_SistemPembayaranID",
                table: "transaksi",
                column: "SistemPembayaranID");

            migrationBuilder.AddForeignKey(
                name: "FK_transaksi_sistemPembayarans_SistemPembayaranID",
                table: "transaksi",
                column: "SistemPembayaranID",
                principalTable: "sistemPembayarans",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
