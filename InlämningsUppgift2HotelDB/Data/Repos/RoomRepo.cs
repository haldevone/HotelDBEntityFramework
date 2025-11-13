using InlämningsUppgift2HotelDB.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningsUppgift2HotelDB.Data.Repos
{
    public class RoomRepo
    {
        private readonly HotelContext _context;
        public RoomRepo()
        {
            _context = new HotelContext();
        }

        public List<Room> GetAllRooms()
        {
            return _context.Rooms.ToList();
        }
        
        public List<Room> GetAllAvailableRooms()
        {
            return _context.Rooms
                .Where(r => r.RoomBooked == false)
                .ToList();
        }

    }
}
