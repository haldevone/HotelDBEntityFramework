namespace InlämningsUppgift2HotelDB
{
    public partial class FormManager : Form
    {
        public FormManager()
        {
            InitializeComponent();
        }

        private void buttonCustomerManagement_Click(object sender, EventArgs e)
        {
            FormCustomers formCustomers = new FormCustomers();
            formCustomers.ShowDialog();
        }

        private void buttonBookings_Click(object sender, EventArgs e)
        {
            FormBooking formBooking = new FormBooking();
            formBooking.ShowDialog();
        }

        private void buttonInvoices_Click(object sender, EventArgs e)
        {
            FormInvoice formInvoice = new FormInvoice();
            formInvoice.ShowDialog();
        }
    }
}
