
using InlämningsUppgift2HotelDB.Data.Entities;
using InlämningsUppgift2HotelDB.Data.Repos;

namespace InlämningsUppgift2HotelDB
{
    public partial class FormCustomers : Form
    {
        private List<Customer> _customers = new List<Customer>();
        CustomerRepo customerRepo = new CustomerRepo();

        public FormCustomers()
        {
            InitializeComponent();
            UpdateCustomerList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer newCustomer = new Customer();
                newCustomer.CustomerName = textBoxCustName.Text;
                newCustomer.CustomerEmail = textBoxCustEmail.Text;
                newCustomer.CustomerPhone = int.Parse(textBoxCustPhone.Text);

                if (CheckExistingCustomer(textBoxCustName.Text))
                {
                    MessageBox.Show("Kunden finns redan i systemet.");
                    return;
                }
                customerRepo.AddCustomer(newCustomer);

                MessageBox.Show($"Kunden {newCustomer.CustomerName} är tillagd!");
                UpdateCustomerList();
                textBoxCustName.Clear();
                textBoxCustEmail.Clear();
                textBoxCustPhone.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fel vid tillägg av kund: " + ex.Message);
            }

        }

        private bool CheckExistingCustomer(string customerName)
        {
            foreach (var customer in _customers)
            {
                if (customer.CustomerName.Equals(customerName, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private void buttonSearchCustomers_Click(object sender, EventArgs e)
        {
            List<Customer> searchedCustomers = customerRepo.SearchCustomerByName(textBoxCondition.Text);
            if (searchedCustomers.Count > 0)
            {
                listBoxCustomerResult.DataSource = searchedCustomers;
                listBoxCustomerResult.DisplayMember = "CustomerName";
                listBoxCustomerResult.ValueMember = "CustomerID";
            }
            else
            {
                MessageBox.Show("Ingen kund hittades med det namnet.");
            }
        }

        private void UpdateCustomerList()
        {
            _customers = customerRepo.GetAll();

            if (_customers.Count > 0)
            {
                listBoxCustomerResult.DataSource = _customers;
                listBoxCustomerResult.DisplayMember = "CustomerName";
                listBoxCustomerResult.ValueMember = "CustomerID";
            }
        }

        private void listBoxCustomerResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectedCustomer();
        }

        private void SetSelectedCustomer()
        {
            if (listBoxCustomerResult.SelectedItem is Customer selectedCustomer)
            {
                textBoxCustName.Text = selectedCustomer.CustomerName;
                textBoxCustEmail.Text = selectedCustomer.CustomerEmail;
                textBoxCustPhone.Text = selectedCustomer.CustomerPhone.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Customer newCust = (Customer)listBoxCustomerResult.SelectedItem;
                newCust.CustomerName = textBoxCustName.Text;
                newCust.CustomerEmail = textBoxCustEmail.Text;
                newCust.CustomerPhone = int.Parse(textBoxCustPhone.Text);
                customerRepo.UpdateCustomer(newCust);

                MessageBox.Show("Kunden är uppdaterad!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fel vid uppdatering av kund: " + ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                customerRepo.DeleteCustomer(((Customer)listBoxCustomerResult.SelectedItem).CustomerID);
                MessageBox.Show("Kunden är borttagen!");
                UpdateCustomerList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fel vid borttagning av kund: " + ex.Message);
            }
        }



    }
}
