using InlämningsUppgift2HotelDB.Data;
using InlämningsUppgift2HotelDB.Data.Entities;
using InlämningsUppgift2HotelDB.Data.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InlämningsUppgift2HotelDB
{
    public partial class FormBooking : Form
    {
        CustomerRepo customerRepo = new CustomerRepo();
        List<Customer> customers = new List<Customer>();
        BookingRepo bookingRepo = new BookingRepo();
        List<Booking> bookings = new List<Booking>();
        RoomRepo roomRepo = new RoomRepo();
        List<Room> availableRooms = new List<Room>();

        public FormBooking()
        {
            InitializeComponent();
            InitBedComboBox();
            InitNoOfGuest();
            customers = customerRepo.GetAll();
            InitCustomersComboBox();
        }

        private void InitBedComboBox()
        {
            comboBoxRoomType.Items.Add("Enkelrum");
            comboBoxRoomType.Items.Add("Dubbelrum");
            comboBoxRoomType.SelectedIndex = 0; // Set default selection
        }
        private void InitNoOfGuest()
        {
            for (int i = 1; i <= 5; i++)
            {
                comboBoxNrOfGuests.Items.Add(i.ToString());
            }
            comboBoxNrOfGuests.SelectedIndex = 0; // Set default selection
        }

        private void InitCustomersComboBox()
        {

            comboBoxCustomers.DataSource = customers;
            comboBoxCustomers.DisplayMember = "CustomerName";
            comboBoxCustomers.ValueMember = "CustomerId";
            comboBoxCustomers.SelectedIndex = -1;
        }


        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_AvailableRooms(object sender, EventArgs e)
        {
            try
            {
                availableRooms = roomRepo.GetAllAvailableRooms();
                availableRooms = availableRooms
                    .Where(r => r.RoomType == comboBoxRoomType.SelectedItem.ToString())
                    .Where(r => r.MaxBeds == int.Parse(comboBoxNrOfGuests.SelectedItem.ToString())
                             || r.MaxBeds == int.Parse(comboBoxNrOfGuests.SelectedItem.ToString()) + 1)
                    .ToList();
                if (availableRooms.Count == 0)
                {
                    listBoxAvailableRoooms.DataSource = null;
                    MessageBox.Show("Inga tillgängliga rum hittades.");
                    return;
                }
                listBoxAvailableRoooms.DataSource = availableRooms;
                listBoxAvailableRoooms.DisplayMember = "DisplayInfo";
                listBoxAvailableRoooms.ValueMember = "RoomID";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void buttonBookRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCustomers.SelectedIndex < 0)
                {
                    MessageBox.Show("Vänligen välj en kund för bokningen.");
                    return;
                }
                if (dateTimePickerCheckIn.Value.Date == dateTimePickerCheckOut.Value.Date)
                {
                    MessageBox.Show("Inchecknings- och utcheckningsdatum kan inte vara samma.");
                    return;
                }
                Customer tempCustomer = (Customer)comboBoxCustomers.SelectedItem;
                Room tempRoom = (Room)listBoxAvailableRoooms.SelectedItem;
                tempRoom.RoomBooked = true;

                Booking booking = new Booking
                {
                    Customer = null,
                    Room = null,
                    StartDate = dateTimePickerCheckIn.Value,
                    EndDate = dateTimePickerCheckOut.Value,
                    TotalGuests = int.Parse(comboBoxNrOfGuests.SelectedItem.ToString()),
                    Status = "Obetald"
                };

                bookingRepo.AddBooking(booking, tempCustomer.CustomerID, tempRoom.RoomID);
                RegisterInvoice(booking);
                MessageBox.Show("Bokningen har genomförts!");
                listBoxAvailableRoooms.DataSource = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void RegisterInvoice(Booking booking)
        {
            try
            {
                InvoiceRepo invoiceRepo = new InvoiceRepo();
                Invoice invoice = new Invoice
                {
                    Booking = null,
                    Amount = Pricelist.GetTotalAmount(booking.Room.RoomType, CalculateTotalNights()),
                    DueDate = DueDate(),
                    Paid = false
                };
                invoiceRepo.AddInvoice(invoice, booking.BookingID);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gick ej att skapa faktura, ta bort bokingen!: {ex.Message}");
            }
        }

        private void button1_BookedRooms(object sender, EventArgs e)
        {
            try
            {
                bookings = bookingRepo.GetAllBookings();
                listBoxBookingResult.DataSource = bookings;
                listBoxBookingResult.DisplayMember = "DisplayInfo";
                listBoxBookingResult.ValueMember = "BookingID";

                if (bookings.Count == 0)
                {
                    listBoxBookingResult.DataSource = null;
                    MessageBox.Show("Inga bokningar hittades.");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private int CalculateTotalNights()
        {
            TimeSpan difference = dateTimePickerCheckOut.Value.Date - dateTimePickerCheckIn.Value.Date;
            return (int)difference.Days;
        }

        private DateTime DueDate()
        {
            return DateTime.Now.AddDays(1);
        }

        private void listBoxBooking_MoreInfo(object sender, EventArgs e)
        {
            if (listBoxBookingResult.SelectedIndex == -1)
            {
                MessageBox.Show("Välj en bokning!");
                return;
            }

            Booking booking = new Booking();
            booking = (Booking)listBoxBookingResult.SelectedItem;

            FormListBookingMoreInfo formListBookingMoreInfo = new FormListBookingMoreInfo(booking);
            formListBookingMoreInfo.Show();

        }

        private void listBoxBookingResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
