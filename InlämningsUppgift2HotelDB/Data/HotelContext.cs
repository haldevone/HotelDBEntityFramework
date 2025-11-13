using InlämningsUppgift2HotelDB.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace InlämningsUppgift2HotelDB.Data
{
    public class HotelContext : DbContext
    {

        //Skapar Connection till Database, connection string finns i App.config
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = ConfigurationManager.ConnectionStrings["HotelDBConnection"].ConnectionString;

            optionsBuilder.UseSqlServer(connString);

        }

        //Mappar Entities till Database Tables
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Room> Rooms { get; set; }


    }
}
