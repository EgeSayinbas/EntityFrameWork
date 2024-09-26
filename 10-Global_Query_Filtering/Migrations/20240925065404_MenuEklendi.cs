using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _10_Global_Query_Filtering.Migrations
{
    /// <inheritdoc />
    public partial class MenuEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Persons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 25, 6, 54, 4, 648, DateTimeKind.Utc).AddTicks(1681),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 25, 6, 23, 55, 805, DateTimeKind.Utc).AddTicks(605));

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 9, 25, 6, 54, 4, 647, DateTimeKind.Utc).AddTicks(9760)),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Menu_PersonId",
                table: "Menu",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Persons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 25, 6, 23, 55, 805, DateTimeKind.Utc).AddTicks(605),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 25, 6, 54, 4, 648, DateTimeKind.Utc).AddTicks(1681));
        }
    }
}
