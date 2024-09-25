using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _5_IEntityTypeConfigurationsKullanimi.Migrations
{
    /// <inheritdoc />
    public partial class UserTablosuEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gsm = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 27, 48, 553, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 27, 48, 553, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 27, 48, 553, DateTimeKind.Local).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 27, 48, 553, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 27, 48, 553, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreateDate", "Email", "Gsm", "Password", "UserName" },
                values: new object[] { 1, new DateTime(2024, 9, 23, 9, 27, 48, 554, DateTimeKind.Local).AddTicks(5377), "admin@gmail.com", "123123", "qweasd", "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Gsm",
                table: "Users",
                column: "Gsm",
                unique: true,
                filter: "[Gsm] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 17, 47, 544, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 17, 47, 544, DateTimeKind.Local).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 17, 47, 544, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 17, 47, 544, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 17, 47, 544, DateTimeKind.Local).AddTicks(2961));
        }
    }
}
