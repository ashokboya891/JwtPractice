using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JwtWebApiTutorial.Migrations
{
    public partial class intial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CityTbl",
                columns: table => new
                {
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityTbl", x => x.CityId);
                });

            migrationBuilder.InsertData(
                table: "CityTbl",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { new Guid("88d06f3e-a035-4cf2-9ebf-35114e27376f"), "KAdapa" });

            migrationBuilder.InsertData(
                table: "CityTbl",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { new Guid("eb053846-2c65-430e-9526-2747d41f50b8"), "knl" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CityTbl");
        }
    }
}
