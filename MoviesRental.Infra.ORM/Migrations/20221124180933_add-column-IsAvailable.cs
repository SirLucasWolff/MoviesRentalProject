using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesRental.Infra.ORM.Migrations
{
    public partial class addcolumnIsAvailable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RentalDate",
                table: "RentDB",
                type: "DATE",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "DATE");

            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "MovieDB",
                type: "bit",
                nullable: true,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "MovieDB");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RentalDate",
                table: "RentDB",
                type: "DATE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "DATE",
                oldNullable: true);
        }
    }
}
