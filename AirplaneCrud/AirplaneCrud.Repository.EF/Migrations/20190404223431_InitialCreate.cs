using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace AirplaneCrud.Repository.EF.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airplanes",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    MaxPassengers = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table => table.PrimaryKey("PK_Airplanes", x => x.Id));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airplanes");
        }
    }
}