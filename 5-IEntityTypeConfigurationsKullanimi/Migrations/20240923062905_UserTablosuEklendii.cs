using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _5_IEntityTypeConfigurationsKullanimi.Migrations
{
    /// <inheritdoc />
    public partial class UserTablosuEklendii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 29, 4, 990, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 29, 4, 990, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 29, 4, 990, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 29, 4, 990, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 9, 23, 9, 29, 4, 990, DateTimeKind.Local).AddTicks(5555));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
