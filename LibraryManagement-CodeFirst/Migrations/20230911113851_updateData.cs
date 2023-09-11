using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement_CodeFirst.Migrations
{
    public partial class updateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PageCount",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 14, 38, 51, 291, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 14, 38, 51, 291, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 14, 38, 51, 291, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 14, 38, 51, 291, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 14, 38, 51, 290, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 14, 38, 51, 290, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 14, 38, 51, 290, DateTimeKind.Local).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 11, 14, 38, 51, 291, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 9, 11, 14, 38, 51, 288, DateTimeKind.Local).AddTicks(7591), "$2a$11$XJrd5WduZyJLfF9OSb4LK.145AcukTMXtrqUseWIzRP7LHHbbVfxO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 9, 11, 14, 38, 51, 289, DateTimeKind.Local).AddTicks(8513), "$2a$11$wKv3Q5eAHw9bId3MDZIkQ.998ftzN01Tj6CXaTv/zvI0QYirdRxY6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PageCount",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 16, 33, 30, 302, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 16, 33, 30, 302, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 16, 33, 30, 302, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 16, 33, 30, 302, DateTimeKind.Local).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 16, 33, 30, 302, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 16, 33, 30, 302, DateTimeKind.Local).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 16, 33, 30, 302, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 16, 33, 30, 302, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 9, 10, 16, 33, 30, 299, DateTimeKind.Local).AddTicks(2075), "$2a$11$TP.CWs8rP5gvgsQ2fajdt.FWAKDbXlhUewC9mr5m5/t0Hq19YESvW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2023, 9, 10, 16, 33, 30, 300, DateTimeKind.Local).AddTicks(9988), "$2a$11$wNRK.WZoBqCbBqb8CV3xtO959yMAgQM11tYDBaCm08XeZ.AaRXYQu" });
        }
    }
}
