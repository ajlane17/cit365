using Microsoft.EntityFrameworkCore.Migrations;

namespace CIT365_SacramentProgram.Migrations
{
    public partial class musicalnumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IntermediateHymnDescription",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "IntermediateHymnNumber",
                table: "Meeting");

            migrationBuilder.AddColumn<string>(
                name: "IntermediateMusic",
                table: "Meeting",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SacramentHymnDescription",
                table: "Meeting",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<short>(
                name: "SacramentHymnNumber",
                table: "Meeting",
                nullable: false,
                defaultValue: (short)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IntermediateMusic",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "SacramentHymnDescription",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "SacramentHymnNumber",
                table: "Meeting");

            migrationBuilder.AddColumn<string>(
                name: "IntermediateHymnDescription",
                table: "Meeting",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<short>(
                name: "IntermediateHymnNumber",
                table: "Meeting",
                type: "smallint",
                nullable: true);
        }
    }
}
