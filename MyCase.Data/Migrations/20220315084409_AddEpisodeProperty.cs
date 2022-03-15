using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCase.Data.Migrations
{
    public partial class AddEpisodeProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rank",
                table: "Episodes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("3e4576c7-09df-4646-9c96-cdb210bb0741"),
                column: "Rank",
                value: "1.Bölüm");

            migrationBuilder.UpdateData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: new Guid("6c91df7f-363a-46ac-9364-543a2e00e743"),
                column: "Rank",
                value: "1.Bölüm");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rank",
                table: "Episodes");
        }
    }
}
