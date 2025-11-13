using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InlämningsUppgift2HotelDB.Data.Entities;

namespace InlämningsUppgift2HotelDB.Data.Repos
{
    public class CustomerRepo
    {
        private readonly HotelContext _hotelContext;

        public CustomerRepo()
        {
            _hotelContext = new HotelContext();
        }

        //INSERT
        public void AddCustomer(Customer customer)
        {
            _hotelContext.Customers.Add(customer);
            _hotelContext.SaveChanges();
        }

        public List<Customer> GetAll()
        {
            return _hotelContext.Customers.ToList();
        }

        public List<Customer> SearchCustomerByName(string customerName)
        {
            return _hotelContext.Customers
                .Where(c => c.CustomerName.Contains(customerName))
                .ToList();
        }

        public Customer GetCustomerById(int customerId)
        {
            return _hotelContext.Customers.SingleOrDefault(c => c.CustomerID == customerId);
        }

        public void UpdateCustomer(Customer updatedCustomer)
        {
            Customer customer = GetCustomerById(updatedCustomer.CustomerID);
            if(customer == null)
            {
                throw new Exception("Customer not found");
            }

            _hotelContext.Entry(customer).CurrentValues.SetValues(updatedCustomer);
            _hotelContext.SaveChanges();
        }

        public void DeleteCustomer(int customerId)
        {
            Customer customer = GetCustomerById(customerId);
            if(customer == null)
            {
                throw new Exception("Customer not found");
            }
            _hotelContext.Customers.Remove(customer);
            _hotelContext.SaveChanges();
        }


    }
}
