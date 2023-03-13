using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoMicroService.Migrations
{
    /// <inheritdoc />
    public partial class coluns_salary_birthdate_users : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "birthdate",
                table: "users",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "salary",
                table: "users",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "birthdate",
                table: "users");

            migrationBuilder.DropColumn(
                name: "salary",
                table: "users");
        }
    }
}
