using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _8_TablePerHierarchy.Migrations
{
    /// <inheritdoc />
    public partial class kamyonveMotorsiklet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Kapasitesi",
                table: "Araclar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotorsikletTipi",
                table: "Araclar",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kapasitesi",
                table: "Araclar");

            migrationBuilder.DropColumn(
                name: "MotorsikletTipi",
                table: "Araclar");
        }
    }
}
