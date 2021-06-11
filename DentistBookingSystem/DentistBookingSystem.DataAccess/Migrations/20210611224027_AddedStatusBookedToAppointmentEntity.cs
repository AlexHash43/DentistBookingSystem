using Microsoft.EntityFrameworkCore.Migrations;

namespace DentistBookingSystem.DataAccess.Migrations
{
    public partial class AddedStatusBookedToAppointmentEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "StatusBooked",
                table: "Appointments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusBooked",
                table: "Appointments");
        }
    }
}
