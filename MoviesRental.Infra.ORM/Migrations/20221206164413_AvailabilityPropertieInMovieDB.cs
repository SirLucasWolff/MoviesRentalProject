using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesRental.Infra.ORM.Migrations
{
    public partial class AvailabilityPropertieInMovieDB : Migration
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
                name: "Availability",
                table: "MovieDB",
                type: "BIT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AvailabilityMessage",
                table: "MovieDB",
                type: "NVARCHAR(50)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ClientName",
                table: "ClientDB",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Availability",
                table: "MovieDB");

            migrationBuilder.DropColumn(
                name: "AvailabilityMessage",
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

            migrationBuilder.AlterColumn<string>(
                name: "ClientName",
                table: "ClientDB",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70,
                oldNullable: true);
        }
    }
}
