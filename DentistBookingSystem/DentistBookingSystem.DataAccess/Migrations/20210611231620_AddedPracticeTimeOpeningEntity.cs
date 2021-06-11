using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentistBookingSystem.DataAccess.Migrations
{
    public partial class AddedPracticeTimeOpeningEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PracticeTimeOpenings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayOfTheWeek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeOpenInTheMorning = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimeClosedInTheMorning = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimeOpenAfternoon = table.Column<TimeSpan>(type: "time", nullable: false),
                    TimeClosedAfternoon = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PracticeTimeOpenings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PracticeTimeOpenings");
        }
    }
}
