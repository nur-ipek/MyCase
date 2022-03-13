using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyCase.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Medium = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Original = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TvShows",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TvShows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TvShows_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Seasons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TvShowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seasons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Seasons_TvShows_TvShowId",
                        column: x => x.TvShowId,
                        principalTable: "TvShows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Episodes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Episodes_Seasons_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Seasons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Medium", "Original" },
                values: new object[] { new Guid("4c1f66c7-69b0-439b-b34d-8ebfddf5942c"), "http://static.tvmaze.com/uploads/images/medium_portrait/0/1.jpg", "http://static.tvmaze.com/uploads/images/original_untouched/0/1.jpg" });

            migrationBuilder.InsertData(
                table: "TvShows",
                columns: new[] { "Id", "ImageId", "Name" },
                values: new object[] { new Guid("1282d141-674d-43b4-89cf-e87c814f0021"), new Guid("4c1f66c7-69b0-439b-b34d-8ebfddf5942c"), "Hayaller ve Hayatlar" });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "Name", "Summary", "TvShowId" },
                values: new object[] { new Guid("88f9b49e-f21e-42af-93ed-0e4746b6eb3f"), "Sezon 1", "Hayallerinin peşinde koşarken hayata yakalananların hikayesini anlatan...", new Guid("1282d141-674d-43b4-89cf-e87c814f0021") });

            migrationBuilder.InsertData(
                table: "Seasons",
                columns: new[] { "Id", "Name", "Summary", "TvShowId" },
                values: new object[] { new Guid("1b750d2a-9594-4a34-be51-c1a5ced11d56"), "Sezon 2", "Hayallerinin peşinde koşarken hayata yakalananların hikayesini anlatan v2...", new Guid("1282d141-674d-43b4-89cf-e87c814f0021") });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "Id", "Name", "SeasonId", "Summary" },
                values: new object[] { new Guid("3e4576c7-09df-4646-9c96-cdb210bb0741"), "Kalbimizi Kıracaklar", new Guid("88f9b49e-f21e-42af-93ed-0e4746b6eb3f"), "Yakın arkadaşlar Dicle,Güneş vs. için yenibir gün.. " });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "Id", "Name", "SeasonId", "Summary" },
                values: new object[] { new Guid("6c91df7f-363a-46ac-9364-543a2e00e743"), "Tehlikeli Sular", new Guid("1b750d2a-9594-4a34-be51-c1a5ced11d56"), "Güneşin işteki ilk günü.. " });

            migrationBuilder.CreateIndex(
                name: "IX_Episodes_SeasonId",
                table: "Episodes",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Seasons_TvShowId",
                table: "Seasons",
                column: "TvShowId");

            migrationBuilder.CreateIndex(
                name: "IX_TvShows_ImageId",
                table: "TvShows",
                column: "ImageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Episodes");

            migrationBuilder.DropTable(
                name: "Seasons");

            migrationBuilder.DropTable(
                name: "TvShows");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
