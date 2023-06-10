using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Edu.Migrations
{
    public partial class CreateStuFacTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacultyId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "CreateDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1845), false, "Mahir" },
                    { 2, new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1847), false, "Nicat" },
                    { 3, new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1848), false, "Anar" },
                    { 4, new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1849), false, "Resul" },
                    { 5, new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1850), false, "Fatime" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CreateDate", "Description", "FacultyId", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1668), "MahirDescription", 5, "team-1.jpg", false, "Mahir" },
                    { 2, new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1683), "MahirDescription", 4, "team-4.jpg", false, "Nicat" },
                    { 3, new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1685), "MahirDescription", 3, "team-2.jpg", false, "Anar" },
                    { 4, new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1686), "MahirDescription", 2, "team-4.jpg", false, "Resul" },
                    { 5, new DateTime(2023, 6, 8, 19, 48, 5, 266, DateTimeKind.Local).AddTicks(1688), "MahirDescription", 1, "team-3.jpg", false, "Fatime" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_FacultyId",
                table: "Students",
                column: "FacultyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Faculties");
        }
    }
}
