using Microsoft.EntityFrameworkCore.Migrations;

namespace CIT365_SacramentProgram.Migrations
{
    public partial class speakerentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdministrationOfSacrament",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "AdultSpeaker1",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "AdultSpeaker2",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "Announcements",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "YouthSpeaker",
                table: "Meeting");

            migrationBuilder.CreateTable(
                name: "Speakers",
                columns: table => new
                {
                    SpeakerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(maxLength: 50, nullable: false),
                    Topic = table.Column<string>(maxLength: 50, nullable: false),
                    Type = table.Column<string>(nullable: false),
                    MeetingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speakers", x => x.SpeakerId);
                    table.ForeignKey(
                        name: "FK_Speakers_Meeting_MeetingId",
                        column: x => x.MeetingId,
                        principalTable: "Meeting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Speakers_MeetingId",
                table: "Speakers",
                column: "MeetingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Speakers");

            migrationBuilder.AddColumn<string>(
                name: "AdministrationOfSacrament",
                table: "Meeting",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdultSpeaker1",
                table: "Meeting",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdultSpeaker2",
                table: "Meeting",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Announcements",
                table: "Meeting",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YouthSpeaker",
                table: "Meeting",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
