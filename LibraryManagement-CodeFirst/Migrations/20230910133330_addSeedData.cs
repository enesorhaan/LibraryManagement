using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement_CodeFirst.Migrations
{
    public partial class addSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "CreatedDate", "FirstName", "Gender", "LastName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 10, 16, 33, 30, 302, DateTimeKind.Local).AddTicks(1376), "Furkan", 0, "Orhan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, new DateTime(2023, 9, 10, 16, 33, 30, 302, DateTimeKind.Local).AddTicks(2240), "Serhan", 0, "Orhan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, new DateTime(2023, 9, 10, 16, 33, 30, 302, DateTimeKind.Local).AddTicks(2245), "Çiğdem", 1, "Öztutan", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, new DateTime(2023, 9, 10, 16, 33, 30, 302, DateTimeKind.Local).AddTicks(2247), "Enes", 0, "Esen", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CreatedDate", "ModifiedDate", "Password", "Role", "Status", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 10, 16, 33, 30, 299, DateTimeKind.Local).AddTicks(2075), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$TP.CWs8rP5gvgsQ2fajdt.FWAKDbXlhUewC9mr5m5/t0Hq19YESvW", 0, 0, "administrator" },
                    { 2, new DateTime(2023, 9, 10, 16, 33, 30, 300, DateTimeKind.Local).AddTicks(9988), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$wNRK.WZoBqCbBqb8CV3xtO959yMAgQM11tYDBaCm08XeZ.AaRXYQu", 1, 0, "enes" }
                });

            migrationBuilder.InsertData(
                table: "StudentDetail",
                columns: new[] { "ID", "BirthDay", "CreatedDate", "ModifiedDate", "PhoneNumber", "SchoolNumber", "Status", "StudentID" },
                values: new object[,]
                {
                    { 1, new DateTime(1999, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 10, 16, 33, 30, 302, DateTimeKind.Local).AddTicks(2795), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "100", 0, 1 },
                    { 2, new DateTime(1988, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 10, 16, 33, 30, 302, DateTimeKind.Local).AddTicks(3621), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "101", 0, 2 },
                    { 3, new DateTime(1997, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 10, 16, 33, 30, 302, DateTimeKind.Local).AddTicks(3627), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "102", 0, 3 },
                    { 4, new DateTime(1999, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 9, 10, 16, 33, 30, 302, DateTimeKind.Local).AddTicks(3629), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "103", 0, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
