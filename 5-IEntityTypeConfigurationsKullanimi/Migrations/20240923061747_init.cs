using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _5_IEntityTypeConfigurationsKullanimi.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Musteriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VergiNo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gsm = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunKodu = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UrunAdi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Fiyat = table.Column<double>(type: "float", nullable: true),
                    Adet = table.Column<double>(type: "float", nullable: true),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Urunler_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "Id", "Aciklama", "CreateDate", "KategoriAdi" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 9, 23, 9, 17, 47, 544, DateTimeKind.Local).AddTicks(2932), "Elektronik" },
                    { 2, "Gida", new DateTime(2024, 9, 23, 9, 17, 47, 544, DateTimeKind.Local).AddTicks(2954), "Gida" },
                    { 3, "Tekstil", new DateTime(2024, 9, 23, 9, 17, 47, 544, DateTimeKind.Local).AddTicks(2958), "Tekstil" },
                    { 4, "Kitap", new DateTime(2024, 9, 23, 9, 17, 47, 544, DateTimeKind.Local).AddTicks(2960), "Kitap" },
                    { 5, "Hirdavat", new DateTime(2024, 9, 23, 9, 17, 47, 544, DateTimeKind.Local).AddTicks(2961), "Hirdavat" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kategoriler_KategoriAdi",
                table: "Kategoriler",
                column: "KategoriAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Musteriler_VergiNo",
                table: "Musteriler",
                column: "VergiNo",
                unique: true,
                filter: "[VergiNo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_KategoriId",
                table: "Urunler",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_UrunKodu",
                table: "Urunler",
                column: "UrunKodu",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musteriler");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
