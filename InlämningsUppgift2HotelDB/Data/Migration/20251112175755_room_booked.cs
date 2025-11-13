using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InlämningsUppgift2HotelDB.Data.Migration
{
    /// <inheritdoc />
    public partial class room_booked : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "RoomBooked",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoomBooked",
                table: "Rooms");
        }
    }
}
