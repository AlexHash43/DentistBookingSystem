using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentistBookingSystem.DataAccess.Migrations
{
    public partial class AddedToPracticeTimeOpeningEntityBreaktimeAndNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeSpan>(
                name: "TimeOpenInTheMorning",
                table: "PracticeTimeOpenings",
                type: "time",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "TimeOpenAfternoon",
                table: "PracticeTimeOpenings",
                type: "time",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "TimeClosedInTheMorning",
                table: "PracticeTimeOpenings",
                type: "time",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "TimeClosedAfternoon",
                table: "PracticeTimeOpenings",
                type: "time",
                nullable: true,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "BreakTimeStart",
                table: "PracticeTimeOpenings",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "BreakTimeStop",
                table: "PracticeTimeOpenings",
                type: "time",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BreakTimeStart",
                table: "PracticeTimeOpenings");

            migrationBuilder.DropColumn(
                name: "BreakTimeStop",
                table: "PracticeTimeOpenings");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "TimeOpenInTheMorning",
                table: "PracticeTimeOpenings",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(TimeSpan),
                oldType: "time",
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "TimeOpenAfternoon",
                table: "PracticeTimeOpenings",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(TimeSpan),
                oldType: "time",
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "TimeClosedInTheMorning",
                table: "PracticeTimeOpenings",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(TimeSpan),
                oldType: "time",
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "TimeClosedAfternoon",
                table: "PracticeTimeOpenings",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0),
                oldClrType: typeof(TimeSpan),
                oldType: "time",
                oldNullable: true);
        }
    }
}
