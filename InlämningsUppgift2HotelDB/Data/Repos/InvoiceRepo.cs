using InlämningsUppgift2HotelDB.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsUppgift2HotelDB.Data.Repos
{
    public class InvoiceRepo
    {
        private readonly HotelContext _context;

        public InvoiceRepo()
        {
            _context = new HotelContext();
        }

        public void AddInvoice(Invoice invoice, int bookingID)
        {
            var booking = _context.Bookings.Find(bookingID);
            invoice.Booking = booking;

            _context.Invoices.Add(invoice);
            _context.SaveChanges();
        }

        public void UpdatePaidInvoice(Invoice invoice)
        {
            var oldInvoice = _context.Invoices.Find(invoice.InvoiceID);
            var booking = _context.Bookings.Find(invoice.BookingID);

            if (oldInvoice != null)
            {
                booking.Status = "Betald";
                oldInvoice.Paid = invoice.Paid;
                _context.SaveChanges();
            }
        }

        public List<Invoice> GetAllInvoices()
        {
            return _context.Invoices
                .Include(b => b.Booking)
                .ToList();
        }

        public void RemoveInvoice(int invoiceID)
        {
            var invoice = _context.Invoices
                .Include(b => b.Booking)
                .ThenInclude(r => r.Room)
                .FirstOrDefault(i => i.InvoiceID == invoiceID);

            if (invoice != null)
            {
                if(invoice.Booking != null)
                {
                    invoice.Booking.Room.RoomBooked = false;
                    _context.Rooms.Update(invoice.Booking.Room);
                    _context.Bookings.Remove(invoice.Booking);
                }

                _context.Invoices.Remove(invoice);
                _context.SaveChanges();
            }
        }

    }
}
