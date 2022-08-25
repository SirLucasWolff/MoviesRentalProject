using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesRental.Infra.ORM.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Telephone = table.Column<int>(type: "INT", nullable: false),
                    Address = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    BornDate = table.Column<DateTime>(type: "DATE", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientDB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "NVARCHAR(60)", nullable: true),
                    Name = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    Password = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    AccessKey = table.Column<string>(type: "NVARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVARCHAR(60)", nullable: true),
                    Category = table.Column<string>(type: "NVARCHAR(100)", nullable: true),
                    Classification = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "DATE", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieDB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RentDB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeName = table.Column<string>(type: "NVARCHAR(60)", nullable: true),
                    MoviesQuantity = table.Column<int>(type: "INT", nullable: true),
                    MovieName = table.Column<string>(type: "NVARCHAR(200)", nullable: false),
                    ClientName = table.Column<string>(type: "NVARCHAR(50)", nullable: true),
                    RentalDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    DayValue = table.Column<int>(type: "INT", nullable: false),
                    MovieValue = table.Column<int>(type: "INT", nullable: false),
                    TotalPrice = table.Column<int>(type: "INT", nullable: true),
                    StatusImage = table.Column<byte[]>(type: "IMAGE", nullable: false),
                    Status = table.Column<string>(type: "NVARCHAR(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentDB", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientDB");

            migrationBuilder.DropTable(
                name: "EmployeeDB");

            migrationBuilder.DropTable(
                name: "MovieDB");

            migrationBuilder.DropTable(
                name: "RentDB");
        }
    }
}
