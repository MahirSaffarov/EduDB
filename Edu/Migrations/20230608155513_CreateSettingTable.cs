using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Edu.Migrations
{
    public partial class CreateSettingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 8, 19, 55, 13, 546, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 8, 19, 55, 13, 546, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 8, 19, 55, 13, 546, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 6, 8, 19, 55, 13, 546, DateTimeKind.Local).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 6, 8, 19, 55, 13, 546, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[,]
                {
                    { 1, "Logo", "logo.png" },
                    { 2, "Phone", "+994504198914" },
                    { 3, "Email", "fiorello@code.edu.az" }
                });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 8, 19, 55, 13, 546, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 8, 19, 55, 13, 546, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 8, 19, 55, 13, 546, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 6, 8, 19, 55, 13, 546, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 6, 8, 19, 55, 13, 546, DateTimeKind.Local).AddTicks(2721));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1688));
        }
    }
}
