using InlämningsUppgift2HotelDB.Data.Entities;
using InlämningsUppgift2HotelDB.Data.Repos;

namespace InlämningsUppgift2HotelDB
{
    public partial class FormInvoice : Form
    {
        InvoiceRepo invoiceRepo = new InvoiceRepo();
        List<Invoice> invoices = new List<Invoice>();

        public FormInvoice()
        {
            InitializeComponent();
            LoadInvoices();
        }
        private void LoadInvoices()
        {
            invoices = invoiceRepo.GetAllInvoices();
            listBoxInvoiceResult.DataSource = invoices;
            listBoxInvoiceResult.DisplayMember = "DisplayInfo";
            listBoxInvoiceResult.ValueMember = "InvoiceID";
        }

        private void buttonRegPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxInvoiceResult.SelectedIndex == -1)
                {
                    MessageBox.Show("Välj en faktura!");
                    return;
                }
                Invoice invoice = new Invoice();
                invoice = listBoxInvoiceResult.SelectedItem as Invoice;
                invoice.Paid = true;

                invoiceRepo.UpdatePaidInvoice(invoice);

                MessageBox.Show("Betalning registrerad.");
                LoadInvoices();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Går ej att betala, fel!" + ex.Message);
            }
        }

        private void buttonRemoveBooking_Click(object sender, EventArgs e)
        {
            try
            {
                if(listBoxInvoiceResult.SelectedIndex == -1)
                {
                    MessageBox.Show("Välj en faktura!"); 
                    return;
                }
                Invoice? selectedInvoice = listBoxInvoiceResult.SelectedItem as Invoice;
                invoiceRepo.RemoveInvoice(selectedInvoice.InvoiceID);

                LoadInvoices();
                MessageBox.Show("Faktura borttagen.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Något gick fel!: " + ex.Message);
            }
        }


    }
}
