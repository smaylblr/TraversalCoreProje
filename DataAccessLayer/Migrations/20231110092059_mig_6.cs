using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DestinationID",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DestinationID1",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_DestinationID1",
                table: "Reservations",
                column: "DestinationID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Destinations_DestinationID1",
                table: "Reservations",
                column: "DestinationID1",
                principalTable: "Destinations",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Destinations_DestinationID1",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_DestinationID1",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "DestinationID",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "DestinationID1",
                table: "Reservations");
        }
    }
}
