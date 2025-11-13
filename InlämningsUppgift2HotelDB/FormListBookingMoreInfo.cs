using InlämningsUppgift2HotelDB.Data.Entities;
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
    public partial class FormListBookingMoreInfo : Form
    {
        Booking booking = new Booking();
        public FormListBookingMoreInfo(Booking b)
        {
            InitializeComponent();
            booking = b;

            ShowMoreInfo();
        }

        private void ShowMoreInfo()
        {
            textBoxCustomer.Text = booking.Customer.CustomerName;
            textBoxCustomerEmail.Text = booking.Customer.CustomerEmail;
            textBoxCustomerPhone.Text = booking.Customer.CustomerPhone.ToString();
            textBoxStartDate.Text = booking.StartDate.ToShortDateString();
            textBoxEndDate.Text = booking.EndDate.ToShortDateString();
            textBoxTotalGuest.Text = booking.TotalGuests.ToString();
            textBoxInvoicePaid.Text = booking.Status;
            textBoxInvoicePrice.Text = booking.Invoice.Amount.ToString() + " kr";
        }
    }
}
