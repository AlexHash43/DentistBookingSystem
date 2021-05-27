using Microsoft.EntityFrameworkCore.Migrations;

namespace DentistBookingSystem.DataAccess.Migrations
{
    public partial class UpdateDatabaseOfUsersAndAppointments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentUser");

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "Appointments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_UsersId",
                table: "Appointments",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Users_UsersId",
                table: "Appointments",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Users_UsersId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_UsersId",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Appointments");

            migrationBuilder.CreateTable(
                name: "AppointmentUser",
                columns: table => new
                {
                    AppointmentsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentUser", x => new { x.AppointmentsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_AppointmentUser_Appointments_AppointmentsId",
                        column: x => x.AppointmentsId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppointmentUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentUser_UsersId",
                table: "AppointmentUser",
                column: "UsersId");
        }
    }
}
