using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsUppgift2HotelDB.Data.Entities
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }

        [Required]
        public int BookingID { get; set; }

        public Booking Booking { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public bool Paid { get; set; }

        [NotMapped]
        public string DisplayInfo
        {
            get
            {
                return $"Faktura: {InvoiceID}, Bokning: {Booking.BookingID}, Belopp: {Amount} kr, " +
                    $"Förfallodatum: {DueDate.ToShortDateString()}, Förfallen: {(OutDated() ? "Ja" : "Nej")}, Betald: {(Paid ? "Ja" : "Nej")}";
            }
        }


        public bool OutDated() 
        {
            return DueDate.Date < DateTime.Now;
        }


    }
}
