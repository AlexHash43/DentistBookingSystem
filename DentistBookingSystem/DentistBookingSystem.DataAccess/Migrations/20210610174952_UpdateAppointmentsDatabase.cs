using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentistBookingSystem.DataAccess.Migrations
{
    public partial class UpdateAppointmentsDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateStop",
                table: "Appointments",
                newName: "TimeStop");

            migrationBuilder.RenameColumn(
                name: "DateStart",
                table: "Appointments",
                newName: "TimeStart");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Appointments",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "TimeAndDateBooked",
                table: "Appointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "TimeAndDateBooked",
                table: "Appointments");

            migrationBuilder.RenameColumn(
                name: "TimeStop",
                table: "Appointments",
                newName: "DateStop");

            migrationBuilder.RenameColumn(
                name: "TimeStart",
                table: "Appointments",
                newName: "DateStart");
        }
    }
}
