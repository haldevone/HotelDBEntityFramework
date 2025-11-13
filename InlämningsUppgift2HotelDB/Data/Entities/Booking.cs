using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InlämningsUppgift2HotelDB.Data.Entities
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }

        [Required]
        public Customer Customer { get; set; }

        [Required]
        public Room Room { get; set; }

        [Required]
        public Invoice Invoice { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        [Range(1, 20)]
        public int TotalGuests { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [NotMapped]
        public string DisplayInfo
        {
            get { return $"BookningsID: {BookingID} - Kund: {Customer.CustomerName} - Status: {Status}"; }
        }

    }
}
