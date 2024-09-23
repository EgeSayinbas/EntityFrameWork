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
            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 28, 21, 707, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 28, 21, 708, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 28, 21, 708, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 28, 21, 708, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 28, 21, 708, DateTimeKind.Local).AddTicks(12));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 18, 56, 992, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 18, 56, 992, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 18, 56, 992, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 18, 56, 992, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 18, 56, 992, DateTimeKind.Local).AddTicks(5047));
        }
    }
}
