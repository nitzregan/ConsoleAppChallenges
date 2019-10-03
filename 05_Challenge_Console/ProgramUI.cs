using _05_Challenge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge_Console
{
    internal class ProgramUI
    {
        CustomerRepository _repo = new CustomerRepository();

        public void Run()
        {
            _repo.SeedList();
            RunMenu();
        }

        private void RunMenu()
        {
            bool usingMenu = true;
            while (usingMenu)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?\n" +
                    "1. Add New Customer\n" +
                    "2. Delete Existing Customer\n" +
                    "3. Update Existing Customer Information\n" +
                    "4. View All Customers\n" +
                    "5. Exit Program\n");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        AddNewCustomer();
                        break;
                    case "2":
                        Console.Clear();
                        DeleteCustomer();
                        break;
                    case "3":
                        Console.Clear();
                        UpdateCustomerInfo();
                        break;
                    case "4":
                        Console.Clear();
                        SeeAllCustomers();
                        break;
                    case "5":
                        usingMenu = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid response...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void AddNewCustomer()
        {
            Console.WriteLine("What is the customer's first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is the customer's last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What type of customer is this?\n" +
                "1. Current Customer\n" +
                "2. Past Customer\n" +
                "3. Potential Customer\n");
            string typeOfCustomerAsString = Console.ReadLine();
            int typeOfCustomerAsInt = int.Parse(typeOfCustomerAsString);
            CustomerType typeOfCustomer = (CustomerType)typeOfCustomerAsInt;

            Customer newCustomer = new Customer(firstName, lastName, typeOfCustomer);
            _repo.AddNewCustomer(newCustomer);
        }

        public void DeleteCustomer()
        {
            SeeAllCustomers();

            Console.WriteLine("Which customer would you like to delete? Enter customer's first name");
            string firstName = Console.ReadLine();

            _repo.DeleteCustomer(firstName);
            Console.Clear();
            SeeAllCustomers();
        }

        public void UpdateCustomerInfo()
        {
            Console.WriteLine("How would you like to search for a customer?\n" +
                "1. Search by Customer First Name\n" +
                "2. Search by Customer Last Name\n");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    UpdateCustomerInfoByFirstName();
                    break;
                case "2":
                    Console.Clear();
                    UpdateCustomerInfoByLastName();
                    break;

                default:
                    Console.WriteLine("Please enter a valid response...");
                    Console.ReadKey();
                    break;
            }
        }

        public void UpdateCustomerInfoByFirstName()
        {
            SeeAllCustomers();

            Console.WriteLine("What is the Customer's first name that you want to update?");
            string firstName = Console.ReadLine();

            Customer oldCustomer = _repo.GetCustomer(firstName);
            Console.WriteLine(oldCustomer);

            Console.WriteLine("What is the customer's first name?");
            string updatedFirstName = Console.ReadLine();

            Console.WriteLine("What is the customer's last name?");
            string updatedLastName = Console.ReadLine();

            Console.WriteLine("What type of customer is this?\n" +
                "1. Current Customer\n" +
                "2. Past Customer\n" +
                "3. Potential Customer\n");
            string typeOfCustomerAsString = Console.ReadLine();
            int typeOfCustomerAsInt = int.Parse(typeOfCustomerAsString);
            CustomerType typeOfCustomer = (CustomerType)typeOfCustomerAsInt;

            Customer updatedCustomer = new Customer(updatedFirstName, updatedLastName, typeOfCustomer);

            _repo.UpdateCustomerInfoByFirstName(firstName, updatedCustomer);

            Console.WriteLine(oldCustomer);
            Console.ReadKey();
        }

        public void UpdateCustomerInfoByLastName()
        {
            SeeAllCustomers();

            Console.WriteLine("What is the Customer's last name that you want to update?");
            string lastName = Console.ReadLine();

            Customer oldCustomer = _repo.GetCustomer(lastName);
            Console.WriteLine(oldCustomer);

            Console.WriteLine("What is the customer's first name?");
            string updatedFirstName = Console.ReadLine();

            Console.WriteLine("What is the customer's last name?");
            string updatedLastName = Console.ReadLine();

            Console.WriteLine("What type of customer is this?\n" +
                "1. Current Customer\n" +
                "2. Past Customer\n" +
                "3. Potential Customer\n");
            string typeOfCustomerAsString = Console.ReadLine();
            int typeOfCustomerAsInt = int.Parse(typeOfCustomerAsString);
            CustomerType typeOfCustomer = (CustomerType)typeOfCustomerAsInt;

            Customer updatedCustomer = new Customer(updatedFirstName, updatedLastName, typeOfCustomer);

            _repo.UpdateCustomerInfoByLastName(lastName, updatedCustomer);

            Console.WriteLine(oldCustomer);
            Console.ReadKey();

        }

        public void SeeAllCustomers()
        {
            List<Customer> customers = _repo.ViewAllCustomers();

            foreach(Customer customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }
            Console.ReadKey();
        }
    }
}
