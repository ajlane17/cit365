using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CIT365_SacramentProgram.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingDate = table.Column<DateTime>(nullable: false),
                    Theme = table.Column<string>(maxLength: 255, nullable: true),
                    Presiding = table.Column<string>(maxLength: 50, nullable: false),
                    Conducting = table.Column<string>(maxLength: 50, nullable: false),
                    Director = table.Column<string>(maxLength: 50, nullable: false),
                    Organist = table.Column<string>(maxLength: 50, nullable: false),
                    Invocation = table.Column<string>(maxLength: 50, nullable: false),
                    OpeningHymnNumber = table.Column<short>(nullable: false),
                    OpeningHymnDescription = table.Column<string>(nullable: false),
                    AdministrationOfSacrament = table.Column<string>(maxLength: 100, nullable: true),
                    YouthSpeaker = table.Column<string>(maxLength: 50, nullable: true),
                    AdultSpeaker1 = table.Column<string>(maxLength: 100, nullable: true),
                    IntermediateHymnNumber = table.Column<short>(nullable: true),
                    IntermediateHymnDescription = table.Column<string>(maxLength: 50, nullable: true),
                    AdultSpeaker2 = table.Column<string>(maxLength: 100, nullable: true),
                    ClosingHymnNumber = table.Column<short>(nullable: false),
                    ClosingHymnDescription = table.Column<string>(nullable: false),
                    Benediction = table.Column<string>(maxLength: 50, nullable: false),
                    Announcements = table.Column<string>(maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
