using Microsoft.EntityFrameworkCore.Migrations;

namespace ClipKeeper.Server.Data.Migrations
{
    public partial class update001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stars_Videos_VideoId",
                table: "Stars");

            migrationBuilder.DropIndex(
                name: "IX_Stars_VideoId",
                table: "Stars");

            migrationBuilder.DropColumn(
                name: "VideoId",
                table: "Stars");

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Stars",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StarVideo",
                columns: table => new
                {
                    StarId = table.Column<int>(nullable: false),
                    VideoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StarVideo", x => new { x.StarId, x.VideoId });
                    table.ForeignKey(
                        name: "FK_StarVideo_Stars_StarId",
                        column: x => x.StarId,
                        principalTable: "Stars",
                        principalColumn: "StarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StarVideo_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "VideoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StarVideo_VideoId",
                table: "StarVideo",
                column: "VideoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StarVideo");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Stars");

            migrationBuilder.AddColumn<int>(
                name: "VideoId",
                table: "Stars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Stars_VideoId",
                table: "Stars",
                column: "VideoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stars_Videos_VideoId",
                table: "Stars",
                column: "VideoId",
                principalTable: "Videos",
                principalColumn: "VideoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
