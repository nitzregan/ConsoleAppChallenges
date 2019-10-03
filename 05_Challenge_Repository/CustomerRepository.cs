using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge_Repository
{
    public class CustomerRepository
    {
        List<Customer> _customerList = new List<Customer>();

        public void AddNewCustomer(Customer customer)
        {
            _customerList.Add(customer);
        }

        public void DeleteCustomer(string firstName)
        {
            foreach (Customer customer in _customerList)
            {
                if (customer.FirstName == firstName)
                {
                    _customerList.Remove(customer);
                    break;
                }
            }
        }

        public Customer GetCustomer(string firstName)
        {
            foreach (Customer customer in _customerList)
            {
                if (customer.FirstName == firstName)
                {
                    return customer;
                }
            }
            return null;
        }

        public void UpdateCustomerInfoByFirstName(string firstName, Customer updates)
        {
            foreach (Customer customer in _customerList)
            {
                if (customer.FirstName == firstName)
                {
                    customer.FirstName = updates.FirstName;
                    customer.LastName = updates.LastName;
                    customer.TypeOfCustomer = updates.TypeOfCustomer;
                    customer.Email = updates.Email;
                    break;
                }
            }
        }

        public void UpdateCustomerInfoByLastName(string lastName, Customer updates)
        {
            foreach (Customer customer in _customerList)
            {
                if (customer.LastName == lastName)
                {
                    customer.FirstName = updates.FirstName;
                    customer.LastName = updates.LastName;
                    customer.TypeOfCustomer = updates.TypeOfCustomer;
                    break;
                }
            }
        }

        public List<Customer> ViewAllCustomers()
        {
            List<Customer> customers = _customerList.OrderBy(c => c.LastName).ToList();
            return customers;
        }

        public void SeedList()
        {
            Customer customer = new Customer("Jake", "Peralta", CustomerType.PotentialCustomer);
            Customer customerTwo = new Customer("Gina", "Linetti", CustomerType.PastCustomer);
            Customer customerThree = new Customer("Ray", "Holt", CustomerType.CurrentCustomer);
            Customer customerFour = new Customer("Amy", "Santiago", CustomerType.CurrentCustomer);
            Customer customerFive = new Customer("Rosa", "Diaz", CustomerType.PastCustomer);
            Customer customerSix = new Customer("Terry", "Jeffords", CustomerType.PotentialCustomer);
            Customer customerSeven = new Customer("Charles", "Boyle", CustomerType.CurrentCustomer);

            AddNewCustomer(customer);
            AddNewCustomer(customerTwo);
            AddNewCustomer(customerThree);
            AddNewCustomer(customerFour);
            AddNewCustomer(customerFive);
            AddNewCustomer(customerSix);
            AddNewCustomer(customerSeven);
        }
    }
}
