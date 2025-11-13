using InlämningsUppgift2HotelDB.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsUppgift2HotelDB.Data.Repos
{
    public class BookingRepo
    {
        private readonly HotelContext _context;

        public BookingRepo()
        {
            _context = new HotelContext();
        }

        //INSERT
        public void AddBooking(Booking booking, int custID, int roomID)
        {
            booking.Customer = _context.Customers.SingleOrDefault(c => c.CustomerID == custID);
            booking.Room = _context.Rooms.SingleOrDefault(r => r.RoomID == roomID);

            booking.Room.RoomBooked = true;

            _context.Bookings.Add(booking);
            _context.SaveChanges();
        }

        public List<Booking> GetAllBookings()
        {
            return _context.Bookings
                .Include(c => c.Customer)
                .Include(r => r.Room)
                .Include(i => i.Invoice)
                .ToList();
        }




    }
}
