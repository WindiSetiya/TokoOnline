using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcTokoOnline.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "transaksiDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "transaksiDetails",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Jumlah = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ProdukID = table.Column<int>(type: "int", nullable: false),
                    TransaksiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transaksiDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_transaksiDetails_product_ProdukID",
                        column: x => x.ProdukID,
                        principalTable: "product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_transaksiDetails_transaksi_TransaksiID",
                        column: x => x.TransaksiID,
                        principalTable: "transaksi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_transaksiDetails_ProdukID",
                table: "transaksiDetails",
                column: "ProdukID");

            migrationBuilder.CreateIndex(
                name: "IX_transaksiDetails_TransaksiID",
                table: "transaksiDetails",
                column: "TransaksiID");
        }
    }
}
