using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InlämningsUppgift2HotelDB.Data.Migration
{
    /// <inheritdoc />
    public partial class added_bookingInvoiceRef : Microsoft.EntityFrameworkCore.Migrations.Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Invoices_BookingID",
                table: "Invoices");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_BookingID",
                table: "Invoices",
                column: "BookingID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Invoices_BookingID",
                table: "Invoices");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_BookingID",
                table: "Invoices",
                column: "BookingID");
        }
    }
}
